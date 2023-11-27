using System.Security.Cryptography;
using System.Text;

namespace testRSA;

internal class Program
{
    private static string publicKey;
    private static string privateKey;

    static byte[] EncryptData(byte[] data, string publicKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.FromXmlString(publicKey);
            return rsa.Encrypt(data, true);
        }
    }

    static byte[] DecryptData(byte[] data, string privateKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.FromXmlString(privateKey);
            return rsa.Decrypt(data, true);
        }
    }

    static void Main(string[] args)
    {
        using (RSACryptoServiceProvider rsa = new(1024))
        {
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }

        Console.WriteLine($"K+ =>\n{publicKey}\nK- =>\n{privateKey}");

        string originalData = "pippo anche io";

        byte[] dataToEncrypt = Encoding.UTF8.GetBytes(originalData);

        byte[] encryptedData = EncryptData(dataToEncrypt, publicKey);
        byte[] decryptedData = DecryptData(encryptedData, privateKey);

        string decryptedText = Encoding.UTF8.GetString(decryptedData);

        Console.WriteLine(decryptedText);
    }
}
