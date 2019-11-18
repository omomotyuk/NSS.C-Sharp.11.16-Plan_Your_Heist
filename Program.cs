using System;
using System.Collections.Generic;

namespace __11._16_Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Phase 1, phase 2
            */

            // 1. Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");
            Console.Write("\n");

            // 1-2. Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            // 2-1. Create a way to store several team members
            List<Dictionary<string, string>> teamMembers = new List<Dictionary<string, string>>();

            // 2-2. Collect several team members' information
            do{
                if( teamMember.ContainsKey("Name") )
                {
                    teamMembers.Add( teamMember );
                }
                teamMember = getTeamMember();
            }
            while( teamMember["Name"] != "" ); // 2-3. Stop collecting team members when a blank name is entered

            Console.Write("\n");

            // 2-4. Display a message containing the number of members of the team
            Console.WriteLine($"Number of team members: {teamMembers.Count}");

            Console.Write("\n");

            // 2-5. Display each team member's information
            foreach( Dictionary<string, string> member in teamMembers )
            {
                // 1-6. Display the team member's information.
                foreach (KeyValuePair<string, string> attribute in member )
                {
                    Console.WriteLine($"{attribute.Key}: {attribute.Value}");
                }
                Console.Write("\n");
            }
        }

        static Dictionary<string, string> getTeamMember()
        {
            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            // 1-3. Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Enter your team member's name:");
            string name = Console.ReadLine();
            teamMember.Add("Name", name);

            if( teamMember["Name"] != "" )
            {
                // 1-4. Prompt the user to enter a team member's skill level and save that skill level with the name.
                Console.WriteLine("Enter your team member's skill level:");
                string skillLevel = Console.ReadLine();
                teamMember.Add("Skill Level", skillLevel);

                // 1-5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                Console.WriteLine("Enter your team member's courage factor:");
                string courageFactor = Console.ReadLine();
                teamMember.Add("Courage Factor", courageFactor);
            }

            return teamMember;
        }

    }
}