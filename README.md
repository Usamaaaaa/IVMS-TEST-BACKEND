# IVMS-TEST-BACKEND  To view Full Read me File open it in Code view
How to Run this Project.

Data Base

I have created a Local Database for this Project.
In order to GET Product Data from Apis 
You need to have a Local db and I have used Sql Server Mangamenet Studio.

Open Sql Server Management Studio.
Connect to the Server 
Add Server Name : (Localdb)\LocalDBDemo
Click Connect

To Create Local DB.

1. Open CMD.
2.Create local Db by entering this command:   sqllocaldb create "LocalDBDemo"
3.Then start local Db : sqllocaldb start"
4.In local db Create A Table with name : Product
5.Add following Columns 
Product_Id	int
title	        nvarchar(50)
description	nvarchar(200)
quantity	int
price	        nchar(10)
category	nvarchar(50)

6. After Creating the table Populate it with Sample Data



Dot Net Backend.

Run this command in Vs Code: dotnet run.
Check the port on which backend end is running from the terminal forexample: http://localhost:5016/swagger/index.html

Angular FrontEnd:

Run npm install or npm i first to install all the dependencies.
Run ng serve to Run Frontend.



Create local Db and populate it with data first inorder to view data in the front end app.
