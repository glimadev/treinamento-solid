namespace _1___SRP.v2
{
    //Primeiramente, a classe User deveria ter somente métodos referente a comportamentos dela mesma.
    public class UserV2
    {
        public UserV2(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Actived = false;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Actived { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void ActiveUser()
        {
            Actived = true;
        }

        public string ChangePassword()
        {
            return "NovaSenha*123";
        }
    }
}
