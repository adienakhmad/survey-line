using System;
using System.Diagnostics;
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

        [Test]
        public void GenerateSurveyPointList_SingleLine_Test()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 11);
            SurveyNamingDesign nameDesign = new SurveyNamingDesign();

            var result = SurveyLineOperation.GenerateSurveyPointList(design, nameDesign).ToList();

            Console.WriteLine("Bearing: {0} Interval:{1} PlusBearing:{2} LineSpacing:{3}", design.Bearing, design.Interval, design.PlusBearing, design.LineSpacing);
            foreach (var point in result)
            {
                var str = string.Format("{0:}\t{1:F6}\t{2:F6}", point.Name, point.X, point.Y);
                Console.WriteLine(str);
            }
        }

        [Test]
        public void GenerateSurveyPointList_MultiLine_Test()
        {
            SurveyDesign design = new SurveyDesign("NUNIT",0,0,90,100,11,90,2,200);
            SurveyNamingDesign nameDesign = new SurveyNamingDesign();

            var result = SurveyLineOperation.GenerateSurveyPointList(design, nameDesign).ToList();

            Console.WriteLine("Bearing: {0} Interval:{1} PlusBearing:{2} LineSpacing:{3}", design.Bearing, design.Interval, design.PlusBearing, design.LineSpacing);
            foreach (var point in result)
            {
                var str = string.Format("{0:}\t{1:F6}\t{2:F6}", point.Name, point.X, point.Y);
                Console.WriteLine(str);
            }
        }

        [Test]
        public void GenerateSurveyPointList_FixedGrid_Test()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 11, 90,2);
            SurveyNamingDesign nameDesign = new SurveyNamingDesign();

            var result = SurveyLineOperation.GenerateSurveyPointList(design, nameDesign).ToList();

            Console.WriteLine("Bearing: {0} Interval:{1} PlusBearing:{2} LineSpacing:{3}", design.Bearing, design.Interval, design.PlusBearing, design.LineSpacing);
            foreach (var point in result)
            {
                var str = string.Format("{0:}\t{1:F6}\t{2:F6}", point.Name, point.X, point.Y);
                Console.WriteLine(str);
            }
        }

    }
}
