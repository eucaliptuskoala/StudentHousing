﻿namespace StudentApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            HelloText = new Label();
            Schedule = new Button();
            ToDo = new Button();
            Announcements = new Button();
            Rules = new Button();
            LogOutLabel = new Label();
            Complaints = new Button();
            Notes = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.BackColor = Color.Transparent;
            HelloText.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            HelloText.ForeColor = Color.WhiteSmoke;
            HelloText.Location = new Point(551, 62);
            HelloText.Margin = new Padding(4, 0, 4, 0);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(68, 44);
            HelloText.TabIndex = 0;
            HelloText.Text = "Hi!";
            // 
            // Schedule
            // 
            Schedule.Anchor = AnchorStyles.None;
            Schedule.BackColor = Color.Snow;
            Schedule.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Schedule.Location = new Point(454, 341);
            Schedule.Margin = new Padding(4, 5, 4, 5);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(264, 197);
            Schedule.TabIndex = 2;
            Schedule.Text = "Schedule\r\n";
            Schedule.UseVisualStyleBackColor = false;
            Schedule.Click += Schedule_Click;
            // 
            // ToDo
            // 
            ToDo.Anchor = AnchorStyles.Right;
            ToDo.BackColor = Color.Snow;
            ToDo.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            ToDo.Location = new Point(840, 341);
            ToDo.Margin = new Padding(4, 5, 4, 5);
            ToDo.Name = "ToDo";
            ToDo.Size = new Size(264, 197);
            ToDo.TabIndex = 3;
            ToDo.Text = "To Do List";
            ToDo.UseVisualStyleBackColor = false;
            ToDo.Click += ToDo_Click;
            // 
            // Announcements
            // 
            Announcements.BackColor = Color.Snow;
            Announcements.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Announcements.Location = new Point(48, 341);
            Announcements.Margin = new Padding(4, 5, 4, 5);
            Announcements.Name = "Announcements";
            Announcements.Size = new Size(264, 197);
            Announcements.TabIndex = 5;
            Announcements.Text = "Announcements";
            Announcements.UseVisualStyleBackColor = false;
            Announcements.Click += Announcements_Click;
            // 
            // Rules
            // 
            Rules.Anchor = AnchorStyles.Bottom;
            Rules.BackColor = Color.Snow;
            Rules.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Rules.Location = new Point(454, 672);
            Rules.Margin = new Padding(4, 5, 4, 5);
            Rules.Name = "Rules";
            Rules.RightToLeft = RightToLeft.Yes;
            Rules.Size = new Size(264, 197);
            Rules.TabIndex = 6;
            Rules.Text = "House Rules";
            Rules.UseVisualStyleBackColor = false;
            Rules.Click += Rules_Click;
            // 
            // LogOutLabel
            // 
            LogOutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogOutLabel.AutoSize = true;
            LogOutLabel.BackColor = Color.Transparent;
            LogOutLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            LogOutLabel.ForeColor = Color.GhostWhite;
            LogOutLabel.Location = new Point(942, 62);
            LogOutLabel.Margin = new Padding(4, 0, 4, 0);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(148, 44);
            LogOutLabel.TabIndex = 7;
            LogOutLabel.Text = "Log Out";
            LogOutLabel.Click += label1_Click;
            // 
            // Complaints
            // 
            Complaints.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Complaints.BackColor = Color.Snow;
            Complaints.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Complaints.Location = new Point(48, 672);
            Complaints.Margin = new Padding(4, 5, 4, 5);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(264, 197);
            Complaints.TabIndex = 8;
            Complaints.Text = "Leave a complaints";
            Complaints.UseVisualStyleBackColor = false;
            Complaints.Click += Complaints_Click;
            // 
            // Notes
            // 
            Notes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Notes.BackColor = Color.Snow;
            Notes.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Notes.Location = new Point(840, 672);
            Notes.Margin = new Padding(4, 5, 4, 5);
            Notes.Name = "Notes";
            Notes.RightToLeft = RightToLeft.Yes;
            Notes.Size = new Size(264, 197);
            Notes.TabIndex = 9;
            Notes.Text = "Notes";
            Notes.UseVisualStyleBackColor = false;
            Notes.Click += Notes_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Announcements);
            panel1.Controls.Add(Notes);
            panel1.Controls.Add(ToDo);
            panel1.Controls.Add(Rules);
            panel1.Controls.Add(Complaints);
            panel1.Controls.Add(HelloText);
            panel1.Controls.Add(LogOutLabel);
            panel1.Controls.Add(Schedule);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 994);
            panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = StudentHousing.Properties.Resources._8ecd7a74040c6137d8db25014de3cfaa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1207, 1063);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label HelloText;
        private Button Schedule;
        private Button ToDo;
        private Button Announcements;
        private Button Rules;
        private Label LogOutLabel;
        private Button Complaints;
        private Button Notes;
        private Panel panel1;
    }
}