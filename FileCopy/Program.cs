using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\PacsFile\1212\image\38\38242\超声\13641\img2.jpg";
            string path2 = @"D:\PacsFile\1212\image\38\38242\超声\13641\img4.jpg";
            string path3 = @"D:\PacsFile\1212\image\38\38242\超声\13641\img6.jpg";
            try
            {

                // Ensure that the target does not exist.
                File.Delete(path2);

                // Copy the file.
                File.Copy(path, path2);
                Console.WriteLine("{0} copied to {1}", path, path2);
                using (FileStream fs = new FileStream(path2, FileMode.Open))
                {
                    byte[] by = new byte[fs.Length];
                    fs.Read(by, 0, (int)fs.Length);
                    using (FileStream n = new FileStream(path3, FileMode.OpenOrCreate))
                    {
                        n.Write(by, 0, by.Length);
                    }
                }
                // Try to copy the same file again, which should fail.
                //File.Copy(path, path2);
                Console.WriteLine("The second Copy operation succeeded, which was not expected.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Double copying is not allowed, as expected.");
                Console.WriteLine(e.ToString());
            }

        }
    }
}
