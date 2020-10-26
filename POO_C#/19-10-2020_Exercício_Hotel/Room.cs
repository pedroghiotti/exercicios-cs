using System;
using System.Collections.Generic;
using System.Text;

namespace _19_10_2020_Exercício_Hotel
{
    class Room
    {
        private int _number;
        public string _guest { get; private set; }

        public Room(int number, string guest) // Construtor da classe.
        {
            _number = number;
            _guest = guest;
        }
        public Room(int number) // Construtor alternativo.
        {
            _number = number; 
        }

        public void SetGuest(string guestName)
        {
            _guest = guestName;
        }

        public override string ToString()
        {
            if(_guest == null)
                return "\nQuarto " + _number + ": Vazio.";
            else 
                return "\nQuarto " + _number + ": " + _guest + ".";
        }
    }
}
