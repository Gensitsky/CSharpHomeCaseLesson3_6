/*
    Описать перечисление ClientType определяющее
    важность клиента, и добавить соответствующее поле
    в структуру Client из задания №2.
*/
using System;

namespace CSharpHomeCaseLesson3p6
{
    enum ClientType
    {
        Default,
        Incentive,
        Patron,
        VIP
    }
    struct Client
    {
        private int clientId;
        private string clientName;
        private string clientLocate;
        private string clientPhone;
        private int clientOrders;
        private double clientAccumulate;
        private ClientType clientType;

        public Client(int id, string name, string locate, string phone,
            int orders, double accumulate, ClientType type)
        {
            clientId = id;
            clientName = name;
            clientLocate = locate;
            clientPhone = phone;
            clientOrders = orders;
            clientAccumulate = accumulate;
            clientType = type;
        }
        public void PrintClient()
        {
            Console.WriteLine($"Id:\t{clientId}");
            Console.WriteLine($"Type:\t{clientType}");
            Console.WriteLine($"Name:\t{clientName}");
            Console.WriteLine($"Locate:\t{clientLocate}");
            Console.WriteLine($"Phone:\t{clientPhone}");
            Console.WriteLine($"Orders:\t{clientOrders}");
            Console.WriteLine($"Accum.:\t{clientAccumulate} $\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(1, "Vadim Gensitsky", "Nikolaev",
                "+380505841810", 10, 1000, ClientType.Default);
            Client client2 = new Client(2, "Vlad Tkachenko", "Kiev",
                "+380505480860", 20, 2000,ClientType.Incentive);
            Client client3 = new Client(3, "Alex Zloba", "Madrid",
                "+380633386522", 100, 10000, ClientType.VIP);

            client1.PrintClient();
            client2.PrintClient();
            client3.PrintClient();

            Console.ReadKey();
        }
    }
}
