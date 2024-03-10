using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}

        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] KodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40272, 40274, 40273 };
            return KodePos[(int) kelurahan];
        }
    }
}
