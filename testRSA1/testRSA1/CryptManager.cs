using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

namespace testRSA1
{
    public class CryptManager
    {
        public RSAParameters GenerateServerKey()
        {
            using RSA rsa = RSA.Create();
            return rsa.ExportParameters(true);
        }

        private byte[] ConvertStrToByte(string str) => Convert.FromBase64String(str);

        public RSAParameters getClientPK(Crypt request)
        {
            byte[] clientPKBytes = ConvertStrToByte(request.ClientPublicKey);
            using RSA rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(clientPKBytes, out _);
            return rsa.ExportParameters(false);
        }

        public bool Decrypt(RSAParameters serverPrivateKey, Message request)
        {
            byte[] encryptedData = ConvertStrToByte(request.message);

            using RSA serverRsa = RSA.Create();
            serverRsa.ImportParameters(serverPrivateKey);
            byte[] decryptedData = serverRsa.Decrypt(encryptedData, RSAEncryptionPadding.OaepSHA256);

            // Converte la stringa decriptata in UTF-8 e la stampa a console
            string decryptedString = Encoding.UTF8.GetString(decryptedData);
            Console.WriteLine($"Decrypted String: {decryptedString}");

            return true;
        }

        public string Crypt(RSAParameters? clientPublicKey, string str)
        {
            using RSA clientRsa = RSA.Create();
            clientRsa.ImportParameters(clientPublicKey ?? new());
            byte[] encryptedData = clientRsa.Encrypt(Encoding.UTF8.GetBytes(str), RSAEncryptionPadding.OaepSHA256);

            // Converte la stringa criptata in Base64 e la restituisce
            return Convert.ToBase64String(encryptedData);

        }
    }
}