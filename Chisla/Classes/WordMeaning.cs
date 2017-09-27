using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla.Classes
{
    class WordMeaning
    {
        public bool err;
        public int res;
        public int num;
        public bool helpFlag;
        public WordMeaning(){}
        public WordMeaning(bool a, int b, int c, bool d)
        {
            err = a;
            res = b;
            num = c;
            helpFlag = d;
        }
    }
}
