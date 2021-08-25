using System;
using System.Collections.Generic;


namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code creates the Type "list" of "string" insults
            List<string> Insults = new List<string> {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };
            
            // This code creates the insultIndexes list, 
            // calls the getRandomInt function 
            // (until the insultIndexes has 3 values), and
            // adds the new value to the insultIndexes list 
            // if it doesn't already exist in the list.
            List<int> insultIndexes = new List<int>();
            while (insultIndexes.Count < 3)
            {
                int candidate = getRandomInt();
                if (!insultIndexes.Contains(candidate))
                {
                    insultIndexes.Add(candidate);
                }
            };
            // This for loop takes the list of random indexes and loops over them to
            // display the three insults in the console.
            for (int i = 0; i <insultIndexes.Count; i ++ )
            {
                int index = insultIndexes[i];
                Console.WriteLine(Insults[index]);
            }
            //  This code creates the random index values between 0 and the
            //  length of the Insults list and returns a value
            int getRandomInt()
            {
                int insultCount = Insults.Count;
                Random insult = new Random();
                int createRandomInsult = insult.Next(0, insultCount);
                return createRandomInsult;
            }

    }
}
}
