using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularAreaWS
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    //Practica 3 - Servicio Web en .NET
    // Servicios web - 9°J
    // Ramos Espinosa Claudia Janeth
    public class CalcularWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public double areacuadrado(double lado1)
        {
            CalcularArea calcular = new CalcularArea();            
            return calcular.cuadrado(lado1);
        }
        [WebMethod]
        public double areatriangulo(double bse, double altura)
        {
            CalcularArea calcular = new CalcularArea();
            return calcular.triangulo(bse, altura);
        }
        [WebMethod]
        public double areacirculo(double radio)
        {
            CalcularArea calcular = new CalcularArea();
            return calcular.circulo(radio);
        }
    }
}
