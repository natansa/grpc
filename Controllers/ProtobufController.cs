using Microsoft.AspNetCore.Mvc;
using ProtobufNet6.Extensions;
using ProtobufNet6.Models;
using System.Text.Json;

namespace ProtobufNet6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProtobufController : ControllerBase
    {
        private readonly ILogger<ProtobufController> _logger;

        public ProtobufController(ILogger<ProtobufController> logger)
        {
            _logger = logger;
        }

        [HttpPost("serialize")]
        public IActionResult Serialize([FromBody] Pessoa pessoa)
        {
            var protobuf = pessoa.SerializeToStringProtobuf();
            _logger.LogInformation($"Pessoa serializada: {protobuf}");
            return Ok(protobuf);
        }

        [HttpPost("deserialize")]
        public IActionResult Deserialize([FromBody] string protobuf)
        {
            var pessoa = protobuf.DeserializeFromStringProtobuf<Pessoa>();
            _logger.LogInformation($"Pessoa deserializada: {JsonSerializer.Serialize(pessoa)}");
            return Ok(pessoa);
        }
    }
}