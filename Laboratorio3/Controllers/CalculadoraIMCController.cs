using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        // GET: CalculadoraIMC
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }

        public ActionResult ResultadosAleatoriosIMC()
        {
            Random random = new Random();
            PersonaModel[] personas = new PersonaModel[30];
            double[] IMCS = new double[30];
            for (int idPersona = 1; idPersona <= 30; ++idPersona)
            {
                double peso = random.NextDouble() * (150 - 20) + 20;
                double estatura = random.NextDouble() + 1;
                personas[idPersona - 1] = new PersonaModel(idPersona, "Sin nombre", peso, estatura);
                IMCS[idPersona - 1] = peso / (estatura * estatura); 
            }
            ViewBag.IMCS = IMCS;
            ViewBag.personas = personas;
            return View();
        }
    }
}