$mode = Read-Host -Prompt "[S]et or [R]emove proxy?"
$git = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TeamFoundation\Team Explorer\Git\cmd"
if ($mode -eq "S")
{
    $pass = Read-Host -AsSecureString -Prompt "Please enter your HSFC password"
    & $git\git.exe config --global http.proxy http://${env:Username}:${pass}@172.20.10.10:8080
    & $git\git.exe config --global https.proxy https://${env:Username}:${pass}@172.20.10.10:8080
    & $git\git.exe config --global http.sslBackend "openssl"
    & $git\git.exe config --global http.sslCAInfo "S:\Computing\3 Student Access - Read Only\cacert.pem"
    & $git\git.exe config --global http.sslVerify false
    & $git\git.exe config --global credential.helper wincred
    echo "Complete."
}
elseif ($mode -eq "R")
{
    & $git\git.exe config --global --unset http.proxy
    & $git\git.exe  config --global --unset https.proxy
    echo "Complete."
}
else
{
    echo "Invalid input. Script will fail."
}
Remove-Variable pass

if ($Host.Name -eq "ConsoleHost")
{
    Read-Host -Prompt "Press enter to close"
}