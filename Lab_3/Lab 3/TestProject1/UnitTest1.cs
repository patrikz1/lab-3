using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Result _output;

        public UnitTest1()
        {
            _output = new Result();
        }


        [TestMethod]
        public void check1(object WinnerList)
        {
            var result = _output.CheckWinBigBoards(WinnerList);

            Assert.IsTrue((bool)result);
        }

        //är inte helt hundra på denna, men en new Result finns.
        //I metoden tar man fram CheckWin...Board med Winnerlist,som jag antar är listan med
        //spelade squares vinst  rmoves, som input och sen ser man med Assert.IsTrue om det stämmer
        //i guess det är nästan rätt pls dont flame me :)

        public void check2(object WinnerList)
        {
            var result = _output.CheckWinSmallBoards(WinnerList);

            Assert.IsTrue((bool)result);
        }
        
        public void check3(object WinnerList)
        {
            var result = _output.CheckWinDiagonal(WinnerList);

            Assert.IsTrue((bool)result);
        }

        public void check4(object WinnerList)
        {
            var result = _output.CheckWinHorizontal(WinnerList);

            Assert.IsTrue((bool)result);
        }
        
        public void check5(object WinnerList)
        {
            var result = _output.CheckWinVertical(WinnerList);

            Assert.IsTrue((bool)result);
        }

    }
}