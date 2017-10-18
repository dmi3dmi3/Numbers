using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla2.Classes
{
    class WordIfno
    {
        public bool Err { get; private set; }
        public int Res { get; private set; }
        public bool HelpFlag { get; private set; }
        public ways Way { get; private set; }

        public enum ways
        {
            Black, Grey, Yellow, Orange, Green, Error
        }
        
        public WordIfno(int b, bool d, ways e)
        {
            Res = b;
            HelpFlag = d;
            Way = e;

        }

        public WordIfno(int b, ways e)
        {
            Res = b;
            HelpFlag = false;
            Way = e;
        }

        public WordIfno()
        {
            Res = -1;
            HelpFlag = true;
            Way = ways.Error;
        }
    }
}
