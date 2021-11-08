# AWS Connect Manager
- Open-source Windows tool to simplify connecting to Amazon AWS EC2 instances. 
- Ever wanted to SSM, WinSCP or RDP to your Linux instances with a single click? Give it a try!

## Screenshots
- Single-click SSM, WinSCP & RDP:
 ![alt tag](https://i.imgur.com/HIsf3Qr.png)
- Configuration Screen
 ![alt tag](https://i.imgur.com/cDXhYPC.png)

## Prerequisites
- .NET Framework 4.7.2 installed on Windows
- AWS CLI - https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-install.html
- AWS Credential File (.aws/credentials) - https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-files.html
- Session Manager plugin for the AWS CLI - https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html
- WinSCP - https://winscp.net/eng/download.php
- ConEmu (auto packaged in the Windows download), if you want to use your own version, download here: https://conemu.github.io/

# WinSCP Prerequisite:
Integration with WinSCP needs some work, it currently requires a manual setup of the new WinSCP connection in WinSCP, which must be configured as follows: 
- Connection Name: AWS
- File Protocol: SCP
- Host Name: localhost
- Port: 54321
- User Name: root
Note: If you want SCP auto-login, you need to configure advanced settings and under SSH / Authentication, configure the path to your private key PPK file (also needs to be configured on the server.

# RDP Auto-Login
- If you want RDP to auto-login to your Windows servers, enter shared RDP credentials into configuration screen. I currently advise against this practice, but if you want to go ahead, be AWARE, that currently credentials are saved into the application config file in a raw unencrypted format.

# Application Download
- You can download the initial release of AWS Connect Manager for Windows (v1.0.0) in zip format from GitHub release page:
- https://github.com/JozefJarosciak/AWS-Connect-Manager/releases/download/v1.0.0/AWS_Connect_Manager-1.0.0.zip

# Application Installation
- Download AWS_Connect_Manager-1.0.0.zip
- Unzip
- Run: AWS-Connect-Manager.exe

# Source Code & Licensing
- Application is coded entirely in C# using Visual Studio. 
- No third-party dependencies except ConEmu (open-source tabbed terminal emulator for Windows). 

# License
- This project is open-source released under GNU GENERAL PUBLIC LICENSE - Version 2, June 1991.
- Feel free to fork and further enhance this project.

# Support
Having trouble? Contact me, I'll try to help as much as I can.

# Author / Contact
- Jozef Jarosciak 
- LinkedIn Contact: https://www.linkedin.com/in/jozefj
