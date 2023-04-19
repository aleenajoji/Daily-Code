using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace FileStream1
{
    internal class WriteAndReader
    {
        static string file = @"D:\Training\DAY 13\poem.txt";
        static void Main(string[] args)
        {
            write();
            read();
        }
        static void write()
        {
            StreamWriter fileStream=new StreamWriter(file);
            fileStream.WriteLine("Hello guyss");
            fileStream.WriteLine("jkhsasj");
            fileStream.Close();
        }
        static void read() { 
            StreamReader sr=new StreamReader(file);
            String s = null;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);   
            }
            sr.Close();
        }
    }
}
