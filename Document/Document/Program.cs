using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Document");
            Console.WriteLine(" ");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            string content;
            Console.WriteLine();
            Console.Write("What content is inside the document?: ");
            content = Console.ReadLine();

            int count = 0;
            foreach (char c in content)
            {
                count++;
            }

            string fileName;
            fileName = name + ".txt";

            string dir;
            dir = fileName;

            try
            {
                StreamWriter sw = new StreamWriter(dir);
                sw.WriteLine("{0}", content);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return;
            }
            finally
            {
                Console.WriteLine(" ");
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", fileName, count);
            }
            Console.ReadLine();
        }
    }
}
