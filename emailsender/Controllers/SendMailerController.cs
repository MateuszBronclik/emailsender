using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public ViewResult Index(emailsender.Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
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
