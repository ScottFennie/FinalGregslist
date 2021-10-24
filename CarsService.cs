using System.Collections.Generic;
using FinalGregsList.Data;
using FinalGregsList.Models;

namespace FinalGregsList.Services
{
    public class CarsService
    {

        private readonly FakeDb _db;
        
        public CarsService(FakeDb db)
        {
            _db = db;
        }

        public Car CreateCar(Car carData)
        {
            carData.Id = _db.GenerateId();
            _db.Cars.Add(carData);
            return carData;

        }

        public List<Car> Get()
        {
            return _db.Cars;
        }

        public Car Get(int carId){
            var car = _db.Cars.Find(c => c.Id == carId);
            if(car == null){
                throw new System.Exception("Invalid Car Id");
            }
            return car;
        }

        public Car Edit(int carId, Car carData)
        {
            var car = Get(carId);
            car.year = carData.year;
            car.img = carData.img ?? car.img;
            car.make = carData.make;
            car.price = carData.price;
            car.description = carData.description ?? car.description;
            return car;
        }
        public Car Delete(int carId){
            var car = Get(carId);
            _db.Cars.Remove(car);
            return car;
        }
    }
}