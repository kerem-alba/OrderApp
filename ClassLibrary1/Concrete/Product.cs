using Core.Entities;
using Core.Enums;
using System;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int ColorId { get; set; }
        public SizeEnum Size { get; set; }
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    }
}