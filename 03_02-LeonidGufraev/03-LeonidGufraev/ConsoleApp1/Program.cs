using System;
using System.Collections;
using System.Windows.Markup;
namespace pz__3
{
    internal class Program
    {
        /*Гуфраев            3пк1
            Вариант 4        Задание: реализовать структуру данных хэш-таблицу размерности x, применяя алгоритм 
хэширования в соответствии с вариантом.Примечания к заданию:
• Хэш таблица строится на основе массива размерности x, параллельно создается массив, отображающий занятость ячеек (bool type) аналогичной размерности. В
данном массиве true ячейка означает наличие содержимого в основном массиве,False – отсутствие значения
• Ключи приемлемо сгенерировать через Random. Диапазон возможных значений 10000 .. 100000
• При создании объекта хэш-таблицы требуется вычислять необходимый размер (количество ключей * 1.5)
• При заполнении хэш-таблицы ключами – использовать собственный алгоритм хеширования в соответствии с вариантом
• В итоге необходимо вывести получившуюся хеш-таблицу на экранварианты
4 f(k) =(k*6/3) % x 88
        */
        static void Main(string[] args)
        {
            MyHashTable hash = new MyHashTable(88);
            hash.HashWork();
            hash.Add(20);
            hash.Add(20);
            hash.HashWork();
            Console.WriteLine("Результаты метода Find - "+ hash.Find(0, 34277));
        }
    }
    public class MyHashTable
    {
        int CountOfAttemps { get; set; } = 0;
        public int Find(int key,int val)
        {
            int indexstart = Hash(key);
            int countAttemps = 1;
            do
            {
                countAttemps++;
                if (GetVisited(indexstart) == true)
                    return 1;
                else
                {
                    if (val == data[indexstart])
                        return indexstart;
                    else NoCollision(indexstart); return 1;
                }
            }
            while (true);
        }
        public bool Add(int key)
        {
            int indexstart = Hash(key);
            NoCollision(indexstart);
            data[indexstart] = rnd.Next();
            return true;
        }
        bool NoCollision(int indexstart)
        {
            for (int i = 0; i < length; i++)
            {
                CountOfAttemps++;
                if (GetVisited(indexstart) == false)
                {
                    indexstart = Convert.ToInt32((double)i + (double)Math.Pow(i, 2) % (double)length);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        Random rnd = new Random();
        static int length;
        int[] data;
        int[] keys;
        public bool[] visited;
        public MyHashTable(int x)
        {
            length = x;
            data = new int[length];
            visited = new bool[length];
            GenerateData();
        }
        int[] GenerateKeys()
        {
            int lenghtkeys = (int)(length * 1.5);
            keys = new int[lenghtkeys];
            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = rnd.Next(10000, 100000);
                keys[i] = Hash(i);
            }
            return keys;
        }
        int GenerateData()
        {
            int[] arr = new int[10];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rnd.Next(0, length + 1);
                GetVisited(arr[j]);
                data[arr[j]] = rnd.Next();
            }
            GenerateKeys();
            return 0;
        }
        bool GetVisited(int a)
        {
            if (!visited[a])
            {
                visited[a] = true;
                return visited[a];
            }
            else
            {
                return !visited[a];
            }
        }
        int Hash(int k)
        {
            return (k * 6 / 3) % length;
        }
        public int[] HashWork()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"ключ: {keys[i]}\tданные: {data[i]}\tрегистр: {visited[i]}");
            }
            return data;
        }
    }
}