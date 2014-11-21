cls
$env:PATH =$env:PATH+";c:\program files\nuget\"
$folders = Get-ChildItem -Directory
foreach($folder in $folders)
{
    $nuspec = Get-ChildItem $folder.FullName -filter "*.nuspec"

    pushd output
    if ($nuspec.FullName)
    {
      #$cmdargs = "nuget.exe pack ..\$folder\$folder.csproj -Build -Prop Configuration=Release -Prop Platform=AnyCPU -IncludeReferencedProjects"
      $cmdargs = "nuget.exe pack ..\$folder\$folder.csproj -Prop Configuration=Release -IncludeReferencedProjects"
      Invoke-Expression $cmdargs

      if (!(Test-Path("$folder*.nupkg")))
      {
        popd
        Break
      }
    }
    popd
}
