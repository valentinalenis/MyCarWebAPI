using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MyCarWebAPI.Models
{
    public class CarService
    {
        private readonly IMongoCollection<Car> _database;

        public CarService(ICarsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _database = database.GetCollection<Car>(settings.CollectionName);
        }

        public List<Car> Get() =>
            _database.Find(car => true).ToList();

        public Car Get(string id) =>
            _database.Find<Car>(car => car.id == id).FirstOrDefault();

        public Car Create(Car car)
        {
            _database.InsertOne(car);
            return car;
        }

        public void Update(string id, Car carIn) =>
            _database.ReplaceOne(car => car.id == id, carIn);

        public void Remove(Car carIn) =>
            _database.DeleteOne(car => car.Consecutivo == carIn.Consecutivo);

        public void Remove(string id) =>
            _database.DeleteOne(car => car.id == id);
    }

}
