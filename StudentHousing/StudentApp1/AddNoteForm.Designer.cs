namespace StudentApp1
{
    partial class AddNoteForm
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
            BackButton = new Button();
            label1 = new Label();
            textBoxNote = new RichTextBox();
            btnAddNote = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(8, 25);
            BackButton.Margin = new Padding(2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(102, 38);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 142);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "Add a note";
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(364, 179);
            textBoxNote.Margin = new Padding(2);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(292, 102);
            textBoxNote.TabIndex = 5;
            textBoxNote.Text = "";
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(468, 363);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(75, 23);
            btnAddNote.TabIndex = 6;
            btnAddNote.Text = "button1";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click_1;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 513);
            Controls.Add(btnAddNote);
            Controls.Add(textBoxNote);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Margin = new Padding(2);
            Name = "AddNoteForm";
            Text = "AddNoteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Label label1;
        private RichTextBox textBoxNote;
        private Button btnAddNote;
    }
}