using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    public class Line
    {
        internal List<Word> Words { get; set; }

        public Line()
        {
            Words = new List<Word>();
        }

        internal void Add(Word w)
        {
            Words.Add(w);
        }

        internal void Clear()
        {
            Words.Clear();
        }

        internal int Count
        {
            get { return Words.Count;  }
        }

        internal int Syllables
        {
            get
            {
                int sylls = 0;
                foreach (Word w in Words)
                {
                    sylls += w.Sylls;
                }
                return sylls;
            }
        }

        public override string ToString()
        {
            StringBuilder line = new StringBuilder();
            line.Append(Words[0].FirstUpper);
            for (int i = 1; i < Words.Count; i++)
            {
                line.Append(" ");
                line.Append(Words[i].Text);
            }
            return line.ToString();
        }

        internal Word this[int i]
        {
            get { return Words[i]; }
            set { Words[i] = value; }
        }
    }
}
