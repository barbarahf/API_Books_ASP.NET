using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibros.Models
{
    /**
     * Return a response, depends on if login is successful or not.
     */
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
