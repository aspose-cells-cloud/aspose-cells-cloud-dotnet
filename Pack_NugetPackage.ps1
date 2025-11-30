dotnet build -c Release Aspose.Cells.Cloud.SDK\Aspose.Cells.Cloud.SDK.csproj
$RootFolder = (Get-Location).Path
$File = "$RootFolder\Aspose.Cells.Cloud.SDK\bin\Release\net6.0\Aspose.Cells.Cloud.SDK.dll"
$FileVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($File).FileVersion.split(".")

if( $FileVersion.Length -eq 2 ){
    $version = $fileVersion[0],$fileVersion[1],"0" -join('.')
} else {
    $version = $fileVersion[0],$fileVersion[1],$fileVersion[2] -join('.')
}
$PackFile = "Aspose.Cells-Cloud.$version.nupkg"
Write-Output "Pack Aspose.Cells Cloud SDK $version For Net."
dotnet pack Aspose.Cells.Cloud.SDK\Aspose.Cells.Cloud.SDK.csproj -c Release --output .\ --no-build

nuget sign $PackFile -CertificateFingerprint "A05FE6B080B8437CE13868FDDB07A565332EF61D" -CertificateStoreName "Enterprise Trust" -CertificateStoreLocation "CurrentUser"

nuget verify $PackFile -All

if (-not (Test-Path packages)) {
    New-Item -ItemType Directory packages | Out-Null
}

if (Test-Path "packages\$PackFile") {
    Remove-Item -Path "packages\$PackFile" -Force
}

if (Test-Path $PackFile) {
    Move-Item -Path $PackFile -Destination "packages\" -Force
    Write-Output "Package moved to: $((Get-Item "packages\$PackFile").FullName)"
} else {
    Write-Error "Package file not found: $PackFile"
}