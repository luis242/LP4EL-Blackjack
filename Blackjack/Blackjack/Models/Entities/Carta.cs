using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models.Entities
{
    public class Carta
    {

        public int Valor { get; set; }
        public char Naipe { get; set; }

        public Carta(char naipe, int valor)
        {
            Naipe = naipe;
            Valor = valor;
        }

        public string NomeCarta
        { 
            get
            {
                string valor;

                switch (Valor)
                {
                    case 11:
                        valor = "J";
                        break;
                    case 12:
                        valor = "Q";
                        break;
                    case 13:
                        valor = "K";
                        break;
                    case 1:
                        valor = "A";
                        break;
                    default:
                        valor = Valor.ToString();
                        break;
                }
                return valor + Naipe;
            }
        }

        public override string ToString()
        {
            return NomeCarta;
        }

    }
}
