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
        public void ProjectSurveyPoint0_0_N0_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N0_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint0_0_N090_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(100, 0);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N090_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(200, 100);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 2nd Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N180_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, -100);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N180_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 0);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 3rd Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N270_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(-100, 0);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N270_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion
        #region 4th Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N360_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, 100);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N360_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = SurveyLineOperation.ProjectSurveyPoint(source, 360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion

//        #region PointNameGenerator Test
//
//        [Test]
//        public void PointNameGenerator_SingleLineTest()
//        {
//            var design = new SurveyDesign("Nunit", 0, 0, 90, 100, 101);
//            design.PointsSeparator = "-";
//
//            var actualName = SurveyLineOperation.DebugPointNameGenerator(design, 12);
//            var expectedName = "Nunit-12";
//
//            Assert.AreEqual(expectedName,actualName);
//        }
//
//        [Test]
//        public void PointNameGenerator_MultiLineTest()
//        {
//            var design = new SurveyDesign("Nunit",0,0,90,100,101,90,5);
//            design.PointsSeparator = "-";
//            design.LineSeparator = "-";
//
//            var actualName = SurveyLineOperation.DebugPointNameGenerator(design, 12, 12);
//            var expectedName = "Nunit-12-12";
//
//            Assert.AreEqual(expectedName, actualName);
//        }
//
//        [Test]
//        public void PointNameGenerator_MultiLineAlphabetTest()
//        {
//            var design = new SurveyDesign("Nunit", 0, 0, 90, 100, 101, 90, 5);
//            design.PointsSeparator = "-";
//            design.LineSeparator = "-";
//            design.LineIndexType = SurveyDesign.IndexType.Alphabet;
//
//            var actualName = SurveyLineOperation.DebugPointNameGenerator(design, 12, 12);
//            var expectedName = "Nunit-L-12";
//
//            Assert.AreEqual(expectedName, actualName);
//        }
//        #endregion
    }
}
