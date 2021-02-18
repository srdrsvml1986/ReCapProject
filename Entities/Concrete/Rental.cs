using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    //Arabanın kiralanma bilgisini tutan tablo oluşturunuz. 
    //Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.

    public class Rental : IEntity
    {
        public int Id { get; set; }
        [ForeignKey("CarId")]
        public int CarId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
