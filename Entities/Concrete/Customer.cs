﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {    
        public int Id { get; set; }
        
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public User User { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
