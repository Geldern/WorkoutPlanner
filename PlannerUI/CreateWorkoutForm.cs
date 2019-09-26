using PlannerLibrary;
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
    public partial class CreateWorkoutForm : Form, IExerciseRequester
    {
        ITrainingRequester callingForm;
        List<ExerciseModel> availableExercise = GlobalConfig.Connection.GetExercise_All();
        List<ExerciseModel> selectedExercises = new List<ExerciseModel>();

        public CreateWorkoutForm(ITrainingRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpList();
        }

        private void CreateWorkoutButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TrainingModel model = new TrainingModel();

                model.TrainingName = workoutNameValue.Text;

                if (circuitTrainingCheckBox.Checked)
                {
                    model.IsCircuitTraining = 1;
                }
                else
                {
                    model.IsCircuitTraining = 0;
                }

                model.NumberOfCircuits = int.Parse(numberOfCircuitsValue.Text);
                model.BreakBetweenCircuit = int.Parse(breakBetweenCircuitsValue.Text);
                model.Exercises = selectedExercises;

                GlobalConfig.Connection.CreateTraining(model);

                callingForm.TrainingCreated(model);

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

            if (workoutNameValue.TextLength == 0)
            {
                output = false;
            }

            int numberOfCircuits = 0;

            if (!int.TryParse(numberOfCircuitsValue.Text, out numberOfCircuits))
            {
                output = false;
            }

            if (numberOfCircuits < 0)
            {
                output = false;
            }

            int breakBetweenCircuits = 0;

            if (!int.TryParse(breakBetweenCircuitsValue.Text, out breakBetweenCircuits))
            {
                output = false;
            }

            if (breakBetweenCircuits < 0)
            {
                output = false;
            }

            if (workoutExercisesListBox.Items.Count == 0)
            {
                output = false;
            }

            return output;
        }

        void WireUpList()
        {
            selectExerciseDropDown.DataSource = null;
            selectExerciseDropDown.DataSource = availableExercise;
            selectExerciseDropDown.DisplayMember = "ExerciseName";

            workoutExercisesListBox.DataSource = null;
            workoutExercisesListBox.DataSource = selectedExercises;
            workoutExercisesListBox.DisplayMember = "DisplayName";
        }

        private void AddExerciseButton_Click(object sender, EventArgs e)
        {
            ExerciseModel exercise = (ExerciseModel)selectExerciseDropDown.SelectedItem;

            if (exercise != null)
            {
                availableExercise.Remove(exercise);
                selectedExercises.Add(exercise);
            }

            WireUpList();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            ExerciseModel exercise = (ExerciseModel)workoutExercisesListBox.SelectedItem;

            if (exercise != null)
            {
                selectedExercises.Remove(exercise);
                availableExercise.Add(exercise);
            }

            WireUpList();
        }

        private void CreateNewExerciseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateExerciseForm frm = new CreateExerciseForm(this);

            frm.Show();
        }

        public void ExerciseComplete(ExerciseModel model)
        {
            availableExercise.Add(model);

            WireUpList();
        }

        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            if (workoutExercisesListBox.SelectedItem != null)
            {
                CreateExerciseForm frm = new CreateExerciseForm(this, (ExerciseModel)workoutExercisesListBox.SelectedItem);

                frm.Show();
            }
        }

        public void ExerciseUpdateComplete(ExerciseModel model)
        {
            int index = selectedExercises.IndexOf(selectedExercises.Find(x => x.Id == model.Id));

            selectedExercises.Remove(selectedExercises.Find(x => x.Id == model.Id));
            selectedExercises.Insert(index, model);

            WireUpList();
        }
    }
}
