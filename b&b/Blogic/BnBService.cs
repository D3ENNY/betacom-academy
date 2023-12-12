using b_b.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace b_b.Blogic
{
    public class BnBService
    {
        private readonly IMongoCollection<BsonDocument> _bnb;
        public BnBService(IOptions<AirBnBdbConfigure> opt)
        {
            MongoClient mongoClient = new(opt.Value.ConnectionString);
            IMongoDatabase mongoDB = mongoClient.GetDatabase(opt.Value.DBname);
            _bnb = mongoDB.GetCollection<BsonDocument>(opt.Value.CollectionName);
        }

        public async Task<IEnumerable<object>> GetBnb()
        {
            List<BsonDocument> tmp = await _bnb.Find(e => true).Limit(10).ToListAsync();
            List<object> returnList = tmp.Select(e => BsonTypeMapper.MapToDotNetValue(e)).ToList();
            return returnList;
        }

        public async Task<object> GetBnBID(int id)
        {
            return BsonTypeMapper.MapToDotNetValue(await _bnb.Find(Builders<BsonDocument>.Filter.Eq("_id", id)).FirstOrDefaultAsync());
        }
    }
}
