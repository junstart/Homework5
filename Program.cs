using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5
{
    /*#region Задание №1
    class Program
    {
        static int size1 = 0, size2 = 0, size3 = 0, size4 = 0;
        /// <summary>
        /// Вывод матрицы на экран
        /// </summary>
        /// <param name="m"></param>
        static void PrintMatrix(int[,] m)
        {
            int count = 0;
            foreach (int z in m)
            {
                count++;
                if (count % m.GetLength(0) == 1)
                {
                    Console.WriteLine();
                }
                Console.Write("{0,4}", z);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение матрицы случайными числами
        /// </summary>
        /// <param name="m"></param>
        /// <param name="r"></param>
        static void FillMatrix(int[,] m, Random r)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++) m[i, j] = r.Next(1, 20);
        }
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="m">Матрица</param>
        /// <param name="multy">Множитель</param>
        static int[,] MultyMatrix(int[,] m, int multy)
        {
            int[,] returnMatrix = new int [m.GetLength(0),m.GetLength(1)];
            for (int k = 0; k < m.GetLength(0); k++)
                for (int j = 0; j < m.GetLength(1); j++)
                    returnMatrix[k, j] = m[k, j] * multy;
                
            return returnMatrix;
        }
        /// <summary>
        /// Перемножение двух матриц
        /// </summary>
        /// <param name="m"></param>
        /// <param name="h"></param>
        static int[,] FullMultyMatrix(int[,] m, int[,] h)
        {
            int[,] returnMatrix = new int[m.GetLength(0), h.GetLength(1)];
            int temp = 0;

            Console.WriteLine("Результат умножения матриц");
            for (int k = 0; k < m.GetLength(0); k++)
            {
                for (int j = 0; j < h.GetLength(1); j++)
                {
                    for (int i = 0; i < m.GetLength(1); i++)
                    {
                        temp += m[k, i] * h[i, j];
                    }
                    returnMatrix[k, j] = temp;
                    temp = 0;
                }
            }    
            return returnMatrix;
            
        }
        /// <summary>
        /// Сумма двух матриц
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static int[,] SumMatrix(int[,] a, int[,] b)
        {
            int[,] returnMatrix = new int[a.GetLength(0), a.GetLength(1)];
                      
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                       returnMatrix[i,j] = a[i, j] + b[i, j];
            return returnMatrix;            
        }
        /// <summary>
        /// Вычмтание матриц
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static int[,] SubtractionMatrix(int[,] a, int[,] b)
        {
            int[,] returnMatrix = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    returnMatrix[i, j] = a[i, j] - b[i, j];
            return returnMatrix;
        }

        /// <summary>
        /// Проверка ввода пользователя
        /// </summary>
        /// <param name="t">ввод пользователя</param>
        /// <returns></returns>
        static int TestUserInput(string t)
        {
            int s = Convert.ToInt32(t);
            if (s <= 0) s = 0;  
            
            return s;
        }
        static void Main(string[] args)
        {
            int[,] matrix_1, matrix_2;//локальеые переменные матрицы
            bool test = true;
            Random fillBase = new Random();
            Console.WriteLine("Введите размер матрицы №1 и №2 (от 1 до 20)");
            //проверка ввода

            do
            {
                size1 = TestUserInput(Console.ReadLine());
                size2 = TestUserInput(Console.ReadLine());
                size3 = TestUserInput(Console.ReadLine());
                size4 = TestUserInput(Console.ReadLine());
                if (size1 == 0 || size2 == 0 || size3 == 0 || size4 == 0)
                {
                    test = false;
                }
                if (!test)
                {
                    Console.WriteLine("Неверный формат ввода, повторите");
                }
            }
            while (!test);

            matrix_1 = new int[size1, size2];
           
            matrix_2 = new int[size3, size4];

            //заполнение матриц
            FillMatrix(matrix_1, fillBase);
            FillMatrix(matrix_2, fillBase);

            Console.WriteLine("Матрица №1");
            PrintMatrix(matrix_1);
            Console.WriteLine("Матрица №2");
            PrintMatrix(matrix_2);

            Console.WriteLine("Введите число для умножения матрицы 1 (от 1 до 100)");
            PrintMatrix(MultyMatrix(matrix_1, Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Введите число для умножения матрицы 2 (от 1 до 100)");
            PrintMatrix(MultyMatrix(matrix_2, Convert.ToInt32(Console.ReadLine())));


            if (matrix_1.GetLength(0) == matrix_2.GetLength(0) && matrix_1.GetLength(1) == matrix_2.GetLength(1))
            {
                Console.WriteLine("Матрица после сложения");
                PrintMatrix(SumMatrix(matrix_1, matrix_2));
                Console.WriteLine("Матрица после вычитания");
                PrintMatrix(SubtractionMatrix(matrix_1, matrix_2));
            }
            else
            {
                Console.WriteLine("Сложение невозможно, размерности заданы неверно");
            }

            if (matrix_1.GetLength(1) == matrix_2.GetLength(0)) PrintMatrix(FullMultyMatrix(matrix_1, matrix_2));
            else
            {
                Console.WriteLine("Умножение матриц невозможно, размерности заданы неверно");
            }

            Console.ReadKey();
        }
    }
    #endregion Задание №1*/

    /*#region Задание №2
    class Program
    {
        static string wordWithMinLength;
        static List<string> wordsMax = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string SearchWordMinLength(string input)
        {
            string[] subs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var min = subs.Min(w => w.Length);
            foreach(string s in subs)
            {
                if (s.Length == min) wordWithMinLength = s;
            }
            return wordWithMinLength;
        }
        /// <summary>
        /// Поиск слов с максимальной длинной
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static List<string> SearchWordsMaxLength(string input)
        {
            string[] subs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var max = subs.Max(w => w.Length);
            foreach (string s in subs)
            {
                if (s.Length == max) wordsMax.Add(s);
            }
            return wordsMax;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для разбора");
            string str = Console.ReadLine();

            Console.WriteLine("Слово с минимальной длинной: " + SearchWordMinLength(str));
            Console.WriteLine("Слова с максимальной длинной: ");
            foreach (string word in SearchWordsMaxLength(str)) Console.Write(word +" ");
            Console.ReadKey();
        }
    }
    #endregion*/

    /*#region Задание №3
    class Program
    {
        /// <summary>
        /// Удаление повторных рядом стоящих символов
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns></returns>
        static string DeleteRepeatChar(string input)
        {
            string outString ="";
            char lastCharDoNotRepeat = input[0];
            outString += input[0];
            for(int i = 1; i < input.Length; i++)
            {
                if(input[i] != lastCharDoNotRepeat)
                {
                    lastCharDoNotRepeat = input[i];
                    outString += input[i];
                }
            }
            return outString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            Console.WriteLine(DeleteRepeatChar(Console.ReadLine().ToLower()));
            Console.ReadKey();
        }
    }
    #endregion*/

    /*#region Задание №4
    class Program
    {
        static int elements;
        /// <summary>
        /// Метод проверки последовательности чисел на прогрессию (арифметическая или геометрическая)
        /// </summary>
        /// <param name="inputDigital"></param>
        /// <returns></returns>
        static string SequenceNumberIsProgression(float [] inputDigital)
        {
            string output = "конец проверки";

            float d = inputDigital[elements - 1] - inputDigital[elements - 2];
            float q = inputDigital[elements - 1] / inputDigital[elements - 2];
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < elements-1; i++)
            {
                if (inputDigital[i+1] - inputDigital[i] == d)
                {
                    count1++;
                }
                if (inputDigital[i + 1] / inputDigital[i] == q) count2++;              
            }

            if (count1 == count2)
            {
                Console.WriteLine("\n {0} - Данная прогрессия является и арифметической и геометрической", inputDigital);
                Console.ReadKey();
            }
            else if (count2 == (elements-1))
            {
                Console.WriteLine("\n {0} - Это геометрическая прогрессия", inputDigital);
                Console.ReadKey();
            }
            else if (count1 == (elements-1))
            {
                Console.WriteLine("\n {0} - Это арифметическая прогрессия ", inputDigital);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n {0} - Данная последовательность не является ни одной из прогрессий", inputDigital);
                Console.ReadKey();
            }

            return output;
        }
        static void Main()
        {
            Console.WriteLine("Введите кол-во символов:");
            elements = int.Parse(Console.ReadLine());
            if (elements <= 1)
            {
                Console.WriteLine("Это не является последовательностью, запустите программу снова");
                Console.ReadKey();
            }
            else
            {
                float[] sequence = new float[elements];
                for (int i = 0; i < elements; i++)
                {
                    Console.WriteLine("Введите {0}-е число", i + 1);

                    sequence[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ваш набор чисел:");
                for (int i = 0; i < elements; i++)
                {
                    Console.Write(sequence[i]+" ");
                }
                Console.ReadKey();
                SequenceNumberIsProgression(sequence);
            }
        }
    }
    #endregion*/

    #region Задание №5
    class Program
    {
        static uint FunctionAkkerman(uint n, uint m)
        {

            if(n == 0)
            {
                return m + 1;
            }
            else if (m == 0)
            {
                return FunctionAkkerman(n - 1, 1);
            }
            else
            {
                return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввелите число №1");          
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите число №2");
            uint b = Convert.ToUInt32(Console.ReadLine());
            uint result = FunctionAkkerman(a,b);
            Console.WriteLine("{0} - Число Аккермана для чисел {1} и {2}", result, a, b);
        }
    }
    #endregion
}
