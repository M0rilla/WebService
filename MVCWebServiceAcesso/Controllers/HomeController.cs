using MVCWebServiceAcesso.ClientServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebServiceAcesso.Controllers
{
    public class HomeController : Controller
    {
        public Service1Client service = new Service1Client();

        public ActionResult Index()
        {
            
            //Criamos uma instância do ServiceClient

            //var clientes = service.All();
            //var cliente = service.GetData(1);
            //var salvar = service.Save("Danilo","845665256");

            return View();
        }

        [HttpGet]
        public JsonResult GetServiceData()
        {
            var _result = service.All();            
                                    
            return Json(_result, JsonRequestBehavior.AllowGet);
        }
    }

}