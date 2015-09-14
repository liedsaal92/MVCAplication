using System.Collections.Generic;
using MvcApplication.Models;

namespace MvcApplication.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}