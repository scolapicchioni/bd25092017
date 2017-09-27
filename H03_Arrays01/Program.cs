using System;


namespace H03_Arrays01 {
    class Program {
        static void Main(string[] args) {
            //int[] listOfNumbers; //null
            //string[] listOfStrings = new string[5]; //null

            //listOfNumbers = new int[5];

            int a;
            a = 5;
            int b = a;
            Console.WriteLine($"a == {a} and b == {b}");

            b = 10;
            Console.WriteLine($"a == {a} and b == {b}");

            int[] listOfNumbersA = new int[5]; //0
            Console.WriteLine($"listOfNumbersA[0] == {listOfNumbersA[0]}");
            Console.WriteLine($"listOfNumbersA[1] == {listOfNumbersA[1]}");
            Console.WriteLine($"listOfNumbersA[2] == {listOfNumbersA[2]}");
            Console.WriteLine($"listOfNumbersA[3] == {listOfNumbersA[3]}");
            Console.WriteLine($"listOfNumbersA[4] == {listOfNumbersA[4]}");

            bool[] listOfBoolsA = new bool[5]; //false
            Console.WriteLine("****************************");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"listOfBoolsA[{i}] == {listOfBoolsA[i]}");
            }

            listOfNumbersA[0] = 42;
            listOfNumbersA[1] = 23;
            listOfNumbersA[2] = 65;
            listOfNumbersA[3] = 12;
            listOfNumbersA[4] = 78;

            //listOfNumbersA = 42;
            Console.WriteLine("****************************");
            for (int i = 0; i < listOfNumbersA.Length; i++) {
                Console.WriteLine($"listOfNumbersA[{i}] == {listOfNumbersA[i]}");
            }

            Console.WriteLine("****************************");
            Console.WriteLine($"listOfNumbersA.Length == {listOfNumbersA.Length}");

            int[,] matrixA = new int[5, 3];
            Console.WriteLine(matrixA.Length);

            matrixA[0, 0] = 0;
            matrixA[0, 1] = 1;
            matrixA[0, 2] = 2;
            matrixA[1, 0] = 10;
            matrixA[1, 1] = 11;
            matrixA[1, 2] = 12;
            matrixA[2, 0] = 20;
            matrixA[2, 1] = 21;
            matrixA[2, 2] = 22;
            matrixA[3, 0] = 40;
            matrixA[3, 1] = 41;
            matrixA[3, 2] = 42;
            matrixA[4, 0] = 40;
            matrixA[4, 1] = 41;
            matrixA[4, 2] = 42;

            for (int r = 0; r < matrixA.GetLength(0); r++) {
                for (int c = 0; c < matrixA.GetLength(1); c++) {
                    matrixA[r, c] = (r + 1) * (c + 1);
                }
            }

            Console.WriteLine("******************************");
            for (int r = 0; r < matrixA.GetLength(0); r++) {
                for (int c = 0; c < matrixA.GetLength(1); c++) {
                    Console.Write($"{matrixA[r, c]}\t");
                }
                Console.WriteLine();
            }

            //int[,,] block = new int[5, 3, 8];

            //block.GetLength(0);

            // int[,,,,,,] block = new int[5, 3, 8,5,4,3,5];

            //block.Rank
            Array.Sort(listOfNumbersA);

            Console.WriteLine("***********************");
            for (int i = 0; i < listOfNumbersA.Length; i++) {
                Console.WriteLine($"listOfNumbersA[i] == {listOfNumbersA[i]}");
            }

            string[] listOfStrings;

            Console.WriteLine("How many words?");
            int wordsNumber = int.Parse(Console.ReadLine());
            listOfStrings = new string[wordsNumber]; //null

            for (int i = 0; i < listOfStrings.Length; i++) {
                Console.Write($"Word {i}: ");
                listOfStrings[i] = Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
