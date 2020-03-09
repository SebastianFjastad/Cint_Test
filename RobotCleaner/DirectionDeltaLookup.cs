using System.Collections.Generic;

namespace RobotCleaner
{
    public static class DirectionDeltaLookup
    {
        private static readonly Dictionary<string, DirectionDelta> _directionDeltas = new Dictionary<string, DirectionDelta> {
            { "N", new DirectionDelta { DeltaY = 1 } },
            { "E", new DirectionDelta { DeltaX = 1, } },
            { "S", new DirectionDelta { DeltaY = -1 } },
            { "W", new DirectionDelta { DeltaX = -1, } }
        };

        public static DirectionDelta GetDirectionDeltaFromCardinalPoint(string cardinalPoint)
        {
            return _directionDeltas[cardinalPoint];
        }
    }
}
