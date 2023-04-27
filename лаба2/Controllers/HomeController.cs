using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using лаба2.Models;

namespace лаба2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id, DateTime data, string ownername, string phonenumber, string servicename, string adress, string plusservice, string review)
        {
            string authData = $"Новый заказ успешно добавлен: " +
                $"ID: {id}  Дата заказа: {data}  ФИО заказчика: {ownername} Номер телефона: {phonenumber} Название услуги: {servicename} Адрес: {adress}  Доп услуги(да/нет): {Convert.ToString(plusservice)} Оценка: {Convert.ToString(review)} ";
            return Content(authData);
        }
        //public IActionResult details()
        //{
        //    return View(User);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}