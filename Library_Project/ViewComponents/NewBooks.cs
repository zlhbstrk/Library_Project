using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Project.Models;

namespace Library_Project.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var BookList = new List<Books>
            {
                new Books
                {
                    ID = 7,
                    BookName = "Korku",
                    Author = "Zweig"
                },
                new Books
                {
                    ID = 8,
                    BookName = "Anna Karanina",
                    Author = "Tolstoy"
                    
                }
            };
            return View(BookList);
        }
    }
}
