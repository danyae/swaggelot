using System.Text.Json.Serialization;

namespace OrderService.Models
{
    public class OrderCreateModel
    {
        public Currency Currency { get; set; }
        public string[] Goods { get; set; }
    }
}