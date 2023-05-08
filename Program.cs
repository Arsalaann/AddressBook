namespace AddressBook{
    static public class Book{
        static public Contact [] AllContacts;
        static int i=0;
        static public void AddContact(Contact contact){
            AllContacts[i]=contact;
            i++;
        }
        static public int GetIndex(string name){
            int ind=0;
            foreach(Contact contact in AllContacts){
                if(contact.firstName==name)
                    break;
                ind++;
            }
            return ind;
        }
        static public void DeleteContact(int ind){
            AllContacts = AllContacts.Where(val => val != ind).ToArray();
        }
    }
    
    public class AddressBookMain{
        public static void Main(string [] args){
            Console.WriteLine("Welcome to Address Book Program");
            Contact Contact1=new Contact();
            string [] info=new string[8];
            for(int i=0;i<8;i++)
                info[i]=Console.ReadLine();
            Contact1.CreateContact(info[0],info[1],info[2],info[3],info[4],info[5],info[6],info[7]);

            Console.WriteLine("Enter name to edit contact");
            string Name=Console.ReadLine();
            int ind=Book.GetIndex(Name);
            Contact dummy=Book.AllContacts[ind];
            Console.WriteLine("You can edit 3 fields firstname,lastname or email");
            dummy.firstName=Console.ReadLine();
            dummy.lastName=Console.ReadLine();
            dummy.email=Console.ReadLine();
            Book.AllContacts[ind]=dummy;

            Console.WriteLine("Enter name to delete");
            Name=Console.ReadLine();
            ind=Book.GetIndex(Name);
            Book.DeleteContacts(ind);
        }
    }
}