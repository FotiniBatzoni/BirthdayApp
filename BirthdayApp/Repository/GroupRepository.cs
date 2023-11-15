using BirthdayApp.Classes;
using BirthdayApp.Repository.Interface;
using MongoDB.Driver;

namespace BirthdayApp.Repository
{
    public class GroupRepository : IRepository<Group>
    {
        private readonly MongoDBContext _dbContext;

        public GroupRepository(MongoDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Group> GetAll()
        {
            return _dbContext.GetCollection<Group>("Groups").Find(FilterDefinition<Group>.Empty).ToList();
        }

        public Group GetById(string id)
        {
            return _dbContext.GetCollection<Group>("Groups").Find(c => c.Id == id).FirstOrDefault();
        }

        public void Add(Group entity)
        {
            _dbContext.GetCollection<Group>("Groups").InsertOne(entity);
        }

        public void Update(Group entity)
        {
            var filter = Builders<Group>.Filter.Eq(c => c.Id, entity.Id);
            var update = Builders<Group>.Update
                .Set(c => c.Name, entity.Name);

            _dbContext.GetCollection<Group>("Groups").UpdateOne(filter, update);
        }

        public void Delete(string id)
        {
            var filter = Builders<Group>.Filter.Eq(c => c.Id, id);
            _dbContext.GetCollection<Group>("Groups").DeleteOne(filter);
        }


    }
}
