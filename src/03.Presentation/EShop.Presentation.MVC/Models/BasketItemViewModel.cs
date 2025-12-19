
namespace EShop.Presentation.MVC.Models
{
    public class BasketItemViewModel
    {
       
            public int Id { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public double Price { get; set; }
        public int ProductId { get; set; }  
            
        
    }
}
