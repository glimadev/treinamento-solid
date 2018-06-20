namespace _1___SRP.v2
{
    //Em outro projeto, poderíamos ter uma classe de serviço ou negócio, como preferir, para manipular esse Usuário.
    public class UserApplication
    {
        IUserV2Repository _repo = new UserV2Repository();

        public void CreateUser()
        {
            UserV2 userV2 = new UserV2("Zézinho", "zezinho@gmail.com", "mudar*123");

            userV2.ActiveUser();

            _repo.Insert(userV2);

            /*fora da entidade Usuario, alteramos a senha e enviamos o e-mail*/
            Utils.SendMail("adm@gmail.com", userV2.Email, "Usuário criado com sucesso", "Sr. " + userV2.Name + ", seu usuário foi criado");
        }
    }
}
