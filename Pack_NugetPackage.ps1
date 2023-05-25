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
$PackFile="Aspose.Cells-Cloud.$version.nupkg" 

Write-Output "Pack Aspose.Cells Cloud SDK $version For Net."
dotnet pack --output .\
dotnet nuget sign  --hash-algorithm  sha256 --certificate-path aspose.pfx  --certificate-password f27Hp99Ds3  --timestamper http://timestamp.digicert.com $PackFile
dotnet nuget verify $PackFile
Write-Output "Move-Item  -Path $PackFile -Destination  packages/$PackFile"
if (Test-Path packages/$PackFile){
    Remove-Item -Path packages/$PackFile 
}
Move-Item  -Path  "$PackFile" -Destination  "packages/$PackFile"
