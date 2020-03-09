using System;
using System.Collections.Generic;

namespace RobotCleaner
{
    public static class CleaningInstructionsConsoleInterface
    {
        public static int CaptureNumNavCommands()
        {
            Console.WriteLine("Enter number of commands to execute:");
            return Convert.ToInt16(Console.ReadLine());
        }

        public static GridBlock CaptureStartupCoords()
        {
            Console.WriteLine("Enter starting coordinates:");
            var startingCoords = Console.ReadLine().Split(' ');
            var startingBlock = new GridBlock(
                Convert.ToInt16(startingCoords[0]),
                Convert.ToInt16(startingCoords[1])
                );
            return startingBlock;
        }

        public static List<NavigationCommand> CaptureNavInstructions()
        {
            const string startKey = "b";
            var navCommandResults = new List<NavigationCommand>();

            Console.WriteLine("Enter each navigation command then press 'enter', then press 'b' to begin");
            var isStartKey = false;

            while (!isStartKey)
            {
                var navInstruction = Console.ReadLine();
                isStartKey = navInstruction == startKey;
                if (!isStartKey)
                {
                    var navCommand = navInstruction.Split(" ");
                    navCommandResults.Add(new NavigationCommand(navCommand[0], Convert.ToInt16(navCommand[1])));
                }
            }
            return navCommandResults;
        }
    }
}
