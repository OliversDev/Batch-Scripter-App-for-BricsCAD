# Batch Scripter for BricsCAD v24
## Overview
The Batch Scripter application allows users to automate the execution of scripts on multiple drawing files. This tool is designed to streamline repetitive tasks in BricsCAD by running scripts across selected drawings efficiently. It creates a script file (.scr) in user's local temporary folder and then run it in the active drawing. It then loops through each drawing file and runs the user defined script.

## Features
Browse and Select Drawings: Add multiple drawing files to the list for batch processing.</br>
Remove Drawings: Remove selected drawing files from the list.</br>
Browse Script Files: Select a script file to run on the chosen drawings. Multiple script files can be added one by one.</br>
Run Script: Execute the selected script on all listed drawings with options to save changes.</br>

## User Interface Guide
The main form of the application includes the following components:</br>
Drawing Files List: Displays the list of selected drawing files for script generation and execution.</br>
Browse Drawings Button: Opens a file dialog to add drawing files to the list.</br>
Remove Drawings Button: Removes selected drawing files from the list.</br>
Browse Script Button: Opens a file dialog to select a script file. Script file can be saved in .scr or .txt file format.</br>
Run Script Button: Executes the selected script on all listed drawings.</br>

![alt text](./Images/BatchScripterUI.png?raw=true)
</br>
![alt text](./Images/BatchScripterUIExample.png?raw=true)
</br>

## Error Handling
If an error occurs during any operation prior to running a script, an error message will be displayed with details about the issue. Common errors include file access issues and invalid file formats.

## Installation
1. Download the latest released DLL file found in https://github.com/Owack/BricsCAD-Batch-Scripter/tree/master/Release
2. Move the file to a desired directory.
3. Open BricsCAD and run "NETLOAD" command.
4. Browse to the DLL file and load it.
5. Run "OW:BatchScripter" command.

## Details
I recommend running commands in this format:</br>
'(command "Name" ...)'</br>
for example (command "ZOOM" "E")</br>
</br>
instead of:</br>
Zoom</br>Extent</br>
</br>
</br>
Avoid trailing spaces or break lines as this may retrigger the rerun of the Batch Scripter command.</br>
</br>
Windows local temporary folder is by default in C:\Users\\%username%\AppData\Local\Temp</br>
Script file name is "BatchScripter_Script_" & GUID & ".scr"</br>
Error Log file is saved to user's local temporary directory with a file name of "BatchScripter_ErrorLog_" & GUID & ".log"</br>
