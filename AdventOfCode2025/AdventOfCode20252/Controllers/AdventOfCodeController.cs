using AdventOfCodeLogic;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2025.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdventOfCodeController : ControllerBase
    {
        private readonly Day1Logic _day1Logic;
        private readonly Day2Logic _day2Logic;

        public AdventOfCodeController(Day1Logic day1Logic)
        {
            _day1Logic = day1Logic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _day1Logic.Day1Part1();
            return Ok(result);
        }

        [HttpGet("day2")]
        public IActionResult GetDay2()
        {
            var result = _day2Logic.Day2Part1();
            return Ok(result);
        }
        
    }
}
