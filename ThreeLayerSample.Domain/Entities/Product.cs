
using ThreeLayerSample.Domain.Contracts;

namespace ThreeLayerSample.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
  
    }
}
