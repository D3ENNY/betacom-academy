namespace startaccademynet4;

public class LogManager
{
    public class DataLog
    {
        public string? Classname {get;set;}
        public string? MethodName {get;set;}
        public DateTime DataTimeLog {get;set;}
        public int ErrorCode {get;set;}
        public string? ErrorMessage {get;set;}
    }
}