using gestioneLogin.assets.obj;

namespace gestioneLogin.engine;

class DataManager : Engine
{
    private readonly Crypt enc = new();

    internal void LoginUser(string name)
    {
        User? u = SearchUser(name);
        if(u != null){
            Console.WriteLine("inserire password: ");
            string pw = Console.ReadLine()!;
            if(enc.VerifyPassword(pw, new KeyValuePair<string, string>(u.Salt, u.Hash)))
                Console.WriteLine("utetente loggato");
            else Console.WriteLine("password errata");
        }else MenuManager.UserNotExistsError();
    }
    // 19 95 181 236 141 185 242 172 162 156 231 200 230 205 31 223 
    // 118 30 162 125 57 93 156 45 152 220 74 230 142 124 162 55 
    // 118 30 162 125 57 93 156 45 152 220 74 230 142 124 162 55
    internal void RegisterUser(string name)
    {

        User? u = SearchUser(name);
        if(u == null){
            Console.WriteLine("inserire password: ");
            string pw = Console.ReadLine()!;
            KeyValuePair<string,string> hash = enc.EncryptSaltString(pw);
            Console.ReadKey();
            AppendXml(new User(name, hash));
            Console.Clear();
            Console.WriteLine("registrazione effetturata");
        }else MenuManager.UserExistError();
    }

    internal User? SearchUser(string username) => ReadXml<User>().Find(x => x.Username.Equals(username));

}