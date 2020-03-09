using System.Collections.Generic;
using System.Linq;

namespace RobotCleaner
{
    public class RobotController
    {
        private CleaningInstructions _instructions;
        private CleaningRobot _robot;

        private RobotController()
        {
            CleanedBlocks = new List<GridBlock>();
        }
        public RobotController(CleaningInstructions instructions)
            : this()
        {
            _instructions = instructions;
            _robot = new CleaningRobot(instructions.StartupGridBlock);
            AddCurrentPositionToTrackedList();
        }

        public List<GridBlock> CleanedBlocks { get; private set; }

        private void AddCurrentPositionToTrackedList()
        {
            CleanedBlocks.Add(_robot.CurrentPosition.Clone());
        }

        private bool IsBlockAlreadyCleaned()
        {
            var result = CleanedBlocks.Any(block => block.X == _robot.CurrentPosition.X && block.Y == _robot.CurrentPosition.Y);
            return result;
        }

        public string StartCleaning()
        {
            ProcessNavigationInstructions();

            return "=> Cleaned: " + CleanedBlocks.Count;
        }

        public void ProcessNavigationInstructions()
        {
            var navCommands = _instructions.NavigationCommands;

            foreach (var command in navCommands)
            {
                int blocksMoved = 0;
                while (blocksMoved < command.DistanceToCover)
                {
                    if (!_robot.CheckCanMove(command.Direction))
                        break;

                    _robot.MoveInDirection(command.Direction);

                    if (!IsBlockAlreadyCleaned())
                        AddCurrentPositionToTrackedList();

                    blocksMoved++;
                }
            }
        }
    }
}
