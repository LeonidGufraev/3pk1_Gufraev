using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace consoleProject
{
    internal class BalansedTree
    {
        private TreeNode root; // ссылка на корень дерева
        public TreeNode Root
        {
            get
            { return root; }
            set
            { root = value; }
        }
        public int countnodes = 0; //количество узлов
        public int Countnodes { get; set; } // создание сбалансированного дерева по количеству вершин
        public BalansedTree(int n)//метод создания сбалансированного дерева
        {
            root = Create(n);
        }
        public TreeNode Create(int n) //простой прямой обход дерева
        {
            TreeNode node;
            string name; string birth; string deth;
            if (n == 0)
                node = null;
            else
            {
                Console.WriteLine("введите данные для узла:");
                Console.Write("Введите полное имя:\t");
                name = Console.ReadLine();
                
                
                Console.Write("Введите дату рождения:\t");
                birth = "01/01/" + Console.ReadLine();
                Console.Write("Введите дату смерти. При отсутствии таковой, введите \"0\"\t");
                deth = Console.ReadLine();
                var a = new Human(name, DateOnly.FromDateTime(Convert.ToDateTime(birth)), deth);
                node = new TreeNode(a);
                this.countnodes++;
                node.Left = Create(n / 2);
                node.Right = Create(n - n / 2 - 1);
            }
            return node;
        }
        public static string Bypass(TreeNode node)
        {
            string result = null;
            if (node.Info == null)
                return null;
            else
            {
                result += node.Info.ToString();
                Bypass(node.Left);
                Bypass(node.Right);
            }
            return result;
            Console.WriteLine(result);
        }
        public static int GetPowerOfTree(BalansedTree node) //вычисление количества узлов на каждом уровне
        {
            int h = 0;
            h = Convert.ToInt32(Math.Log(node.countnodes + 1, 2) - 1);
            return h;
        }
        public int GetCountsOfLevel(BalansedTree node, int i)
        {
            int m = 0;
            if (i > GetPowerOfTree(node))
            {
                Console.WriteLine("Уровня не существует!");
                return 0;
            }
            m = Convert.ToInt32(Math.Pow(2, i));
            return m;
        }

    }
}