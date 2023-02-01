using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string[] wordArr;
            int wordLenght, index;
            bool isCheck;
            do
            {
                Console.Write("Lütfen kelime ve sayı girin (xxxxx,1): ");
                word = Console.ReadLine();
                wordArr = word.Split(',');
                wordLenght = wordArr[0].Length;
                index = int.Parse(wordArr[1]);
                if (wordLenght > index)
                {
                    isCheck = true;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş..");
                    isCheck = false;
                }
            } while (isCheck == false);

            System.Console.WriteLine(wordArr[0].Remove(index - 1, 1));

        }
    }
}