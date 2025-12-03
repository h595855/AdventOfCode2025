using AdventOfCodeLogic;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2025.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Day1Controller : ControllerBase
    {
        private readonly Day1Logic _logic;

        public Day1Controller(Day1Logic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _logic.Day1Part1();
            return Ok(result);
        }
    }
}
