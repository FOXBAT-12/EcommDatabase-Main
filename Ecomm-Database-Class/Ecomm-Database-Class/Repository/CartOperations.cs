//using Ecomm_Database_Class.Data;
//using Ecomm_Database_Class.Model;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks; 


//namespace Ecomm_Database_Class.Repository
//{
//    public class CartOperations
//    {
//        private readonly AppDbContext _context;

//        public CartOperations()
//        {
//            _context = new AppDbContext();
//        }

//        public List<Cart> GetAllCarts()
//        {
//            return _context.CartItems.ToList();
//        }

//        public Cart GetCartById(int id)
//        {
//            return _context.CartItems.FirstOrDefault(c => c.CartItemID == id);
//        }

//        public void AddCart(Cart cart)
//        {
//            _context.CartItems.Add(cart);
//            _context.SaveChanges();
//        }

//        public void UpdateCart(Cart cart)
//        {
//            _context.CartItems.Update(cart);
//            _context.SaveChanges();
//        }

//        public void DeleteCart(int id)
//        {
//            var cart = _context.CartItems.FirstOrDefault(c => c.CartItemID == id);
//            if (cart != null)
//            {
//                _context.CartItems.Remove(cart);
//                _context.SaveChanges();
//            }
//        }
//    }
//}
