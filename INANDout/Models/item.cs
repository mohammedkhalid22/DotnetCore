using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace INANDout.Models
{
    public class item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
    }
   

}
