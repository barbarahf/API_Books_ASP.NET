using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ApiLibros.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
