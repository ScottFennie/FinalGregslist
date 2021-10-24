using System;
using System.Collections.Generic;
using FinalGregsList.Models;

namespace FinalGregsList.Data
{
    public class FakeDb{
        private Random _random = new Random();
        public List<Car> Cars = new List<Car>();


        public int GenerateId(){
            return _random.Next(10000, 1000000);
        }
    }
}