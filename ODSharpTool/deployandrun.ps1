dotnet publish --framework net6.0 --runtime linux-arm64 --self-contained
wsl rsync /mnt/c/Repos/ODSharp/ODSharpTool/bin/Debug/net6.0/linux-arm64/publish/ electronerd@carpi2.local:~/odsharptool/  --progress --delete --archive --stats --recursive --rsh=ssh.exe
ssh electronerd@carpi2.local ~/odsharptool/ODSharpTool