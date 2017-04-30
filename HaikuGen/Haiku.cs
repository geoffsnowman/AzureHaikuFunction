using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    public class Haiku
    {
        public List<Line> Lines;

        private int[] haikuStructure = new int[] { 5, 7, 5 };

        public Haiku()
        {
            Lines = new List<Line>();
            foreach (int sylls in haikuStructure)
            {
                Structure struc = LineTypes.GetStructure();
                Line line = struc.Generate(sylls);
                Lines.Add(line);
            }
        }
    }
}
