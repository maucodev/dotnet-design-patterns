using System;
using ChainResponsibility.WebServerExample;

namespace ChainResponsibility
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Web Server Example
            //

            var encryptor = new Encryptor(default);
            var compressor = new Compressor(encryptor);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var webServer = new WebServer(authenticator);

            webServer.Handle(new HttpRequest("admin", "admin"));

            Console.ReadLine();

            webServer.Handle(new HttpRequest("admin", "xyz"));

            Console.ReadLine();
        }
    }
}