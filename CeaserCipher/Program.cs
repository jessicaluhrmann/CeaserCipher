namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you encrypting or decrypting a message?");
            var answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "encrypt")
            {
                Console.WriteLine("Please input your message to encrypt:");

                Encrypt();
            }

            else
            {
                Console.WriteLine("Please input the message to decrypt:");

                Decrypt();
            }

            static void Encrypt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                var message = Console.ReadLine();
                message = message.ToLower();
                
                char[] secretMessage = message.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];

                var i = 0;
                for (i = 0; i < secretMessage.Length; i++)
                {
                    var msgChar = secretMessage[i];
                    var ogChar = Array.IndexOf(alphabet, msgChar);
                    var encryptedCharPos = (ogChar + 3) % 26;
                    var encryptedChar = alphabet[encryptedCharPos];
                    encryptedMessage[i] = encryptedChar;

                    var newMessage = String.Join("", encryptedMessage);
                    Console.WriteLine(newMessage);
                }
            }

            static void Decrypt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                var message = Console.ReadLine();
                message = message.ToLower();

                char[] secretMessage = message.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];

                var i = 0;
                for (i = 0; i < secretMessage.Length; i++)
                {
                    var msgChar = secretMessage[i];
                    var ogChar = Array.IndexOf(alphabet, msgChar);
                    var encryptedCharPos = (ogChar - 3) % 26;
                    var encryptedChar = alphabet[encryptedCharPos];
                    encryptedMessage[i] = encryptedChar;

                    var newMessage = String.Join("", encryptedMessage);
                    Console.WriteLine(newMessage);
                }
            }

        }
    }
}