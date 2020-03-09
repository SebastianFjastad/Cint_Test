
namespace RobotCleaner
{
    public class NavigationCommand
    {
        public NavigationCommand(string cardinalPoint, int distanceToCover)
        {
            Direction = DirectionDeltaLookup.GetDirectionDeltaFromCardinalPoint(cardinalPoint);
            DistanceToCover = distanceToCover;
        }

        public DirectionDelta Direction { get; set; }
        public int DistanceToCover { get; set; }
    }
}
