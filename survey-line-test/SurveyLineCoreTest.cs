using NUnit.Framework;
using SurveyLine.Core;

namespace SurveyLineTest
{
    [TestFixture]
    public class SurveyLineCoreTest
    {
        private const double Tolerancy = 1e-12; // tolerance for difference between expected and actual

        #region 1st Quadran Projection Test
        [Test]
        public void ProjectLocationTest0_0_N0_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyPointOperation.ProjectLocation(source, 0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest100_100_N0_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = SurveyPointOperation.ProjectLocation(source, 0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest0_0_N90_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(100, 0);

            var actual = SurveyPointOperation.ProjectLocation(source, 90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest100_100_N90_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(200, 100);

            var actual = SurveyPointOperation.ProjectLocation(source, 90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 2nd Quadran Projection Test
        [Test]
        public void ProjectLocationTest0_0_N180_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, -100);

            var actual = SurveyPointOperation.ProjectLocation(source, 180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest100_100_N180_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 0);

            var actual = SurveyPointOperation.ProjectLocation(source, 180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 3rd Quadran Projection Test
        [Test]
        public void ProjectLocationTest0_0_N270_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(-100, 0);

            var actual = SurveyPointOperation.ProjectLocation(source, 270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest100_100_N270_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyPointOperation.ProjectLocation(source, 270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 4th Quadran Projection Test
        [Test]
        public void ProjectLocationTest0_0_N360_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyPointOperation.ProjectLocation(source, 360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectLocationTest100_100_N360_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = SurveyPointOperation.ProjectLocation(source, 360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
    }
}
