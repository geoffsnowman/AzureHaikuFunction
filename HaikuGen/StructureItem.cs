using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    internal class StructureItem
    {
        internal List<Word> Words { get; set; }
        private Random _rand;
        int _minimum;
        int _maximum;

        internal StructureItem(List<Word> words)
        {
            Words = words;
            _rand = new Random();
            FindMinimum();
            FindMaximum();
        }

        private void FindMinimum()
        {
            _minimum = 999;
            foreach (Word w in Words)
            {
                if (w.Sylls < _minimum)
                {
                    _minimum = w.Sylls;
                }
            }
        }

        internal int Minimum
        {
            get { return _minimum; }
        }

        private void FindMaximum()
        {
            _maximum = 0;
            foreach (Word w in Words)
            {
                if (w.Sylls > _maximum)
                {
                    _maximum = w.Sylls;
                }
            }
        }

        internal int Maximum
        {
            get { return _maximum; }
        }

        internal Word GetWord()
        {
            int item = _rand.Next(Words.Count);
            Word w = Words[item];
            return w;
        }

        public static StructureItem operator + (StructureItem a, StructureItem b)
        {
            List<Word> newlist = new List<Word>(a.Words.Concat(b.Words));
            return new StructureItem(newlist);
        }
    }
}
