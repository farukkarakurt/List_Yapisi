using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Ornek_calısma
{
    class Class1
    {
        string isim;
        int numara;
        string mevki;

        public string ADI
        {
            get { return isim; }
            set { isim = value; }
        }

        public int NO
        {
            get { return numara; }
            set { numara = value; }
        }
        public string MEVKI
        {
            get { return mevki; }
            set { mevki = value; }
        }
    }
}
