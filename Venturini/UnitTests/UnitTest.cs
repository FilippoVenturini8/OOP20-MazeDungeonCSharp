using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Venturini;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPoint2D()
        {
            Point2D point = new Point2D(100, 200);

            Assert.IsNotNull(point);

            Assert.AreEqual(100, point.X);
            Assert.AreEqual(200, point.Y);
        }

        [TestMethod]
        public void TestVector2D()
        {
            Vector2D vector = new Vector2D(500, 500);

            Assert.IsNotNull(vector);

            Assert.AreEqual(500, vector.X);
            Assert.AreEqual(500, vector.Y);
        }

        [TestMethod]
        public void TestBoundingBox()
        {
            BoundingBox boundingBox = new BoundingBox(new Point2D(100, 100), 300, 400);

            Assert.IsNotNull(boundingBox);

            Assert.AreEqual(300, boundingBox.Width);
            Assert.AreEqual(400, boundingBox.Height);

            Assert.AreEqual(400, boundingBox.BRCorner.X);
            Assert.AreEqual(500, boundingBox.BRCorner.Y);

            boundingBox.move(new Point2D(900, 900));
            Assert.AreEqual(900, boundingBox.ULCorner.X);
            Assert.AreEqual(900, boundingBox.ULCorner.Y);

            BoundingBox boundingbox1 = new BoundingBox(new Point2D(900, 950), 300, 400);
            Assert.IsTrue(boundingBox.intersectWith(boundingbox1));
        }

        [TestMethod]
        public void TestSimpleObject()
        {
            AbstractSimpleObject simple = new SimpleObjectImpl(new Point2D(400, 500), 10);

            Assert.IsNotNull(simple);

            Assert.AreEqual(400, simple.Position.X);
            Assert.AreEqual(500, simple.Position.Y);

            Assert.AreEqual(10, simple.Id);

            simple.BoundingBox = new BoundingBox(new Point2D(900, 950), 300, 400);
            Assert.AreEqual(900, simple.BoundingBox.ULCorner.X);
            Assert.AreEqual(950, simple.BoundingBox.ULCorner.Y);
        }

        [TestMethod]
        public void TestDynamicObject()
        {
            AbstractDynamicObject dynamic = new DynamicObjectImpl(300, new Point2D(600, 700), 23);
            BoundingBox boundingBox = new BoundingBox(dynamic.Position, 300, 400);
            dynamic.BoundingBox = boundingBox;

            Assert.IsNotNull(dynamic);

            Assert.AreEqual(600, dynamic.Position.X);
            Assert.AreEqual(700, dynamic.Position.Y);

            Assert.AreEqual(23, dynamic.Id);

            dynamic.Position = new Point2D(300, 300);
            Assert.AreNotEqual(600, dynamic.Position.X);
            Assert.AreNotEqual(700, dynamic.Position.X);

            Assert.AreEqual(300, dynamic.BoundingBox.ULCorner.X);
            Assert.AreEqual(300, dynamic.BoundingBox.ULCorner.Y);

            Assert.AreEqual(600, dynamic.GetLastPosition().X);
            Assert.AreEqual(700, dynamic.GetLastPosition().Y);
        }
    }
}
