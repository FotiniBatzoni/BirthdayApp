using BirthdayApp.Classes;
using BirthdayApp.Repository.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Interfaces
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly MongoDBContext _dbContext;

        public PersonRepository(MongoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Person> GetAll()
        {
            return _dbContext.GetCollection<Person>("Persons").Find(FilterDefinition<Person>.Empty).ToList();
        }

        public Person GetById(string id)
        {
            var objectId = ObjectId.Parse(id);
            return _dbContext.GetCollection<Person>("Persons").Find(c => c.Id == objectId).FirstOrDefault();
        }

        public void Add(Person entity)
        {
            _dbContext.GetCollection<Person>("Persons").InsertOne(entity);
        }

        public void Update(Person entity)
        {
            var filter = Builders<Person>.Filter.Eq(c => c.Id, entity.Id);
            var update = Builders<Person>.Update
                .Set(c => c.FirstName, entity.FirstName)
                .Set(c => c.LastName, entity.LastName)
                .Set(c => c.Birthday, entity.Birthday)
                .Set(c => c.Sex, entity.Sex);

            _dbContext.GetCollection<Person>("Persons").UpdateOne(filter, update);
        }

        public void Delete(string id)
        {
            var objectId = ObjectId.Parse(id);
            var filter = Builders<Person>.Filter.Eq(c => c.Id, objectId);
            _dbContext.GetCollection<Person>("Persons").DeleteOne(filter);
        }
    }
  
}
