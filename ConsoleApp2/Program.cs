using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Teams\\Team.txt";

            string[] lines = System.IO.File.ReadAllLines(path);

            
            FootballTeams[] teams = new FootballTeams[lines.Length];




            for (int i = 0; i < lines.Length; i++)
            {

                string[] parts = lines[i].Split('|');

                FootballTeams team = new()
                {
                    clubID = int.Parse(parts[0].Trim()),
                    clubName = parts[1].Trim(),
                    country = parts[2].Trim(),
                    city = parts[3].Trim(),

                    foundedYear = int.Parse(parts[4].Trim()),
                    stadiumName = parts[5].Trim(),

                    titleWon = int.Parse(parts[6].Trim())


                };

                teams[i] = team;

            //    Console.WriteLine(
            // $@"Club ID: {team.clubID}
            //Club Name: {team.clubName}
            //Country: {team.country}
            //City: {team.city}
            //Founded Year: {team.foundedYear}
            //Stadium Name: {team.stadiumName}
            //Titles Won: {team.titleWon}
            //----------------------------");
            }

            foreach (var team in teams)
            {
               Console.WriteLine(
            $@"Club ID: {team.clubID}
            Club Name: {team.clubName}
            Country: {team.country}
            City: {team.city}
            Founded Year: {team.foundedYear}
            Stadium Name: {team.stadiumName}
            Titles Won: {team.titleWon}
            ----------------------------");

            }
        }
    }
}
