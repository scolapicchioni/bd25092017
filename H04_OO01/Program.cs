using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO01 {
    class Program {
        static void Main(string[] args) {
            //step 1: variable declaration
            Random generator;
            //step 2: initialization with a new object
            generator = new Random();

            //step 3: invoke the method
            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);

            //int i = 5;

            //step 1: variable declaration
            //step 2: instance 
            FileInfo something = new FileInfo(@"C:\program files\something.txt");
            //step 3: use it
            Console.WriteLine(something.Exists);

            FileStream fs = something.OpenWrite();
            //fs.
            //string x;
            //fs = x;
            //x = fs;

            //DirectoryInfo di = new DirectoryInfo(@"C:\CM");
            //FileInfo[] filesInCM = di.GetFiles();
            //foreach (FileInfo info in filesInCM) {
            //    info.Name
            //}


            FileInfo temp = new FileInfo(@"C:\temp.txt");
            Console.WriteLine(temp.Exists);

            ArrayList arrayList = new ArrayList();
            int position = arrayList.Add(1);
            arrayList.Add(4);
            arrayList.Add(2);
            arrayList.Add(5);

            //arrayList.Count = 2;



            Console.WriteLine(dice1);
            Console.ReadLine();
        }
    }
}
