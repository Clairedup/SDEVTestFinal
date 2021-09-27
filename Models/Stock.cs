using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDEVTest.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }
        public decimal Price { get; set; }
        public int StockLeft { get; set; }
    }
}
