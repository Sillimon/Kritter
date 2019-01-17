using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KritterLib
{
    public class DinoukBebek : Critter
    {
        public DinoukBebek(String latinName, String name, Gender sex)
        {
            this.m_latinName = latinName;
            this.m_name = name;
            this.m_sex = sex;
        }

        public override void yell() { Console.WriteLine("NARDINE MARDINOUK BEBEK DE LA STREET !"); }
    }
}
