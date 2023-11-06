using Microsoft.AspNetCore.Mvc;

using WebApplication1.obj;
using WebApplication1.Const;

using ToolBoxLibrary.DatabaseBox;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployerController : ControllerBase
    {

        private readonly ILogger<EmployerController> _logger;
        private DatabaseBox db = new(source: Constant.dbSource, DbName: Constant.dbName, security: true);

        public EmployerController(ILogger<EmployerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Employers", Name = "GetEmployers")]
        public IEnumerable<Employers> GetEmployers([FromQuery] string Name = null)
        {
            List<Employers> employersList = new();
            List<Dictionary<string, string>> employerResult;
            try
            {
                if(Name == null)
                    employerResult = db.Query(Constant.getEmployerQuery);
                else
                {
                    Dictionary<string,string> param = new();
                    param.Add("param", Name);
                    employerResult = db.Query(Constant.getEmployerQueryParam, param);
                }

                employerResult.Where(x => !employersList.Any(e =>
                    e.RegisterId.Equals(x["Matricola"]))
                ).ToList()
                .ForEach(v => employersList.Add(new Employers(
                    v["Matricola"],
                    v["Nominativo"],
                    v["Ruolo"],
                    v["Reparto"],
                    v["Eta"],
                    v["Indirizzo"],
                    v["Citta"],
                    v["Provincia"],
                    v["CAP"],
                    v["Telefono"]
                 )));

                List<Dictionary<string, string>> employerActivityResult = db.Query(Constant.getEmployerActivityQuery);
                Employers.TotalEmployersActivitiesList.AddRange(
                   employerActivityResult.Select(x => new EmployersActivity(
                       x["DataAttivita"],
                       x["Attivita"],
                       x["Ora"],
                       x["Matricola"])
                   ).ToList()
                );

                employersList.ForEach(x =>
                    x.EmployersActivities.AddRange(Employers.TotalEmployersActivitiesList.Where(e => e.EmployerID == x.RegisterId))
                );
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            return employersList;
        }
    }
    
}