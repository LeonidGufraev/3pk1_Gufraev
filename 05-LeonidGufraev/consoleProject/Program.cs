﻿using System.Xml.Linq;

namespace consoleProject
{
    /*
     * ФИО студента: Гуфраев
     * номер варианта: 4
     * условие задачи (скопировать из листа задания): 
     * 1. Создать сбалансированное дерево (см. Теоретическую часть).
     * 2. Реализовать алгоритм прямого обхода дерева (см. Теореческуючасть)
3. Реализовать алгоритм вычисления высоты (глубины) дерева - h
4. Реализовать метод для вычисления количества узлов на определённом уровне дерева - m
5. В качестве информационного поля дерева хранить объект человека с данными:
a. ФИО
b. Дата рождения (DateOnly)
c. Дата смерти (DateOnly) - для нынеживущих: DateOnly.MinValue;
6. Реализовать создание дерева (генеалогического дерева на 7 элементов по схеме в теоретической части)

7. Реализовать подсчёт и вывод ныне живущих членов семьи
8. Реализовать подсчёт средней продолжительности жизни членов семьи.(игнорировать в подсчёте ныне живущих членов семьи)
9. Найти и вывести членов семьи, рождённых в 21 и 20 веках соответственно.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            BalansedTree tree = new BalansedTree(1);
            Console.WriteLine("Высота дерева: " + BalansedTree.GetPowerOfTree(tree));
            Console.WriteLine("Введите номер уровня!");
            Console.WriteLine("Количество элементов на уровне: "+ tree.GetCountsOfLevel(tree,Convert.ToInt32(Console.ReadLine())));
            BalansedTree.Bypass(tree.Root);
        }
    }
}