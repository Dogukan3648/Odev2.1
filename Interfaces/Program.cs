
using Interfaces;
//Interfacess();
//Demo();



ICustomerDal[] customerDals = new ICustomerDal[3]

{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

static void Interfacess()
{
    PersonManager personManager = new PersonManager();

    Customer customer = new Customer { Id = 1, FirstName = "Doğukan", LastName = "Bozkır", City = "İstanbul" };


    Student student = new Student { Id = 2, FirstName = "Muhammed", LastName = "Emen", Departmant = "Computer" };


    personManager.Add(student);


    personManager.Add(customer);
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}

interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }

}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}