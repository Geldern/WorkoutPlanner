namespace PlannerUI
{
    partial class CreateWorkoutForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.workoutNameLabel = new System.Windows.Forms.Label();
            this.workoutNameValue = new System.Windows.Forms.TextBox();
            this.circuitTrainingCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberOfCircuitsLabel = new System.Windows.Forms.Label();
            this.numberOfCircuitsValue = new System.Windows.Forms.TextBox();
            this.selectExerciseDropDown = new System.Windows.Forms.ComboBox();
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.createNewExerciseLink = new System.Windows.Forms.LinkLabel();
            this.createWorkoutButton = new System.Windows.Forms.Button();
            this.workoutExercisesListBox = new System.Windows.Forms.ListBox();
            this.exercisesLabel = new System.Windows.Forms.Label();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.breakBetweenCircuitsValue = new System.Windows.Forms.TextBox();
            this.breakBetweenCircuitsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(281, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Create Workout";
            // 
            // workoutNameLabel
            // 
            this.workoutNameLabel.AutoSize = true;
            this.workoutNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workoutNameLabel.Location = new System.Drawing.Point(14, 109);
            this.workoutNameLabel.Name = "workoutNameLabel";
            this.workoutNameLabel.Size = new System.Drawing.Size(203, 37);
            this.workoutNameLabel.TabIndex = 4;
            this.workoutNameLabel.Text = "Workout Name:";
            // 
            // workoutNameValue
            // 
            this.workoutNameValue.BackColor = System.Drawing.Color.Lavender;
            this.workoutNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workoutNameValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.workoutNameValue.Location = new System.Drawing.Point(21, 149);
            this.workoutNameValue.Name = "workoutNameValue";
            this.workoutNameValue.Size = new System.Drawing.Size(364, 35);
            this.workoutNameValue.TabIndex = 5;
            // 
            // circuitTrainingCheckBox
            // 
            this.circuitTrainingCheckBox.AutoSize = true;
            this.circuitTrainingCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circuitTrainingCheckBox.Location = new System.Drawing.Point(21, 205);
            this.circuitTrainingCheckBox.Name = "circuitTrainingCheckBox";
            this.circuitTrainingCheckBox.Size = new System.Drawing.Size(214, 41);
            this.circuitTrainingCheckBox.TabIndex = 6;
            this.circuitTrainingCheckBox.Text = "Circuit Training";
            this.circuitTrainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberOfCircuitsLabel
            // 
            this.NumberOfCircuitsLabel.AutoSize = true;
            this.NumberOfCircuitsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfCircuitsLabel.Location = new System.Drawing.Point(14, 264);
            this.NumberOfCircuitsLabel.Name = "NumberOfCircuitsLabel";
            this.NumberOfCircuitsLabel.Size = new System.Drawing.Size(249, 37);
            this.NumberOfCircuitsLabel.TabIndex = 7;
            this.NumberOfCircuitsLabel.Text = "Number Of Circuits:";
            // 
            // numberOfCircuitsValue
            // 
            this.numberOfCircuitsValue.BackColor = System.Drawing.Color.Lavender;
            this.numberOfCircuitsValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberOfCircuitsValue.Location = new System.Drawing.Point(310, 267);
            this.numberOfCircuitsValue.Name = "numberOfCircuitsValue";
            this.numberOfCircuitsValue.Size = new System.Drawing.Size(75, 35);
            this.numberOfCircuitsValue.TabIndex = 8;
            this.numberOfCircuitsValue.Text = "0";
            // 
            // selectExerciseDropDown
            // 
            this.selectExerciseDropDown.BackColor = System.Drawing.Color.Lavender;
            this.selectExerciseDropDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selectExerciseDropDown.FormattingEnabled = true;
            this.selectExerciseDropDown.Location = new System.Drawing.Point(21, 437);
            this.selectExerciseDropDown.Name = "selectExerciseDropDown";
            this.selectExerciseDropDown.Size = new System.Drawing.Size(364, 38);
            this.selectExerciseDropDown.TabIndex = 9;
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.addExerciseButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addExerciseButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addExerciseButton.Location = new System.Drawing.Point(21, 507);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(158, 46);
            this.addExerciseButton.TabIndex = 11;
            this.addExerciseButton.Text = "Add Exercise";
            this.addExerciseButton.UseVisualStyleBackColor = false;
            this.addExerciseButton.Click += new System.EventHandler(this.AddExerciseButton_Click);
            // 
            // createNewExerciseLink
            // 
            this.createNewExerciseLink.AutoSize = true;
            this.createNewExerciseLink.Location = new System.Drawing.Point(271, 404);
            this.createNewExerciseLink.Name = "createNewExerciseLink";
            this.createNewExerciseLink.Size = new System.Drawing.Size(114, 30);
            this.createNewExerciseLink.TabIndex = 12;
            this.createNewExerciseLink.TabStop = true;
            this.createNewExerciseLink.Text = "create new";
            this.createNewExerciseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewExerciseLink_LinkClicked);
            // 
            // createWorkoutButton
            // 
            this.createWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.createWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createWorkoutButton.Location = new System.Drawing.Point(360, 577);
            this.createWorkoutButton.Name = "createWorkoutButton";
            this.createWorkoutButton.Size = new System.Drawing.Size(257, 68);
            this.createWorkoutButton.TabIndex = 13;
            this.createWorkoutButton.Text = "Create Workout";
            this.createWorkoutButton.UseVisualStyleBackColor = false;
            this.createWorkoutButton.Click += new System.EventHandler(this.CreateWorkoutButton_Click);
            // 
            // workoutExercisesListBox
            // 
            this.workoutExercisesListBox.BackColor = System.Drawing.Color.Lavender;
            this.workoutExercisesListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.workoutExercisesListBox.FormattingEnabled = true;
            this.workoutExercisesListBox.ItemHeight = 30;
            this.workoutExercisesListBox.Location = new System.Drawing.Point(456, 145);
            this.workoutExercisesListBox.Name = "workoutExercisesListBox";
            this.workoutExercisesListBox.Size = new System.Drawing.Size(334, 364);
            this.workoutExercisesListBox.TabIndex = 14;
            // 
            // exercisesLabel
            // 
            this.exercisesLabel.AutoSize = true;
            this.exercisesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exercisesLabel.Location = new System.Drawing.Point(449, 105);
            this.exercisesLabel.Name = "exercisesLabel";
            this.exercisesLabel.Size = new System.Drawing.Size(121, 37);
            this.exercisesLabel.TabIndex = 15;
            this.exercisesLabel.Text = "Exercises";
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.editSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editSelectedButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.editSelectedButton.Location = new System.Drawing.Point(815, 193);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(120, 68);
            this.editSelectedButton.TabIndex = 16;
            this.editSelectedButton.Text = "Edit Selected";
            this.editSelectedButton.UseVisualStyleBackColor = false;
            this.editSelectedButton.Click += new System.EventHandler(this.EditSelectedButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.removeSelectedButton.Location = new System.Drawing.Point(815, 313);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(120, 68);
            this.removeSelectedButton.TabIndex = 17;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // breakBetweenCircuitsValue
            // 
            this.breakBetweenCircuitsValue.BackColor = System.Drawing.Color.Lavender;
            this.breakBetweenCircuitsValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.breakBetweenCircuitsValue.Location = new System.Drawing.Point(310, 329);
            this.breakBetweenCircuitsValue.Name = "breakBetweenCircuitsValue";
            this.breakBetweenCircuitsValue.Size = new System.Drawing.Size(75, 35);
            this.breakBetweenCircuitsValue.TabIndex = 19;
            this.breakBetweenCircuitsValue.Text = "0";
            // 
            // breakBetweenCircuitsLabel
            // 
            this.breakBetweenCircuitsLabel.AutoSize = true;
            this.breakBetweenCircuitsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.breakBetweenCircuitsLabel.Location = new System.Drawing.Point(14, 326);
            this.breakBetweenCircuitsLabel.Name = "breakBetweenCircuitsLabel";
            this.breakBetweenCircuitsLabel.Size = new System.Drawing.Size(290, 37);
            this.breakBetweenCircuitsLabel.TabIndex = 18;
            this.breakBetweenCircuitsLabel.Text = "Break Between Circuits:";
            // 
            // CreateWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(962, 710);
            this.Controls.Add(this.breakBetweenCircuitsValue);
            this.Controls.Add(this.breakBetweenCircuitsLabel);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.exercisesLabel);
            this.Controls.Add(this.workoutExercisesListBox);
            this.Controls.Add(this.createWorkoutButton);
            this.Controls.Add(this.createNewExerciseLink);
            this.Controls.Add(this.addExerciseButton);
            this.Controls.Add(this.selectExerciseDropDown);
            this.Controls.Add(this.numberOfCircuitsValue);
            this.Controls.Add(this.NumberOfCircuitsLabel);
            this.Controls.Add(this.circuitTrainingCheckBox);
            this.Controls.Add(this.workoutNameValue);
            this.Controls.Add(this.workoutNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateWorkoutForm";
            this.Text = "Create Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label workoutNameLabel;
        private System.Windows.Forms.TextBox workoutNameValue;
        private System.Windows.Forms.CheckBox circuitTrainingCheckBox;
        private System.Windows.Forms.Label NumberOfCircuitsLabel;
        private System.Windows.Forms.TextBox numberOfCircuitsValue;
        private System.Windows.Forms.ComboBox selectExerciseDropDown;
        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.LinkLabel createNewExerciseLink;
        private System.Windows.Forms.Button createWorkoutButton;
        private System.Windows.Forms.ListBox workoutExercisesListBox;
        private System.Windows.Forms.Label exercisesLabel;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.TextBox breakBetweenCircuitsValue;
        private System.Windows.Forms.Label breakBetweenCircuitsLabel;
    }
}