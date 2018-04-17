using System;
using Geolib.Services;
using GeoLib.Contract;
using GeoLib.Data.Entities;
using GeoLib.Data.RepositoryInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GeoLib.UnitTests
{
    [TestClass]
    public class GeoLibServiceTest
    {
        [TestMethod]
        public void Test_ServiceOperation_GetZipInfo()
        {
            //Arrange

            Mock<IZipCodeRepository> mockZipCodeRepository = new Mock<IZipCodeRepository>();

            const string ZIP = "80200";

            ZipCode zipCode = new ZipCode()
            {
                City = "Gdańsk",
                State = new State() {Abbreviation = "PR"},
                Zip = ZIP
            };

            mockZipCodeRepository.Setup(mr => mr.GetByZip(ZIP)).Returns(zipCode);

            IGeoService geoService = new GeoManager(mockZipCodeRepository.Object, null);

            //Act

            var returnedZipCode = geoService.GetZipInfo(ZIP);

            //Assert
            Assert.IsTrue(returnedZipCode.City == "Gdańsk", "ZipCode City should be Gdańsk");
            Assert.IsTrue(returnedZipCode.State == "PR");
        }
    }
}
