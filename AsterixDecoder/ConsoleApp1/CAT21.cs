using System;
using System.Collections.Generic;
using System.Text;

namespace AsterixDecoder
{
    class CAT21
    {
        String[] cat21;
        public CAT21(String[] X)
        {
            this.cat21 = X;
        }
        

        public string Get_Data_Item(int v)
        {
            return cat21[v];
        }

    }
}
