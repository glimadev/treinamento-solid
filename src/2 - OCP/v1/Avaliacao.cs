using System.Collections.Generic;

namespace _2___OCP.v1
{
    public class Avaliacao
    {
        public string Placa { get; set; }
    }

    public class AvaliacaoApollo : Avaliacao
    {
        public void GravarNoApollo()
        {
            // codigo para gravar avalicao
        }
    }

    public class AvaliacaoDealerNet : Avaliacao
    {
        public void GravarNoDealerNet()
        {
            // codigo para gravar avalicao
        }
    }

    public class GravarAvaliacaos
    {
        public void GravacaoDeAvaliacaos(IList<Avaliacao> avalicaos)
        {
            foreach (var avalicao in avalicaos)
            {
                if (avalicao is AvaliacaoApollo)
                    ((AvaliacaoApollo)avalicao).GravarNoApollo();
                else if (avalicao is AvaliacaoDealerNet)
                    ((AvaliacaoDealerNet)avalicao).GravarNoDealerNet();
            }
        }
    }

    //PROBLEMAS

    //Você pode estar se perguntando: qual o problema de mais um simples “else if”?

    //Vamos pensar nas seguintes situações:

    //Existem outras partes da aplicação que também fazem as verificações por tipo vistas no método “GravarAvaliacaos” para invocar outros métodos específicos de cada classe concreta.
    //Para piorar, algumas dessas partes estão em outros componentes da aplicação.
    //O que acontece quando precisamos de um novo dms?

    //Além de criarmos nosso novo arquivo, como “AvaliacaoSisdia”, teríamos que:

    //1) Alterar todos os métodos que precisem fazer uso do novo tipo(certamente aqueles com vários “if/else if” ou um belo “switch..case”).

    //2) Recompilar e fazer o deploy de todos os componentes que foram impactados.
}
