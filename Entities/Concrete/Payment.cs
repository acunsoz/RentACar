using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CardNumber { get; set; }
        public string FullName { get; set; }
        public int ExpirationMounth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
}
