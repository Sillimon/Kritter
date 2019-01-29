using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KritterLib
{
    [Table(Name = "Critters")]
    public class Critter
    {
        [Column(Name = "IdCritter",DbType ="bigint", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        private long m_ID;

        [Column(Name = "LatinName", DbType ="text",CanBeNull = true)]
        private String m_latinName;

        [Column(Name = "Name", DbType = "text", CanBeNull = false)]
        private String m_name;

        [Column(Name = "Weight", DbType = "numeric", CanBeNull = false)]
        private int m_weight;

        [Column(Name = "BirthDate", DbType = "text", CanBeNull = true)]
        private String m_birthDate;

        [Column(Name = "Sex", DbType = "bigint", CanBeNull = true)]
        private Gender m_sex;

        public Critter() { }

        public Critter(String latin, String name, int weight)
        {
            this.LatinName = latin;
            this.Name = name;
            this.Weight = weight;
        }

        #region Getter/Setter
        public long ID { get => m_ID; set => m_ID = value; }
        public string LatinName { get => m_latinName; set => m_latinName = value; }
        public string Name { get => m_name; set => m_name = value; }
        public int Weight { get => m_weight; set => m_weight = value; }
        public String BirthDate { get => m_birthDate; set => m_birthDate = value; }
        public Gender Sex { get => m_sex; set => m_sex = value; }
        #endregion

        public override string ToString()
        {
            String ret = String.Empty;

            if (this.LatinName != null)
                ret += String.Format("({0}) ", LatinName);

            ret += String.Format("{0} \n--> {1} Kg", Name, Weight);

            if (BirthDate != null)
                ret += String.Format("\n--> {0}", BirthDate);

            ret += String.Format("\n--> {0}", Sex.ToString());

            return ret;
        }
    }
}
