using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc,Rendering;

namespace HairSalon.AddControllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstorDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists
                              .Include(brand => stylist.Stylists)
                              .FirstorDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstorDefault(stylist => stylist.StylistId == id);
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Clients.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstorDefault(stylist => stylist.StylistId == id);
      ViewBag.field = "Name";
      ViewBag.name = thisStylist.Name;
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstorDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}