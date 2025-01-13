using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class MadlibService
    {
        public string MadlibMethod(string monster, string monsterAdjec, string noun1, string noun2, string object1, string object2, string location, string location2, string userName, string userNameAdjec)
        {

            Console.WriteLine("\nTHE STORY WILL GENERATE AS YOU FILL IN EMPTY FIELDS\n");
            Console.WriteLine("\t   RICHES & GLORY\n<----------TELL YOUR STORY---------->");

            string line1 = "\nLet me jot down your story...";
            string line2 = "\nWhat a spectacular tale...";
            string line3 = "\nOh, when I finish this I know you are going to love it!!!";
            string line4 = "\nNearly done...";
            
            string line5 =$"\n\n1)Finally, I slayed the foul beast {monster}.";
            string line6 =$"\n2)A nasty {monsterAdjec} monster that brings fear to all {noun1}!";
            string line7 =$"\n3)I, and my trustee {object1}, barely managed to win, but it is all worth it!";
            string line8 =$"\n4)Now, for the reward, I looted a {noun2} and a {object2} from the beast's inners.";
            string line9 =$"\n5)I will forever have this displayed on my {location}.";
            string line10 =$"\n6)The bards shall forever sing the story of {userName}.";
            string line11 =$"\n7)People will forever remember me as a {userNameAdjec} of the {location2}";

            return line1 + line2 + line3 + line4 + line5 + line6 + line7 + line8 + line9 + line10 + line11;
        }
    }
}