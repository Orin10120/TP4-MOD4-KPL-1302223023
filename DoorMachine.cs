using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
    public class DoorMachine
    {
        public enum DoorMachineState { Terkunci, Terbuka};
        public void RunState()
        {
            DoorMachineState State = DoorMachineState.Terkunci;
            string command;

            string[] screenName = { "Pintu Terkunci", "Pintu tidak terkunci" };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("State saat ini adalah " + State);
                Console.WriteLine("Enter Command: ");

                command = Console.ReadLine();

                switch(State)
                {
                    case DoorMachineState.Terkunci:
                        if(command == "KunciPintu")
                        {
                            State = DoorMachineState.Terkunci;
                        } else if(command == "BukaPintu")
                        {
                            State = DoorMachineState.Terbuka;
                        }
                        break;


                    case DoorMachineState.Terbuka:
                        if(command == "KunciPintu")
                        {
                            State = DoorMachineState.Terkunci;
                        } else if (command == "BukaPintu")
                        {
                            State = DoorMachineState.Terbuka;
                        }
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(screenName[(int)State]);
        }
    }
}
