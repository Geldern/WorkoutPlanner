namespace PlannerUI
{
    partial class WorkoutViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startWorkoutButton = new System.Windows.Forms.Button();
            this.stopWorkoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.workoutName = new System.Windows.Forms.Label();
            this.viewerTimer = new System.Windows.Forms.Timer(this.components);
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.exerciseToDoListBox = new System.Windows.Forms.ListBox();
            this.exerciseInProgressListBox = new System.Windows.Forms.ListBox();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.selectExerciseButton = new System.Windows.Forms.Button();
            this.finishSeriesButton = new System.Windows.Forms.Button();
            this.startExerciseTimeButton = new System.Windows.Forms.Button();
            this.stopExerciseTimeButton = new System.Windows.Forms.Button();
            this.exerciseTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startWorkoutButton
            // 
            this.startWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.startWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.startWorkoutButton.Location = new System.Drawing.Point(580, 108);
            this.startWorkoutButton.Name = "startWorkoutButton";
            this.startWorkoutButton.Size = new System.Drawing.Size(105, 43);
            this.startWorkoutButton.TabIndex = 1;
            this.startWorkoutButton.Text = "Start";
            this.startWorkoutButton.UseVisualStyleBackColor = false;
            this.startWorkoutButton.Click += new System.EventHandler(this.StartWorkoutButton_Click);
            // 
            // stopWorkoutButton
            // 
            this.stopWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.stopWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.stopWorkoutButton.Location = new System.Drawing.Point(580, 166);
            this.stopWorkoutButton.Name = "stopWorkoutButton";
            this.stopWorkoutButton.Size = new System.Drawing.Size(105, 43);
            this.stopWorkoutButton.TabIndex = 2;
            this.stopWorkoutButton.Text = "Stop";
            this.stopWorkoutButton.UseVisualStyleBackColor = false;
            this.stopWorkoutButton.Click += new System.EventHandler(this.StopWorkoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Location = new System.Drawing.Point(668, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 43);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(173, 50);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Workout:";
            // 
            // workoutName
            // 
            this.workoutName.AutoSize = true;
            this.workoutName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workoutName.Location = new System.Drawing.Point(191, 9);
            this.workoutName.Name = "workoutName";
            this.workoutName.Size = new System.Drawing.Size(155, 50);
            this.workoutName.TabIndex = 6;
            this.workoutName.Text = "<none>";
            // 
            // viewerTimer
            // 
            this.viewerTimer.Tick += new System.EventHandler(this.ViewerTimer_Tick);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(797, 25);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 30);
            this.currentDateLabel.TabIndex = 7;
            this.currentDateLabel.Text = "dd.MM.rrrr";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(729, 25);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(62, 30);
            this.currentTimeLabel.TabIndex = 8;
            this.currentTimeLabel.Text = "00:00";
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stopwatchLabel.Location = new System.Drawing.Point(290, 93);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(284, 128);
            this.stopwatchLabel.TabIndex = 9;
            this.stopwatchLabel.Text = "00:00";
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1000;
            this.stopwatchTimer.Tick += new System.EventHandler(this.StopwatchTimer_Tick);
            // 
            // exerciseToDoListBox
            // 
            this.exerciseToDoListBox.BackColor = System.Drawing.Color.Lavender;
            this.exerciseToDoListBox.FormattingEnabled = true;
            this.exerciseToDoListBox.ItemHeight = 30;
            this.exerciseToDoListBox.Location = new System.Drawing.Point(21, 238);
            this.exerciseToDoListBox.Name = "exerciseToDoListBox";
            this.exerciseToDoListBox.Size = new System.Drawing.Size(348, 214);
            this.exerciseToDoListBox.TabIndex = 10;
            // 
            // exerciseInProgressListBox
            // 
            this.exerciseInProgressListBox.BackColor = System.Drawing.Color.Lavender;
            this.exerciseInProgressListBox.FormattingEnabled = true;
            this.exerciseInProgressListBox.ItemHeight = 30;
            this.exerciseInProgressListBox.Location = new System.Drawing.Point(546, 281);
            this.exerciseInProgressListBox.Name = "exerciseInProgressListBox";
            this.exerciseInProgressListBox.Size = new System.Drawing.Size(348, 34);
            this.exerciseInProgressListBox.TabIndex = 11;
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inProgressLabel.Location = new System.Drawing.Point(539, 238);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(164, 40);
            this.inProgressLabel.TabIndex = 12;
            this.inProgressLabel.Text = "In Progress:";
            // 
            // selectExerciseButton
            // 
            this.selectExerciseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.selectExerciseButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectExerciseButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.selectExerciseButton.Location = new System.Drawing.Point(375, 272);
            this.selectExerciseButton.Name = "selectExerciseButton";
            this.selectExerciseButton.Size = new System.Drawing.Size(105, 43);
            this.selectExerciseButton.TabIndex = 13;
            this.selectExerciseButton.Text = "Select";
            this.selectExerciseButton.UseVisualStyleBackColor = false;
            this.selectExerciseButton.Click += new System.EventHandler(this.SelectExerciseButton_Click);
            // 
            // finishSeriesButton
            // 
            this.finishSeriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.finishSeriesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishSeriesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.finishSeriesButton.Location = new System.Drawing.Point(627, 321);
            this.finishSeriesButton.Name = "finishSeriesButton";
            this.finishSeriesButton.Size = new System.Drawing.Size(186, 43);
            this.finishSeriesButton.TabIndex = 14;
            this.finishSeriesButton.Text = "Finish Series";
            this.finishSeriesButton.UseVisualStyleBackColor = false;
            this.finishSeriesButton.Click += new System.EventHandler(this.FinishSeriesButton_Click);
            // 
            // startExerciseTimeButton
            // 
            this.startExerciseTimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.startExerciseTimeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startExerciseTimeButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.startExerciseTimeButton.Location = new System.Drawing.Point(709, 238);
            this.startExerciseTimeButton.Name = "startExerciseTimeButton";
            this.startExerciseTimeButton.Size = new System.Drawing.Size(79, 37);
            this.startExerciseTimeButton.TabIndex = 15;
            this.startExerciseTimeButton.Text = "Start";
            this.startExerciseTimeButton.UseVisualStyleBackColor = false;
            this.startExerciseTimeButton.Click += new System.EventHandler(this.StartExerciseTimeButton_Click);
            // 
            // stopExerciseTimeButton
            // 
            this.stopExerciseTimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.stopExerciseTimeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopExerciseTimeButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.stopExerciseTimeButton.Location = new System.Drawing.Point(794, 238);
            this.stopExerciseTimeButton.Name = "stopExerciseTimeButton";
            this.stopExerciseTimeButton.Size = new System.Drawing.Size(79, 37);
            this.stopExerciseTimeButton.TabIndex = 16;
            this.stopExerciseTimeButton.Text = "Stop";
            this.stopExerciseTimeButton.UseVisualStyleBackColor = false;
            this.stopExerciseTimeButton.Click += new System.EventHandler(this.StopExerciseTimeButton_Click);
            // 
            // exerciseTimer
            // 
            this.exerciseTimer.Interval = 1000;
            this.exerciseTimer.Tick += new System.EventHandler(this.ExerciseTimer_Tick);
            // 
            // WorkoutViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.stopExerciseTimeButton);
            this.Controls.Add(this.startExerciseTimeButton);
            this.Controls.Add(this.finishSeriesButton);
            this.Controls.Add(this.selectExerciseButton);
            this.Controls.Add(this.inProgressLabel);
            this.Controls.Add(this.exerciseInProgressListBox);
            this.Controls.Add(this.exerciseToDoListBox);
            this.Controls.Add(this.stopwatchLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.workoutName);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stopWorkoutButton);
            this.Controls.Add(this.startWorkoutButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "WorkoutViewerForm";
            this.Text = "Workout Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkoutViewerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startWorkoutButton;
        private System.Windows.Forms.Button stopWorkoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label workoutName;
        private System.Windows.Forms.Timer viewerTimer;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.Timer stopwatchTimer;
        private System.Windows.Forms.ListBox exerciseToDoListBox;
        private System.Windows.Forms.ListBox exerciseInProgressListBox;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.Button selectExerciseButton;
        private System.Windows.Forms.Button finishSeriesButton;
        private System.Windows.Forms.Button startExerciseTimeButton;
        private System.Windows.Forms.Button stopExerciseTimeButton;
        private System.Windows.Forms.Timer exerciseTimer;
    }
}