using b_b.Blogic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace b_b.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BnBController
    {
        private BnBService _BnB;

        public BnBController(BnBService service)
        {
            _BnB = service;
        }

        [HttpGet]
        public Task<IEnumerable<object>> Get() => _BnB.GetBnb();

        [HttpGet("{id}")]
        public Task<object> Get(int id) => _BnB.GetBnBID(id) ?? NotFound();


    }
}
