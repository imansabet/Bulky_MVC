﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ShoopingCartRespoitory : Repository<ShoppingCart> , IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoopingCartRespoitory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


       

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
