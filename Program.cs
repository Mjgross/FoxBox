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
        }

    }
}
