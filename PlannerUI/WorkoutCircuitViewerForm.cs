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
    public partial class WorkoutCircuitViewerForm : Form
    {
        int stopwatchCounter;
        int stopwatchBreakCounter;
        bool isBreakTime;
        TrainingModel training;

        List<ExerciseModel> exercisesToDo;

        public WorkoutCircuitViewerForm(TrainingModel model)
        {
            InitializeComponent();

            viewerTimer.Start();

            SetupTraining(model);
        }

        private void StartWorkoutButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();
        }

        private void StopWorkoutButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
        }

        private void ViewerTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
            currentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchCounter++;

            if (isBreakTime)
            {
                stopwatchBreakCounter--;
                stopwatchLabel.Text = FormEditor.DisplayStopwatchTime(stopwatchBreakCounter);

                if (stopwatchBreakCounter == 0)
                {
                    isBreakTime = false;
                }
            }
            else
            {
                stopwatchLabel.Text = FormEditor.DisplayStopwatchTime(stopwatchCounter);
            }
        }

        private void FinishCircuitButton_Click(object sender, EventArgs e)
        {
            if (training.NumberOfCircuits == 0)
            {
                MessageBox.Show("Good job! You finished workout.");
            }
            else
            {
                stopwatchTimer.Start();

                if (!isBreakTime)
                {
                    training.NumberOfCircuits--;
                }

                isBreakTime = true;

                if (stopwatchBreakCounter == 0)
                {
                    stopwatchBreakCounter = training.BreakBetweenCircuit;
                }
            }

            numberOfCircuitsValueLabel.Text = training.NumberOfCircuits.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SetupTraining(TrainingModel model)
        {
            training = model;

            workoutName.Text = training.TrainingName;
            numberOfCircuitsValueLabel.Text = training.NumberOfCircuits.ToString();
            exercisesToDo = training.Exercises;

            isBreakTime = false;

            WireUpList();
        }

        void WireUpList()
        {
            exerciseToDoListBox.DataSource = null;
            exerciseToDoListBox.DataSource = exercisesToDo;
            exerciseToDoListBox.DisplayMember = "DisplayShortName";
        }
    }
}
