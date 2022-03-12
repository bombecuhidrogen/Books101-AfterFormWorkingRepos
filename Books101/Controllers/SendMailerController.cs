using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
namespace SendMail.Controllers
{
    public class SendMailerController : Controller
    {
        //      
        // GET: /SendMailer/       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Books101.Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                string mailto = "safigos861@xindax.com";
                MailMessage mail = new MailMessage();
                mail.To.Add(mailto);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("rosiuuugabi@gmail.com", "gfgffhbgfrygryt123456789"); // Enter seders User name and password       
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", _objModelMail);
            }
            else
            {
                return View();
            }
        }
    }
}