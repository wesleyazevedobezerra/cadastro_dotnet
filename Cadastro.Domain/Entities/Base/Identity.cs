using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities.Base
{
    public class Identity <TEntity> where TEntity : struct
    {
        private TEntity _id;
        public TEntity Id

        {
            get => _id;
            set
            {
   

                if (value is int || value is Guid)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException("Id must be either int or Guid.");
                }
            }
        }
    }
}
