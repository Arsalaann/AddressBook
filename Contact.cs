namespace AddressBook{
    public class Contact{
        public string firstName,lastName,address,city,state,zipCode,phoneNumber,email;
        public Contact(){
            firstName="";lastName="";address="";city="";state="";zipCode="";phoneNumber="";email="";
        }
        public Contact(string a,string b,string c,string d,string e,string f,string g,string h){
            firstName=a;
            lastName=b;
            address=c;
            city=d;
            state=e;
            zipCode=f;
            phoneNumber=g;
            email=h;
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

        public void DisplayContact(){
            Console.WriteLine("\nFirsname: "+this.firstName+"\nLastName: "+this.lastName+"\nCity: "+this.city+"\nState: "+this.state);
        }
    }
}