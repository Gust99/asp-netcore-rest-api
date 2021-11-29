using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VentasUcb.Core.Entities;
using VentasUcb.Core.Interfaces;
using VentasUcb.Infraestructure.Repositories;

namespace VentasUcb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestapiController : ControllerBase
    {
        private readonly ITestapiRepository _testapiRepository;
        public TestapiController(ITestapiRepository testapiRepository)
        {
            _testapiRepository = testapiRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTestapiAsync()
        {
            //var result = new TestapiRepository().GetTestapi();
            var result = await _testapiRepository.GetTestapi();
            return Ok(result);
        }
    }
}
