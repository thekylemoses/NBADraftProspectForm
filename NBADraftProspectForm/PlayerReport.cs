using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftProspectForm
{
    public class PlayerReport
    {
        private string name;
        private string school;
        private int year; //0 - Fr, 1 - So, 2 - Jr, 3 - Sr
        private int level; //0 - DI, 1 - DII, 2 - DIII, 3 - Other
        private int height; 
        private int weight;
        private List<int> pos; //0 - PG, 1 - SG, 2 - SF, 3 - PF, 4 - C
        private string notes;

        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public string School
        {
            get { return school; }  
            set { school = value; }

        }

        public int Year
        {
            get { return year; }    
            set { year = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public List<int> Positions
        {
            get { return pos; }
            private set { pos = value; }
        }

        public void addPos(int poss)
        {
            if (!pos.Contains(poss))
            {
                pos.Add(poss);
            }
        }

        public void clearPos()
        {
            pos.Clear();
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public PlayerReport()
        {
            Name = "";
            School = "";
            Year = 0;
            Level = 0;
            Height = 0;
            Weight = 0;
            Positions = new List<int>();
            Notes = "";
        }

        public PlayerReport(string name, string school, int year, int level, int height, int weight, List<int> pos, string notes)
        {
            Name = name;
            School = school;
            Year = year;
            Level = level;
            Height = height;
            Weight = weight;
            Positions = pos;
            Notes = notes;
        }

        public string YearAsString()
        {
            if(Year == 0)
            {
                return "Freshman";
            }
            if(Year == 1)
            {
                return "Sophomore";
            }
            if (Year == 2)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public string LevelAsString()
        {
            if (Level == 0)
            {
                return "Division I";
            }
            if (Level == 1)
            {
                return "Division II";
            }
            if (Level == 2)
            {
                return "Division III";
            }
            else
            {
                return "Other";
            }
        }

        public string PosAsString()
        {
            string result = "";
            if (pos.Contains(0))
            {
                result = result + "PG";
            }
            if (pos.Contains(1))
            {
                result = result + "SG";
            }
            if (pos.Contains(2))
            {
                result = result + "SF";
            }
            if (pos.Contains(3))
            {
                result = result + "PF";
            }
            if (pos.Contains(4))
            {
                result = result + "C";
            }
            return result.Trim();
        }

        public override string ToString()
        {
            return String.Format("Name = {0}, School = {1}, Year = {2}, Level = {3}, Height = {4}in. , Weight = {5}lbs., Posistion(s) = {6}, Notes = {7}", Name, School, YearAsString(), LevelAsString(), Height, Weight, PosAsString(), Notes);
        }

    }
}
