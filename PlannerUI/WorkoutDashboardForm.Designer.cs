namespace PlannerUI
{
    partial class WorkoutDashboardForm
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
            this.createWorkoutButton = new System.Windows.Forms.Button();
            this.planYourWorkoutButton = new System.Windows.Forms.Button();
            this.selectWorkoutDropDown = new System.Windows.Forms.ComboBox();
            this.loadWorkoutButton = new System.Windows.Forms.Button();
            this.plannedWorkoutListBox = new System.Windows.Forms.ListBox();
            this.loadPlannedWorkoutButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // createWorkoutButton
            // 
            this.createWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.createWorkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.createWorkoutButton.FlatAppearance.BorderSize = 5;
            this.createWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createWorkoutButton.Location = new System.Drawing.Point(45, 302);
            this.createWorkoutButton.Name = "createWorkoutButton";
            this.createWorkoutButton.Size = new System.Drawing.Size(257, 68);
            this.createWorkoutButton.TabIndex = 14;
            this.createWorkoutButton.Text = "Create Workout";
            this.createWorkoutButton.UseVisualStyleBackColor = false;
            this.createWorkoutButton.Click += new System.EventHandler(this.CreateWorkoutButton_Click);
            // 
            // planYourWorkoutButton
            // 
            this.planYourWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.planYourWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.planYourWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.planYourWorkoutButton.Location = new System.Drawing.Point(45, 390);
            this.planYourWorkoutButton.Name = "planYourWorkoutButton";
            this.planYourWorkoutButton.Size = new System.Drawing.Size(257, 68);
            this.planYourWorkoutButton.TabIndex = 15;
            this.planYourWorkoutButton.Text = "Plan Your Workout";
            this.planYourWorkoutButton.UseVisualStyleBackColor = false;
            this.planYourWorkoutButton.Click += new System.EventHandler(this.PlanYourWorkoutButton_Click);
            // 
            // selectWorkoutDropDown
            // 
            this.selectWorkoutDropDown.BackColor = System.Drawing.Color.Lavender;
            this.selectWorkoutDropDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selectWorkoutDropDown.FormattingEnabled = true;
            this.selectWorkoutDropDown.Location = new System.Drawing.Point(12, 109);
            this.selectWorkoutDropDown.Name = "selectWorkoutDropDown";
            this.selectWorkoutDropDown.Size = new System.Drawing.Size(323, 38);
            this.selectWorkoutDropDown.TabIndex = 16;
            // 
            // loadWorkoutButton
            // 
            this.loadWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.loadWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.loadWorkoutButton.Location = new System.Drawing.Point(94, 162);
            this.loadWorkoutButton.Name = "loadWorkoutButton";
            this.loadWorkoutButton.Size = new System.Drawing.Size(158, 46);
            this.loadWorkoutButton.TabIndex = 17;
            this.loadWorkoutButton.Text = "Load Workout";
            this.loadWorkoutButton.UseVisualStyleBackColor = false;
            this.loadWorkoutButton.Click += new System.EventHandler(this.LoadWorkoutButton_Click);
            // 
            // plannedWorkoutListBox
            // 
            this.plannedWorkoutListBox.BackColor = System.Drawing.Color.Lavender;
            this.plannedWorkoutListBox.FormattingEnabled = true;
            this.plannedWorkoutListBox.ItemHeight = 30;
            this.plannedWorkoutListBox.Location = new System.Drawing.Point(419, 109);
            this.plannedWorkoutListBox.Name = "plannedWorkoutListBox";
            this.plannedWorkoutListBox.Size = new System.Drawing.Size(413, 274);
            this.plannedWorkoutListBox.TabIndex = 18;
            // 
            // loadPlannedWorkoutButton
            // 
            this.loadPlannedWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.loadPlannedWorkoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadPlannedWorkoutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.loadPlannedWorkoutButton.Location = new System.Drawing.Point(505, 401);
            this.loadPlannedWorkoutButton.Name = "loadPlannedWorkoutButton";
            this.loadPlannedWorkoutButton.Size = new System.Drawing.Size(241, 46);
            this.loadPlannedWorkoutButton.TabIndex = 19;
            this.loadPlannedWorkoutButton.Text = "Load Planned Workout";
            this.loadPlannedWorkoutButton.UseVisualStyleBackColor = false;
            this.loadPlannedWorkoutButton.Click += new System.EventHandler(this.LoadPlannedWorkoutButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.headerLabel.Location = new System.Drawing.Point(245, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(355, 50);
            this.headerLabel.TabIndex = 20;
            this.headerLabel.Text = "Workout Dashboard";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(651, 25);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(62, 30);
            this.currentTimeLabel.TabIndex = 21;
            this.currentTimeLabel.Text = "00:00";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(719, 25);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 30);
            this.currentDateLabel.TabIndex = 22;
            this.currentDateLabel.Text = "dd.MM.rrrr";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // WorkoutDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.loadPlannedWorkoutButton);
            this.Controls.Add(this.plannedWorkoutListBox);
            this.Controls.Add(this.loadWorkoutButton);
            this.Controls.Add(this.selectWorkoutDropDown);
            this.Controls.Add(this.planYourWorkoutButton);
            this.Controls.Add(this.createWorkoutButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "WorkoutDashboardForm";
            this.Text = "Workout Dashboard";
            this.Shown += new System.EventHandler(this.WorkoutDashboardForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createWorkoutButton;
        private System.Windows.Forms.Button planYourWorkoutButton;
        private System.Windows.Forms.ComboBox selectWorkoutDropDown;
        private System.Windows.Forms.Button loadWorkoutButton;
        private System.Windows.Forms.ListBox plannedWorkoutListBox;
        private System.Windows.Forms.Button loadPlannedWorkoutButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Timer timer;
    }
}