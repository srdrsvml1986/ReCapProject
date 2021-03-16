using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _Colorservice;

        public ColorsController(IColorService Colorservice)
        {
            _Colorservice = Colorservice;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_Colorservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }
        [HttpGet("getbyid")]
        public IActionResult get(int id)
        {
            var result=_Colorservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }   
        [HttpGet("getcars")]
        public IActionResult getCars(int colorId)
        {
            var result=_Colorservice.GetCars(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }   
        [HttpPost("add")]
        public IActionResult AddColor(Color color)
        {
            var result = _Colorservice.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult UpdateColor(Color color)
        {
            var result = _Colorservice.Update(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteColor(Color color)
        {
            var result = _Colorservice.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
