using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreT.Entities.Abstract;

namespace EntitiesT.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
