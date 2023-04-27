# Zoo-Management-System-Project
## About Zoo Management System
##### Zoo Management System (ZMS) is a Windows Form application built in C# that allows a zoo to manage assigned work and store relevant animal + employee information. Five functional requirements have been implemented: Startup, Login, AddTask, UpdateTask, and Logout.

## Functional Requirements

##### ZMS uses SQLite to query and store information pertaining to Employees, Animals, and Tasks. As a proof-of-concept, it initializes a clean database file upon startup. It is filled with example entries for demo purposes.

##### Users are able to login either as an employee or elevated admin account. Upon sucessfully logging in, they will be sent to the UpdateMenu and AddTaskMenu pages respectively. Input validation is present so bad data will be stopped on the external side before it is put in any queries. The user's login information is stored into the database.

##### Employees are given assigned tasks to do throughout their employment. Employees will be able to switch between tasks. Upon sucessful completion of the assigned task, employees will mark the task as complete and it will be not be shown on the UpdateMenu page. 

##### Admins will be able to assign tasks to employees. Once submitted, a green text confirmation will notify the admin that the task has been added. Incomplete submissions, such as not filling out the AddTaskMenu completely, will not send a confirmation and will not add the task to the employee.

##### Users are able to log out of their UpdateMenu and AddTaskMenu pages. Upon logging out, a Logout form will appear. The user's logout information is stored into the database. 



