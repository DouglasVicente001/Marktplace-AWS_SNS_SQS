using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Consumidor
{
    class Program
    {
        static async Task Main(String[] args)
        {
            Console.WriteLine("EAIII consumidor");


            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/986421409375/teste"
            };

            while (true)
            {
                var response = await client.ReceiveMessageAsync(request);


                foreach (var mensagem in response.Messages)
                {
                    Console.WriteLine(mensagem.Body);
                    await client.DeleteMessageAsync("https://sqs.sa-east-1.amazonaws.com/986421409375/teste", mensagem.ReceiptHandle);
                }
            }
        }
    }
}