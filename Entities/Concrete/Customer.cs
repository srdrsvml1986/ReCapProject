using Core.Entities;
using Core.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {    
        public int Id { get; set; }
        
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }=new HashSet<Rental>();
    }
}
