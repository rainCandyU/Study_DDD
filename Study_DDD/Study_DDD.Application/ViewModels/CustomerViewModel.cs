using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_DDD.Application.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public Guid iD { get; set; }

        [Required(ErrorMessage = $"{nameof(Name)} is required.")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "E-maill is required.")]
        [EmailAddress]
        [DisplayName("E-maill")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Birth Date is required.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Birth Data is not invalid")]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
