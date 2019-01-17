using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KritterLib
{
    public abstract class Critter
    {
        protected String m_latinName;
        protected String m_name;
        protected Gender m_sex;

        public abstract void yell();

        public void exposeID()
        {
            Console.WriteLine("Latin name : " + this.m_latinName);
            Console.WriteLine("Name : " + this.m_name);
            Console.WriteLine("Gender : " + this.m_sex);
        }
    }
}
