using System;

namespace ChainResponsibilitiesPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura el concepto de la compra.");
            string concept = Console.ReadLine();
            string amountText;
            double amount;

            bool isDecimal;
            do
            {
                Console.WriteLine("Captura el monto de la compra.");
                amountText = Console.ReadLine();
                isDecimal = double.TryParse(amountText, out amount);
            }
            while (!isDecimal);

            Requisition requisition = new Requisition()
            {
                Concept = concept,
                Amount = amount
            };

            IAuthorizer coordinator = new Coordinator();
            IAuthorizer manager = new Manager();
            IAuthorizer assistantManager = new AssistantManager();
            IAuthorizer director = new Director();

            coordinator.Next = manager;
            manager.Next = assistantManager;
            assistantManager.Next = director;

            string message = coordinator.AuthorizerRequest(requisition);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
