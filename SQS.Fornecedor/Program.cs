using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using static System.Net.WebRequestMethods;



namespace SQS.Fornecedor
{
    class Program
    {
        static async Task Main(String[] args)
        {
            Console.WriteLine("EAIII");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new SendMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/986421409375/teste",
                MessageBody = "Teste 123"
            };
            await client.SendMessageAsync(request);
        }
    }
}