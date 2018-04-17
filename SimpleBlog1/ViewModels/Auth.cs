using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SimpleBlog1.ViewModels
{
    public class Authlogin
    {
        public object Test;
        public string test  { get; set; }
        
        [Required]
        public string UserName {get; set;}
       [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}
    }
}