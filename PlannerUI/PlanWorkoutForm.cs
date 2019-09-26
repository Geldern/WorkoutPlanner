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
    public partial class PlanWorkoutForm : Form
    {
        IPlannedTrainingRequester callingForm;
        List<TrainingModel> avibleTrainings;
        List<PlannedTrainingModel> plannedWorkouts = new List<PlannedTrainingModel>();

        public PlanWorkoutForm(IPlannedTrainingRequester caller, List<TrainingModel> trainings)
        {
            InitializeComponent();

            callingForm = caller;

            avibleTrainings = trainings;

            dateTimer.Start();

            WireUpList();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            plannedWorkouts.Remove((PlannedTrainingModel)plannedWorkoutListBox.SelectedItem);

            WireUpList();
        }

        private void AddWorkoutToListButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PlannedTrainingModel plannedTrainingModel = new PlannedTrainingModel((TrainingModel)selectWorkoutDropDown.SelectedItem, workoutDateTimePicker.Value);

                plannedWorkouts.Add(plannedTrainingModel);

                WireUpList();
            }
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.PlanWorkouts(plannedWorkouts);

            callingForm.PlanningCompleted(plannedWorkouts);

            Close();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
            currentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        void WireUpList()
        {
            selectWorkoutDropDown.DataSource = null;
            selectWorkoutDropDown.DataSource = avibleTrainings;
            selectWorkoutDropDown.DisplayMember = "TrainingName";

            plannedWorkoutListBox.DataSource = null;
            plannedWorkoutListBox.DataSource = plannedWorkouts;
            plannedWorkoutListBox.DisplayMember = "DisplayNameAndDate";
        }

        bool ValidateForm()
        {
            bool output = true;

            if (selectWorkoutDropDown.SelectedItem == null)
            {
                output = false;
            }

            if (workoutDateTimePicker.Value.TimeOfDay < DateTime.Today.TimeOfDay && workoutDateTimePicker.Value.Date <= DateTime.Today.Date)
            {
                output = false;
            }

            return output;
        }
    }
}
