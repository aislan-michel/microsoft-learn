param(
    [int]
    [Parameter(Mandatory, HelpMessage = "Please provide a type")]
    $type
)

Remove-Item stores

mkdir stores

Set-Location stores

if($type -eq 1){
    
    touch sales.json
    touch totals.txt
    
    mkdir 201
    mkdir 202
    
    Set-Location 201  
    
    touch sales.json
    touch salestotals.json
    touch inventory.txt 
    
    cd..

    cd..

} elseif ($type -eq 2) {
    touch sales.json
    touch totals.txt

    for ($i = 1; $i -lt 5; $i++) {
        $name = "20" + $i;
        mkdir $name

        Set-Location $name

        touch inventory.txt
        touch sales.json
        touch salestotals.json
        
        cd..
    }
}else{
    Write-Host "provide a valid type"
}






