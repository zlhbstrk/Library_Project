using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Project.Models; //*
using Microsoft.AspNetCore.Mvc;

namespace Library_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var book = new List<Books>()
            {
                new Books(){ID=1, BookName="Satranç", Author="Zweig"},
                new Books(){ID=2, BookName="Dr Ox'un Deneyi", Author="Jules Verne"},
                new Books(){ID=3, BookName="Deli Fişek", Author="Vasconceulos"},
                new Books(){ID=4, BookName="Kırmızı Bisiklet", Author="Muzaffer İzgü"},
                new Books(){ID=5, BookName="Toros Canavarı", Author="Aziz Nesin"},
                new Books(){ID=6, BookName="Eşikte Duran İnsan", Author="Rasim Özdenören"}
            };

            return View(book);
        }
    }
}
