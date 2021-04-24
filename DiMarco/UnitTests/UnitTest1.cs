using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiMarco;

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
            Assert.AreEqual(200, vector1.X);
            Assert.AreEqual(200, vector1.Y);
        }
        
        [TestMethod]
        public void TestMainCharacter()
        {
            Point2D position = new Point2D(100, 100);
            IMainCharacter mainCharacter = new MainCharacter(position);
            Assert.AreEqual(0, mainCharacter.Money);
            Assert.AreEqual(100, mainCharacter.Life);
            Assert.AreEqual(100, mainCharacter.MaxLife);
            mainCharacter.TakesDamage(50);
            Assert.AreEqual(50, mainCharacter.Life);
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

        [TestMethod]
        public void TestBullet()
        {
            Point2D p = new Point2D(100, 100);
            Vector2D v = new Vector2D(200, 200);
            IBulletFactory bulletFactory = new BulletFactoryImpl();
            IBullet bullet = bulletFactory.CreateMainCharacterBullet(p, v, 0, 0);
            Assert.IsNotNull(bullet);
            Assert.AreEqual(bullet.Damage, 10);
        }
    }
}
