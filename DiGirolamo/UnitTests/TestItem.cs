using System;
using DiGirolamo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestItem
    {
        private double health;
        private int damage;
        private int bulletSpeed;
        private int speed;

        private const int MORE_DAMAGE = 5;
        private const double MORE_HEALTH = 20;
        private const int MORE_SPEED = 40;
        private const int MORE_BULLETSPEED = 40;
        [TestInitialize]
        public void basicSkills()
        {
            health = 3.0;
            damage = 10;
            bulletSpeed = 100;
            speed = 50;

        }
        private void addSkills(IItem item)
        {
            this.health += item.Health;
            this.damage += item.Damage;
            this.speed += item.Speed;
            this.bulletSpeed += item.BulletSpeed;
        }
        [TestMethod]
        public void TestArthemideBow()
        {
            IItem item = new ItemBuilder.Builder(Items.ArthemideBow, 0).addDamage(MORE_DAMAGE).build();
            addSkills(item);
            Assert.AreEqual(15, this.damage);
            Assert.AreEqual(3.0, this.health);
            Assert.AreEqual(50, this.speed);
            Assert.AreEqual(100, this.bulletSpeed);
        }
        [TestMethod]
        public void TestOracleAmulet()
        {
            IItem item = new ItemBuilder.Builder(Items.OracleAmulet, 0).addDamage(MORE_DAMAGE).addSpeed(MORE_SPEED).addBulletSpeed(MORE_BULLETSPEED).build();
            addSkills(item);
            Assert.AreEqual(15, this.damage);
            Assert.AreEqual(3.0, this.health);
            Assert.AreEqual(90, this.speed);
            Assert.AreEqual(140, this.bulletSpeed);
        }
        [TestMethod]
        public void TestHermesBoots()
        {
            IItem item = new ItemBuilder.Builder(Items.HermesBoots, 0).addSpeed(MORE_SPEED).build();
            addSkills(item);
            Assert.AreEqual(10, this.damage);
            Assert.AreEqual(3.0, this.health);
            Assert.AreEqual(90, this.speed);
            Assert.AreEqual(100, this.bulletSpeed);
        }
        [TestMethod]
        public void TestHealth()
        {
            IItem item = new ItemBuilder.Builder(Items.Health, 0).addHelath(MORE_HEALTH).build();
            addSkills(item);
            Assert.AreEqual(10, this.damage);
            Assert.AreEqual(23, this.health);
            Assert.AreEqual(50, this.speed);
            Assert.AreEqual(100, this.bulletSpeed);
        }

    }
}
