using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace APITest_Facade_AAA_Method.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>
    
    public class Endpoints
    {
        //Base URL
        public const string BaseURL = "https://petstore.swagger.io/v2";

        public static string GetPetByPetId(string petId) => $"{BaseURL}/pet/{petId}";

        public static string PostPet() => $"{BaseURL}/pet";

        public static string DeletePetByPetId(string petId) => $"{BaseURL}/pet/{petId}";
    }
}