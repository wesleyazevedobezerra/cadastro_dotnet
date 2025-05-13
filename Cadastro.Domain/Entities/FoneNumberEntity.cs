using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class FoneNumberEntity: Identity<int>
    {
        public string ddi { get; set; }
        public string ddd { get; set; }
        public string number { get; set; }
        public int userId { get; set; }
        public UserEntity user { get; set; }
    }
}
