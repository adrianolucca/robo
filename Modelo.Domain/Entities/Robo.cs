using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
   public class Robo
    {

        public Cabeca Cabeca { get; set; }
        public BracoDireito BracoDireito { get; set; }
        public BracoEsquerdo BracoEsquerdo { get; set; }

        public string status { get; set; }
        public string mensagem { get; set; }

    }

    public class Cabeca
    {
        public int ProximoMovimentoRotacao { get; set; }

        public int MovimentoAtualRotacao { get; set; }

        public int ProximoMovimentoInclinacao { get; set; }

        public int MovimentoAtualInclinacao { get; set; }
    }

    public class BracoDireito
    {
        public int ProximoMovimentoCotovelo { get; set; }

        public int MovimentoAtualCotovelo { get; set; }

        public int ProximoMovimentoPulso { get; set; }

        public int MovimentoAtualPulso { get; set; }
    }

    public class BracoEsquerdo
    {
        public int ProximoMovimentoCotovelo { get; set; }

        public int MovimentoAtualCotovelo { get; set; }

        public int ProximoMovimentoPulso { get; set; }

        public int MovimentoAtualPulso { get; set; }
    }

}
