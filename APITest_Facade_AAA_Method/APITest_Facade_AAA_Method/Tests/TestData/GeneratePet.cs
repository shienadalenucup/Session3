using APITest_Facade_AAA_Method.DataModels;
using System;

namespace APITest_Facade_AAA_Method.Tests.TestData
{
    public class GeneratePet
    {
        public static PetJsonModel demoPet()
        {
            return new PetJsonModel
            {
                Id = 22377,
                Category = new Category()
                {
                    Id = 9876,
                    Name = "Small Breed"
                },
                Name = "Bruno",
                PhotoUrls = new string[]
                {
                    "https://images.app.goo.gl/J8mwktStNPomuzfp6"
                },
                Tags = new Category[]
                {
                   new Category() { Id = 9876, Name = "Dachschund" }
                },
                Status = "Available"
            };
        }
    }
}