namespace AddressBook{
    public class AddressBookMain{
        public static void Main(string [] args){

            //string name;
            //int ind;
            Console.WriteLine("\nWelcome to Address Book Program....\n\n******************************\n");

            //First Add an Address Book;
            NewAddressBook Book=AllBooks.AddBook("Book1");

            //Add contacts to address book
            // Console.Write("Enter number of contacts you wanna enter: ");
            // Contact dummyContact = new Contact();
            // int totalContacts=Convert.ToInt32(Console.ReadLine());
            // while(totalContacts-->0){
            //     dummyContact=Book.AddContact();
            //     Book.myContacts.Add(dummyContact);
            //     Console.WriteLine("Contact created and saved Successfully\n");
            // }
            Book.myContacts.Add(new Contact("Madarsh","Sharma","begumganj","beuwemganj","mp","324324","ww@gm.com","9894233434"));
            Book.myContacts.Add(new Contact("Ayrsh","Shama","beganj","beumganj","tremp","324324","ww@gm.com","9894233434"));
            Book.myContacts.Add(new Contact("resdarsh","aharma","ebegumganj","berfumganj","mp","324324","ww@gm.com","9894233434"));
            Book.myContacts.Add(new Contact("Adarsh","Suurma","obegumganj","beumgeranj","mp","324324","ww@gm.com","9894233434"));
            
            //Book.SavedContacts();

            //UsingFiles.UsingTextFile(Book);
            //string read=File.ReadAllText("./DemoTextFile.txt");
            //Console.WriteLine(read);

            UsingFiles.UsingCSVFile(Book);
            
            



            //Edit contact
            // Console.Write("Wanna edit[y/n]?: ");
            // char c=Convert.ToChar(Console.ReadLine());
            // if(c.Equals('y')){
            //     Console.Write("Enter name to edit contact: ");
            //     name=Console.ReadLine();
            //     ind=Book.GetIndex(name);
            //     if(ind==Book.myContacts.Count)
            //         Console.WriteLine("Name not exist!");
            //     else{
            //         dummyContact=Book.AddContact();
            //         Book.myContacts[ind]=dummyContact;
            //     }
            //     Book.SavedContacts();
            // }

            //Delete contact
            // Console.Write("Wanna delete[y/n]?: ");
            // c=Convert.ToChar(Console.ReadLine());
            // if(c=='y'){
            //     Console.Write("Enter name to delete: ");
            //     name=Console.ReadLine();
            //     ind=Book.GetIndex(name);
            //     if(ind==Book.myContacts.Count)
            //         Console.WriteLine("Name not exist!");
            //     else
            //         Book.DeleteContact(ind);
            //     Book.SavedContacts();
            // }

            //Check for repatation in an address book
            //Book.CheckRepeatation();

            //Search by name inside a city or state
            //AllBooks.SearchByCityOrState("ashwin","Bhopal");

            //Count 
            //Console.WriteLine(AllBooks.SearchByCityOrState("ashwin","Bhopal"));

            //Book.SortContactsByName();
            // Book.SortByCityStateOrZip();
            // Book.SavedContacts();
            //AllBooks.AllBooksDisplay();

        }
    }
}