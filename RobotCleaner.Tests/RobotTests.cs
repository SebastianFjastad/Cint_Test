using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RobotCleaner.Tests
{
    //[TestClass]
    //public class RobotTests
    //{
    //    [TestMethod]
    //    public void Check_Positive_X_Move_Adjacent_To_Boundary_Is_Allowed()
    //    {
    //        var startingPosition = new GridBlock(99_999, 1);
    //        var robot = new CleaningRobot(startingPosition);
    //        var navCommand = new NavigationCommand("E", 1);

    //        var result = robot.CheckCanMove(navCommand.Direction);

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void Check_Negative_X_Move_Adjacent_To_Boundary_IsAllowed()
    //    {
    //        var startingPosition = new GridBlock(-99_999, 1);
    //        var robot = new CleaningRobot(startingPosition);
    //        var navCommand = new NavigationCommand("W", 1);

    //        var result = robot.CheckCanMove(navCommand.Direction);

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void Check_Positive_X_Move_Does_Not_Cross_Border()
    //    {
    //        var startingPosition = new GridBlock(100_000, 1);
    //        var robot = new CleaningRobot(startingPosition);
    //        var navCommand = new NavigationCommand("E", 1);

    //        var result = robot.CheckCanMove(navCommand.Direction);

    //        Assert.IsFalse(result);
    //    }

    //    [TestMethod]
    //    public void Check_Negative_X_Move_Does_Not_Cross_Border()
    //    {
    //        var startingPosition = new GridBlock(-100_000, 1);
    //        var navCommand = new NavigationCommand("W", 1);
    //        var robot = new CleaningRobot(startingPosition);

    //        var result = robot.CheckCanMove(navCommand.Direction);

    //        Assert.IsFalse(result);
    //    }

    //    [TestMethod]
    //    public void Check_Cleaned_Blocks_Count()
    //    {
    //        var instructions = new CleaningInstructions(
    //                numOfNavCommands: 4,
    //                startupBlock: new GridBlock(1, 1),
    //                navCommands: new List<NavigationCommand>
    //                {
    //                    new NavigationCommand("E", 3),
    //                    new NavigationCommand("W", 1),
    //                    new NavigationCommand("N", 2),
    //                    new NavigationCommand("S", 4),
    //                });

    //        var controller = new RobotController(instructions);
    //        controller.ProcessNavigationInstructions();

    //        Assert.IsTrue(controller.CleanedBlocks.Count == 8);
    //    }
    //}
}