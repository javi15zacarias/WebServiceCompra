using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using WebServiceCompra.Model;

namespace WebServiceCompra
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void validarCredenciales(String apiKey, String user, String password)
        {
            if (apiKey.Equals(Apikey.apiKey))
            {
                Response respuesta = new Response();
                respuesta.respuestas = "El usuario ha sído encontrado de manera sadisfactoria";
                HttpContext.Current.Response.ContentType = "application/json; charset=utf-8 ";
                HttpContext.Current.Response.Write(JsonConvert.SerializeObject(respuesta));
            }
            else
            {
                Response respuesta = new Response();
                respuesta.respuestas = "ApiKeyErronea";
                HttpContext.Current.Response.ContentType = "application/json; charset=utf-8 ";
                HttpContext.Current.Response.Write(JsonConvert.SerializeObject(respuesta));
            }
         
        }
    }
}
