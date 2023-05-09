namespace AddressBook{
   public class NewAddressBook{
        public List <Contact> myContacts=new List<Contact>();
        public string bookName="";
        public NewAddressBook(string name){
            this.bookName = name;
        }
        static public string [] PROPS={"Firstname","Lastname","Address","City","State","Zipcode","Phone","Email"};
        public Contact AddContact(){
            string [] info=new string[8];
            Contact dummyContact=new Contact();
            for(int i=0;i<8;i++){
                Console.Write(PROPS[i]+" : ");
                info[i]=Console.ReadLine();
            }
            dummyContact.CreateContact(info[0],info[1],info[2],info[3],info[4],info[5],info[6],info[7]);
            return dummyContact;
        }
        public int GetIndex(string name){
            int ind=0;
            foreach(Contact contact in myContacts){
                if(contact.firstName==name)
                    break;
                ind++;
            }
            return ind;
        }
        public void DeleteContact(int ind){
            myContacts.Remove(myContacts[ind]);
        }

        public void SavedContacts(){
            Console.WriteLine("\n"+this.bookName+" Saved contacts....");
            int num=0;
            foreach(Contact contact in myContacts)
                Console.WriteLine((++num)+") FirstName: "+contact.firstName);
            Console.WriteLine("\n**********************************************\n");
        }
    }
}