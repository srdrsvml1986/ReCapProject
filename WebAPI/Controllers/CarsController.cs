using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        ICarImageService _carImageService;
        IRentalService _rentalService;

        public CarsController(ICarService carService, ICarImageService carImageService, IRentalService rentalService)
        {
            _carService = carService;
            _carImageService = carImageService;
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }
        [HttpGet("getbyid")]
        public IActionResult get(int id)
        {
            var imgs = _carImageService.GetImagesByCarId(id);
            var rentals = _rentalService.GetAll(x=>x.CarId==id);
            var result=_carService.GetById(id);
            foreach (var img in imgs.Data)
            {
                result.Data.CarImages.Add(img);
            }
            foreach (var rental in rentals.Data)
            {
                result.Data.Rentals.Add(rental);
            }

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }

        [HttpGet("getdetails")]
        public IActionResult GetCarDetails()
        {
            var result=_carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);             
        }

        [HttpPost("add")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult UpdateCar(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteCar(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
