

using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();

productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Doğukan";
customer.LastName = "Bozkır";
customer.City = "İstanbul";

Customer customer2 = new Customer { Id = 2 ,FirstName = "Muhammed",LastName = "Emen",City = "Batman"};


Console.WriteLine(customer2.FirstName);



