# CommieClient
## communism hahahaha ![image](https://user-images.githubusercontent.com/68202118/123335900-09dafd00-d53d-11eb-82db-84310da5c9c1.png) ![image](https://raw.githubusercontent.com/juaneth/CommieClient/master/LinuxCommieClient.png)
(temporary ui, subject to change)


# Build Instructions

## Download the repository by clicking [here](https://github.com/juaneth/CommieClient/archive/refs/heads/master.zip) and open with Visual Studio (make sure you have .NET ## Desktop Development), then once its all loaded click 'Build' and then 'Build Solution'

## To access the built application, go to wherever you have the downloaded project and go to 'CommieClient/bin/debug/net5.0-windows/'

## To make this functional and not break upon launch you should download the 'test release' [here](https://github.com/juaneth/CommieClient/releases/download/0.0.0/comclient-x64.zip) and then replace the files inside there with the ones you have made

# Running on Linux (Wine)

## After building the project (I dont know how you even do that on linux so you might have to make a windows virtual machine and then transfer the files) you should install wine (if you dont know how, search up on google 'install wine on (your linux distrobution)' and follow those instructions and continue to the next step then download .net runtime from [here](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-5.0.7-windows-x64-installer) and then open up your terminal and type in 'wine dotnet-runtime-5.0.7-win-x64.exe' and run that, follow install instructions until it is finished and then go to where Commie Client is built to and open the terminal in that folder and run 'wine CommieClient.exe' then it should open up just like it would on windows
