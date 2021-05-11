using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class WordsDataBase
    {
        public string Word { get; private set; }
        public WordsDataBase(string word)
        {
            Word = word;
        }

        public static Dictionary<string, WordsDataBase> AddWords()
        {

        }

    }
}
