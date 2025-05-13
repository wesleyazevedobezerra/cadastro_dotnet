using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class UserEntity : Identity<int>
    {
        //private DateTime _dtb;
        //public UserEntity(DateTime dateBirthday)
        //{
        //    _dtb = dateBirthday;
        //}
        public string name { get; set; }
        public IEnumerable<EmailEntity> email { get; set; } //IEnumerateble cria uma lista
        public string password { get; set; }
        public string? confirmPassword { get; set; }
        public IEnumerable<FoneNumberEntity> foneNumber { get; set; }

        public DateTime dateBirthday { get; set; }

        //public DateTime dateBirthday { 

        //    get { return _dtb; } 
        //    set {
        //        if (value < DateTime.Now.AddYears(-18))
        //        {
        //            //Disparo erro
        //        }
        //        else
        //            _dtb = value;

        //    } 

        //}

        public IEnumerable<AddressEntity> address { get; set; }
        
    }
}
