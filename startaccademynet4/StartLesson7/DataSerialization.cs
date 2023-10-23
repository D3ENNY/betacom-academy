using Newtonsoft.Json;
namespace startaccademynet4;

class DataSerialization{
    //JSON -> Javascricp Script Object Notation
    internal class Fly
    {
        public string NumeroVolo{get; set;} = "";
        public string Origine{get;set;} = "";
        public string Destinazione {get;set;} = "";
        public string DataPartenza {get;set;} = "";
        public string DataArrivo {get;set;} = "";
        public int Capacita {get;set;}
        public string Cod_IATA {get;set;} = "";
        public string Compagnia {get;set;} = "";

        private List<Fly> flys = new();


        internal void LoadFly(){
            string fJson = String.Empty;
            
            using(StreamReader sr = new(Path.Combine("assets/", "fileTest.json")))
            {
                fJson = sr.ReadToEnd();
            }

            flys = JsonConvert.DeserializeObject<List<Fly>>(fJson) ?? new();
        }

        internal void  SaveJson()
        {
            object jsonOut = JsonConvert.SerializeObject(flys, Formatting.Indented);
            using(StreamWriter sw = new(Path.Combine("assets/","fileTestCopy.json")))
            {
                sw.WriteLine(jsonOut);
            }
        }

    }
}