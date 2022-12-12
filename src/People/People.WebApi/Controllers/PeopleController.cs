using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpDEV.StockManager.People.BusinessRules.Dtos;

namespace UpDEV.StockManager.People.WebApi.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleController()
        {
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody][CustomizeValidator(RuleSet = "person-create")] PersonDto person)
        {
            return Ok(person);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody][CustomizeValidator(RuleSet = "person-put")]  PersonDto person, long id)
        {
            return Ok(new
            {
                Id = id,
                Person = person
            });
        }

        [HttpPatch("patch")]
        public IActionResult Patch([FromBody][CustomizeValidator(RuleSet = "person-patch")] PersonDto person,long id)
        {
            return Ok(new
            {
                Id = id, 
                Person = person
            });
        }
    }
}
