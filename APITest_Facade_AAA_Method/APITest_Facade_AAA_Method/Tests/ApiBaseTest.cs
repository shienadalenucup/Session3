using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using APITest_Facade_AAA_Method.DataModels;

namespace APITest_Facade_AAA_Method.Tests
{
    public class ApiBaseTest
	{
		public RestClient RestClient { get; set; }

		public PetJsonModel PetDetails { get; set; }

		[TestInitialize]
		public void Initilize()
		{
			RestClient = new RestClient();
		}

		//[TestCleanup]
		//public void CleanUp()
		//{

		//}
	}
}