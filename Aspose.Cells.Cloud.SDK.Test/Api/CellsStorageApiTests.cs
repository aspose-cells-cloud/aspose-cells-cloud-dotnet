﻿/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class  CellsStorageApiTests : CellsBaseTest
    {
        private CellsApi instance;
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
        /// Test CellsDownloadFileTest
        /// </summary>
        [Test]
        public void CellsDownloadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            Stream stream = GetTestDataStream(name);
            instance.UploadFile(name, stream);
            var response = instance.DownloadFile(name);
            Assert.IsInstanceOf<Stream>(response, "Download file.");
        }

        /// <summary>
        /// Test CellsUploadFileTest
        /// </summary>
        [Test]
        public void CellsStorageApiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            Stream stream = GetTestDataStream(name);
            var response = instance.UploadFile(TEMPFOLDER +"\\"+name, stream);
            Assert.IsInstanceOf<FilesUploadResult>(response, "Upload file.");
            var responseObjectExists = instance.ObjectExists(name);
            Assert.IsInstanceOf<ObjectExist>(responseObjectExists, "StorageExist.");
            //create folder
            instance.CreateFolder(TEMPFOLDER + "\\new");
            //copy name to 1+name
            instance.CopyFile(TEMPFOLDER + "\\" + name, TEMPFOLDER + @"\new"+ name);
            //rename
            instance.MoveFile(TEMPFOLDER + "\\" + name,TEMPFOLDER + @"\1" + name);
            //delete uploaded file
            instance.DeleteFile(TEMPFOLDER + "\\1" + name);
            //create folder
            instance.CopyFolder(TEMPFOLDER + "\\new",TEMPFOLDER + "\\new2");
            instance.MoveFolder(TEMPFOLDER + "\\new2", TEMPFOLDER + "\\new3");
            //Get file list
            var responseList = instance.GetFilesList(TEMPFOLDER);
            Assert.IsInstanceOf<FilesList>(responseList, "Get file list.");

            
            instance.CreateFolder(TEMPFOLDER + "\\2");

            var responseStorageExists = instance.StorageExists("Default App");
            Assert.IsInstanceOf<StorageExist>(responseStorageExists, "StorageExist.");
        }

    }
}
