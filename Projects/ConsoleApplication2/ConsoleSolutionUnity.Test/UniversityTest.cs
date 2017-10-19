using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleSolutionUnity;
using Moq;
using NUnit.Framework;

namespace ConsoleSolutionUnityTest
{
    [TestFixture]
    public class UniversityTest
    {

            Mock<IUniversity> mockUniversity;

            Student systemUnderTest;

            //IStudent Student = new Student(university); 
            [TestCase("Eng", "You are in the Engineering program.")]
            [TestCase("Bus", "You are in the Business program.")]
            [TestCase("", "You have not selected a program type.")]
            [TestCase("1", "You have not selected a program type.")]
            [TestCase("22", "You have not selected a program type.")]
            public void Test_Show_Expected_Result(string ProgType, string expectedResult)
            {
                mockUniversity = new Mock<IUniversity>(MockBehavior.Strict);
                mockUniversity.Setup(p => p.ShowResult(ProgType)).Returns(expectedResult);

                systemUnderTest = new Student(mockUniversity.Object);
                var result = systemUnderTest.DisplayResult(ProgType);
                Assert.That(result, Is.EqualTo(expectedResult));

                mockUniversity.VerifyAll();
            }
        }
    }

