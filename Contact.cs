namespace AddressBook{
    public class Contact{
        public string firstName{ get; set; } 
        public string lastName{ get; set;} 
        public string address{ get; set; } 
        public string city{ get; set; } 

        public string zipCode{get;set;}
        public string state{ get; set; } 
        public string phoneNumber{ get; set; } 
        public string email{ get; set; } 
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