using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Parcial3Avisos.Models; 

namespace Parcial3Avisos.Controllers.Api
{
    [ApiController]
    [Route("mi-proyecto")]
    public class MiProyectoController : ControllerBase {
        [HttpGet("integrantes")]
        public IActionResult Integrantes() {
           MiProyecto mi = new MiProyecto();
           mi.NombreIntegrante1 = "Mia Adyeren Castillo Gamez";
           mi.NombreIntegrante2 = "Danna Paola Castillo Briales";

           return Ok (mi);
        }

        [HttpGet("presentacion")]
        public IActionResult Presentacion() {
            var client = new MongoClient(CadenasConexion.Mongo_DB);
            var bd = client.GetDatabase("Escuela_Mia_Danna");
            var collection = bd.GetCollection<Equipo>("Equipo");
            
             var item = collection.Find(FilterDefinition<Equipo>.Empty).FirstOrDefault();
            return Ok(item);
        }
    }
    
}
