using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        [Column("UsersId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Id is 60 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for rhe Name is 60 characte")]
        public string Addres { get; set; }
        public string Phone { get; set; }
    }
}
