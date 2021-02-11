using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color()
        {
            Cars = new HashSet<Car>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
