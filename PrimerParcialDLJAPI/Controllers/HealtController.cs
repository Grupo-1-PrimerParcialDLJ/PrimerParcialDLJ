using Microsoft.AspNetCore.Mvc;

namespace PrimerParcialDLJAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    /// <summary>
    /// Health check endpoint. Returns "Healthy".
    /// </summary>
    [HttpGet("ping")]
    [ProducesResponseType(typeof(string), 200)]
    public IActionResult Ping()
    {
        return Ok("Healthy");
    }
}