using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private const string URL = "https://localhost:7196/chatHub/";

        static void Main(string[] args)
        {

            try
            {
                var connection = new HubConnectionBuilder().WithUrl(URL).Build();
                connection.On<string, string>("ReceiveMessage", (use, message) =>
                {
                    Console.WriteLine(use);
                    Console.WriteLine(message);
                });
                connection.StartAsync();

                while (true)
                {

                }


            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
