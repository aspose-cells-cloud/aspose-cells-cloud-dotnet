

namespace Aspose.Cells.Cloud.SDK.Test.ShortCodes
{

    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    [TestFixture]
    public class MergeTests : CellsBaseTest
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
        public void ShortCodeTests_Merge()
        {
            Requests.MergeRequest mergeRequest =
                  new Requests.MergeRequest { InputFiles = new string[]{ GetInputFilePath(BOOK1), GetInputFilePath(MYDOC) } ,OutputPath = GetOutFilePath( BOOK1 + ".pdf") };
            instance.Merge(mergeRequest);
        }


        
    }
}

