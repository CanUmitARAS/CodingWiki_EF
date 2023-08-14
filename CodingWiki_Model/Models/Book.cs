using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models
{
    public class Book
    {
        
        public int BookId { get; set; }
        public string Title { get; set; }
        [MaxLength(40)]
        [Required]
        public string ISBN { get; set; }

        public decimal Price{ get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
    }
}
