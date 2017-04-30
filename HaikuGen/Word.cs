using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    internal class Word
    {
        public Word (string text, int sylls)
        {
            Text = text;
            Sylls = sylls;
        }

        public string Text { get; set; }
        public int Sylls { get; set; }
        public string FirstUpper
        {
            get
            {
                string upper = Char.ToUpperInvariant(this.Text[0]) + this.Text.Substring(1);
                return upper;
            }
        }
    }
}
