using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Domain
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime CreationDate { get; set; }  

    }
}
