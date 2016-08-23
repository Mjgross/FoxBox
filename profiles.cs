using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FoxBoxCDemo
{


    public class profiles
    {

        public string mainFolder; //contains the main FoxBox folder
        public string profileFolder;    //contains the profile Folder
        public string[] filePaths;
        public string userName;

        private Form1 proForm;

        public profiles(Form1 mainForm)
        {
            proForm = mainForm;
        }


        public void profileCheck()
        {


            string profileDest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appendTo = profileDest + "\\FoxBox";
            string profilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FoxBox\\Profiles";
            try
            {

                if (!Directory.Exists(appendTo))
                {
                    DirectoryInfo direct = Directory.CreateDirectory(appendTo);
                    //  mainFolder = appendTo;
                }

                if (!Directory.Exists(profilePath))
                {
                    DirectoryInfo profPath = Directory.CreateDirectory(profilePath);
                    // profileFolder = profilePath;
                }
                mainFolder = appendTo;
                profileFolder = profilePath;
                populateProfiles();
            }
            catch (Exception ex)
            {
                 //("Unable to create/find main folder.")
            }
        }

        public void populateProfiles()
        {
            try
            {
                proForm.ProfileBox.Items.Clear();
                filePaths = Directory.GetFiles(profileFolder, "*.txt");
                for (Int32 i = 0; i <= filePaths.Length - 1; i++)
                {
                    string direct = Path.GetFileNameWithoutExtension(filePaths[i]);
                    proForm.ProfileBox.Items.Add(direct);

                }

            }
            catch (Exception ex)
            {

            }
        }

        public void createProfile()
        {
            userName = proForm.profileNameCreate.Text;
            
                string newProfile = profileFolder + "\\" + userName;
            try
            {


                StreamWriter sw = File.CreateText(newProfile + ".txt");
                sw.Close();
                populateProfiles();
            }
            catch
            {
               // proForm.Message
            }

        }

        public void updateApps(string user)
        {
            try
            {
                proForm.ApplicationBox.Items.Clear();
                string line;
                string path = profileFolder + "\\" + user + ".txt";
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while((line = file.ReadLine()) != null){
                    proForm.ApplicationBox.Items.Add(line);
                }
                file.Close();
            }
            catch
            {

            }
        }
    }

}

       
    

