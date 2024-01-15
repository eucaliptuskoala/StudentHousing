using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class AddNoteForm : Form
    {
        private readonly Room userRoom;

        public AddNoteForm(Room room)
        {
            InitializeComponent();
            userRoom = room;
        }

        private void SaveRoomToJson()
        {
            string roomsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\rooms.json");

            try
            {
                // Читаем существующий JSON из файла
                string existingJson = File.Exists(roomsFilePath) ? File.ReadAllText(roomsFilePath) : "";

                // Десериализуем JSON в список комнат
                List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(existingJson) ?? new List<Room>();

                // Находим текущую комнату в списке (или создаем новую, если ее нет)
                Room currentRoom = rooms.FirstOrDefault(r => r.RoomNumber == userRoom.RoomNumber);
                if (currentRoom == null)
                {
                    currentRoom = new Room(userRoom.RoomNumber);
                    rooms.Add(currentRoom);
                }

                // Обновляем данные текущей комнаты (замените на свою логику)
                currentRoom.Notes = userRoom.Notes;

                // Сериализуем список комнат обратно в JSON
                string updatedJson = JsonConvert.SerializeObject(rooms, Formatting.Indented);

                // Пишем обновленный JSON обратно в файл
                File.WriteAllText(roomsFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving room to JSON file: {ex.Message}");
            }
        }

        private void btnAddNote_Click_1(object sender, EventArgs e)
        {
            string noteContent = textBoxNote.Text;

            if (!string.IsNullOrEmpty(noteContent))
            {
                // Create a new Note
                Note newNote = new Note(noteContent);

                // Add the note to the user's room
                userRoom.Notes.Add(newNote);

                // Save the room to update the notes in the file
                SaveRoomToJson();

                MessageBox.Show("Note added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a note before adding.");
            }
        }
    }
}
