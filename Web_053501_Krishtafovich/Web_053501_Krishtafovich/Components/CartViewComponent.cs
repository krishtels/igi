using Microsoft.AspNetCore.Mvc;
using Web_053501_Krishtafovich.Extensions;
using Web_053501_Krishtafovich.Models;

namespace Web_053501_Krishtafovich.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
