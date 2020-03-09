using System;

namespace RobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin! Hit 'enter' to set me up.");
            Console.ReadLine();

            CleaningInstructions instructions = new CleaningInstructions(
                CleaningInstructionsConsoleInterface.CaptureNumNavCommands(),
                CleaningInstructionsConsoleInterface.CaptureStartupCoords(),
                CleaningInstructionsConsoleInterface.CaptureNavInstructions());

            RobotController robotController = new RobotController(instructions);
            var cleaningResult = robotController.StartCleaning();

            Console.WriteLine(cleaningResult);
            Console.ReadLine();
        }
    }
}
