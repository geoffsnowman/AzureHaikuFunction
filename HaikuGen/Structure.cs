using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    internal class Structure
    {
        private List<StructureItem> Items { get; set; }

        internal Structure(List<StructureItem> items)
        {
            Items = items;
        }

        private int Minimum 
        {
            get
            {
                int min = 0;
                foreach (StructureItem item in Items)
                {
                    min += item.Minimum;
                }
                return min;
            }
        }

        private int Maximum
        {
            get
            {
                int max = 0;
                foreach (StructureItem item in Items)
                {
                    max += item.Maximum;
                }
                return max;
            }
        }

        internal Line Generate(int requiredsylls)
        {
            if (requiredsylls < Minimum)
            {
                throw new ArgumentOutOfRangeException("Invalid syllable count.");
            }

            if (requiredsylls > Maximum)
            {
                throw new ArgumentOutOfRangeException("Invalid syllable count.");
            }

            Line line = new Line();
            while (line.Syllables != requiredsylls)
            {
                line.Clear();
                for (int i = 0; i < Items.Count; i++)
                {
                    line.Add(Items[i].GetWord());
                }
            }
            return line;
        }
    }
}
