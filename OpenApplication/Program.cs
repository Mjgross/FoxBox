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

           
            // System.Diagnostics.FileVersionInfo fileVer = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileVersionInfo;
            // Process[] currentProc = Process.GetProcessesByName("OpenApplication");
            //string wanted_path = Path.GetDirectoryName(this);
            // string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            //  string finalDir = Path.GetFileNameWithoutExtension(System.AppDomain.CurrentDomain.FriendlyName);
            //File.SetAttributes(this, FileAttributes.Normal);
            string path = Directory.GetCurrentDirectory();
            string profilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FoxBox\\Profiles";

            try {
                StreamReader file = new StreamReader(profilePath);

                while ((line = file.ReadLine()) != null)
                {
                    Process.Start(line);
                }
                file.Close();
            }
            catch
            {

            }
           // "C:\\Users\\Matt\\Documents\\ASU\\Junior\\FSE301\\FoxBoxC\\FoxBoxCDemo\\OpenApplication"
        }

    }
}
