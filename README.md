# BricsCAD Batch Scripter for BricsCAD v24
Overview
The Batch Scripter application allows users to automate the execution of scripts on multiple drawing files. This tool is designed to streamline repetitive tasks in BricsCAD by running scripts across selected drawings efficiently. It creates a script file (.scr) in user's local temporary folder and then run it in the active drawing. It then loops through each drawing file and runs the user defined script.

Features Browse and Select Drawings: Add multiple drawing files to the list for batch processing.
Remove Drawings: Remove selected drawing files from the list.
Browse Script Files: Select a script file to run on the chosen drawings. Multiple script files can be added one by one. Run Script: Execute the selected script on all listed drawings with options to save changes.

User Interface Guide
The main form of the application includes the following components:
Drawing Files List: Displays the list of selected drawing files for script generation and execution.
Browse Drawings Button: Opens a file dialog to add drawing files to the list.
Remove Drawings Button: Removes selected drawing files from the list.
Browse Script Button: Opens a file dialog to select a script file. Script file can be saved in .scr or .txt file format. 
Run Script Button: Executes the selected script on all listed drawings.

Error Handling If an error occurs during any operation, an error message will be displayed with details about the issue. Common errors include file access issues and invalid file formats.
Error Log file is saved to user's local temporary directory.
