
using System;

namespace RobotCleaner
{
    public class CleaningRobot
    {
        public const int gridBounds = 100_000;

        public CleaningRobot(GridBlock startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public GridBlock CurrentPosition { get; set; }

        public void MoveInDirection(DirectionDelta direction)
        {
            CurrentPosition.X += direction.DeltaX;
            CurrentPosition.Y += direction.DeltaY;
        }

        public bool CheckCanMove(DirectionDelta direction)
        {
            var xInBounds = CheckDirectionDeltaIsInBounds(direction.DeltaX + CurrentPosition.X);
            var yInBounds = CheckDirectionDeltaIsInBounds(direction.DeltaY + CurrentPosition.Y);
            return xInBounds && yInBounds;
        }

        private static bool CheckDirectionDeltaIsInBounds(int val)
        {
            var isInBounds = Math.Abs(val) <= Math.Abs(gridBounds);
            return isInBounds;
        }
    }
}
