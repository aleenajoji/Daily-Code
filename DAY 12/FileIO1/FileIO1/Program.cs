using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo temp=new DirectoryInfo("D:\\Training\\DAY 12\\FileIO1\\io1");
            temp.Create();
            Console.WriteLine("***** Directory Info *****\n");



            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

            Console.WriteLine("FullName: {0}", dir.FullName);

            Console.WriteLine("Name: {0}", dir.Name);

            Console.WriteLine("Parent: {0}", dir.Parent);

            Console.WriteLine("Creation: {0}", dir.CreationTime);

            Console.WriteLine("Attributes: {0}", dir.Attributes);

            Console.WriteLine("Root: {0}", dir.Root);
            
            Console.WriteLine("**************************\n");

            DriveInfo[] myDrive = DriveInfo.GetDrives();

            Console.WriteLine("**************************\n");
        }
    }
}
