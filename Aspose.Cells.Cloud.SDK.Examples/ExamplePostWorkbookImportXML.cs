using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localName = "Template.xlsx";
string dataXML = "data.xml";
string remoteName = "Template.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
this.UploadFile( dataXML, remoteFolder + "/data.xml", "");

var importXMLRequestXMLFileSource = new DataSource()
{
    DataSourceType = "CloudFileSystem",
    DataPath = remoteFolder + "/data.xml"
};
var importXMLRequestImportPosition = new ImportPosition()
{
    SheetName = "Sheet1",
    RowIndex = 3,
    ColumnIndex = 4
};
var importXMLRequest = new ImportXMLRequest()
{
    XMLFileSource = importXMLRequestXMLFileSource,
    ImportPosition = importXMLRequestImportPosition
};
var request = new PostWorkbookImportXMLRequest(
    name: remoteName,
    importXMLRequest: importXMLRequest,
    folder: remoteFolder,
    storageName: ""
);
this.CellsApi.PostWorkbookImportXML(request);
