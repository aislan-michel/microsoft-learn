Remove-Item repositories

mkdir repositories

Set-Location repositories

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


