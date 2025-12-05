[ApiController]
[Route("api/index")]
public class IndexController : ControllerBase
{
    [HttpPost("validarCredenciales")]
    public IActionResult ValidarCredenciales([FromBody] CredencialesDto dto)
    {
        // Lógica de validación aquí
        }
    }