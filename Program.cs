using System;

namespace SQLGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] givenNames = new string[] {
                    "James", "John", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Robert",
                    "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen",
                    "Christopher", "Daniel", "Matthew", "Anthony", "DonaldDuck", "Mark", "Paul", "Steven", "Andrew", "Kenneth",
                    "Nancy", "Lisa", "Margaret", "Betty", "Sandra", "Ashley", "Dorothy", "Kimberly", "Emily", "Donna",
                    "Kenneth", "Joshua", "Kevin", "Brian", "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey",
                    "Michelle", "Carol", "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Laura", "Sharon", "Cynthia",
                    "Mohammed", "Ahmed", "Beshoi", "Kirollos", "Habib", "Fatima", "Meriem", "Nadia", "Omar", "Aya",
                    "Alya", "Santiago", "Juan", "Mateo", "Pedro", "Santino", "Dylan", "Kevin", "José", "Noah",
                    "Liam", "Alexis", "Alexandra", "Luis", "Joaquín", "Gabriella", "Sofía", "Lucía", "Emilia", "Olivia",
                    "Alice", "Mariana", "Cheng", "Liang", "Ning", "Lian", "Shu", "Xian", "Yun", "Kim",
                    "Sô", "Minato", "Itsuki", "Asahi", "Sakura", "Aoi", "Rin", "Kaede", "Min-Jun", "Seo-yeon" };

            string[] familyNames = new string[] {
                    "Ali", "Mohamed", "Johannes", "Ndong", "Ivanova", "Wang", "Satô", "Kim", "Chen", "De La Cruz",
                    "Devi", "Jónsdóttir", "Hansen", "Andersson", "Korhonen", "Jensen", "De Jong", "Martin", "Müller", "Smith",
                    "Murphy", "Peeters", "Schmit", "Garcia", "Silva", "Rossi", "Borg", "Papadopoulus", "Popa", "Nowak",
                    "Gruber", "Melnik", "Hernandez", "Lopez", "Rodriguez", "Williams", "Harris", "John", "Devi", "Zhang",
                    "Johnson", "Brown", "Jones", "Miller", "Davis", "Wilson", "Taylor"};

            string[] birthYears = new string[] { "1923", "1925", "1926", "1929", "1931", "1932", "1933", "1935", "1936", "1938",
            "1940", "1941", "1942", "1944", "1947", "1949", "1951", "1952", "1953", "1954",
            "1955", "1959", "1962", "1963", "1967", "1969", "1973", "1974", "1978", "1979",
            "1980", "1981", "1983", "1984", "1988", "1990", "1991", "1993", "1995", "1999",
            "2000", "2001", "2002", "2003" };

            string[] monthsNumbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            string[] daysNumbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15",
                                                    "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };

            string[] phoneNumberRegion = new string[] { "070", "076", "011", "0158", "018", "0653", "0243", "026", "040", "0560", "08", "072", "073"  };

            string[] adressRegion = new string[] { "Norrköping", "Gnesta", "Uppsala", "Delsbo", "Borlänge", "Gävle", "Sandviken", "Valbo", "Malmö", 
                                                    "Torsby", "Stockholm", "Umeå", "Piteå", "Eskilstuna", "Norrtälje", "Edsbyn", "Hofors", "Skellefteå" };

            string[] typeOfRoad = new string[] { "vägen", "vägen", "vägen", "gatan", "gatan", "gatan", "avenyn", "allén", "stigen", "bo", "gränden", "plan", "stigen" };

            string[] roadNames = new string[] { "Sofiedals", "Huvud", "Små", "Snickar", "Rallar", "Köpmans", "Mario", "Bred", "Smör", "Källbergs", "Trädgårds",
                                            "Sommar", "Världs", "Ring", "Skol", "Björk", "Järnvägs", "Skogs", "Strand", "Ängs", "Stor", "Park", "Vikinga", 
                                            "Akademi", "Akter", "Artilleri", "Bastu", "Bergs", "Bonde", "Breda-", "Brunns", "Central", "Dala", "Eks", 
                                            "Första", "Andra", "Tredje", "Fjärde", "Femte", "Första", "Andra", "Första",
                                            "Frej", "Tor", "Gaffel", "Oden", "Tyr", "Gås", "Björn", "Get", "Ko", "Havre", "Korn", "Höglund", "Klipp",
                                            "Kyrk", "Liljeholms", "Skomakar", "Norr", "Syd", "Väst", "Öst", "Pil", "Präst", "Ost", "Riddar", "Skepp", "Skytt",
                                            "Slip", "Slotts", "Sol", "Te", "Teater", "Textil", "Villo", "Östra", "Västra" };

            char[] letters = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'A', 'B', 'C', 'D', 'E', 'F' };

            Random roll = new Random();

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(
                    $"Name:      {givenNames[roll.Next(0, (givenNames.Length - 1))]} {familyNames[roll.Next(0, (familyNames.Length - 1))]}\n" +
                    $"Born:      {birthYears[roll.Next(0, (birthYears.Length - 1))]}-{monthsNumbers[roll.Next(0, (monthsNumbers.Length - 1))]}-{daysNumbers[roll.Next(0, (daysNumbers.Length - 1))]}\n" +
                    $"Living at: {roadNames[roll.Next(0, (roadNames.Length - 1))]}{typeOfRoad[roll.Next(0, (typeOfRoad.Length - 1))]} {roll.Next(0, 150)}{letters[roll.Next(0, (letters.Length - 1))]}\n" +
                    $"           {adressRegion[roll.Next(0, (adressRegion.Length-1))]}\n" +
                    $"Phone no.: {phoneNumberRegion[roll.Next(0, (phoneNumberRegion.Length-1))]}-{roll.Next(100000,999999)}\n\n");
            }

            /*
             ToDo
                Add comapnies
                Add bank accounts
                    for companies
                    for people
                Create procedures for the companies to pay their employees
                Create logs and stuff
             */

        }
    }
}
