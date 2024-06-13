using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class TreeNode
    {
        public Human Info { get; set; } // информационное поле узла
        public TreeNode Left { get; set; } //ссылка на левое поддерево
        public TreeNode Right { get; set; }//ссылка на правое поддерево
        public TreeNode(Human info) => this.Info = info;
        public TreeNode(Human info, TreeNode left, TreeNode right)
        {
            Info = info;
            Left = left;
            Right = right;
        }
    }
}