using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces.Services;
using Modelo.Service;
using Moq;
using NSubstitute;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public  class UnitTest
    {
        private IRoboService mock;

        [TestMethod]
        public void TestePulsoIncorreto()
        {
            mock = Substitute.For<IRoboService>();
            Robo robo = new Robo();
            robo.BracoDireito = new BracoDireito();
            robo.BracoDireito.ProximoMovimentoPulso = 3;
            robo.BracoDireito.ProximoMovimentoCotovelo = 2;
            mock.NextMove(robo)
               .Returns(new Robo  {mensagem = "Valor do Cotovelo errado." }); 
           

        }

        [TestMethod]
        public void TestePulsoCorreto()
        {
            mock = Substitute.For<IRoboService>();
            Robo robo = new Robo();
            robo.BracoDireito = new BracoDireito();
            robo.BracoDireito.ProximoMovimentoPulso = 4;
            robo.BracoDireito.MovimentoAtualPulso = 3;
            robo.BracoDireito.MovimentoAtualCotovelo = 4;
          
            mock.NextMove(robo)
               .Returns(new Robo { mensagem = "Movimento do pulso direito atualizado." }); 

        }

        [TestMethod]
        public void TesteRotacaoInorreto()
        {
            mock = Substitute.For<IRoboService>();
            Robo robo = new Robo();
            robo.Cabeca = new Cabeca();
            robo.Cabeca.MovimentoAtualInclinacao = 3;
            robo.Cabeca.MovimentoAtualRotacao = 1;
            robo.Cabeca.ProximoMovimentoRotacao = 2;

            mock.NextMove(robo)
               .Returns(new Robo { mensagem = "Movimento de rotação da cabeça não seguiu a regra." });

        }

        [TestMethod]
        public void TesteRotacaoCorreto()
        {
            mock = Substitute.For<IRoboService>();
            Robo robo = new Robo();
            robo.Cabeca = new Cabeca();
            robo.Cabeca.MovimentoAtualInclinacao = 2;
            robo.Cabeca.MovimentoAtualRotacao = 1;
            robo.Cabeca.ProximoMovimentoRotacao = 2;

            mock.NextMove(robo)
               .Returns(new Robo { mensagem = "Movimento de rotação da cabeça atualizada." });

        }
    }
}
