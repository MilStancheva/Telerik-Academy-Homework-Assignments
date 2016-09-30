using System;

public class CompanyInfo
{
    public static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string companyNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstname = Console.ReadLine();
        string managerLastname = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", companyNumber);
        Console.WriteLine("Fax: {0}", faxNumber.Length == 0 ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstname, managerLastname, managerAge, managerPhone);
    }
}