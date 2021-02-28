using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Car :IEntity
    {      
        public int Id { get; set; }
        [ForeignKey("BrandID")]
        public int BrandID { get; set; }
        [ForeignKey("ColorID")]
        public int ColorID { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual ICollection<CarImage> CarImages { get; set; } = new HashSet<CarImage>();
        public virtual ICollection<Rental> Rentals { get; set; } = new HashSet<Rental>();
    }
}
