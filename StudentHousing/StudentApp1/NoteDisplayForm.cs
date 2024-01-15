using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace StudentApp1
{
    public partial class NoteDisplayForm : Form
    {
        private readonly User currentUser;
        private readonly Room userRoom;
        private List<Note> notes;

        public NoteDisplayForm(User user, Room room)
        {
            InitializeComponent();
            currentUser = user;
            userRoom = room;
            LoadNotesForCurrentUserRoom();
        }

        private void LoadNotesForCurrentUserRoom()
        {
            if (userRoom != null)
            {
                notes = userRoom.Notes;

                DisplayLatestNotes(notes);
            }
            else
            {
                MessageBox.Show("User is not assigned to any room.");
            }
        }

        private void DisplayLatestNotes(List<Note> notes)
        {

            tableLayoutPanel.Controls.Clear();

            // Display the latest 4 notes
            int startIndex = Math.Max(0, notes.Count - 4);

            for (int i = startIndex; i < notes.Count; i++)
            {
                Note note = notes[i];

                // Создаем новый Label для отображения заметки
                Label label = new Label();
                label.Text = note.Content; // Устанавливаем текст заметки

                // Добавляем Label в tableLayoutPanel
                tableLayoutPanel.Controls.Add(label);
            }
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm(currentUser);
            this.Close();
            form1.Show();
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            AddNoteForm addNotesForm = new AddNoteForm(userRoom);
            addNotesForm.ShowDialog();

            // Reload notes after adding
            LoadNotesForCurrentUserRoom();
        }
    }
}
