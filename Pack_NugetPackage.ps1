dotnet build -c Release Aspose.Cells.Cloud.SDK\Aspose.Cells.Cloud.SDK.csproj
$RootFolder = (Get-Location).Path
$File = "$RootFolder\Aspose.Cells.Cloud.SDK\bin\Release\net6.0\Aspose.Cells.Cloud.SDK.dll"  # 修正为 net6.0
$FileVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($File).FileVersion.split(".")

if( $FileVersion.Length -eq 2 ){
    $version = $fileVersion[0],$fileVersion[1],"0" -join('.')
} else {
    $version = $fileVersion[0],$fileVersion[1],$fileVersion[2] -join('.')
}
$PackFile = "Aspose.Cells-Cloud.$version.nupkg"
Write-Output "Pack Aspose.Cells Cloud SDK $version For Net."
dotnet pack Aspose.Cells.Cloud.SDK\Aspose.Cells.Cloud.SDK.csproj -c Release --output .\ --no-build
if (Test-Path "aspose.pfx") {
    dotnet nuget sign $PackFile `
        --hash-algorithm sha256 `
        --certificate-path aspose.pfx `
        --certificate-password f27Hp99Ds3 `
        --timestamper http://timestamp.digicert.com

    dotnet nuget verify $PackFile
}
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