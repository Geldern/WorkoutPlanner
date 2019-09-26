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
    public partial class WorkoutViewerForm : Form
    {
        TrainingModel training;
        int stopwatchCounter;
        int stopwatchBreakCounter;
        int stopwatchExerciseTimeCounter;
        int exerciseTimeLength;
        bool isStopwatchRunning;

        List<ExerciseModel> exerciseToDo;
        List<ExerciseModel> exerciseInProgress = new List<ExerciseModel>();

        public WorkoutViewerForm(TrainingModel model)
        {
            InitializeComponent();

            SetupTraining(model);

            WireUpList();
        }

        private void ViewerTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
            currentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        void SetupTraining(TrainingModel model)
        {
            viewerTimer.Start();

            training = model;

            workoutName.Text = training.TrainingName;

            exerciseToDo = training.Exercises;

            isStopwatchRunning = false;

            stopwatchTimer.Start();

            TurnOffExerciseTimeButton();
        }

        void WireUpList()
        {
            exerciseToDoListBox.DataSource = null;
            exerciseToDoListBox.DataSource = exerciseToDo;
            exerciseToDoListBox.DisplayMember = "DisplayName";

            exerciseInProgressListBox.DataSource = null;
            exerciseInProgressListBox.DataSource = exerciseInProgress;
            exerciseInProgressListBox.DisplayMember = "DisplayName";
        }

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            if (isStopwatchRunning)
            {
                stopwatchCounter++;
            }

            if (stopwatchBreakCounter > 0)
            {
                stopwatchBreakCounter--;
                stopwatchLabel.Text = FormEditor.DisplayStopwatchTime(stopwatchBreakCounter);
            }
            else
            {
                if (stopwatchExerciseTimeCounter > 0)
                {
                    stopwatchLabel.Text = FormEditor.DisplayStopwatchTime(stopwatchExerciseTimeCounter);
                }
                else
                {
                    stopwatchLabel.Text = FormEditor.DisplayStopwatchTime(stopwatchCounter);
                }
            }
        }

        private void StartWorkoutButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();

            isStopwatchRunning = true;
        }

        private void StopWorkoutButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();

            isStopwatchRunning = false;
        }

        

        private void SelectExerciseButton_Click(object sender, EventArgs e)
        {
            if (exerciseToDoListBox.SelectedItem == null && exerciseToDo.Count > 0)
            {
                exerciseToDoListBox.SelectedItem = exerciseToDo.First();
            }

            if (IsNotFinishedExercise())
            {
                if (exerciseInProgress.Count > 0)
                {
                    SwapExercises();
                }
                else
                {
                    exerciseInProgress.Add((ExerciseModel)exerciseToDoListBox.SelectedItem);
                    exerciseToDo.Remove((ExerciseModel)exerciseToDoListBox.SelectedItem);
                }

                WireUpList();
            }
            else
            {
                MessageBox.Show("Select unfinished exercise.", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void FinishSeriesButton_Click(object sender, EventArgs e)
        {
            ExerciseModel exercise = exerciseInProgress.First();

            stopwatchBreakCounter = exercise.BreakBetweenSeries;

            stopwatchTimer.Start();

            if (exerciseInProgress.Count > 0)
            {
                exercise.NumberOfSeries--;

                if (exercise.NumberOfSeries == 0)
                {
                    SwapExercises();
                }

                WireUpList();
            }
        }

        void SwapExercises()
        {
            ExerciseModel exercise = exerciseInProgress.First();
            ExerciseModel exerciseToInsert;

            if (IsNotFinishedExercise())
            {
                exerciseToInsert = (ExerciseModel)exerciseToDoListBox.SelectedItem;
            }
            else
            {
                exerciseToInsert = exerciseToDo.Find(x => x.NumberOfSeries > 0);
            }

            if (exerciseToInsert != null)
            {
                if (exerciseToInsert.ExerciseTime > 0)
                {
                    TurnOnExerciseTimeButton();
                }
                else
                {
                    TurnOffExerciseTimeButton();
                }

                exerciseInProgress.Remove(exercise);
                exerciseInProgress.Insert(0, exerciseToInsert);

                exerciseToDo.Remove(exerciseToInsert);
                exerciseToDo.Remove(exerciseToDo.Find(x => x.Id == exercise.Id));
                exerciseToDo.Add(exercise);
            }

            if (exerciseToInsert == null)
            {
                exerciseInProgress.Remove(exercise);
                exerciseToDo.Remove(exerciseToDo.Find(x => x.Id == exercise.Id));
                exerciseToDo.Add(exercise);

                WireUpList();

                MessageBox.Show("You finished all exercises.");
            }
        }

        bool IsNotFinishedExercise()
        {
            bool output = true;

            ExerciseModel exercise = (ExerciseModel)exerciseToDoListBox.SelectedItem;

            if (exercise.NumberOfSeries == 0)
            {
                output = false;
            }

            return output;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkoutViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exerciseInProgress.Count > 0)
            {
                ExerciseModel exercise = exerciseInProgress.First();

                exerciseInProgress.Remove(exercise);
                exerciseToDo.Remove(exerciseToDo.Find(x => x.Id == exercise.Id));
                exerciseToDo.Add(exercise);

                exerciseToDo.OrderBy(x => x.Id);

                WireUpList();
            }
        }

        void TurnOnExerciseTimeButton()
        {
            startExerciseTimeButton.Enabled = true;
            stopExerciseTimeButton.Enabled = true;

            startExerciseTimeButton.BackColor = Color.White;
            stopExerciseTimeButton.BackColor = Color.White;
        }

        void TurnOffExerciseTimeButton()
        {
            startExerciseTimeButton.Enabled = false;
            stopExerciseTimeButton.Enabled = false;

            startExerciseTimeButton.BackColor = Color.Gray;
            stopExerciseTimeButton.BackColor = Color.Gray;

            exerciseTimer.Stop();
        }

        private void StartExerciseTimeButton_Click(object sender, EventArgs e)
        {
            exerciseTimeLength = exerciseInProgress.First().ExerciseTime;
            exerciseTimer.Start();
        }

        private void StopExerciseTimeButton_Click(object sender, EventArgs e)
        {
            exerciseTimer.Stop();
        }

        private void ExerciseTimer_Tick(object sender, EventArgs e)
        {
            stopwatchExerciseTimeCounter++;

            if (exerciseTimeLength == stopwatchExerciseTimeCounter)
            {
                FinishSeriesButton_Click(this, EventArgs.Empty);

                stopwatchExerciseTimeCounter = 0;

                exerciseTimer.Stop();
            }
        }
    }
}
