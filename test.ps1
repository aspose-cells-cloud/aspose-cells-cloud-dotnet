[string[]]$lines =dotnet build  --framework netstandard2.0  --configuration Release .\Aspose.Cells.Cloud.SDK\Aspose.Cells.Cloud.SDK.csproj
foreach( $line in  $lines)
{
    if($line -match  "Build succeeded")
    {
        Write-Host  "Aspose.Cells.Cloud.SDK.csproj Build succeeded."
        break;
    }
}
[string[]]$lines =dotnet build  --framework netcoreapp2.2 .\Aspose.Cells.Cloud.SDK.Test\Aspose.Cells.Cloud.SDK.Test.csproj
foreach( $line in  $lines)
{
    if($line -match  "Build succeeded")
    {
        Write-Host  "Aspose.Cells.Cloud.SDK.Test.csproj Build succeeded."
        break;
    }
}
[string[]]$lines = dotnet test  --framework netcoreapp2.2 .\Aspose.Cells.Cloud.SDK.Test\Aspose.Cells.Cloud.SDK.Test.csproj
$total = 0
$passed = 0
$failed = 0
foreach( $line in  $lines)
{
    Write-Host  $line
    if($line -match "Total tests: (\d+)")
    {  
        $total=$matches[1]
    }     
    if($line -match "Passed: (\d+)")
    {  
        $passed=$matches[1]
    }  
    if($line -match "Failed: (\d+)")
    {  
        $failed=$matches[1]
    }  
}

$EndTime = Get-Date
$timespan ="{0:N2}" -f (New-TimeSpan $StartTime  $EndTime).TotalSeconds
Write-Host "Spent ${timespan}s on finishing test. Result : Total ${total}, Passed ${passed} , Failed ${failed} ."