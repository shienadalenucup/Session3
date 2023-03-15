using Microsoft.VisualStudio.TestTools.UnitTesting;
using APITest_Facade_AAA_Method.Helpers;
using APITest_Facade_AAA_Method.Resources;
using APITest_Facade_AAA_Method.DataModels;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using APITest_Facade_AAA_Method.Tests.TestData;

namespace APITest_Facade_AAA_Method.Tests
{
    [TestClass]

    public class Session3Test : ApiBaseTest
    {
        private static List<PetJsonModel> petCleanUpList = new List<PetJsonModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task DemoGetPet()
        {
            //Arrange
            var demoGetRequest = new RestRequest(Endpoints.GetPetByPetId(PetDetails.Id.ToString()));
            petCleanUpList.Add(PetDetails);

            //Act
            var demoResponse = await RestClient.ExecuteGetAsync<PetJsonModel>(demoGetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, demoResponse.StatusCode, "Status code is not equal to 200");
            Assert.AreEqual(PetDetails.Name, demoResponse.Data.Name);
            Assert.AreEqual(PetDetails.Category.Name, demoResponse.Data.Category.Name);
            Assert.AreEqual(PetDetails.PhotoUrls[0], demoResponse.Data.PhotoUrls[0]);
            Assert.AreEqual(PetDetails.Tags[0].Name, demoResponse.Data.Tags[0].Name);
            Assert.AreEqual(PetDetails.Status, demoResponse.Data.Status);
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(Endpoints.GetPetByPetId(data.Id.ToString()));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }


    }
}