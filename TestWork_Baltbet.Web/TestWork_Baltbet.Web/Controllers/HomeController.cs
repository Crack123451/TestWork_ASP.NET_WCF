using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWork_Baltbet.Web.ServiceReference;

namespace TestWork_Baltbet.Web.Controllers
{
    public class HomeController : Controller
    {
        private BaltbetServiceClient _client = new BaltbetServiceClient("BasicHttpBinding_IBaltbetService");
        private int _pageSize = 10;

        public ActionResult Index(int pageNum = 0)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            try
            {
                ViewBag.ListAccounts = _client.GetListAccounts().OrderBy(a => a.Name).Skip(_pageSize * pageNum).Take(_pageSize);
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                ModelState.AddModelError(String.Empty, "Ошибка подключения к серверу. Сервер недоступен");
            }
            ViewBag.PageNum = pageNum;
            ViewBag.ItemsCount = _client.GetListAccounts().Count();
            ViewBag.PageSize = _pageSize;
            return View();
        }
    }
}