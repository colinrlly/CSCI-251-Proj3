using System;
using SecureMessaging;

namespace CSCI_251_Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsa = new RSA();

            if (args.Length < 2)
            {
                printHelp();
            }
            else if (args.Length == 2)
            {
                switch(args[0]) {
                    case "keyGen":
                        rsa.keyGen(int.Parse(args[1]));

                        break;
                    case "sendKey":
                        rsa.sendKey(args[1]);
                    
                        break;
                    case "getKey":
                        rsa.getKey(args[1]);

                        break;
                    case "getMsg":
                        rsa.getMsg(args[1]);

                        break;
                    default:
                        printHelp();
                        break;
                }
            }
            else if (args.Length == 3)
            {
                if (args[0] == "sendMsg") {
                    rsa.sendMsg(args[1], args[2]);
                } else {
                    printHelp();
                }
            }
            else {
                printHelp();
            }
        }

        static void printHelp() {
            Console.WriteLine("HELP!");
        }
    }
}
