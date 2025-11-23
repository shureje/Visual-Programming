using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class FileMaker
    {
        public FileMaker() 
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("../../binaryFile.dat", FileMode.OpenOrCreate)))
            {
                Random random = new Random();
                byte [] buffer = new byte[1024];
                for (int i = 0; i < 1000000; i++)
                {
                    random.NextBytes(buffer);
                    writer.Write(buffer);
                }
               
            }
        }
    }
}
