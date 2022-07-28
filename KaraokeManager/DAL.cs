using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager
{
    class DAL
    {
        public DAL()
        {

        }
        public void WriteToFile(String content, String filename)
        {
            File.WriteAllText(filename, content);
        }
        
        public String readNameFromFile(string filename)
        {
            String username = File.ReadAllText(filename);
            return username;
        }
    }
}
