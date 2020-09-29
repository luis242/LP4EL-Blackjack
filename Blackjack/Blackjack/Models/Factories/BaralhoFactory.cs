using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackjack.Models.Entities;

namespace Blackjack.Models.Factories
{
    public class BaralhoFactory
    {

        public static Baralho CriarBaralho()
        {
            List<Carta> cartas = new List<Carta>();

            for (int i = 1; i < 14; i++)
            {
                Carta[] naipes = { new Carta('♥', i), new Carta('♦', i), new Carta('♣', i), new Carta('♠', i) };
                cartas.AddRange(naipes.ToList());
            }

            return new Baralho(cartas);
        }
    }
}
