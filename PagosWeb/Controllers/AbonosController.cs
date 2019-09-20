using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagosWeb.Models;

namespace PagosWeb.Controllers
{
    public class AbonosController : Controller
    {
        PagosDb db = new PagosDb();
        // GET: Abonos
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacturaAbonoId,FechaAbono,MontoAbono,Notas,FacturaId")] FacturaAbono abono)
        {
            if (ModelState.IsValid)
            {
                FacturaAbono obj = new FacturaAbono();
                Facturas oFact = db.Facturas.DefaultIfEmpty(null).FirstOrDefault(f => f.FacturaId == abono.FacturaId);
                decimal saldo = oFact.Saldo;
                obj.FacturaId = abono.FacturaId;
                obj.FechaAbono = abono.FechaAbono;
                obj.MontoAbono = abono.MontoAbono;
                obj.SaldoAnterior = saldo;
                obj.Notas = abono.Notas;

                db.FacturaAbono.Add(obj);
                db.SaveChanges();

                //descontando la factura
                oFact.Saldo = oFact.Saldo - obj.MontoAbono;
                if (oFact.Saldo == 0) {oFact.Cancelado = true;}
                db.Entry(oFact).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(abono);
        }

        public ActionResult Historial()
        {
            return View();
        }
        public JsonResult buscarFactura(int idfact)
        {
            Facturas obj;
            obj = db.Facturas.DefaultIfEmpty(null).FirstOrDefault(x => x.FacturaId == idfact);
            return Json(new { FacturaId=obj.FacturaId,
                Cliente =obj.Clientes.NombreCompleto,
                Monto=obj.MontoFactura,
                Fecha=obj.FechaFactura,
                Saldo=obj.Saldo},
                JsonRequestBehavior.AllowGet);
        }
        public JsonResult getAbonos(int idfact)
        {
            var lista = db.FacturaAbono.Where(x => x.FacturaId == idfact).ToList();
            var obj = (from a in lista
                       select new
                       {
                           FechaAbono = ""+a.FechaAbono,
                           MontoAbono = a.MontoAbono,
                           SaldoAnterior = a.SaldoAnterior,
                           Notas = a.Notas
                       });
            return Json(new { data = obj }, JsonRequestBehavior.AllowGet);

        }
    }
}