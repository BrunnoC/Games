using System;
using System.Drawing;
using FormGame.Properties;

namespace FormGame
{
    class Jogo
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public Image[] imagens =
        {
            Resources.pedra,
            Resources.papel,
            Resources.tesoura
        };

        public Image ImgJogador { get; private set; }
        public Image ImgMáquina { get; private set; }

        public Resultado Play(int jogador)
        {
            int jogadaMáquina = MáquinaRun();
            ImgJogador = imagens[jogador - 1];
            ImgMáquina = imagens[jogadaMáquina - 1];

            if (jogadaMáquina == 1 && jogador == 1 || jogadaMáquina == 2 && jogador == 2 || jogadaMáquina == 3 && jogador == 3)
                return Resultado.Empatar;
            else if (jogadaMáquina == 3 && jogador == 1 || jogadaMáquina == 1 && jogador == 2 || jogadaMáquina == 2 && jogador == 3)
                return Resultado.Ganhar;
            else
                return Resultado.Perder;

        }

        private int MáquinaRun()
        {
            Random aleatorio = new Random();
            int jogada = aleatorio.Next(1, 4);
            return jogada;
        }

    }
}
