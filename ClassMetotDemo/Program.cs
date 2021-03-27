using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.TcNO = 1234567890;
            customer1.Name = "Hasan";
            customer1.LastName = "Bozkurt";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.TcNO = 1267898151;
            customer2.Name = "Mahmut";
            customer2.LastName = "Keskin";
            
            Customer customer3 = new Customer();
            customer3.Id = 1;
            customer3.TcNO = 1245896485;
            customer3.Name = "Sarı";
            customer3.LastName = "Cevdet";

            Customer customer4 = new Customer();
            customer4.Id = 1;
            customer4.TcNO = 1057898456;
            customer4.Name = "Cuma";
            customer4.LastName = "Çelik";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            Console.WriteLine("------------Müşteriler Eklendi-----------");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);
            Console.WriteLine("------------Müşteriler Silindi-----------");

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4};
            customerManager.List(customers);
            Console.WriteLine("------------Müşteri Listesi-----------");
        }
    }
}
