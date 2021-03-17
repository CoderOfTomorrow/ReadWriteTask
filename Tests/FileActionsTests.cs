using NUnit.Framework;
using ReadWrite.Implimentations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tests
{
    public class FileActionsTests
    {
        private string filePath = "test.txt";
        private string fileData = "ipsum lorem";
        private string unexistingPath = "utest.txt";

        [SetUp]
        public void Setup()
        {
            //Arrange
            FileStream testFile = File.Create(filePath);
            testFile.Close();
            using (StreamWriter newFile = new StreamWriter(filePath))
            {
                newFile.Write(fileData);
            }
        }

        [Test]
        public void ReadActionFromExistingFile()
        {
            //Act
            FileActions newFileActions = new FileActions(filePath);
            
            Assert.AreEqual(newFileActions.Read(),fileData);
            
        }

        [Test]
        public void ReadActionFromUnexistingFile()
        {
            //Act
            FileActions newFileActions = new FileActions(unexistingPath);

            Assert.AreEqual(newFileActions.Read(),null);

        }
    }
}
