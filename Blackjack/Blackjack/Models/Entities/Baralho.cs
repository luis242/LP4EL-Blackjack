using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models.Entities
{
    public class Baralho
    {

        public List<Carta> Cartas { get; set; }

        public Baralho(List<Carta> cartas)
        {
            Cartas = cartas;
        }
        public Carta ComprarCarta()
        {
            Carta carta = Cartas.First();
            Cartas.RemoveAt(0);
            return carta;
        }

        public void DevolverCartas(List<Carta> mao)
        {
            Cartas.AddRange(mao);
        }

        public void Embaralhar()
        {
            Cartas.Sort();
        }

    }
}
