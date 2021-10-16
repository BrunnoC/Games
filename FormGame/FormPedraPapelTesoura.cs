using System;

namespace FormGame
{
    public partial class FormPedraPapelTesoura : DevExpress.XtraEditors.XtraForm
    {
        public FormPedraPapelTesoura()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            IniciaJogo(1);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            IniciaJogo(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            IniciaJogo(3);
        }

        private void IniciaJogo(int jogador)
        {
            Jogo jogo = new Jogo();

            switch (jogo.Play(jogador))
            {
                case Jogo.Resultado.Ganhar:
                    lblResultado.Text = "Você Ganhou! Parabéns..";
                    goto default;
                case Jogo.Resultado.Empatar:
                    lblResultado.Text = "Vish! Empatou..";
                    goto default;
                case Jogo.Resultado.Perder:
                    lblResultado.Text = "ihh, Perdeu kkkk";
                    goto default;
                default:
                    escolhaJogador.BackgroundImage = jogo.ImgJogador;
                    escolhaMaquina.BackgroundImage = jogo.ImgMáquina;
                    break;
            }



        }
    }
}
