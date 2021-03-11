using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibros.Models;
namespace ApiLibros.Controllers
{

    //[ApiController]
    //[Route("[controller]")]

    [Produces("application/json")]
    [Route("/libros")]
    public class BooksController : Controller
    {
        private readonly BookStoreContext context;
        public BooksController(BookStoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return context.Libros.ToList();
        }

    }
}
