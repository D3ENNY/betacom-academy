using gestioneLogin.assets.obj;

namespace gestioneLogin.engine;

class DataManager : Engine
{
    private readonly Crypt enc = new(); 

    internal void RegisterUser(string name)
    {

        User? u = SearchUser(name);
        if(u == null){
            Console.WriteLine("inserire password: ");
            string pw = Console.ReadLine()!;
            KeyValuePair<string,string> hash = enc.EncryptSaltString(pw);
            AppendXml(new User(name, hash));
            Console.Clear();
            Console.WriteLine("registrazione effetturata");
        }else MenuManager.UserExistError();
    }

    internal User? SearchUser(string username) => ReadXml<User>().Find(x => x.Username.Equals(username));

}