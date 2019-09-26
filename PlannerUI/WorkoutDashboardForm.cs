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
    public partial class WorkoutDashboardForm : Form, ITrainingRequester, IPlannedTrainingRequester
    {
        List<TrainingModel> avibleTrainings = GlobalConfig.Connection.GetTraining_All();
        List<PlannedTrainingModel> plannedTrainings = GlobalConfig.Connection.LoadPlannedTrainings_All();

        public WorkoutDashboardForm()
        {
            InitializeComponent();

            timer.Start();

            WireUpList();
        }

        void WireUpList()
        {
            selectWorkoutDropDown.DataSource = null;
            selectWorkoutDropDown.DataSource = avibleTrainings;
            selectWorkoutDropDown.DisplayMember = "TrainingName";

            plannedTrainings = plannedTrainings.OrderBy(x => x.TrainingDateAndTime).ToList();

            plannedWorkoutListBox.DataSource = null;
            plannedWorkoutListBox.DataSource = plannedTrainings;
            plannedWorkoutListBox.DisplayMember = "DisplayNameAndDate";
        }

        private void LoadWorkoutButton_Click(object sender, EventArgs e)
        {
            if ((TrainingModel)selectWorkoutDropDown.SelectedItem != null)
            {
                LoadViewerForm((TrainingModel)selectWorkoutDropDown.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select workout.");
            }
        }

        private void CreateWorkoutButton_Click(object sender, EventArgs e)
        {
            CreateWorkoutForm frm = new CreateWorkoutForm(this);

            frm.Show();
        }

        private void PlanYourWorkoutButton_Click(object sender, EventArgs e)
        {
            PlanWorkoutForm frm = new PlanWorkoutForm(this, avibleTrainings);

            frm.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
            currentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        public void TrainingCreated(TrainingModel model)
        {
            avibleTrainings.Add(model);

            WireUpList();
        }

        private void LoadPlannedWorkoutButton_Click(object sender, EventArgs e)
        {
            if ((PlannedTrainingModel)plannedWorkoutListBox.SelectedItem != null)
            {
                PlannedTrainingModel plannedTraining = (PlannedTrainingModel)plannedWorkoutListBox.SelectedItem;

                LoadViewerForm(plannedTraining.Training);
            }
            else
            {
                MessageBox.Show("Select planned workout.");
            }
        }

        void LoadViewerForm(TrainingModel model)
        {
            if (model.IsCircuitTraining == 1)
            {
                WorkoutCircuitViewerForm frm = new WorkoutCircuitViewerForm(model);

                frm.Show();
            }
            else
            {
                WorkoutViewerForm frm = new WorkoutViewerForm(model);

                frm.Show();
            }
        }

        public void PlanningCompleted(List<PlannedTrainingModel> models)
        {
            models.ForEach(x => plannedTrainings.Add(x));

            WireUpList();
        }

        void CheckForWorkout()
        {
            bool toDayWorkout = false;

            if (plannedTrainings.Count > 0)
            {
                foreach (PlannedTrainingModel plannedTraining in plannedTrainings)
                {
                    if (plannedTraining.TrainingDateAndTime.Date == DateTime.Now.Date)
                    {
                        toDayWorkout = true;
                    }
                }
            }

            if (toDayWorkout)
            {
                MessageBox.Show("You have planned workout for to day.", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You do not have planned workout for to day.", "", MessageBoxButtons.OK);
            }
        }

        private void WorkoutDashboardForm_Shown(object sender, EventArgs e)
        {
            CheckForWorkout();
        }
    }
}
