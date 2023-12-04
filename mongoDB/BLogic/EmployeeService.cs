using Microsoft.Extensions.Options;
using mongoDB.Models;
using MongoDB.Driver;

namespace mongoDB.BLogic
{
    public class EmployeeService
    {
        private IMongoCollection<Employee> _employees;
        public EmployeeService(IOptions<EmployeesDbConfig> opt ) 
        {
            MongoClient mongoClient = new(opt.Value.ConnectionString);
            IMongoDatabase mongoDB = mongoClient.GetDatabase(opt.Value.DatabaseName);
            _employees = mongoDB.GetCollection<Employee>(opt.Value.EmployeesCollectionName);
        }

        public async Task<IEnumerable<Employee>> GetEmployee() => await _employees.Find(e => true).ToListAsync();

        public async Task<DeleteResult> DeleteEmployer(string id) => await _employees.DeleteOneAsync(e => e.Id == id);
    }
}
