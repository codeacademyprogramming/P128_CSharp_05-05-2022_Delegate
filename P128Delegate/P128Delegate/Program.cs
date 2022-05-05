using System;

namespace P128Delegate
{
    class Program
    {
        public delegate bool CheckNum<T>(T item);
        public delegate bool CheckNum();
        public delegate bool CheckNum<T,U>(T n, U m);
        //public delegate int Test(int[] arr, CheckNum checkNum);

        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //CheckNum checkNumEven = new CheckNum(IsEven);
            //CheckNum checkNumOdd = new CheckNum(IsOdd);

            //Console.WriteLine(Sum(arr, checkNumEven));
            //Console.WriteLine(Sum(arr, checkNumOdd));

            //CheckNum<int> checkNum = IsEven;
            //checkNum += Test1;
            //checkNum += IsOdd;
            //checkNum += Test;
            //checkNum -= Test;
            ////Anonym Method Sintacsis
            //checkNum += 
            //    delegate (int num) 
            //    {
            //        Console.WriteLine("Anonym Method {0} {1}", num % 5 == 0, 128);
            //        return num % 5 == 0;
            //    };
            ////Lambda Expresion Sintacsis - One Parametr
            //checkNum += n => n % 7 == 0;
            ////Lambda Expresion Sintacsis - Parametrless
            //CheckNum checkNum1 = () => 2 % 7 == 0;
            ////Lambda Expresion Sintacsis - Grater Than 1 parametr
            //CheckNum<int, byte> checkNum2 = (n, a) => n % 7 == 0;
            ////checkNum += n => 
            ////{
            ////    Console.WriteLine("Lambda Method {0} {1}", n % 5 == 0, 128);
            ////    return n % 7 == 0;
            ////};
            //checkNum(8);

            //Console.WriteLine();

        }

        //static int Sum(int[] arr, CheckNum<int> checkNum)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (checkNum(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        ////static int SumOdd(int[] arr)
        ////{
        ////    int result = 0;

        ////    foreach (int item in arr)
        ////    {
        ////        if (IsOdd(item))
        ////        {
        ////            result += item;
        ////        }
        ////    }

        ////    return result;
        ////}

        //static bool IsOdd(int num)
        //{
        //    Console.WriteLine("IsOdd {0} {1}", num % 2 != 0, 128);
        //    return num % 2 != 0;
        //}

        //static bool IsEven(int num)
        //{
        //    Console.WriteLine("IsEven {0} {1}", num % 2 == 0, 128);
        //    return num % 2 == 0;
        //}

        //static bool Test(int num)
        //{
        //    Console.WriteLine("Test");
        //    return false;
        //}

        //static bool Test1<T>(T num)
        //{
        //    Console.WriteLine("Test Generic");
        //    return false;
        //}
    }
}
