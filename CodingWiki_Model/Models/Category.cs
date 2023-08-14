﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("category")]
    public class Category
    {
        public int CategoryId { get; set; }

        [Column("Name")]
        public string CategoryName { get; set; }

     
    }

}
