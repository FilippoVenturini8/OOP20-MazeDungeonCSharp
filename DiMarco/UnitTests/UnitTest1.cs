using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiMarco;
using NuGet.Frameworks;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPoint2D()
        {
            Point2D position = new Point2D(100, 100);
            Assert.AreEqual(100, position.X);
            Assert.AreEqual(100, position.Y);
        }

        [TestMethod]
        public void TestVector2D()
        {
            Vector2D vector = new Vector2D(100, 100);
            Assert.AreEqual(100, vector.X);
            Assert.AreEqual(100, vector.Y);
            Vector2D vector1 = vector.Mul(2);
            Assert.AreEqual(200, vector.X);
            Assert.AreEqual(200, vector.Y);
        }

        [TestMethod]
        public void TestMainCharacter()
        {
            Point2D position = new Point2D(100, 100);
            IMainCharacter mainCharacter = new MainCharacter(position);
            Assert.AreEqual(100, mainCharacter.Life);
            Assert.AreEqual(100, mainCharacter.MaxLife);
            mainCharacter.TakesDamage(50);
            Assert.AreEqual(50, mainCharacter.Life);
            mainCharacter.IncreaseBulletSpeed(10);
            mainCharacter.IncreaseDamage(10);
            mainCharacter.IncreaseSpeed(10);
            mainCharacter.SetShoot(true, VectorDirection.UP);
            Assert.IsTrue(mainCharacter.Shoot);
            Assert.IsFalse(mainCharacter.IsWin());
            mainCharacter.PickedUpFinalArtifact();
            Assert.IsTrue(mainCharacter.IsWin());
            Assert.IsFalse(mainCharacter.IsDead());
            mainCharacter.TakesDamage(100);
            Assert.IsTrue(mainCharacter.IsDead());
        }


    }
}
