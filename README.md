# Requirements Document

## **1\. Introduction**

Richard Riordan and Sarah Naumann have requested the development of a web-based system that allows users to retrieve, modify, and add student information stored in a centralized database. As part of this project, a new database will be designed to store student records, and existing student data will be migrated from a Google Spreadsheet into the new system.

## **1.1 Purpose**

This document outlines the expectations and requirements for the system that Richard and Sarah requested to help with entering student data. This document will cover the functional and non-functional requirements of the system as well as give the clients an insight into our process.

- Create and deploy a system that allows student information to be entered and retrieved, making it easier for staff to view and manage records while complying with FERPA regulations.  
- Create functions that allow users to modify the new database, allowing future additions to the degree.

## **1.2 Background/Scope**

Right now, the client’s process consists of modifying a Google spreadsheet with student information by hand and having trouble finding information within it. The goal is to create a system that gets the information they need with less hassle.

**In Scope:**

- System to retrieve, modify, and add information on a student.  
- System to modify the fields themselves for student information.  
- Database to store the student information.  
- Setting up temporary servers to store data on.

**Out of Scope:**

- Maintenance of servers beyond the term  
- No Mobile support

## **2\. System Overview**

**At a glance the system will be able to:**

- Manage student records  
- Organize student records according to users search query  
- Ideally automatically generate information porting from Banner  
- Have a layout that is easy to read and understand  
- Simple to update and enter records  
- Be accessible on desktop  
- Have the capacity to audit data, restore, and back-up deleted records  
- Able to let admins create users and edit data tables to allow for edits to data

## **3\. User Types and Characteristics**

### **Regular**

- Full read/write permission  
  
  - Frequent use  
  - primary user accounts
  
  ### **Admin**
  
  - Regular \+ create account and delete account  
  - Infrequent use  
  - role is mostly just adding and deleting accounts  

## **4\. Functional Requirements**

*This section covers all of the features that will be included in the program in order for it to function.*

### **4.1 Feature Area: Regular User Features**

*This section covers features available to regular users.*

#### **4.1.1 Data Input**

- Student information that can be inputted  
  - Cohort Year  
  - L Number  
  - Name  
  - Last Update (date)  
  - Address  
    - Street  
    - City  
    - ZIp  
  - Contact Information  
    - Lane Email  
    - Personal Email  
    - Phone Number  
  - Class Grade  
    - Student class grades, including but not limited to:  
    - HIM 107, HIM 120, HIM 125, HIM 154, HIM 160, HIM 183, HIM 200, HIM 210, HIM 222, HIM 225, HIM 230, HIM 241, HIM 242, HIM 260, HIM 270, HIM 271, HIM 273, HP 153, HP 220 (2020), CO-OP 206, HIM 280 Co-op, and HIM 298\.  
  - Notes  
    - Notes about student that may be relevant or helpful  
- Class information that can be inputted  
  - Class Number  
  - Class Prefix  
  - Minimum passing Grade  
- How information can be inputted  
  - Manually with text boxes and menus  
  - Import via Spreadsheet   
  - Import via CSV  

#### **4.1.2 Data Processing**

- Student information can be filtered by any of the students' data categories  
- When student data is updated, the Last Update will show the day it was updated and information can be filtered by last update  
- Student grades can be compared to the minimum passing grade for that class and flagged if below it for a repeat.  
- The number of students who have taken a specific course over a specific period of time.  
- The number of students who pass all classes compared to those who don't.

#### **4.1.3 Data Viewing**

- Data can be viewed as a spreadsheet and filtered by each column  
  - columns   
    - L Number  
    - Name  
    - Last Update  
    - Passing all classes  
- Data can be viewed by student where it will show all information available about that student  
- Reports can be generated to give figures like  
  - Course grade average,   
  - number of students   
    - Passing classes  
    - Failing classes  
    - Can be filtered by date  
  - Student Grade average

## **4.2 Feature Area: Admin Features**

- Admins will be able to add/delete users, update notification templates, edit table for database, and retrieve audit documents.

- Admins will be able to do manual password resets, update logins, update user permissions, and enable/disable accounts.
  
  #### **4.2.1 Create User Account**

- Admin staff can create user accounts by entering required information such as Name, Email, Role and Login Credentials  

- The system must validate required fields before saving the new account.  

- The system should prevent duplicate accounts based on unique identifiers (Email or others)

#### **4.2.2 Edit User Account**

- Admin staff can update user information such as name, email, address or role.  
- Admin should be able to find the user account they wish to edit by searching for (Name, email, role)  
- The system should validate changes before saving.  
- The system must prevent changes that violate system rules (removing the last admin)

#### **4.2.3 Delete User Account**

- Only staff with role Admin can delete a user.   
- The admin should be able to search for a user by: Email, Name, Username or role potentially.   
- The system should display a confirmation prompt before deletion.   
- System prevents deletion of accounts that are required for system operation (admin account) at least 1 person needs to be admin. 

### **4.3 Feature Area: Automated System Processes**

*This section covers automatic tasks the system performs in the background, such as moving data from Moodle into the new database and filling in the correct fields without user input.*

#### **4.3.1 Data Migration from Moodle**

- The migration in the system should import all the required student fields( name, email, phone nr, grades and more)  
- The migration must ensure no duplicate student records are created.   
- The migration must be performed using FERPA-compliant procedures so developers do not access student data.  
- The system should log any issues in the migration process.

## **4.4 Notification Engine**

- The system will only be able to send notifications to students and staff based upon records in the database. It will notify the user to contact specific individuals that are handling data entries.

- Notifications will be sent manually when a database category that is needed to be updated.

- SMS, email, and mail will be the supported channels. Preferences can be updated on these categories

- Admins can update the template and rules for the notification structure

### **4.5 Security Requirements**

This section describes the security measures the system must follow, with a focus on meeting FERPA regulations.

#### **4.5.1 FERPA-Compliant Data Access Control**

- The system must restrict access to student records based on user role.   
- Only authorized staff (Admin) may view full student profiles.   
- Developers must only interact with: Mock Data  
- The system must prevent unauthorized users from: Student names, contact info, academic records, exporting or downloading student data.  
- The system must ensure that production data is never exposed in development environments.  

## **5\. System Interfaces and Integrations**

The system will communicate with an external database as well as possibly Banner. It must be able to both retrieve and send data to the database. Ideally the client would also like to receive information from Banner. We may need to use an API depending on if we can get access to Banner services and if we can use them.

## **6\. Non-Functional Requirements**

*This section outlines the system's performance, usability, reliability, and other quality expectations.* 

## **6.1 Performance Requirements**

#### **6.1.1 System Performance**

- Under normal operating conditions (up to 10 concurrent users), the system shall maintain an average API response time of ≤ 300 milliseconds.  
  
  - Under peak load conditions (20 concurrent users), the system shall maintain:  
    
    - An average API response time of ≤ 500 milliseconds, and  
    - 95% of all API requests complete within 800 milliseconds.
    
    **6.1.2 Database Performance**

- Database queries returning up to 1,000 records shall execute within 1 second under peak load conditions.  

- Search operations on indexed fields (e.g., Student ID, Last Name, L\#) shall return results within 500 milliseconds under normal load.

## **6.2 Reliability and Availability**

- The system shall ensure that all data is stored and retrieved accurately.  
- The system will be able to recognize data corruption and have security measures in place in case they occur. Database and Software will be developed in a manner to mitigate this.  
- The system will be able to handle and log errors that are meaningfully displayed to the user.  
- The system will be able to completely restore data within 4 hours

## **6.3 Security**

The system will have user credentials required to use the system. Some users will be given simply viewing privileges, while others will have the ability to modify the data within. Data encryption would be done automatically through https. The data will have to be compliant with FERPA regulations, and as such, will not give out information beyond the classes themselves.

## **6.4. Scalability**

- The system shall support storage of at least 80,000 student records without requiring architectural redesign.

- The system shall support a minimum of 20 concurrent authenticated users.

- The system architecture shall support the addition of new database tables and columns without requiring major architectural redesign.

- The system shall support at least 20% annual data growth for five years without requiring system re-architecture.

## **7\. Constraints and Assumptions**

**Constraints:**

- Lane will likely not assist us with server hosting and database access.  
  
  - Any funds for the project during development will have to come out of pocket.
    
    **Assumptions:**    

- We will have to find an affordable server host for the site and data that the client can acquire themselves.

## **8\. Acceptance Criteria**

*This section defines the conditions that must be met for the system to be accepted as complete and functioning as intended.* 

### **Definition of Done**

- The system meets all functional requirements and non-functional requirements  
- All core features (data entry, retrieval, admin tools) work as intended.   
- No critical or high-severity bugs remain.  
- The system successfully migrates data and can retrieve it from the database.   
- FERPA-Compliant access restrictions are fully enforced.  
- Data migration from Moodle completes without error or data loss.

### **Validation and Verification**

- **Unit Testing** (Test one small piece of the system at a time.)  
- **Integration Testing** ( Test how multiple parts of the system work together.)  
- **System Testing** (Tests the entire system end-to-end, as if a real user is testing it.)  
- Verification that developers cannot access real student data. 
