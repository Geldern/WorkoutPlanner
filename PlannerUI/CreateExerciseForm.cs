using PlannerLibrary;
using PlannerLibrary.DataAccess;
using PlannerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerUI
{
    public partial class CreateExerciseForm : Form
    {
        IExerciseRequester callingForm;
        ExerciseModel modelToUpdate;
        bool isCreateExercise = false;
        bool isUpdateExercise = false;

        public CreateExerciseForm(IExerciseRequester caller)
        {
            InitializeComponent();

            isCreateExercise = true;

            createExerciseButton.Text = "Create Exercise";

            callingForm = caller;
        }

        public CreateExerciseForm(IExerciseRequester caller, ExerciseModel model)
        {
            InitializeComponent();

            isUpdateExercise = true;

            createExerciseButton.Text = "Update Exercise";

            callingForm = caller;
            modelToUpdate = model;

            FillRecords();
        }

        private void CreateExerciseButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ExerciseModel model = new ExerciseModel(exerciseNameValue.Text, numberOfRepetitionsValue.Text, exerciseTimeValue.Text, numberOfSeriesValue.Text, breakBetweenSeriesValue.Text);

                if (isCreateExercise)
                {
                    GlobalConfig.Connection.CreateExercise(model);

                    callingForm.ExerciseComplete(model);
                }
                 
                if (isUpdateExercise)
                {
                    model.Id = modelToUpdate.Id;

                    GlobalConfig.Connection.UpdateExercise(modelToUpdate, model);

                    callingForm.ExerciseUpdateComplete(model);
                }

                Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.", "Invalid information", MessageBoxButtons.OK);
            }
        }

        bool ValidateForm()
        {
            bool output = true;

            if (exerciseNameValue.TextLength == 0)
            {
                output = false;
            }

            int numberOfRepetitions = IsValidInt(numberOfRepetitionsValue.Text, 0, output).ValueItem;
            int exerciseTime = IsValidInt(exerciseTimeValue.Text, 0, output).ValueItem;

            output = IsValidInt(numberOfRepetitionsValue.Text, 0, output).BoolItem;
            output = IsValidInt(exerciseTimeValue.Text, 0, output).BoolItem;
            output = IsValidInt(numberOfSeriesValue.Text, 1, output).BoolItem;
            output = IsValidInt(breakBetweenSeriesValue.Text, 0, output).BoolItem;

            if (numberOfRepetitions == 0 && exerciseTime == 0)
            {
                output = false;
            }
            else if(numberOfRepetitions > 0 && exerciseTime > 0)
            {
                output = false;
            }

            return output;
        }

        (bool BoolItem, int ValueItem) IsValidInt(string aText, int aMinimumValue, bool aOutput)
        {
            if (!int.TryParse(aText, out int number))
            {
                aOutput = false;
            }

            if (number < aMinimumValue)
            {
                aOutput = false;
            }

            return (aOutput, number);
        }

        void FillRecords()
        {
            exerciseNameValue.Text = modelToUpdate.ExerciseName;
            numberOfRepetitionsValue.Text = modelToUpdate.NumberOfRepetitions.ToString();
            exerciseTimeValue.Text = modelToUpdate.ExerciseTime.ToString();
            numberOfSeriesValue.Text = modelToUpdate.NumberOfSeries.ToString();
            breakBetweenSeriesValue.Text = modelToUpdate.BreakBetweenSeries.ToString();
        }
    }
}
