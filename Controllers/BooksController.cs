using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibros.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiLibros.Controllers
{

    //[ApiController]
    //[Route("[controller]")]
   [Authorize]
    [ApiController]
    [Produces("application/json")]
    [Route("/libros")]
    public class BooksController : Controller
    {
        private readonly BookStoreDbContext context;
        public BooksController(BookStoreDbContext context)
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
