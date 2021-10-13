using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer
{
    internal class FileHandler
    {
        public void createFile(string user, string pass)
        {
            string fileName = @"Accounts.txt";

            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                }
                else
                {
                    FileStream fs = new FileStream(fileName, FileMode.Append,FileAccess.Write,FileShare.Read);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(user + " " + pass);
                        
                    }
                    fs.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
