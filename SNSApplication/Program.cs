using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System;
using System.Threading.Tasks;

namespace SNSApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            AmazonSimpleNotificationServiceClient client = new AmazonSimpleNotificationServiceClient("", "", Amazon.RegionEndpoint.USWest2);

            PublishRequest request = new PublishRequest();
            request.Message = "Seu número da sorte: Z4T568TUYA";
            request.PhoneNumber = "+55";

            var result = client.PublishAsync(request).Result;

            Console.WriteLine("Mensagem enviada!");
            Console.ReadKey();
        }
    }
}
