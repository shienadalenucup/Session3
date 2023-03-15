using RestSharp;
using APITest_Facade_AAA_Method.DataModels;
using APITest_Facade_AAA_Method.Resources;
using APITest_Facade_AAA_Method.Tests.TestData;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace APITest_Facade_AAA_Method.Helpers
{
    /// <summary>
    /// Demo class containing all methods for pet
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new pet
        /// </summary>
        /// 
        public static async Task<PetJsonModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.demoPet();
            var postRequest = new RestRequest(Endpoints.PostPet());

            //Send Post Request to add new user
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetJsonModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}