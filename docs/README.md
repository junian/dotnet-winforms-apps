# Contact Manager

## Brief 
- Contact Manager is a simple WinForms application designed to maintain a list of contacts. It includes functionalities for listing and creating contacts. However, there are a few bugs with this that need to be addressed.
- Below are three tasks to work through, the first is bug fixing and the second two are new features to implement. There are optional tasks that you can work on if you desire. 
- Spend a maximum of two hours on these tasks. It's okay if you can't complete all tasks within this timeframe.

## Setup Instructions
1. Open the solution file (`ContactManager.sln`) in Visual Studio.
2. Build the solution to restore any missing NuGet packages.
3. Run the application.
4. If you get the following error just clean and rebuild - "system.dllnotfoundexception: unable to load dll 'sqlite.interop.dll'"

## GitHub Instructions 
1. Clone this repo
2. When you have completed your changes please share a link to a repo or compressed file with your changes

## Demo



https://github.com/user-attachments/assets/3b4a8b99-f7a8-4e4e-a929-623f099ca00a



## Tasks
1. **Fix the existing Bugs**:
	- [x] Find and fix the existing bugs in the application, these will all be fixed when you can list and add contacts successfully at the moment there are a few bugs preventing you from doing this 

2. **Implement an Edit Form**:
	- [x] Need a new button on the Contact Listing to open a new Edit Form
	- [x] This will open an edit form for the Contact selected on the grid
	- [x] The new form will have fields for all the Contact properties along with a save button
	- [x] When the save is complete it will return to the listing and refresh the grid 
	
3.  **Implement a Contact Import**
	- [x] Create a Contact file import that can be triggered from the Contact Listing form
	- [x] The format of the file can be CSV, XML or **JSON**, you can choose
	- [x] Add some basic validation to ensure the file is valid
	- [x] Provide a confirmation of the import to the user 

## Extra Optional Tasks

1. **Implement a Search Feature**:
	- [x] Add a way of filtering the Contacts on the Contact Listing Form
   
2. **Implement an active flag for Contacts**:
	- [x] Need to be able to filter the contact listing so it only displays contacts that are active

3. **Implement Error Handling and Validation**:
	- [x] Currently none of the forms have any error handling or validation, implement this throughout

