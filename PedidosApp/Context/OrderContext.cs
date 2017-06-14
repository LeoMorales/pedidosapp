using PedidosApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PedidosApp.Context
{
    public class OrderContext : DbContext
    {
        public DbSet<OrderModel> Orders { get; set; }
    }
}