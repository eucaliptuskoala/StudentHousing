namespace StudentApp1
{
    partial class Announcements
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
            backLabel = new Label();
            SuspendLayout();
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backLabel.Location = new Point(10, 7);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(65, 29);
            backLabel.TabIndex = 0;
            backLabel.Text = "Back";
            backLabel.Click += backLabel_Click;
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(backLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Announcements";
            Text = "Announcements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backLabel;
    }
}