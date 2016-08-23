using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace OpenApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            string line;

            string path = Directory.GetCurrentDirectory();  //path of program

            //Grabs the myDocuments/FoxBox/Profiles/"USER" txt file
            string profilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
                                 + "\\FoxBox\\Profiles\\"
                                 + System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".txt";
            string finalPath = profilePath.Replace("vshost", ""); 

            try
            {
                //StreamReader path to the Profile file
                StreamReader file = new StreamReader(finalPath);

                //opens each file in the text document
                while ((line = file.ReadLine()) != null)
                {
                    Process.Start(line);
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("Error Cannot Open File.");
            }
        }

    }
}
