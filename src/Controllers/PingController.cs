using Microsoft.AspNetCore.Mvc;

namespace apiFactory.Controllers;

[ApiController]
[Route ("[controller]")]
public class PingController : ControllerBase {

    private readonly ILogger<PingController> _logger;
    private readonly IUseCaseFactory _useCaseFactory;
    public PingController (ILogger<PingController> logger, IUseCaseFactory useCaseFactory) {
        _logger = logger;
        _useCaseFactory = useCaseFactory;
    }

    [HttpGet(template:"/ping")]
    public PongResponse GetPing ([FromQuery]string apiKey, [FromQuery] string tipoProduto) {

        return _useCaseFactory.GetUseCase (apiKey, tipoProduto).Execute ();
    }
}