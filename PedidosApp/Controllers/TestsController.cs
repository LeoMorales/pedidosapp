using PedidosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace PedidosApp.Controllers
{
    public class TestsController : Controller
    {

        public string Index()
        {
            return "Aca vamos a probar la gestion de los pedidos...";
        }

        public string Carga()
        {
            // Prueba los objetos del modelo...
            ProductModel p = new ProductModel { Id = 101, Name = "Plastico", Type = ProductType.Both, Thumbnail = "" };
            AccessoryModel accesory_a = new AccessoryModel { Id = 101, Name = "AccesoryA", ImageUrl = "", Price = "1000.0" };
            Color red_color = new Color { Id = 101, Name = "RedColor", Value = "#100", Accessory = accesory_a };
            OrderSizesModel order_size_s = new OrderSizesModel { Id = 202, A = 10, B = 20, C = 0, D = 0 };
            UserModel order_requestor = new UserModel {
                Id = 101,
                Dni = "40697897",
                Lat = 1000,
                Long = 1000,
                AmputationType = ProthesisType.Hand.ToString(),
                City = "Trelew",
                Address = "Sarmiento y San Martin",
                Country = "Argentina",
                Email = "user@gmail.com",
                Gender = Gender.F,
                Phone = "159878878",
                ProductType = ProductType.Left,
                ProthesisType = ProthesisType.Hand,
                ResponsableName = "Marge",
                UserName = "Lisa",
                Birth = new DateTime(2000, 12, 4)
            };


            string response = "";
            response += order_requestor.describe_yourself() + "<br>";
            response += p.describe_yourself();
            return response;
        }

        public ActionResult OrdersManagement()
        {
            OrderSizesModel order_size = new OrderSizesModel { Id = 202, A = 10, B = 20, C = 0, D = 0 };

            UserModel order_requestor = new UserModel
            {
                Id = 101,
                Dni = "40697897",
                Lat = 1000,
                Long = 1000,
                AmputationType = ProthesisType.Hand.ToString(),
                City = "Trelew",
                Address = "Sarmiento y San Martin",
                Country = "Argentina",
                Email = "user@gmail.com",
                Gender = Gender.F,
                Phone = "159878878",
                ProductType = ProductType.Left,
                ProthesisType = ProthesisType.Hand,
                ResponsableName = "Marge",
                UserName = "Lisa",
                Birth = new DateTime(2000, 12, 4)
            };

            UserModel order_user = new UserModel
            {
                Id = 101,
                Dni = "30697897",
                Lat = 1002,
                Long = 1002,
                AmputationType = ProthesisType.Hand.ToString(),
                City = "Ciudad",
                Address = "Sarmiento y San Martin, Trelew",
                Country = "Argentina",
                Email = "user@gmail.com",
                Gender = Gender.F,
                Phone = "159878878",
                ProductType = ProductType.Left,
                ProthesisType = ProthesisType.Hand,
                ResponsableName = "Marge",
                UserName = "John",
                Birth = new DateTime(1990, 12, 4)
            };

            var orders = new List<OrderModel>
            {
                new OrderModel {
                    Comments = "Order Comments A",
                    Design = 1,
                    Id = 101,
                    OrderRequestor = order_requestor,
                    OrderUser = order_user,
                    Sizes = order_size,
                    Status = OrderStatus.Pending
                },
                new OrderModel {
                    Comments = "Order Comments B",
                    Design = 1,
                    Id = 102,
                    OrderRequestor = order_requestor,
                    OrderUser = order_user,
                    Sizes = order_size,
                    Status = OrderStatus.Ready
                },
                new OrderModel {
                    Comments = "Order Comments B2",
                    Design = 1,
                    Id = 104,
                    OrderRequestor = order_requestor,
                    OrderUser = order_user,
                    Sizes = order_size,
                    Status = OrderStatus.Printing
                },

                new OrderModel {
                    Comments = "Order Comments C",
                    Design = 2,
                    Id = 103,
                    OrderRequestor = order_requestor,
                    OrderUser = order_user,
                    Sizes = order_size,
                    Status = OrderStatus.Delivered
                }

            }; 

            return View(orders);
        }
    }
}
