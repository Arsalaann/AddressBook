namespace AddressBook{
    public class AddressBookMain{
        public static void Main(string [] args){

            string name;
            int ind;
            Console.WriteLine("\nWelcome to Address Book Program....\n\n******************************\n");

            //First Add an Address Book;
            NewAddressBook Book=AllBooks.AddBook("Book1");

            //Add contacts to address book
            Console.Write("Enter number of contacts you wanna enter: ");
            Contact dummyContact = new Contact();
            int totalContacts=Convert.ToInt32(Console.ReadLine());
            while((totalContacts)-->0){
                dummyContact=Book.AddContact();
                Book.myContacts.Add(dummyContact);
                Console.WriteLine("Contact created and saved Successfully\n");
            }
            
            Book.SavedContacts();

            //Edit contact
            Console.Write("Wanna edit[y/n]?: ");
            char c=Convert.ToChar(Console.ReadLine());
            if(c.Equals('y')){
                Console.Write("Enter name to edit contact: ");
                name=Console.ReadLine();
                ind=Book.GetIndex(name);
                if(ind==Book.myContacts.Count)
                    Console.WriteLine("Name not exist!");
                else{
                    dummyContact=Book.AddContact();
                    Book.myContacts[ind]=dummyContact;
                }
                Book.SavedContacts();
            }

            //Delete contact
            Console.Write("Wanna delete[y/n]?: ");
            c=Convert.ToChar(Console.ReadLine());
            if(c=='y'){
                Console.Write("Enter name to delete: ");
                name=Console.ReadLine();
                ind=Book.GetIndex(name);
                if(ind==Book.myContacts.Count)
                    Console.WriteLine("Name not exist!");
                else
                    Book.DeleteContact(ind);
                Book.SavedContacts();
            }

            //Check for repatation in an address book
            Book.CheckRepeatation();

            //Search by name inside a city or state
            AllBooks.SearchByCityOrState("ashwin","Bhopal");

            AllBooks.AllBooksDisplay();

        }
    }
}