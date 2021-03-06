﻿using System;
using NUnit.Framework;
using SurveyLine.Core;
using SurveyLine.Ex;
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
            var source = new Station(0, 0);
            var expected = new Station(0, 100);

            var actual = source.ProjectTo(0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N0_100()
        {
            var source = new Station(100, 100);
            var expected = new Station(100, 200);

            var actual = source.ProjectTo(0, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint0_0_N090_100()
        {
            var source = new Station(0, 0);
            var expected = new Station(100, 0);

            var actual = source.ProjectTo(90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N090_100()
        {
            var source = new Station(100, 100);
            var expected = new Station(200, 100);

            var actual = source.ProjectTo(90, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion

        #region 2nd Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N180_100()
        {
            var source = new Station(0, 0);
            var expected = new Station(0, -100);

            var actual = source.ProjectTo(180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N180_100()
        {
            var source = new Station(100, 100);
            var expected = new Station(100, 0);

            var actual = source.ProjectTo(180, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion

        #region 3rd Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N270_100()
        {
            var source = new Station(0, 0);
            var expected = new Station(-100, 0);

            var actual = source.ProjectTo(270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N270_100()
        {
            var source = new Station(100, 100);
            var expected = new Station(0, 100);

            var actual = source.ProjectTo(270, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        #endregion

        #region 4th Quadran Projection Test
        [Test]
        public void ProjectSurveyPoint0_0_N360_100()
        {
            var source = new Station(0, 0);
            var expected = new Station(0, 100);

            var actual = source.ProjectTo(360, 100);

            Assert.AreEqual(expected.X, actual.X, Tolerancy, "X Fail");
            Assert.AreEqual(expected.Y, actual.Y, Tolerancy, "Y Fail");

        }
        [Test]
        public void ProjectSurveyPoint100_100_N360_100()
        {
            var source = new Station(100, 100);
            var expected = new Station(100, 200);

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
            Console.WriteLine(survey.BuildSurveyPoints().ToString());

        }

        [Test]
        public void GenerateSurveyPointList_MultiLine_Debug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 11, 90, 2, 200);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            Console.WriteLine(survey.BuildSurveyPoints().ToString());
        }

        [Test]
        public void GenerateSurveyPointList_FixedGrid_Debug()
        {
            SurveyDesign design = new SurveyDesign("NUNIT", 0, 0, 90, 100, 5, 90, 5);
            StationNameDesign nameDesign = new StationNameDesign();

            SurveyFactory survey = new SurveyFactory(design, nameDesign);
            Console.WriteLine(survey.Design.ToString());
            Console.WriteLine(survey.BuildSurveyPoints().ToString());
        }

        #endregion
        
        #region Exception Test

        [Test]
        [ExpectedException(typeof (ZeroIntervalException))]
        public void ZeroIntervalTest()
        {
            var survey = new SurveyFactory(new SurveyDesign("NUNIT Zero Interval", 0, 0, 90, 0, 11));
            survey.BuildSurveyPoints();
        }

        #endregion

        #region enumeration test

        [Test]
        public void DesignTypeEnumeration_Test_0_SingleLine()
        {
            int a = 0;

            var actual = (SurveyDesign.DesignType) a;
            var expected = SurveyDesign.DesignType.SingleLine;

            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void DesignTypeEnumeration_Test_1_MultiLine()
        {
            int a = 1;

            var actual = (SurveyDesign.DesignType)a;
            var expected = SurveyDesign.DesignType.MultiLine;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DesignTypeEnumeration_Test_2_FixedGrid()
        {
            int a = 2;

            var actual = (SurveyDesign.DesignType)a;
            var expected = SurveyDesign.DesignType.RectangularGrid;

            Assert.AreEqual(expected, actual);
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
            var inLatLong = survey.BuildSurveyPoints().ToWGS84Geographic(new UTMZone(49, false));
            Console.WriteLine(inLatLong.ToString());
        }

        #endregion
    }
}
