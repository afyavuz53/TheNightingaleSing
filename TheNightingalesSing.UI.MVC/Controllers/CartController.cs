using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Helper;
using TheNightingalesSing.UI.MVC.Models.Cart;

namespace TheNightingalesSing.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(HttpContext.Session.Get<MyCart>("cart"));
        }
        public IActionResult GetCartButton()
        {
            MyCart myCart = HttpContext.Session.Get<MyCart>("cart");
            return PartialView("_cartButton", myCart.TotalAmount);
        }
        [HttpPost]
        public IActionResult AddCartItem([FromBody] CartVM cartVM)
        {
            MyCart myCart = HttpContext.Session.Get<MyCart>("cart");
            CartItem addedCart = new CartItem
            {
                ID = cartVM.ID,
                Name = cartVM.Name,
                Price = cartVM.Price,
                Amount = 1
            };
            myCart.AddCart(addedCart);
            HttpContext.Session.Set("cart", myCart);
            return PartialView("_cartButton", myCart.TotalAmount);
        }
        public IActionResult UpdateCartItem(int id, short amount)
        {
            MyCart myCart = HttpContext.Session.Get<MyCart>("cart");
            myCart.UpdateCart(id, amount);
            HttpContext.Session.Set("cart", myCart);
            return PartialView("_tableList", myCart);
        }
        public IActionResult DeleteCartItem(int id)
        {
            MyCart myCart = HttpContext.Session.Get<MyCart>("cart");
            myCart.DeleteCart(id);
            HttpContext.Session.Set("cart", myCart);
            return PartialView("_tableList", myCart);
        }
    }
}
