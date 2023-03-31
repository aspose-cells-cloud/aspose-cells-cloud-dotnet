dotnet build -c Release 
$RootFoler=(Get-Location).Path
$File = "$RootFoler\Aspose.Cells.Cloud.SDK\bin\Release\netstandard2.0\Aspose.Cells.Cloud.SDK.dll"
$FileVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($File).FileVersion.split(".")
$version
if( $FileVersion.Length -eq 2 ){
    $version=$fileVersion[0],$fileVersion[1],"0" -join('.')
}else{
    $version=$fileVersion[0],$fileVersion[1],$fileVersion[2] -join('.')
}
$TempPackFile="Aspose.Cells.Cloud.SDK.$version.nupkg"
$PackFile="packages\Aspose.Cells-Cloud.$version.nupkg" 

Write-Output "Pack Aspose.Cells Cloud SDK $version For Net."
dotnet pack --output .\
Write-Output "Move-Item  -Path $TempPackFile -Destination  $PackFile"
Move-Item  -Path  "$TempPackFile" -Destination  "$PackFile"
