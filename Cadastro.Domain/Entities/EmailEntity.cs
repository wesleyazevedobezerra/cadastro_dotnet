using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class EmailEntity: Identity <int>
    {
        public string email { get; set; }
        public int userId { get; set; }
        public UserEntity user { get; set; }
    }
}
