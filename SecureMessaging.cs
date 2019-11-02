using System;

namespace SecureMessaging {
    public class RSA {
        public bool keyGen(int keysize) {
            Console.WriteLine("keyGen" + keysize);

            return true;
        }
        
        public bool sendKey(string email) {
            Console.WriteLine("keyGen" + email);

            return true;
        }

        public bool getKey(string email) {
            Console.WriteLine("keyGen" + email);

            return true;
        }

        public bool sendMsg(string email, string plaintext) {
            Console.WriteLine("keyGen" + email + plaintext);

            return true;
        }

        public bool getMsg(string email) {
            Console.WriteLine("keyGen" + email);

            return true;
        }
    }
}
