using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLogic;
using MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class MyController : ControllerBase
    {

        private readonly ILogic _logic;


        public MyController(ILogic logic)
        {
            _logic = logic;
        }




        [HttpPost]

        public IActionResult Additional(AdditionViewModel model)
        {
            var bringme = _logic.Addition(model);
            return Ok(bringme);
        }



        [HttpPost]

        public IActionResult Subtraction(SubtractionViewModel model)
        {
            var giveme = _logic.Subtraction(model);
            return Ok(giveme);
        }


        [HttpPost]

        public IActionResult Multiply(MultiplyViewModel model)
        {
            var getme = _logic.Multiply(model);
            return Ok(getme);
        }



        [HttpPost]

        public IActionResult Division(DivisionViewModel model)
        {
            var getit = _logic.Division(model);
            return Ok(getit);
        }


    }
}
