using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApiNorthWind
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Agregar estas lineas para trabajar con el Entity Framework y enviar JSON nada mas
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            //Es altamente recomendable no pasar directamente las entidades ,si no crear
            //un UserModel en la carpeta de los modelos por que se puede decidir que se muestra y que no
            //[KnowTypeAttribute(typeof(UserModel))] saber cual es la clase expuesta en la API REST

        
        }
    }
}
