using System.Collections.Generic;
using FinalGregsList.Models;
using FinalGregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalGregsList.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpPost]
        public ActionResult<Car> CreateCar([FromBody] Car carData)
        {
            try
            {
                 var car = _cs.CreateCar(carData);
                 return Ok(car);
            }
            catch (System.Exception error)
            {
                
                return BadRequest(error);
            }
        }



      [HttpGet]
      public ActionResult<List<Car>> GetCars(){
          try
          {
               var cars = _cs.Get();
               return Ok(cars);
          }
          catch (System.Exception error)
          {
              return BadRequest(error.Message);
          }
      }
      [HttpPut("{carId}")]
      public ActionResult<Car> EditCar(int carId, [FromBody] Car carData){
          try
          {
               var car = _cs.Edit(carId, carData);
               return Ok(car);
          }
          catch (System.Exception error)
          {
              return BadRequest(error.Message);
          }
      }
      [HttpDelete("{carId}")]
      public ActionResult<Car> DeleteCar(int carId){
          try
          {
               var car = _cs.Delete(carId);
               return Ok(car);
          }
          catch (System.Exception error)
          {
              return BadRequest(error.Message);
          }
      }

    }
}