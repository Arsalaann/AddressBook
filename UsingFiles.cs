using System.Globalization;
using CsvHelper;
namespace AddressBook
{
    public class UsingFiles
    {
        public static void UsingTextFile(NewAddressBook Book)
        {
            using(StreamWriter writer=new StreamWriter("/home/luser/pgming/AddressBook/DemoTextFile.txt"))
            {
                foreach(Contact contact in Book.myContacts)
                {
                    writer.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", contact.firstName, contact.lastName,contact.address ,contact.city,contact.state,contact.zipCode,contact.phoneNumber,contact.email);
                }
            }
        } 
        public static void UsingCSVFile(NewAddressBook Book)
        {
            using(var writer=new StreamWriter("./DemoCSVFile.csv"))
            using(var csv = new CsvWriter(writer,CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Book.myContacts);
            }

        }
        public static void ReadFromCSVFile(NewAddressBook Book)
        {
            using(var reader=new StreamReader("./DemoCSVFile.csv"))
            using(var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var contact=csv.GetRecords<Contact>();
                Console.WriteLine(contact.ToString());
            }
            
        }
            
    }
}