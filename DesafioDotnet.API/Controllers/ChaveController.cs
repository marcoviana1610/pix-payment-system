using DesafioDotnet.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDotnet.API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ChaveController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post(ChaveModel chave) 
        {
            try
            {
                return Ok("Chave pix adicionada com sucesso");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
