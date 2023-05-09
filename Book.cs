namespace AddressBook{
   static public class Book{
        static public List <Contact> AllContacts=new List<Contact>();
        static public string [] PROPS={"Firstname","Lastname","Address","City","State","Zipcode","Phone","Email"};
        static public Contact AddContact(){
            
            string [] info=new string[8];
            Contact dummyContact=new Contact();
            for(int i=0;i<8;i++){
                Console.Write(PROPS[i]+" : ");
                info[i]=Console.ReadLine();
            }
            dummyContact.CreateContact(info[0],info[1],info[2],info[3],info[4],info[5],info[6],info[7]);
            return dummyContact;
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
            AllContacts.Remove(AllContacts[ind]);
        }

        static public void SavedContacts(){
            Console.WriteLine("\nSaved contacts....");
            int num=0;
            foreach(Contact contact in AllContacts)
                Console.WriteLine((++num)+") FirstName: "+contact.firstName);
            Console.WriteLine("\n**********************************************\n");
        }
    }
}