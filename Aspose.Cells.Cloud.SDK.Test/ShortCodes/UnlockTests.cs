

namespace Aspose.Cells.Cloud.SDK.Test.ShortCodes
{

    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    [TestFixture]
    public class UnlockTests : CellsBaseTest
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
        public void ShortCodeTests_Unlock()
        {
            Requests.UnlockRequest unlockRequest   =
                  new Requests.UnlockRequest {InputPath = GetInputFilePath(NEEDUNLOCK), OutputPath = GetOutFilePath( BOOK1 + "_unlock.pdf") , Password = "123456"};
            instance.Unlock(unlockRequest);
        }


        [Test]
        public void ShortCodeTests_Unlock_SaveCloud()
        {
            Requests.UnlockRequest unlockRequest =
                  new Requests.UnlockRequest { InputPath = GetInputFilePath(NEEDUNLOCK), OutputPath =BOOK1 + "_unlock.xlsx", Password = "123456", SaveToCloud = true };
            instance.Unlock(unlockRequest);
        }

    }
}

