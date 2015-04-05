using System;
using NUnit.Framework;
using SurveyLine.Core;
using SurveyLine.Transformation;

namespace SurveyLineTest
{
    [TestFixture]
    public class SurveyLineExtensionTest
    {
        private const double Tolerancy = 1e-12; // tolerance for difference between expected and actual

        #region 1st Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N0_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(0, 100);

            var actual = source.ProjectTo(0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N0_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = source.ProjectTo(0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint0_0_N090_100()
        {
            var source = new SurveyPoint(0, 0);
            var expected = new SurveyPoint(100, 0);

            var actual = source.ProjectTo(90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N090_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(200, 100);

            var actual = source.ProjectTo(90, 100);

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

            var actual = source.ProjectTo(180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N180_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 0);

            var actual = source.ProjectTo(180, 100);

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

            var actual = source.ProjectTo(270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N270_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(0, 100);

            var actual = source.ProjectTo(270, 100);

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

            var actual = source.ProjectTo(360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N360_100()
        {
            var source = new SurveyPoint(100, 100);
            var expected = new SurveyPoint(100, 200);

            var actual = source.ProjectTo(360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }

        #endregion

    }

    [TestFixture]
    public class SurveyLineCoreTest
    {
        #region Survey Factory Test

        [Test]
        public void GenerateSurveyPointList_SingleLine_Debug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 11);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            Console.WriteLine(survey.CreateSurveyPoints().ToString());

        }

        [Test]
        public void GenerateSurveyPointList_MultiLine_Debug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 11, 90, 2, 200);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            Console.WriteLine(survey.CreateSurveyPoints().ToString());
        }

        [Test]
        public void GenerateSurveyPointList_FixedGrid_Debug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 5, 90, 5);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            Console.WriteLine(survey.CreateSurveyPoints().ToString());
        }

        #endregion
    }

    [TestFixture]
    public class SurveyLineTransformationTest
    {
        #region WGS84 Trannsformation Test

        [Test]
        public void ToWGS84GeographicTransformDebug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 422048, 9184693, 90, 100, 11);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            var inLatLong = survey.CreateSurveyPoints().ToWGS84Geographic(new UTMZone(49, false));
            Console.WriteLine(inLatLong.ToString());
        }

        #endregion
    }
}
