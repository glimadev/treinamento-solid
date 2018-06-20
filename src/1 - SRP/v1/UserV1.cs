using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace _1___SRP.v1
{
    //Nesse cenário, a classe Usuario além das suas responsabilidades(métodos) como por exemplo ativar o usuário, iniciar suas características(propriedades) 
    //ou até mesmo atualizar um valor dela mesma, vemos que ela foi sobrecarregada com a responsabilidade de fazer a persistência no banco de dados e 
    //ainda enviar e-mail.Futuramente isso vai gerar problemas graves e sujeita as famosas “gambiarras”. Qualquer modificação futura vai demandar um 
    //tempo razoável na análise e na implementação.Outro grave problema é o forte acoplamento, imagine se um dia esse projeto usar um banco de dados diferente, 
    //todas as classes terão que ser modificadas.Por fim, mas não menos importante, como a classe que é uma entidade de domínio, tem a obrigação de enviar e-mail, 
    //teremos que poluir nosso domínio com a referência do System.Net.Mail também gerando forte acoplamento.
    public class UserV1
    {
        FakeDataContext _db = new FakeDataContext();

        public UserV1(string name, string email, string password)
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

        public void Insert(UserV1 user)
        {
            _db.Save(user);

            _db.SaveChanges();
        }

        public List<UserV1> GetAll()
        {
            return _db.Users.ToList();
        }

        public void Delete(UserV1 user)
        {
            _db.Remove(user);

            _db.SaveChanges();
        }

        public void ChangePassword()
        {
            string newPass = "NovaSenha*123";
            ChangePasswordMail(newPass);
        }

        public void ChangePasswordMail(string newPass)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("adm.sistema@gmail.com");
                mail.To.Add(Email);
                mail.Subject = "Você solicitou a redefinição de senha";
                mail.Body = "Caro sr." + Name + ", sua nova senha é: " + newPass;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Send(mail);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
