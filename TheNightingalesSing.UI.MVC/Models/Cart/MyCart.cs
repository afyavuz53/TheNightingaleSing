﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.UI.MVC.Models.Cart
{
    public class MyCart
    {
        static private Dictionary<int, CartItem> sepet=new Dictionary<int, CartItem>();
        public List<CartItem> GetAllCartItem => sepet.Values.ToList();
        public void AddCart(CartItem cartItem)
        {
            if (sepet.ContainsKey(cartItem.ID))
            {
                sepet[cartItem.ID].Amount += cartItem.Amount;
                return;
            }
            sepet.Add(cartItem.ID, cartItem);
        }
        public void UpdateCart(int id,short amount)
        {
            if (sepet.ContainsKey(id))
            {
                sepet[id].Amount = amount;
            }
        }
        public void DeleteCart(int id)
        {
            if (sepet.ContainsKey(id))
            {
                sepet.Remove(id);
            }
        }
        public int TotalAmount => sepet.Values.Sum(a => a.Amount);
    }
}
