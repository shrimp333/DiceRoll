using DiceRole;

namespace DiceRollTests
{
    public class UnitTest1
    {
        [Fact]
        public void AverageTest()
        {
            ClGame game = new ClGame();
            game.results = new List<int>() { 2, 7, 3, 11, 2, 2 };
            Assert.Equal(4.50, game.GetAverage());

            ClGame game2 = new ClGame();
            game2.results = new List<int>() { 18, 4, 6, 12, 19 };
            Assert.Equal(11.80, game2.GetAverage());

            ClGame game3 = new ClGame();
            game3.results = new List<int>() { 5 };
            Assert.Equal(5, game3.GetAverage());

            ClGame game4 = new ClGame();
            Assert.Equal(0, game4.GetAverage());
        }

        [Fact]
        public void TotalTest()
        {
            ClGame game = new ClGame();
            game.results = new List<int>() { 2, 7, 3, 11, 2, 2 };
            Assert.Equal(27, game.GetTotal());

            ClGame game2 = new ClGame();
            game2.results = new List<int>() { 18, 4, 6, 12, 19 };
            Assert.Equal(59, game2.GetTotal());

            ClGame game3 = new ClGame();
            game3.results = new List<int>() { 5 };
            Assert.Equal(5, game3.GetTotal());
            
            ClGame game4 = new ClGame();
            Assert.Equal(0, game4.GetTotal());
        }
    }
}