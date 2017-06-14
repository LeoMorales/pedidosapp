using PedidosApp.Context;
using PedidosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PedidosApp.Controllers
{
    public class OrderController : Controller
    {
        private OrderContext db = new OrderContext();

        // GET: Order
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        // GET: Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            OrderModel order = db.Orders.Find(id);
            if (order == null)
                return HttpNotFound();
            return View(order);
            
        }

        // GET: Order/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(OrderModel order)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(order);
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            OrderModel order = db.Orders.Find(id);
            if (order == null)
                return HttpNotFound();
            return View(order);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderModel order)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(order);
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            OrderModel order = db.Orders.Find(id);
            if (order == null)
                return HttpNotFound();
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, OrderModel prod)
        {
            try
            {
                // TODO: Add delete logic here
                OrderModel order = new OrderModel();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    order = db.Orders.Find(id);
                    if (order == null)
                        return HttpNotFound();

                    db.Orders.Remove(order);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(order);

            }
            catch
            {
                return View();
            }
        }
    }
}
