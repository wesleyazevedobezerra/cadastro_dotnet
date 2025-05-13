using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
    public class FoneNumberViewModel
    {
        public int id { get; set; }
        public string ddi { get; set; }
        public string ddd { get; set; }
        public string number { get; set; }
    }
}
