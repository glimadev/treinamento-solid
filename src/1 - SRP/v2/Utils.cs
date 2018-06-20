using System.Net.Mail;

namespace _1___SRP.v2
{
    //O ideal era criar uma rotina para envio de e-mail genérica em um projeto de infraestrutura.
    public class Utils
    {
        public static void SendMail(string de, string para, string assunto, string corpo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = assunto;
                mail.Body = corpo;
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
