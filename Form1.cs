using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FoxBoxCDemo
{
    public partial class Form1 : Form
    {
        //public vars
        OpenFileDialog file = new OpenFileDialog();
        string[] list = new string[10];
        string finalDir;
        string selectedUser;
        string[] userApps = new string[10];

        //private form
        private profiles pro;

        public Form1()
        {
            InitializeComponent();
            pro = new profiles(this);
            pro.profileCheck();

        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(selectedUser) && (ApplicationBox.Items.Count > 0))
            {
                //StreamWriter stream = File.CreateText(pro.profileFolder + "\\" + selectedUser + ".txt");
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                System.IO.File.WriteAllLines(pro.profileFolder + "\\" + selectedUser + ".txt", userApps);
                // System.IO.File.Copy("C:\\Users\\Matt\\Documents\\ASU\\Junior\\FSE301\\FoxBoxC\\FoxBoxCDemo\\OpenApplication\\bin\\Release\\OpenApplication.exe", pro.mainFolder + "\\OpenApplication.exe", true);
                System.IO.File.Copy(docPath + "\\FoxBox\\FoxBoxCDemo\\OpenApplication\\bin\\Release\\OpenApplication.exe", pro.mainFolder + "\\OpenApplication.exe", true);
                System.IO.File.Move(pro.mainFolder + "\\OpenApplication.exe", pro.mainFolder + "\\" + selectedUser + ".exe");
                //  System.IO.File.Copy("C:\\Users\\Matt\\Documents\\ASU\\Junior\\FSE301\\FoxBoxC\\FoxBoxCDemo\\OpenApplication\\bin\\Release\\OpenApplication.exe", "C:\\Program Files" + "\\OpenApplication.exe");
                //  System.IO.File.Move("C:\\Program Files" + "\\OpenApplication.exe", "C:\\Program Files\\" + selectedUser + ".exe");

                //  ProcessStartInfo startInfo = new ProcessStartInfo();
                // startInfo.FileName = "C:\\Users\\Matt\\Documents\\ASU\\Junior\\FSE301\\FoxBoxC\\FoxBoxCDemo\\OpenApplication";

                // Process.Start(startInfo);
                File.SetAttributes(pro.mainFolder + "\\" + selectedUser + ".exe", FileAttributes.Normal);
                MessageBox.Show("saving");
                //  "C:\\Users\\Matt\\Documents\\ASU\\Junior\\FSE301\\FoxBoxC\\FoxBoxCDemo\\OpenApplication"

                //TESTING HERE
               
            }

            else
            {

                MessageBox.Show("There must be an application to be saved.");
            }
        }

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
        private void populateList()
        {
            //ApplicationBox.Items.Add(finalDir);
            /*ApplicationBox.Items.
            int arraySize = 0;
            for (Int32 i = 0; i <= list.Length - 1; i++)
            {
                if (list[i] != null)
                    arraySize++;
            }
            string[] array = new string[arraySize];
            for(Int32 i = 0; i <= array.Length-1; i++)
            {
                array[i] = list[i];
                ApplicationBox.Items.Add(array[i]);
            } */
            

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if(ProfileBox.SelectedIndex != -1)
            {
                try
                {
                    ProfileBox.Items.Remove(ProfileBox.SelectedItem);
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
