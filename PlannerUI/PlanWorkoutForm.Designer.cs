namespace PlannerUI
{
    partial class PlanWorkoutForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.planButton = new System.Windows.Forms.Button();
            this.workoutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.plannedWorkoutListBox = new System.Windows.Forms.ListBox();
            this.selectWorkoutDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addWorkoutToListButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.headerLabel.Location = new System.Drawing.Point(313, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(328, 50);
            this.headerLabel.TabIndex = 21;
            this.headerLabel.Text = "Plan Your Workout";
            // 
            // planButton
            // 
            this.planButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.planButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.planButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.planButton.Location = new System.Drawing.Point(135, 399);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(186, 68);
            this.planButton.TabIndex = 22;
            this.planButton.Text = "Plan";
            this.planButton.UseVisualStyleBackColor = false;
            this.planButton.Click += new System.EventHandler(this.PlanButton_Click);
            // 
            // workoutDateTimePicker
            // 
            this.workoutDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.workoutDateTimePicker.CustomFormat = "dd.MM.yyyy | HH:mm";
            this.workoutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.workoutDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.workoutDateTimePicker.Location = new System.Drawing.Point(12, 224);
            this.workoutDateTimePicker.Name = "workoutDateTimePicker";
            this.workoutDateTimePicker.Size = new System.Drawing.Size(217, 35);
            this.workoutDateTimePicker.TabIndex = 23;
            // 
            // plannedWorkoutListBox
            // 
            this.plannedWorkoutListBox.BackColor = System.Drawing.Color.Lavender;
            this.plannedWorkoutListBox.FormattingEnabled = true;
            this.plannedWorkoutListBox.ItemHeight = 30;
            this.plannedWorkoutListBox.Location = new System.Drawing.Point(477, 103);
            this.plannedWorkoutListBox.Name = "plannedWorkoutListBox";
            this.plannedWorkoutListBox.Size = new System.Drawing.Size(387, 364);
            this.plannedWorkoutListBox.TabIndex = 25;
            // 
            // selectWorkoutDropDown
            // 
            this.selectWorkoutDropDown.BackColor = System.Drawing.Color.Lavender;
            this.selectWorkoutDropDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selectWorkoutDropDown.FormattingEnabled = true;
            this.selectWorkoutDropDown.Location = new System.Drawing.Point(12, 123);
            this.selectWorkoutDropDown.Name = "selectWorkoutDropDown";
            this.selectWorkoutDropDown.Size = new System.Drawing.Size(323, 38);
            this.selectWorkoutDropDown.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "ON";
            // 
            // addWorkoutToListButton
            // 
            this.addWorkoutToListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.addWorkoutToListButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addWorkoutToListButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addWorkoutToListButton.Location = new System.Drawing.Point(305, 213);
            this.addWorkoutToListButton.Name = "addWorkoutToListButton";
            this.addWorkoutToListButton.Size = new System.Drawing.Size(122, 46);
            this.addWorkoutToListButton.TabIndex = 28;
            this.addWorkoutToListButton.Text = "Add";
            this.addWorkoutToListButton.UseVisualStyleBackColor = false;
            this.addWorkoutToListButton.Click += new System.EventHandler(this.AddWorkoutToListButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.removeSelectedButton.Location = new System.Drawing.Point(893, 251);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(120, 68);
            this.removeSelectedButton.TabIndex = 29;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(849, 25);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(62, 30);
            this.currentTimeLabel.TabIndex = 31;
            this.currentTimeLabel.Text = "00:00";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(917, 25);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 30);
            this.currentDateLabel.TabIndex = 30;
            this.currentDateLabel.Text = "dd.MM.rrrr";
            // 
            // dateTimer
            // 
            this.dateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // PlanWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1042, 490);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.addWorkoutToListButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectWorkoutDropDown);
            this.Controls.Add(this.plannedWorkoutListBox);
            this.Controls.Add(this.workoutDateTimePicker);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PlanWorkoutForm";
            this.Text = "Plan Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.DateTimePicker workoutDateTimePicker;
        private System.Windows.Forms.ListBox plannedWorkoutListBox;
        private System.Windows.Forms.ComboBox selectWorkoutDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addWorkoutToListButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Timer dateTimer;
    }
}