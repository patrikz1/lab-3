using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace TestBoards
{
    [TestClass]
    public class UnitTest1
    {
        string TestData = "NW.CC, NC.CC, NW.NW, NE.CC, NW.SE, CE.CC, CW.CC, SE.CC, CW.NW, CC.CC, CW.SE, CC.NW, CC.SE, CE.NW, SW.CC, CE.SE, SW.NW, SE.SE, SW.SE";
        string ExpectedWinner = "X";

        [TestMethod]
        public void ExpectedResultTest()
        {
            var makemoves = new Game(new GameSetup().PopulateBoards(), new GameSetup().PopulatePlayers(), TestData).MakeMoves(new GameSetup().PopulatePlayers(), new GameSetup().PopulateBoards(), TestData);
            var result = new Result(makemoves);
            Assert.AreEqual(ExpectedWinner, result.WinnerPlayer);
        }
    }
}