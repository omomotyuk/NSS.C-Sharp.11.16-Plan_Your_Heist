using System;
using System.Collections.Generic;

namespace __11._16_Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1
            // 1. Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");

            // 2. Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            Console.WriteLine("Enter your team member's name");
            string name = Console.ReadLine();
            teamMember.Add("Name", name);

            // 3. Prompt the user to enter a team member's name and save that name.
            // 4. Prompt the user to enter a team member's skill level and save that skill level with the name.
            // 5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            // 6. Display the team member's information.

        }
    }
}