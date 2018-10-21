using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalPrivadoHP.Controllers
{
	[RequireHttps]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<HospitalPrivadoHP.Models.ApplicationUser>(new UserStore<HospitalPrivadoHP.Models.ApplicationUser>(new HospitalPrivadoHP.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
			}
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Tu página de Contacto.";

			return View();
		}
	}
}