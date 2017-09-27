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

            //int[,] matrixA = new int[5, 3];
            //Console.WriteLine(matrixA.Length);

            //matrixA[0, 0] = 0;
            //matrixA[0, 1] = 1;
            //matrixA[0, 2] = 2;
            //matrixA[1, 0] = 10;
            //matrixA[1, 1] = 11;
            //matrixA[1, 2] = 12;
            //matrixA[2, 0] = 20;
            //matrixA[2, 1] = 21;
            //matrixA[2, 2] = 22;
            //matrixA[3, 0] = 40;
            //matrixA[3, 1] = 41;
            //matrixA[3, 2] = 42;
            //matrixA[4, 0] = 40;
            //matrixA[4, 1] = 41;
            //matrixA[4, 2] = 42;



            int[,] matrixA = new int[,] {
                { 0, 1, 2 },
                { 10,11,12 },
                { 20,21,22},
                { 30,31,32},
                { 40,41,42}
            };

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


            //string[] italianDays = new string[7];

            //italianDays[0] = "Lunedi";
            //italianDays[1] = "Martedi";
            //italianDays[2] = "Mercoledi";
            //italianDays[3] = "Giovedi";
            //italianDays[4] = "Venerdi";
            //italianDays[5] = "Sabato";
            //italianDays[6] = "Domenica";

            //string[] italianDays = new string[7] {
            //    "Lunedi", "Martedi", "Mercoledi",
            //    "Giovedi", "Venerdi", "Sabato", "Domenica"
            //};

            string[] italianDays = new string[] {
                "Lunedi", "Martedi", "Mercoledi",
                "Giovedi", "Venerdi", "Sabato", "Domenica"
            };

            int[][] listOfListsOfNumbers = new int[5][];
            listOfListsOfNumbers[0] = new int[3];
            listOfListsOfNumbers[1] = new int[7];
            listOfListsOfNumbers[2] = new int[8];
            listOfListsOfNumbers[3] = new int[2];
            listOfListsOfNumbers[4] = new int[22];

            listOfListsOfNumbers[4][0] = 22;

            Console.WriteLine("*******************************");

            int[] numbersA = new int[] {5,10,15,20 };

            int[] numbersB = numbersA;

            numbersB[0] = 2000;

            for (int i = 0; i < numbersA.Length; i++) {
                Console.WriteLine($"numbersA[{i}] == {numbersA[i]}; numbersB[{i}] == {numbersB[i]}");
            }

            int[] temp = new int[5];

            for (int i = 0; i < numbersA.Length; i++) {
                temp[i] = numbersA[i];
            }
            numbersA = temp;

            foreach (string day in italianDays) {
                Console.WriteLine(day);
            }


            int[] list3 = new int[100];

            list3[0] = 12;
            list3[1] = 12;
            list3[2] = 12;
            list3[3] = 12;


            Console.ReadLine();
        }
    }
}
