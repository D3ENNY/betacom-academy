using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace startaccademynet4;

class Encrypt
{
    internal string EncryptString(string sValue){
        StringBuilder strB = new();
        try
        {
                SHA256 sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sValue)); 

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("x2")); //c2 serve per convertire in HEX
                } 
        }
        catch (System.Exception)
        {
            
            throw;
        }
        return strB.ToString();
    }

    internal KeyValuePair<string,string> EncryptSaltString(string sValue){
        byte[] byteSalt = new byte[16];
        string EncResult = string.Empty;
        string EncSalt = string.Empty;
        try
        {
            RandomNumberGenerator.Fill(byteSalt);
            EncResult = Convert.ToBase64String(
                //dotnet add package Microsoft.AspNetCore.Cryptography.KeyDerivation --version 7.0.12
                KeyDerivation.Pbkdf2(   
                    password: sValue,
                    salt: byteSalt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000,
                    numBytesRequested: 132
                )
            );
            EncSalt = Convert.ToBase64String(byteSalt);
        }
        catch (System.Exception)
        {
            throw;
        }
        return new KeyValuePair<string, string>(EncSalt, EncResult);
    }
}