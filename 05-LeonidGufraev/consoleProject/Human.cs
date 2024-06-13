using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class Human
    {
        public string FullName { get; set; }
        public DateOnly Birth { get; set; }
        public DateOnly Deth { get; set; }
        public Human(string fullname, DateOnly birth, string deth)
        {
            FullName = fullname;
            Birth = birth;
            if (deth == "0")
                Deth = DateOnly.MinValue;
            else
                Deth = DateOnly.FromDateTime(Convert.ToDateTime("01/01/"+deth));
        }
        public override string ToString()
        {
            string data = $"имя: {FullName}, год рождения: {Birth}, год смерти: {Deth}";
            return data.ToString();
        }
    }
}
