namespace AddressBook{
    static public class Book{
        static Contact [] AllContacts;
        static int i=0;
        static public void AddContact(Contact contact){
            AllContacts[i]=contact;
            i++;
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
        }
    }
}