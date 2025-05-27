using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Parcial3Avisos.Models; 

namespace Parcial3Avisos.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiProyectoController : ControllerBase
    {
        [HttpGet("integrantes")]
        public ActionResult<MiProyecto> Integrantes()
        {
            var proyecto = new MiProyecto
            {
                Id = ObjectId.GenerateNewId().ToString(),
                NombreIntegrante1 = "Mia Adyeren Castillo Gamez",
                NombreIntegrante2 = "Danna Paola Castillo Briales"
            };

            return Ok(proyecto);
        }
    }
}
