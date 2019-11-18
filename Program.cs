using System;
using System.Collections.Generic;

namespace __11._16_Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Phase 1, phase 2, phase 3
            */

            // 1. Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!\n");

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
            Console.WriteLine($"Number of team members: {teamMembers.Count}\n");

            // 3-1. Stop displaying each team member's information
            //showTeamInfo(teamMembers);

            // 3-2. Store a value for the bank's difficulty level. Set this value to 100
            int bankDifficultyLevel = 100;

            // 3-3. Sum the skill levels of the team. Save that number
            int teamSkillLevel = getSkillLevelSum(teamMembers);

            // 4-1. Create a random number between -10 and 10 for the heist's luck value
            Random heistLuckValue = new Random();

            // 4-2. Add this number to the bank's difficulty level
            bankDifficultyLevel += heistLuckValue.Next(-10,10);

            // 4-3. Before displaying the success or failure message, display a report that shows
            // 4-3. The bank's difficulty level
            Console.WriteLine($"Bank's difficulty level: {bankDifficultyLevel}");
            // 4-3. The team's combined skill level
            Console.WriteLine($"Teams skill level sum: {teamSkillLevel}");

            // 3-4. Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
            if( teamSkillLevel >= bankDifficultyLevel )
            {
                Console.WriteLine("Bank heist - success");
            }
            else
            {
                Console.WriteLine("Bank heist - failure");
            }

        }

        static Dictionary<string, string> getTeamMember()
        {
            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            // 1-3. Prompt the user to enter a team member's name and save that name.
            Console.Write("Enter your team member's name: ");
            string name = Console.ReadLine();
            teamMember.Add("Name", name);

            if( teamMember["Name"] != "" )
            {
                // 1-4. Prompt the user to enter a team member's skill level and save that skill level with the name.
                Console.Write("Enter your team member's skill level: ");
                string skillLevel = Console.ReadLine();
                teamMember.Add("Skill Level", skillLevel);

                // 1-5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                Console.Write("Enter your team member's courage factor: ");
                string courageFactor = Console.ReadLine();
                teamMember.Add("Courage Factor", courageFactor);
            }

            return teamMember;
        }

        static void showTeamInfo( List<Dictionary<string, string>> teamMembers )
        {
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

        static int getSkillLevelSum( List<Dictionary<string, string>> teamMembers )
        {
            int sum = 0;
            foreach( Dictionary<string, string> member in teamMembers )
            {
                // 3-3. Sum the skill levels of the team
                sum += Convert.ToInt32(member["Skill Level"]);
            }
            return sum;
        }


    }
}