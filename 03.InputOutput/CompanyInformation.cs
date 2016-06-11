using System;

namespace _2.Problem_Print_Company_Information
{
    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name : ");
            string companyName = Console.ReadLine();
            Console.Write("Company address : ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number : ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site : ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age : ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone : ");
            string phone = Console.ReadLine();

            if (String.IsNullOrEmpty(faxNumber))
            {
                faxNumber = "(no fax)";
            }
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age:\n{7},tel. {8})",
                companyName, companyAddress, phoneNumber, faxNumber, webSite, firstName, lastName, age, phone);
        }
    }
}
