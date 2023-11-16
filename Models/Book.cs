using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Add title property")]
        public string? Title { get; set; }

        public string? Des { get; set; }
    }

}
