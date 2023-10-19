using System.ComponentModel.DataAnnotations;

namespace gestioneLogin.assets.obj;

public class User
{
    [Required]
    public string Username{get;set;} =  string.Empty;

    [Required]
    public string Salt{get;set;} = "";

    public string Hash {get;set;} = "";

    public User() { }

    public User(string Username, KeyValuePair<string, string> hash)
    {
        this.Username = Username;
        this.Salt = hash.Value;
        this.Hash = hash.Key;
    }

    public override string ToString(){
        return $"u: {this.Username} - h: {this.Hash}";
    }
}