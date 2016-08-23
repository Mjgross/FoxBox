using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace FoxBoxCDemo
{
    public partial class Form1 : Form
    {
        //Total amount of users and files allowed
        const int size = 50;

        //public vars
        OpenFileDialog file = new OpenFileDialog();
        string[] list = new string[size];
        string finalDir;
        string selectedUser;
        string[] userApps = new string[size];

        //private form
        private profiles pro;

        //Form Initiation
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            pro = new profiles(this);
            pro.profileCheck();
            

        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //ensures that a user is selected and there is atleast 1 application to be saved
            //Writes each app file location to a text file
            //Creates a new OpenApplication file and saves it to the documents folder
            if (!string.IsNullOrWhiteSpace(selectedUser) && (ApplicationBox.Items.Count > 0))
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                System.IO.File.WriteAllLines(pro.profileFolder + "\\" + selectedUser + ".txt", userApps);          
                System.IO.File.Copy(docPath + "\\FoxBox\\FoxBoxCDemo\\OpenApplication\\bin\\Release\\OpenApplication.exe", pro.mainFolder + "\\OpenApplication.exe", true);
                System.IO.File.Move(pro.mainFolder + "\\OpenApplication.exe", pro.mainFolder + "\\" + selectedUser + ".exe");
                File.SetAttributes(pro.mainFolder + "\\" + selectedUser + ".exe", FileAttributes.Normal);
                MessageBox.Show("saving");         
            }

            else
            {
                //dialog box
                DialogResult dia;
                string message = "Please select a profile to save to.";
                string caption = "No profile selected.";
                dia = MessageBox.Show(message, caption);
            }
        }

        //Openfile function
        //Pulls up the w
        private void openFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    for(Int32 i = 0; i < list.Length-1; i++)
                    {
                        if(string.IsNullOrWhiteSpace(list[i]))
                        {
                            finalDir = Path.GetFileNameWithoutExtension(file.FileName);
                            list[i] = finalDir;
                            break;
                        }    
                    }
                    for (Int32 i = 0; i < list.Length - 1; i++)
                    {
                        if (string.IsNullOrWhiteSpace(userApps[i]))
                        {
                            userApps[i] = Path.GetFullPath(file.FileName);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open file. Error: " + ex.Message);
            }
            ApplicationBox.Items.Add(finalDir);
     }

        //Removes the selected Application from the Profile
        private void removeApp_Click(object sender, EventArgs e)
        {
           if(ApplicationBox.SelectedIndex != -1)
                ApplicationBox.Items.Remove(ApplicationBox.SelectedItem);
            else
            {
                MessageBox.Show("Please select an application to remove.");
            }
        }

         private void ProfileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: update apps when profile index changes
            if (ProfileBox.SelectedItem != null)
            {
                string profileUser = ProfileBox.SelectedItem.ToString();
                pro.updateApps(profileUser);
                ApplicationBox.Show();
                selectedUser = profileUser;
            }
        } 

        //creates profile for the user. Names cannot be the same
        private void createProf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(profileNameCreate.Text))
            {
                pro.createProfile();
            }
            else
            {
                MessageBox.Show("Cannot create profile");
            }
        }

        //remove profile and all contents associated with it
        private void button1_Click(object sender, EventArgs e)
        {
            if(ProfileBox.SelectedIndex != -1)
            {
                try
                {
                    ProfileBox.Items.Remove(ProfileBox.SelectedItem);
                    ApplicationBox.Items.Clear();
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    System.IO.File.Delete(pro.profileFolder + "\\" + selectedUser + ".txt");
                    System.IO.File.Delete(docPath + "\\FoxBox\\" + selectedUser + ".exe");
                }
                catch
                {
                    MessageBox.Show("Error cannot remove profile.");
                }
            }
        }
    }
}
