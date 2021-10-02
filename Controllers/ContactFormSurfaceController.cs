using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using AarhusWebDevCoop.ViewModels;
using System.Net.Mail;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace AarhusWebDevCoop.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if(!ModelState.IsValid)
            { return CurrentUmbracoPage(); }
           
            MailMessage message = new MailMessage();
            message.To.Add("valka.yordanov@gmail.com");
            message.Subject = model.Subject;
            message.From = new MailAddress("valka.yordanov@gmail.com", "Aarhus Web Developer Corporation");
            message.Body = "From " + model.Name + ", " + model.Email + ": " + model.Message;

            GuidUdi currentPageUdi = new GuidUdi(CurrentPage.ContentType.ItemType.ToString(), CurrentPage.Key);
            IContent msg = Services.ContentService.CreateContent(model.Subject, currentPageUdi, "message");
            msg.SetValue("messagename", model.Name);
            msg.SetValue("email", model.Email);
            msg.SetValue("subject", model.Subject);
            msg.SetValue("messageContent", model.Message);
            
            Services.ContentService.Save(msg);


            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp-relay.sendinblue.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("valka.yordanov@gmail.com", "OGhykLAtbr3TxZs9");

                // send mail 
                smtp.Send(message);
            }

            TempData["success"] = true;
            return RedirectToCurrentUmbracoPage();
        }
    }
}