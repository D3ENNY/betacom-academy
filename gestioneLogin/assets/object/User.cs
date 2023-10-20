using System.ComponentModel.DataAnnotations;

namespace gestioneLogin.assets.obj;

public class User
{
    public string Username{get;set;} =  string.Empty;
    public string Salt{get;set;} = "";
    public string Hash {get;set;} = "";

    public User() { }

    public User(string Username, KeyValuePair<string, string> hash)
    {
        this.Username = Username;
        this.Salt = hash.Key;
        this.Hash = hash.Value;
    }

    public override string ToString(){
        return $"u: {this.Username} - h: {this.Hash} - s: {this.Salt}";
    }
}