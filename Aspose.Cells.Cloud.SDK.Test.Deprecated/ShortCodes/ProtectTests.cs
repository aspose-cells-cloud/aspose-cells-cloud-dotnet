

namespace Aspose.Cells.Cloud.SDK.Test.ShortCodes
{

    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    [TestFixture]
    public class ProtectTests : CellsBaseTest
    {
        private ICellsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }
        /// <summary>
        /// Test OAuthPost
        /// </summary>
        [Test]
        public void ShortCodeTests_Protect()
        {
            Requests.ProtectRequest protectRequest =
                  new Requests.ProtectRequest { InputPath = GetInputFilePath(BOOK1), OutputPath = GetOutFilePath( BOOK1 + "_protect.xlsx") , Password = "123456"};
            instance.Protect(protectRequest);
        }


        [Test]
        public void ShortCodeTests_Protect_SaveCloud()
        {
            Requests.ProtectRequest protectRequest =
                  new Requests.ProtectRequest { InputPath = GetInputFilePath(BOOK1), OutputPath =BOOK1 + "_protect.xlsx", Password = "123456", SaveToCloud = true };
            instance.Protect(protectRequest);
        }

    }
}

