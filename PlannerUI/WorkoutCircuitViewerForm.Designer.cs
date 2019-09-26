namespace PlannerUI
{
    partial class WorkoutCircuitViewerForm
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
            this.workoutName = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.viewerTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.stopWorkoutButton = new System.Windows.Forms.Button();
            this.startWorkoutButton = new System.Windows.Forms.Button();
            this.exerciseToDoListBox = new System.Windows.Forms.ListBox();
            this.finishCircuitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberOfCircuitsLabel = new System.Windows.Forms.Label();
            this.numberOfCircuitsValueLabel = new System.Windows.Forms.Label();
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // workoutName
            // 
            this.workoutName.AutoSize = true;
            this.workoutName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workoutName.Location = new System.Drawing.Point(191, 9);
            this.workoutName.Name = "workoutName";
            this.workoutName.Size = new System.Drawing.Size(155, 50);
            this.workoutName.TabIndex = 8;
            this.workoutName.Text = "<none>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(173, 50);
            this.headerLabel.TabIndex = 7;
            this.headerLabel.Text = "Workout:";
            // 
            // viewerTimer
            // 
            this.viewerTimer.Tick += new System.EventHandler(this.ViewerTimer_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(520, 25);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(62, 30);
            this.currentTimeLabel.TabIndex = 10;
            this.currentTimeLabel.Text = "00:00";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(588, 25);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 30);
            this.currentDateLabel.TabIndex = 9;
            this.currentDateLabel.Text = "dd.MM.rrrr";
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stopwatchLabel.Location = new System.Drawing.Point(178, 89);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(284, 128);
            this.stopwatchLabel.TabIndex = 13;
            this.stopwatchLabel.Text = "00:00";
            // 
            // stopWorkoutButton
            // 
            this.stopWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.stopWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.stopWorkoutButton.Location = new System.Drawing.Point(468, 162);
            this.stopWorkoutButton.Name = "stopWorkoutButton";
            this.stopWorkoutButton.Size = new System.Drawing.Size(105, 43);
            this.stopWorkoutButton.TabIndex = 12;
            this.stopWorkoutButton.Text = "Stop";
            this.stopWorkoutButton.UseVisualStyleBackColor = false;
            this.stopWorkoutButton.Click += new System.EventHandler(this.StopWorkoutButton_Click);
            // 
            // startWorkoutButton
            // 
            this.startWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.startWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.startWorkoutButton.Location = new System.Drawing.Point(468, 104);
            this.startWorkoutButton.Name = "startWorkoutButton";
            this.startWorkoutButton.Size = new System.Drawing.Size(105, 43);
            this.startWorkoutButton.TabIndex = 11;
            this.startWorkoutButton.Text = "Start";
            this.startWorkoutButton.UseVisualStyleBackColor = false;
            this.startWorkoutButton.Click += new System.EventHandler(this.StartWorkoutButton_Click);
            // 
            // exerciseToDoListBox
            // 
            this.exerciseToDoListBox.BackColor = System.Drawing.Color.Lavender;
            this.exerciseToDoListBox.FormattingEnabled = true;
            this.exerciseToDoListBox.ItemHeight = 30;
            this.exerciseToDoListBox.Location = new System.Drawing.Point(21, 244);
            this.exerciseToDoListBox.Name = "exerciseToDoListBox";
            this.exerciseToDoListBox.Size = new System.Drawing.Size(348, 304);
            this.exerciseToDoListBox.TabIndex = 14;
            // 
            // finishCircuitButton
            // 
            this.finishCircuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.finishCircuitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishCircuitButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.finishCircuitButton.Location = new System.Drawing.Point(457, 335);
            this.finishCircuitButton.Name = "finishCircuitButton";
            this.finishCircuitButton.Size = new System.Drawing.Size(186, 43);
            this.finishCircuitButton.TabIndex = 18;
            this.finishCircuitButton.Text = "Finish Circuit";
            this.finishCircuitButton.UseVisualStyleBackColor = false;
            this.finishCircuitButton.Click += new System.EventHandler(this.FinishCircuitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Location = new System.Drawing.Point(498, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 43);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // numberOfCircuitsLabel
            // 
            this.numberOfCircuitsLabel.AutoSize = true;
            this.numberOfCircuitsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfCircuitsLabel.Location = new System.Drawing.Point(375, 262);
            this.numberOfCircuitsLabel.Name = "numberOfCircuitsLabel";
            this.numberOfCircuitsLabel.Size = new System.Drawing.Size(268, 40);
            this.numberOfCircuitsLabel.TabIndex = 19;
            this.numberOfCircuitsLabel.Text = "Number Of Circuits:";
            // 
            // numberOfCircuitsValueLabel
            // 
            this.numberOfCircuitsValueLabel.AutoSize = true;
            this.numberOfCircuitsValueLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfCircuitsValueLabel.Location = new System.Drawing.Point(649, 262);
            this.numberOfCircuitsValueLabel.Name = "numberOfCircuitsValueLabel";
            this.numberOfCircuitsValueLabel.Size = new System.Drawing.Size(49, 40);
            this.numberOfCircuitsValueLabel.TabIndex = 20;
            this.numberOfCircuitsValueLabel.Text = "00";
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1000;
            this.stopwatchTimer.Tick += new System.EventHandler(this.StopwatchTimer_Tick);
            // 
            // WorkoutCircuitViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(713, 569);
            this.Controls.Add(this.numberOfCircuitsValueLabel);
            this.Controls.Add(this.numberOfCircuitsLabel);
            this.Controls.Add(this.finishCircuitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exerciseToDoListBox);
            this.Controls.Add(this.stopwatchLabel);
            this.Controls.Add(this.stopWorkoutButton);
            this.Controls.Add(this.startWorkoutButton);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.workoutName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "WorkoutCircuitViewerForm";
            this.Text = "Workout Circuit Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workoutName;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Timer viewerTimer;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.Button stopWorkoutButton;
        private System.Windows.Forms.Button startWorkoutButton;
        private System.Windows.Forms.ListBox exerciseToDoListBox;
        private System.Windows.Forms.Button finishCircuitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numberOfCircuitsLabel;
        private System.Windows.Forms.Label numberOfCircuitsValueLabel;
        private System.Windows.Forms.Timer stopwatchTimer;
    }
}