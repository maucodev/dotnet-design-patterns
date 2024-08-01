using System;
using Composite.BasicExample;
using Composite.TeamsExample;

namespace Composite
{
    public abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var groupOne = new Group();
            var groupTwo = new Group();
            var groupThree = new Group();

            groupOne.Add(new Shape());
            groupOne.Add(new Shape());

            groupTwo.Add(new Shape());
            groupTwo.Add(new Shape());

            groupThree.Add(groupOne);
            groupThree.Add(groupTwo);
            groupThree.Render();
            groupThree.Move();
            
            Console.ReadLine();

            //
            // Teams Example
            //

            var subTeamOne = new Team();
            var subTeamTwo = new Team();
            var dreamTeam = new Team();

            subTeamOne.Add(new TruckResource());
            subTeamOne.Add(new HumanResource());
            subTeamOne.Add(new HumanResource());

            subTeamTwo.Add(new TruckResource());
            subTeamTwo.Add(new HumanResource());
            subTeamTwo.Add(new HumanResource());

            dreamTeam.Add(subTeamOne);
            dreamTeam.Add(subTeamTwo);

            dreamTeam.Deploy();

            Console.ReadLine();
        }
    }
}
