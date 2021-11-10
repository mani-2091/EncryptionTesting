using System.Text;
using EncryptionTesting.StandardLib;

namespace EncryptionTesting.Net5
{
    internal class Program
    {
        private static string PASSPHRASE = "nzv86ri4H2qYHqc&m6rL";

        static void Main(string[] args)
        {
            var input = "12345678901234567890";
            var inputLength = input.Length;
            var inputBytes = Encoding.UTF8.GetBytes(input);

            var encrypted = StringCipher.Encrypt(input, PASSPHRASE);

            var output = StringCipher.Decrypt(encrypted, PASSPHRASE);
            var outputLength = output.Length;
            var outputBytes = Encoding.UTF8.GetBytes(output);

            var lengthDiff = inputLength - outputLength;
        }
    }
}
