using System.Collections.Generic;

namespace RobotCleaner
{
    public class CleaningInstructions
    {
        private CleaningInstructions()
        {
            NavigationCommands = new List<NavigationCommand>();
        }

        public CleaningInstructions(
            int numOfNavCommands,
            GridBlock startupBlock,
            List<NavigationCommand> navCommands)
            : this()
        {
            NumberOfNavigationCommands = numOfNavCommands;
            StartupGridBlock = startupBlock;
            NavigationCommands = navCommands;
        }

        public int NumberOfNavigationCommands { get; }
        public GridBlock StartupGridBlock { get; set; }
        public List<NavigationCommand> NavigationCommands { get; }
    }
}
