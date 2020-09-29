using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Blackjack.Models.Factories;

namespace Blackjack.Models.Entities
{
    public class Dealer
    {

        private Baralho _baralho { get; set; }
       
        public Dealer()
        {
            _baralho = BaralhoFactory.CriarBaralho();
        }

        public List<Carta> EntregarMao()
        {
            Carta[] mao = { _baralho.ComprarCarta(), _baralho.ComprarCarta() };
            return mao.ToList();
        }

        public Carta DescerCartas()
        {
            return _baralho.ComprarCarta();
        }

        public int ContarPontos(List<Carta> mao)
        {
            int pontos = 0;
            int ases = 0;
            foreach (Carta carta in mao)
            {
                int valor = carta.Valor;
                if (valor == 1)
                {
                    ases += 1;
                }
                pontos += valor > 10 ? 10 : valor;
            }

            for (int i = 0; i < ases; i++)
            {
                pontos += pontos + 10 < 21 ? 10 : 0;
            }

            return pontos;
        }

        public void RetornarMao(List<Carta> mao)
        {
            _baralho.DevolverCartas(mao);
        }

    }
}
