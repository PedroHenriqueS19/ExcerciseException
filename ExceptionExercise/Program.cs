using System;
using ExceptionExercise.Entities.Accounts;
using ExceptionExercise.Entities.Exceptions;
namespace ExceptionExercise
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter account data: ");
            Console.Write($"Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"Holder: ");
            string holder = Console.ReadLine();
            Console.Write($"Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write($"Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Account account = new Account(number, holder, balance, withdrawLimit); //instanciei a classe Account para que os dados fossem armazenados nela
            Console.WriteLine();
            Console.Write($"Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try //tentamos fazer dar certo a primeira instanciação
            {
                account.Withdraw(amount); //função que veio da classe Accounts para fazer a subtração dos dados 'amount' e 'Balance'
                Console.WriteLine($"New balance: {account.Balance:f2}");
            }
            catch (DomainException e)//caso dê errado a tentativa, será apresentado um dos erros listados dentro da classe 'Account'
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (Exception e)//caso algum erro genérico não citado na classe 'Account' apareça, esse CATCH trará a tona a mensagem do erro ocorrido 
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}