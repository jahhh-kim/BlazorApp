using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ExampleModel
    {
      [Required(ErrorMessage ="이름은필수입니다")]
      [StringLength(10,ErrorMessage ="10자이상 입력하세요")]
      public string Name { get; set; }
    }
}
