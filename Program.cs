namespace AddressBook{
    public class Contact{
        string firstName,lastName,address,city,state,zipCode,phoneNumber,email;
        public Contact(){
            firstName="";lastName="";address="";city="";state="";zipCode="";phoneNumber="";email="";
        }
        public void CreateContact(string a,string b,string c,string d,string e,string f,string g,string h){
            firstName=a;
            lastName=b;
            address=c;
            city=d;
            state=e;
            zipCode=f;
            phoneNumber=g;
            email=h;
        }
    }
    public class AddressBookMain{
        public static void Main(string [] args){
            Console.WriteLine("Welcome to Address Book Program");
            Contact Contact1=new Contact();
            Contact1.CreateContact("Arsalan","Khan","abc","bcd","cde","3422342","91283928","abcd@gmail.com");
        }
    }
}