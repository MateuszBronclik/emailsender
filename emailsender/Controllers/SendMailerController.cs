using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace emailsender.Controllers
{
    public class SendMailerController : Controller
    {
        // GET: SendEmailController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(_objModelMail.To);
                    mail.From = new MailAddress(_objModelMail.From);
                    mail.Subject = _objModelMail.Subject;
                    string Body = _objModelMail.Body;
                    mail.Body = Body;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new System.Net.NetworkCredential("username", "password"); // podać hasło i email wysyłającego
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Wystąpił błąd podczas wysyłania e-maila: {ex.Message}");
                    return View(_objModelMail);
                }

                return RedirectToAction("Success");
            }
            else
            {
                return View();
            }
        }



        #region default crud
        //// GET: SendEmailController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: SendEmailController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: SendEmailController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SendEmailController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: SendEmailController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SendEmailController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: SendEmailController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        #endregion

    }
}
