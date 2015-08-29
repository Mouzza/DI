using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UI_MVC.Models;

namespace UI_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Gelieve alles correct in te vullen.");
                return PartialView(model);
            }
            else
            {
                //Als bericht verzonden wordt -> 
                var body = "<html><body style='color:grey; font-size:15px;'>" +
                "<font face='Helvetica, Arial, sans-serif'>" +
                "<h1>U heeft een nieuw bericht</h1><br/>" +
                "<div style='background-color: #DDDDDD;border:1px solid black;padding: 1%;'><p> <strong>DATUM:</strong> {3} </p>" +
                "<p> <strong>NAAM:</strong> {0} {1} </p>" +
                "<p> <strong>EMAIL:</strong> {2} </p>" +
                "<p> <strong>TEL. NUMMER:</strong> {4} </p><br/>" +
                " <p> <strong>BERICHT:</strong> </p><p> {5} </p>" +
                "</div></body></html>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("yamakasi_boy@hotmail.com")); //replace with valid value
                message.Subject = "JAAI WEBMAIL";
                message.Body = string.Format(body, model.Achternaam, model.Voornaam, model.Email, DateTime.Now, model.Telefoonnummer, model.Bericht);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Verzonden");
                }



            }
        }
    }
}