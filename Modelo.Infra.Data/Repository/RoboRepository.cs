using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces.Repositories;

namespace Modelo.Infra.Data.Repository
{
    public class RoboRepository : IRoboRepository
    {
         
      public Robo  NextMove(Robo robo)
        {

            try
            {
                if (robo.Cabeca.MovimentoAtualInclinacao + 1 == robo.Cabeca.ProximoMovimentoInclinacao
                 || robo.Cabeca.MovimentoAtualInclinacao - 1 == robo.Cabeca.ProximoMovimentoInclinacao)
                {
                    robo.Cabeca.MovimentoAtualInclinacao = robo.Cabeca.ProximoMovimentoInclinacao;
                    robo.mensagem = "Movimento de inclinação da cabeça atualizada. \n";
                }

                else if (robo.Cabeca.ProximoMovimentoInclinacao != robo.Cabeca.MovimentoAtualInclinacao)
                {
                    robo.mensagem += "Movimento de rotação da cabeça não seguiu a regra. \n";
                }


                if ((robo.Cabeca.MovimentoAtualRotacao + 1 == robo.Cabeca.ProximoMovimentoRotacao
                  || robo.Cabeca.MovimentoAtualRotacao - 1 == robo.Cabeca.ProximoMovimentoRotacao)
                  && robo.Cabeca.MovimentoAtualInclinacao != 3)
                {
                    robo.Cabeca.MovimentoAtualRotacao = robo.Cabeca.ProximoMovimentoRotacao;
                    robo.mensagem += "Movimento de rotação da cabeça atualizada. \n";
                }

                else if(robo.Cabeca.ProximoMovimentoRotacao != robo.Cabeca.MovimentoAtualRotacao)
                {
                    robo.mensagem += "Movimento de rotação da cabeça não seguiu a regra. \n";
                }


                if (robo.BracoDireito.MovimentoAtualCotovelo + 1 == robo.BracoDireito.ProximoMovimentoCotovelo
                    || robo.BracoDireito.MovimentoAtualCotovelo - 1 == robo.BracoDireito.ProximoMovimentoCotovelo)
                {
                    robo.BracoDireito.MovimentoAtualCotovelo = robo.BracoDireito.ProximoMovimentoCotovelo;
                    robo.mensagem += "Movimento do cotovelo direito atualizado. \n";
                }

                else if (robo.BracoDireito.MovimentoAtualCotovelo != robo.BracoDireito.ProximoMovimentoCotovelo)
                {
                    robo.mensagem += "Movimento do cotovelo direito não seguiu a regra. \n";
                }

                if (robo.BracoEsquerdo.MovimentoAtualCotovelo + 1 == robo.BracoEsquerdo.ProximoMovimentoCotovelo
                     || robo.BracoEsquerdo.MovimentoAtualCotovelo - 1 == robo.BracoEsquerdo.ProximoMovimentoCotovelo)
                {
                    robo.BracoEsquerdo.MovimentoAtualCotovelo = robo.BracoEsquerdo.ProximoMovimentoCotovelo;
                    robo.mensagem += "Movimento do cotovelo esquerdo atualizado. \n";
                }
                else if (robo.BracoEsquerdo.MovimentoAtualCotovelo != robo.BracoEsquerdo.ProximoMovimentoCotovelo)
                {
                    robo.mensagem += "Movimento do cotovelo esquerdo não seguiu a regra. \n";
                }

                 if((robo.BracoDireito.MovimentoAtualPulso + 1 == robo.BracoDireito.ProximoMovimentoPulso
                    || robo.BracoDireito.MovimentoAtualPulso - 1 == robo.BracoDireito.ProximoMovimentoPulso)
                    && robo.BracoDireito.MovimentoAtualCotovelo == 4)
                {
                    robo.BracoDireito.MovimentoAtualPulso = robo.BracoDireito.ProximoMovimentoPulso;
                    robo.mensagem += "Movimento do pulso direito atualizado. \n";
                }

                 else if (robo.BracoDireito.ProximoMovimentoPulso != robo.BracoDireito.MovimentoAtualPulso)
                {
                    robo.mensagem += "Movimento do pulso direito não seguiu a regra. \n";
                }

                if ((robo.BracoEsquerdo.MovimentoAtualPulso + 1 == robo.BracoEsquerdo.ProximoMovimentoPulso
                  || robo.BracoEsquerdo.MovimentoAtualPulso - 1 == robo.BracoEsquerdo.ProximoMovimentoPulso)
                  && robo.BracoEsquerdo.MovimentoAtualCotovelo == 4)
                {
                    robo.BracoEsquerdo.MovimentoAtualPulso = robo.BracoEsquerdo.ProximoMovimentoPulso;
                    robo.mensagem = "Movimento do pulso esquerdo atualizado. \n";
                }
                else if (robo.BracoEsquerdo.ProximoMovimentoPulso != robo.BracoEsquerdo.MovimentoAtualPulso)
                {
                    robo.mensagem += "Movimento do pulso direito não seguiu a regra. \n";
                }

                robo.status = "OK";
              

                return robo;

            }
            catch
            {
                robo = new Robo { mensagem = "Houve uma falha na chamada.", status = "NOK" };
                return robo;
            }
        }
    }
}
