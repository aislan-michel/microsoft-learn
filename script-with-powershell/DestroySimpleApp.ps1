Param(
    [string]$name = "app"
)

rmdir $name

Write-Host "$name was destroy"