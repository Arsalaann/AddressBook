namespace AddressBook{
    public class AddressBookMain{
        public static void Main(string [] args){

            string name;
            int ind;

            //Contacts Add
            Console.WriteLine("\nWelcome to Address Book Program....\n\n******************************\n");
            Console.Write("Enter number of contacts you wanna enter: ");
            Contact dummyContact = new Contact();
            int totalContacts=Convert.ToInt32(Console.ReadLine());
            while((totalContacts)-->0){
                dummyContact=Book.AddContact();
                Book.AllContacts.Add(dummyContact);
                Console.WriteLine("Contact created and saved Successfully\n");
            }
            
            Book.SavedContacts();

            //Edit contact
            Console.Write("Wanna edit[y\n]?: ");
            char c=Convert.ToChar(Console.ReadLine());
            if(c.Equals('y')){
                Console.Write("Enter name to edit contact: ");
                name=Console.ReadLine();
                ind=Book.GetIndex(name);
                if(ind==Book.AllContacts.Count)
                    Console.WriteLine("Name not exist!");
                else{
                    dummyContact=Book.AddContact();
                    Book.AllContacts[ind]=dummyContact;
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
                if(ind==Book.AllContacts.Count)
                    Console.WriteLine("Name not exist!");
                else
                    Book.DeleteContact(ind);
                Book.SavedContacts();
            }

        }
    }
}