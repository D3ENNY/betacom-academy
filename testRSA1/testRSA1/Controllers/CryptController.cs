using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using testRSA1;

namespace testRSA1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptController : ControllerBase
    {
        private static RSAParameters serverPrivateKey;
        private static string ServerPublicKey;

        private static RSAParameters? clientPublicKey;

        private CryptManager cm;

        private readonly ILogger<CryptController> _logger;

        public CryptController(ILogger<CryptController> logger) {
            _logger = logger;
            this.cm = new();

            serverPrivateKey = cm.GenerateServerKey();
        }

        [HttpPost("ExchangePublicKey")]
        public ActionResult ExchangePublicKey([FromBody] Crypt request)
        {
            clientPublicKey ??= cm.getClientPK(request);
            ServerPublicKey = Convert.ToBase64String(serverPrivateKey.Modulus);

            return Ok(new
            {
                ServerPublicKey
            });

        }

        [HttpPost("DecryptString")]
        public ActionResult DecryptString([FromBody] Message request)
        {
            if(cm.Decrypt(serverPrivateKey, request))
                return Ok("String decrypted and printed to console.");
            return NotFound();

        }

        [HttpGet("EncryptString")]
        public ActionResult<string> EncryptString()
        {
            string dataToEncrypt = "pippo anche io";

            if (clientPublicKey == null)
                return BadRequest("Client public key not set.");
            return Ok(cm.Crypt(clientPublicKey, dataToEncrypt));
        }
    }
}