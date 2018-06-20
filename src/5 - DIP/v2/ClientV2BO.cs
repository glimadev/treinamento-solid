namespace _5___DIP
{
    //"Seria injusto dizer que qualquer um dos princípios SOLID é mais importante que o outro. 
    //No entanto, provavelmente nenhum dos outros tem um efeito tão imediato e profundo em seu código do que o DIP."

    //A classe ClientBO não vai mais depender de uma implementação e sim de uma abstração, 
    //não interessa pra ela como se cadastra um Cliente, qual o banco de dados ou quem realmente 
    //só importa pra ClienteBO que existe um contrato que prevê o cadastro de uma entidade Cliente.
    public class ClientV2BO
    {
        private IClientV2Repository _ClientV2Repository;

        public ClientV2BO(IClientV2Repository ClientV2Repository)
        {
            _ClientV2Repository = ClientV2Repository;
        }

        public void SaveClientV2(ClientV2 ClientV2)
        {
            _ClientV2Repository.Save(ClientV2);
        }
    }
}
