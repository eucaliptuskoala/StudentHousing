using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace StudentApp1
{
    public partial class AdminForm : Form
    {
        private const string jsonFilePath = "users.json";
        private const string messageFilePath = "AnnouncementMessage.json";
        private UserDatabase userDatabase;
        private List<Room> rooms = new List<Room>();


        public AdminForm()
        {
            InitializeComponent();
            LoadUserData();
            InitializeRooms();

        }
        private void InitializeRooms()
        {
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room(i));
            }
        }

        private void LoadUserData()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                userDatabase = JsonConvert.DeserializeObject<UserDatabase>(json);
                if (userDatabase != null && userDatabase.Users != null)
                {
                    return;
                }
            }
                userDatabase = new UserDatabase { Users = new List<User>() };
            }
        

        private void SaveUserData()
        {
            string json = JsonConvert.SerializeObject(userDatabase);
            File.WriteAllText(jsonFilePath, json);
        }

        private void SaveTextToJsonFile(string text, string filePath)
        {
            try
            {
                string existingJson = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                List<string> messages = JsonConvert.DeserializeObject<List<string>>(existingJson) ?? new List<string>();
                messages.Add(text);
                string updatedJson = JsonConvert.SerializeObject(messages, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving text to JSON file: {ex.Message}");
            }
        }

        private void LogOut()
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void LogOutLabel1_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOutLabel2_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        public class UserDatabase
        {
            public List<User> Users { get; set; }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User newUser = new User
            {
                Id = userDatabase.Users.Count,
                Name = textBox1.Text,
                Username = textBox2.Text,
                Age = int.Parse(textBox3.Text),
                Email = textBox4.Text,
                Password = textBox5.Text,
                Room = int.Parse(textBox6.Text)
            };
            int roomNumber = int.Parse(textBox6.Text);
            rooms[roomNumber - 1].Register(newUser);
            rooms[roomNumber - 1].AssignTasksRandomly();

            userDatabase.Users.Add(newUser);
            SaveUserData();

            MessageBox.Show("User has been added!");

        }
        private void sendAnnouncement_btn_Click(object sender, EventArgs e)
        {
            string textToSave = textBox7.Text;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
            string textWithTime = $"{textToSave}          Time: {currentTime}";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), messageFilePath);

            SaveTextToJsonFile(textWithTime, filePath);

            MessageBox.Show("Saved to JSON file!");
        }
    }
}
