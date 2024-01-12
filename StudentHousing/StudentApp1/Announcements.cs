using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class Announcements : Form
    {
        private string jsonFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementMessage.json");
        private string StudentName;

        public Announcements()
        {
            InitializeComponent();
            this.Padding = new Padding(0, 50, 0, 0);
            backLabel.Location = new Point(10, 10); 

            LoadJsonContent();
        }




        private void LoadJsonContent()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string jsonFilePath = Path.Combine(desktopPath, jsonFileName);

                if (File.Exists(jsonFilePath))
                {
                    string jsonContent = File.ReadAllText(jsonFilePath);
                    MatchCollection matches = Regex.Matches(jsonContent, "\"([^\"]*)\"");
                    foreach (Match match in matches)
                    {
                        TextBox textBox = new TextBox
                        {
                            Multiline = true,
                            ReadOnly = true,
                            Text = match.Groups[1].Value.Trim(),
                            Dock = DockStyle.Top,
                            Height = 50
                        };

                        Controls.Add(textBox);
                    }
                }
                else
                {
                    TextBox textBox = new TextBox
                    {
                        Multiline = true,
                        ReadOnly = true,
                        Text = "No JSON file found.",
                        Dock = DockStyle.Top,
                        Height = 50
                    };

                    Controls.Add(textBox);
                }
            }
            catch (Exception ex)
            {
                // Display an error message
                TextBox textBox = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Text = $"Error loading JSON content: {ex.Message}",
                    Dock = DockStyle.Top,
                    Height = 50 
                };

                Controls.Add(textBox);
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back()
        {
            MainForm form1 = new MainForm(CurrentUser.LoggedInUser);
            this.Close();
            form1.Show();
        }


        private void logoutLabel_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }
    }
}
