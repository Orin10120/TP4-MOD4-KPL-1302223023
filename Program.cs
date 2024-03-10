using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Kode Pos Dari " + KodePos.Kelurahan.Kujangsari + " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Kujangsari));
            Console.WriteLine("Kode Pos Dari " + KodePos.Kelurahan.Margasari + " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Margasari));
            Console.WriteLine("Kode Pos Dari " + KodePos.Kelurahan.Batununggal + " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Batununggal));*/


            DoorMachine machine = new DoorMachine();
            machine.RunState(); 
        }
    }
}
