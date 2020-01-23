using Microsoft.AspNetCore.Mvc;
using ApiPNB.entities;
using ApiPNB.Interfaces;

namespace ApiPNB.Controllers
{
    [Route("api")]
    [ApiController]
    public class PnbController : ControllerBase
    {
        private readonly IPnbRestCpf iPnbRestCpf;

        public PnbController(IPnbRestCpf iPnbRestCpf)
              => this.iPnbRestCpf = iPnbRestCpf;

        [HttpGet("cpf/{cpf}")]
        public ActionResult<JsonCpf> GetCpf(string cpf)
           => iPnbRestCpf.ProcessaAsync(cpf);


        // GET api/contas/idPessoa
        [HttpGet("contas/{idPessoa}")]
        public ActionResult GetContas(int idPessoa)
        {
            return Ok("contas " + idPessoa);
        }

        // POST api/conta/idPessoa
        [HttpGet("conta/{idConta}")]
        public IActionResult GetConta(int idConta)
        {
            return Ok("conta " + idConta);
        }

        // PUT api/faturas/idConta
        [HttpGet("fatura/{idConta}")]
        public IActionResult getFatura(int idConta)
        {
            return Ok("Faturas " + idConta);
        }

        
    }
}
