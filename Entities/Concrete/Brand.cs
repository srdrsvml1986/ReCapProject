using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Model { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
