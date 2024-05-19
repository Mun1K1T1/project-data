using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Laboratory_2.Data.Models.Data
{
    public class EEntity
    {
        [Key]
        public Guid Key { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
