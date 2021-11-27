using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите предложение:");
           string text = Console.ReadLine(); //ввод предложения с клавиатуры
           string[] sArray = text.Split(); //разделение строки на массив

           int maxLength = 0; //переменная максимального значения длины слова
            //определяем элемент(слово) с максимальным количеством букв
            foreach (string s in sArray) //цикл перебирает все элементы(слова) массива и сравнивает с текущим максимальным значением
            {
                if (s.Length > maxLength) 
                {
                    maxLength = s.Length; //записывает текущее значение в переменную
                }
            }   
            
            int longWord = 0;
            foreach (string s in sArray) //цикл перебирает все элементы (кол-во символов) массива и сравнивает со значением переменной maxLenght
            {
                int i = Convert.ToInt32(s.Length);
                if (i == maxLength) //проверяет условие, если текущее i равно maxLenght, то выводит результат
                {
                    longWord++;
                    Console.WriteLine("Самое длинное слово - {0} состоит из {1} букв", s, maxLength); //вывод результата - строка и максимальное количество букв
                }
            }
                    Console.ReadKey();
        }
    }
}
