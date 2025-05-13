using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cadastro.Application.ViewModels
{
    public  class UserViewModel
    {


  
        public string name { get; set; }
        public IEnumerable<EmailViewModel> email { get; set; } //IEnumerateble cria uma lista
        public string password { get; set; }
        public string? confirmPassword { get; set; }
        public IEnumerable<FoneNumberViewModel> foneNumber { get; set; }

        public DateTime dateBirthday { get; set; }

      
        public IEnumerable<AddressViewModel> address { get; set; }
    }
    
}
