using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using TestWork_Baltbet.Web.Models;
using TestWork_Baltbet.Web.ServiceReference;

namespace TestWork_Baltbet.Web.Controllers
{
    public class AccountController : Controller
    {
        private BaltbetServiceClient Client = new BaltbetServiceClient("BasicHttpBinding_IBaltbetService");

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                    if (!Client.CheckUserLogin(model.Login))
                    {
                        Client.AddUser(model.Gender, model.Age, model.Login, model.Name, model.LastName, model.Passport, model.Password);
                        FormsAuthentication.SetAuthCookie(model.Login, true);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        ModelState.AddModelError(String.Empty, "Такой пользователь уже существует");
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                ModelState.AddModelError(String.Empty, "Ошибка подключения к серверу. Сервер недоступен");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            try
            {
                if (Client.CheckUser(model.Login, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError(String.Empty, "Неверный логин или пароль");
            }
            catch(System.ServiceModel.EndpointNotFoundException ex)
            {
                ModelState.AddModelError(String.Empty, "Ошибка подключения к серверу. Сервер недоступен");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
            }
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}