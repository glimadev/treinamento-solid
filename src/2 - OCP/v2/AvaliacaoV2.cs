using System.Collections.Generic;

namespace _2___OCP.v2
{
    //Mudanças:
    //1) Tornamos “Avaliacao” uma classe abstrata, uma vez que não temos intenção de instanciá-la.
    //2) Criamos um método abstrato para gravação na classe base (chamado de “Gravar”).
    //3) Fizemos com que as classes derivadas implementem o método “Gravar”.
    //4) Introduzimos nosso novo requisito, ou seja, um novo tipo de avaliacao(AvaliacaoSisdia), o qual também herda de “Avaliacao” e implementa “Gravar”.
    //5) Por fim, eliminamos as checagens de tipo do método “GravarAvaliacaoV2s” e passamos a usar polimorfismo.
    public abstract class AvaliacaoV2
    {
        public abstract void Gravar();
    }

    public class AvaliacaoV2Apollo : AvaliacaoV2
    {
        public override void Gravar()
        {
            // codigo para gravação avaliacao
        }
    }

    public class AvaliacaoV2DealerNet : AvaliacaoV2
    {
        public override void Gravar()
        {
            // codigo para gravação avaliacao
        }
    }

    public class AvaliacaoV2Sisdia : AvaliacaoV2
    {
        public override void Gravar()
        {
            // codigo para gravação avaliacao
        }
    }

    public class GeradorDeAvaliacaoV2s
    {
        public void GravarAvaliacaoV2s(IList<AvaliacaoV2> avaliacaos)
        {
            foreach (var avaliacao in avaliacaos)
                avaliacao.Gravar();
        }
    }
}
