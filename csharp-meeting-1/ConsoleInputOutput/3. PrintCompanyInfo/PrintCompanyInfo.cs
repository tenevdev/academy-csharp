using System;

class PrintCompanyInfo
{
    static void Main(string[] args)
    {
        Company company = new Company(true);

        company.PrintCompanyInfo();
    }
}

class Manager
{
    public Manager(bool initWithConsoleInput)
    {
        if (initWithConsoleInput)
        {
            Console.Write("\tManager First Name: ");
            this.FirstName = Console.ReadLine();

            Console.Write("\tManager Last Name: ");
            this.LastName = Console.ReadLine();

            Console.Write("\tManager Age: ");
            this.Age = byte.Parse(Console.ReadLine());

            Console.Write("\tManager Phone Number: ");
            this.PhoneNumber = Console.ReadLine();
        }
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public string PhoneNumber { get; set; }
}

class Company
{
    public Company(bool initWithConsoleInput)
    {
        if (initWithConsoleInput)
        {
            Console.Write("Company Name: ");
            this.Name = Console.ReadLine();

            Console.Write("Company Address: ");
            this.Address = Console.ReadLine();

            Console.Write("Company Phone Number: ");
            this.PhoneNumber = Console.ReadLine();

            Console.Write("Company Fax Number: ");
            this.FaxNumber = Console.ReadLine();

            Console.Write("Company Website: ");
            this.Website = Console.ReadLine();

            this.Manager = new Manager(true);
        }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string Website { get; set; }
    public Manager Manager { get; set; }

    public void PrintCompanyInfo()
    {
        Console.WriteLine();
        Console.WriteLine("Displaying company information");
        Console.WriteLine();

        Console.WriteLine("Company name: " + this.Name);
        Console.WriteLine("Company address: " + this.Address);
        Console.WriteLine("Company phone number: " + this.PhoneNumber);
        Console.WriteLine("Company fax number: " + this.FaxNumber);
        Console.WriteLine("Company website: " + this.Website);
        Console.WriteLine("\tManager first name: " + this.Manager.FirstName);
        Console.WriteLine("\tManager last name: " + this.Manager.LastName);
        Console.WriteLine("\tManager age: " + this.Manager.Age);
        Console.WriteLine("\tManager phone number: " + this.Manager.PhoneNumber);
    }
}