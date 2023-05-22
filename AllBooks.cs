namespace AddressBook{
    static public class AllBooks{
        public static Dictionary<string,NewAddressBook> AllAddressBooks=new Dictionary<string,NewAddressBook>();
        public static void AllBooksDisplay(){
            foreach(var kvp in AllAddressBooks)
                Console.WriteLine("\n"+kvp.Key);
            Console.WriteLine("\n****************************************\n");
        }
        public static NewAddressBook AddBook(string name){
            NewAddressBook dummyBook=new NewAddressBook(name);
            AllAddressBooks.Add(name,dummyBook);
            return dummyBook;
        }

        public static void SearchByCityOrState(string name,string CityOrState){
            foreach(var addressBooks in AllAddressBooks){
                foreach(var contact in addressBooks.Value.myContacts){
                    if(contact.city == CityOrState || contact.state == CityOrState && contact.firstName==name)
                        contact.DisplayContact(); 
                }
            }
        }
    }
}