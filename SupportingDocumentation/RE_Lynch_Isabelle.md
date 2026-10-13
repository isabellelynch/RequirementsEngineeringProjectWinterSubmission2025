# Requirements Engineering

Grind Booking System  
Submitted By: Isabelle Lynch (T00264026)  
Computing with Software Development  
Date Submitted: 05/12/2025  

## Table of Contents

- [1 Introduction/overview](#1-introductionoverview)
- [2 Functional Components](#2-functional-components)
- [3 User Requirements](#3-user-requirements)
  - [3.1 GrindBookingSYS will manage the Tutors](#31-grindbookingsys-will-manage-the-tutors)
  - [3.2 GrindBookingSYS will manage the Students](#32-grindbookingsys-will-manage-the-students)
  - [3.3 GrindBookingSYS will manage the Schedule](#33-grindbookingsys-will-manage-the-schedule)
  - [3.4 GrindBookingSYS will manage the Bookings](#34-grindbookingsys-will-manage-the-bookings)
  - [3.5 GrindBookingSYS will perform Administrative Reporting](#35-grindbookingsys-will-perform-administrative-reporting)
- [4 System Requirements](#4-system-requirements)
  - [4.1 System Level Use Case Diagram](#41-system-level-use-case-diagram)
  - [4.2 Manage Tutors](#42-manage-tutors)
    - [4.2.1 Use Case: Add Tutor](#421-use-case-add-tutor)
    - [4.2.2 Use Case: Remove Tutor](#422-use-case-remove-tutor)
    - [4.2.3 Use Case: Display Tutor Details](#423-use-case-display-tutor-details)
    - [4.2.4 Use Case: Update Tutor Details](#424-use-case-update-tutor-details)
    - [4.2.5 Use Case: Validate Tutor Details](#425-use-case-validate-tutor-details)
    - [4.2.6 Use Case: Handle Invalid Tutor Details](#426-use-case-handle-invalid-tutor-details)
  - [4.3 Manage Students](#43-manage-students)
    - [4.3.1 Use Case: Add Student](#431-use-case-add-student)
    - [4.3.2 Use Case: Remove Student](#432-use-case-remove-student)
    - [4.3.3 Use Case: Display Student Details](#433-use-case-display-student-details)
    - [4.3.4 Use Case: Update Student Details](#434-use-case-update-student-details)
    - [4.3.5 Use Case: Validate Student Details](#435-use-case-validate-student-details)
    - [4.3.6 Use Case: Handle Invalid Student Details](#436-use-case-handle-invalid-student-details)
  - [4.4 Manage Schedule](#44-manage-schedule)
    - [4.4.1 Use Case: View Schedule](#441-use-case-view-schedule)
    - [4.4.2 Use Case: Upload Grinds To Schedule](#442-use-case-upload-grinds-to-schedule)
    - [4.4.3 Use Case: Remove Grinds From Schedule](#443-use-case-remove-grinds-from-schedule)
  - [4.5 Manage Bookings](#45-manage-bookings)
    - [4.5.1 Use Case: Make a Booking](#451-use-case-make-a-booking)
    - [4.5.2 Use Case: Cancel a Booking](#452-use-case-cancel-a-booking)
    - [4.5.3 Use Case: View Bookings](#453-use-case-view-bookings)
    - [4.5.4 Use Case: Load Booking Pages](#454-use-case-load-booking-pages)
  - [4.6 Perform Administrative Reporting](#46-perform-administrative-reporting)
    - [4.6.1 Use Case: Perform Yearly Revenue Analysis](#461-use-case-perform-yearly-revenue-analysis)
    - [4.6.2 Use Case: Produce Tutor Earnings Analysis](#462-use-case-produce-tutor-earnings-analysis)
- [5 System Model](#5-system-model)
  - [5.1 Level-0 DFD – System Level](#51-level-0-dfd--system-level)
  - [5.2 Level-1 DFD – System Level](#52-level-1-dfd--system-level)
  - [5.3 Level-2 DFD](#53-level-2-dfd)
  - [5.4 Level-2 DFD (Process P1: Manage Tutors)](#54-level-2-dfd-process-p1-manage-tutors)
  - [5.5 Level-2 DFD (Process P2: Manage Students)](#55-level-2-dfd-process-p2-manage-students)
  - [5.6 Level-2 DFD (Process P3: Manage Schedule)](#56-level-2-dfd-process-p3-manage-schedule)
  - [5.7 Level-2 DFD (Process P4: Manage Bookings)](#57-level-2-dfd-process-p4-manage-bookings)
  - [5.8 Level-2 DFD (Process P5: Perform Administrative Reporting)](#58-level-2-dfd-process-p5-perform-administrative-reporting)
  - [5.9 Level-3 DFD (Process P4.1: Make a Booking)](#59-level-3-dfd-process-p41-make-a-booking)
- [6 Data Model (UML Class Diagram)](#6-data-model-uml-class-diagram)
  - [6.1 Class Diagram](#61-class-diagram)
  - [6.2 Relational Schema](#62-relational-schema)
  - [6.3 Database Schema](#63-database-schema)
- [7 Conclusion](#7-conclusion)

## 1 Introduction/overview

The purpose of this document is to present a comprehensive set of requirements for the Grinds Booking System, a desktop-based application designed to support the efficient management of tutoring services within an educational environment. The system aims to streamline the administration of tutors, students, schedules, bookings and reporting functions, replacing manual or fragmented processes with an integrated, structured solution. By clearly defining the functional and system-level requirements this document provides a foundational blueprint for the design, development and validation of the system.

The Grinds Booking System will support several key stakeholder groups, including managers responsible for daily administration, tutors delivering grinds, students attending the grinds, and business owners requiring high-level operational and financial insights. The system must therefore offer reliable data handling, intuitive user interfaces and robust mechanisms for ensuring data integrity, consistency and traceability across all interactions.

This requirements specification document outlines the systems functional components, user requirements, detailed use case descriptions, data flow diagrams and data models. Each module, Manage Tutors, Manage Students, Manage Schedule, Process Bookings and Perform Administrative Reporting, is defined in depth to ensure that system behaviour is fully understood prior to implementation. The level of detail provided ensures all constraints, business rules and external interactions are captured so that the final system meets the operational expectations of stakeholders and supports future expansion.

## 2 Functional Components

![Functional Components](images/functional-components.png)

## 3 User Requirements

### 3.1 GrindBookingSYS will manage the Tutors

3.1.1. GrindBookingSYS will add a tutor.

3.1.2. GrindBookingSYS will remove a tutor.

3.1.3. GrindBookingSYS will show tutor details.

3.1.4. GrindBookingSYS will update tutor details.

### 3.2 GrindBookingSYS will manage the Students

3.2.1. GrindBookingSYS will add a student.

3.2.2. GrindBookingSYS will remove a student.

3.2.3. GrindBookingSYS will show student details.

3.2.4. GrindBookingSYS will update student details.

### 3.3 GrindBookingSYS will manage the Schedule

3.3.1. GrindBookingSYS will add grinds to the Schedule.

3.3.2. GrindBookingSYS will remove grinds from the Schedule.

3.3.3. GrindBookingSYS will show the grind Schedule.

### 3.4 GrindBookingSYS will manage the Bookings

3.4.1. GrindBookingSYS will make a booking.

3.4.2. GrindBookingSYS will cancel a booking.

3.4.3. GrindBookingSYS will show bookings.

### 3.5 GrindBookingSYS will perform Administrative Reporting

3.5.1. GrindBookingSYS will produce a yearly revenue analysis.

3.5.2. GrindBookingSYS will produce a tutor’s earnings analysis chart.

## 4 System Requirements

The system requirements of the system are presented in this section of the document. The system requirements for the Grinds Booking System will include a Manage Tutors Module, a Manage Students Module, a Manage Schedule Module, a Manage Bookings Module and a Perform Admin Module. The Grinds Booking System will handle all functions as efficiently as possible.

The Manage Tutors Module will handle all tasks relating to Tutors. This module will add a Tutor to the system. This module will remove a Tutor from the system. This module will allow for amendments to be made to a Tutors information. This module will provide an interface for the user to view any Tutors information that he/she may need. This module will also ensure that the data remains in a consistent state by using the Validate Tutor Details function.

The Manage Students Module will handle all tasks relating to Students. This module will add a Student to the system. This module will remove a Student from the system. This module will allow for amendments to be made to a Students information. This module will provide an interface for the user to view any Students information that he/she may need. This module will also ensure that the data remains in a consistent state by using the Validate Student Details function.

The Manage Schedule Module will handle all tasks relating to the Schedule. This module will add a Grind to the Schedule. This module will remove a Grind from the Schedule. This module will provide an interface for the user to view the Schedule information. This module will ensure that all grinds are unique and that no room/tutor can be double booked.

The Manage Bookings Module will handle all tasks relating to Bookings. This module will add a Booking to the system on behalf of a student. This module will cancel a Booking on the system on behalf of a student. This module will provide an interface for the user to view any Students Bookings that he/she may need. This module will process any payments made on Booking and any Refunds due upon cancellation. This module will also ensure that the data remains in a consistent state by using the Validate Student Details function.

The Perform Admin Module will process the administrative requirements requested by the owners of the Grinds Booking System. This module will Generate the yearly revenue figure based on a chosen year and display it. This module will generate a graphical representation of the earnings of all the Tutors on the system.

All Modules will protect referential integrity and entity integrity and ensure that all data remains in a consistent state.

### 4.1 System Level Use Case Diagram

The following system-level use case diagram illustrates the high-level system requirements.

![System Level Use Case Diagram](images/system-use-case-diagram.png)

### 4.2 Manage Tutors

This Module will handle all functions related to the tutors. It will allow the user to add tutors to the system or remove tutors from the system, show the user tutor details upon request and provide a means to update the tutor details when necessary. This Module will interact with the Tutors File to retrieve information and update information within the file. This Module will also interact with the TutorRates File and Subjects File when adding a Tutor to retrieve the appropriate information.

#### 4.2.1 Use Case: Add Tutor

This function adds a tutor to the Grind Booking System. A grind cannot be booked with the tutor until he/she has been added to the system. Their details must be recorded in the Tutors file. A tutor has an associated Tutor Number {TutorID} which identifies them. A tutor also has a Tutor Rate Code {RateCode} which determines the rate of their grinds.

![Use Case: Add Tutor diagram](images/uc-add-tutor.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC001 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function adds a new tutor to the grinds booking system |
| **Preconditions** | The tutor who previously attained the role that the new tutor will now be fulfilling must first be removed. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Add Tutor function. |  |
| 2 |  | Retrieve RateCodes from the TutorRates File |
| 3 |  | Load the RateCodes onto the UI. |
| 4 |  | Retrieve SubjectCodes from the Subjects File. |
| 5 |  | Load the SubjectCodes onto the UI. |
| 6 |  | Display the UI. |
| 7 | Enter the required data:<br>• FirstName<br>• Surname<br>• RateCode<br>• SubjectCode<br>• Email<br>• PhoneNo |  |
| 8 | Confirm the addition of the tutor by clicking the ‘Add Tutor’ button. |  |
| 9 |  | Display a Confirmation Window on the UI: *Has {name} provided proof of his/her Garda Vetting.* |
| 10 | Confirm that the Tutor has provided his/her proof of Garda Vetting Information. |  |
| 11 |  | Invoke the Validate Tutor Details Function. |
| 12 |  | Ensure there isn’t already a Tutor with the same FirstName, Surname combination on the system. |
| 13 |  | Generate the next TutorID value and assign it to this tutor. |
| 14 |  | Save the details in the Tutors File:<br>• FirstName<br>• Surname<br>• TutorID<br>• RateCode<br>• SubjectCode<br>• Email<br>• PhoneNo |
| 15 |  | Display a confirmation message:<br>*Tutor {FirstName Surname} has been successfully added to the Grinds Booking System and has been assigned the TutID of {TutorID}.* |
| 16 |  | Reset the UI. |

#### Alternate Scenarios

**Garda Vetting Proof not supplied**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Confirmation Window answer detected ‘No’. |
| 12 |  | Display an appropriate Error Message:<br>*Error! Unfortunately, a new tutor cannot be added to the system without proof of their Garda Vetting being supplied. Please ensure this document has been submitted and try again.* |
| 13 |  | Return to Step 6. |

**Duplicate Tutor Detected**

| Step | Manager | System |
|:---:|---|---|
| 12 |  | Duplicate FirstName LastName combination detected from the Tutors File. |
| 13 |  | Display an Error Message: *A Tutor {FirstName Surname} has already been added to our records. Please ensure the details you have entered are not ones of a tutor we already have saved before proceeding.* |
| 14 |  | Return to Step 6. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | A tutor has been added to the Grind Booking System. Their details have been recorded in the Tutors file. |
| **Post conditions** | Grinds can now be booked with this tutor. |
| **Business Rules** | The new tutor must be Garda Vetted before being added to the system. |
| **Implementation Constraints** | — |

#### 4.2.2 Use Case: Remove Tutor

This function removes a Tutor from the Grind Booking System. Their details must be removed from the Tutors file. Any future bookings that have been made with the Tutor must be cancelled and all students must be notified of any cancelled grind bookings that had been made with this tutor. Payments that have been made for future bookings with this Tutor must be refunded.

![Use Case: Remove Tutor diagram](images/uc-remove-tutor.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC002 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function removes a tutor from the grinds booking system. |
| **Preconditions** | A tutor must already have been added to the grinds booking system, using the ‘Add Tutor’ use case, to be removed. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Remove Tutor function. |  |
| 2 |  | Retrieve the relevant Tutor Details from the Tutors File.<br>• TutorID<br>• FirstName<br>• Surname |
| 3 |  | Load the retrieved Tutor Details onto the system. |
| 4 |  | Display the Details in a List View box. |
| 5 |  | Fill the selection boxes with the corresponding Tutor Details retrieved in Step 2. |
| 6 |  | Display the UI. |
| 7 | Use the selection boxes to filter through the Tutors. |  |
| 8 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have TutID’s and LastName values that match the FirstName ‘John’ remaining as options.* |
| 9 | Select the appropriate Tutor. |  |
| 10 | Confirm the removal of the selected Tutor by pressing the ‘Remove Tutor’ button. |  |
| 11 |  | Ensure a single Tutor has been selected so he/she can be removed.<br>• TutorID selection box must only contain one value<br>• FirstName selection box must only contain one value<br>• Surname selection box must only contain one value |
| 12 |  | Display a confirmation message-box:<br>*Are you sure you wish to remove {FirstName, Surname} from our system?* |
| 13 | Confirm the removal. |  |
| 14 |  | Remove all information associated with this tutor from the Tutors File:<br>• FirstName<br>• Surname<br>• TutorID<br>• RateCode<br>• SubjectCode<br>• Email<br>• PhoneNo |
| 15 |  | Remove all future grinds from the Schedule File that have a corresponding TutorID to the selected Tutor. |
| 16 |  | Remove all future bookings from the Bookings File that have a corresponding TutorID to the selected Tutor. |
| 16 |  | Notify each Student that corresponds to each of the cancelled bookings, of the cancellation via their Email. |
| 17 |  | Refund any payments made for future bookings with this tutor. |
| 18 |  | Record any refunds in the Refunds File<br>• Generate the next RefundRef and assign it to this transaction<br>• Attach the appropriate StudentID<br>• Attach the appropriate Amount (Found using the selected Tutors RateCode) |
| 19 |  | Display a confirmation message:<br>*Tutor {FirstName Surname} has been successfully removed from the Grinds Booking System.* |
| 19 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Tutor not selected**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Unique Tutor not selected. |
| 12 |  | Display an appropriate error message<br>*A unique tutor must be chosen to remove him/her from the Grinds Booking System, please select a single tutor before continuing.* |
| 13 |  | Reset the UI. |
| 14 |  | Return to Step 6. |

**User Does Not Confirm Removal**

| Step | Manager | System |
|:---:|---|---|
| 13 |  | ‘No’ selected on the Confirmation window indicating the user does not wish to remove this tutor. |
| 14 |  | Reset the UI. |
| 15 |  | Return to Step 6. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | A tutor has been removed from the Grind Booking System. Their details have been removed from the Tutors file.<br>All future grinds with this tutor have been removed from the Schedule File. Any students enrolled in the future grinds will be notified of cancellation via email and will be issued a full refund.<br>The refund has been recorded in the Refunds File. The Cancelled bookings have been removed from the Bookings File. |
| **Post conditions** | Grinds can no longer be booked with this Tutor. |
| **Business Rules** | If grinds must be cancelled due to the removal of a tutor, a full refund must be issued to each student enrolled. |
| **Implementation Constraints** | — |

#### 4.2.3 Use Case: Display Tutor Details

This function allows the details associated with a Tutor to be displayed. Tutors can be identified by their unique identification number {TutorID} or by using their first and last name {FirstName, Surname}. All details will be displayed to the user on a new window.

![Use Case: Display Tutor Details diagram](images/uc-display-tutor-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC003 |
| **Priority** | Low |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function displays all information associated with a particular tutor that is stored in the Tutors File on the Grind Booking System. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke Display Tutor Details function. |  |
| 2 |  | Retrieve the relevant Tutor Details from the Tutors File<br>• TutorID<br>• FirstName<br>• Surname |
| 3 |  | Load the details into the corresponding selection boxes on the UI. |
| 4 |  | Display the UI. |
| 5 | Select the appropriate data fields to identify the tutor that you seek. |  |
| 6 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have TutID’s and LastName values that match the FirstName ‘John’ remaining as options.* |
| 7 | Select the tutor you seek. |  |
| 8 | Click the ‘Show Tutor Details’ button to display the details. |  |
| 9 |  | Ensure a unique tutor has been selected.<br>• TutorID selection box must only contain one item.<br>• FirstName selection box must only contain one item.<br>• Surname selection box must only contain one item. |
| 10 |  | Locate the chosen tutor in the Tutors File. |
| 11 |  | Retrieve the remaining details for the chosen tutor from the Tutors File<br>• RateCode<br>• SubjectCode<br>• Email<br>• PhoneNo |
| 12 |  | Display an Information Window containing the retrieved details:<br>*The Details of the chosen tutor are:*<br>*Tutor ID: {TutorID}*<br>*First Name: {FirstName}*<br>*Surname: {Surname}*<br>*Subject: {SubjectCode}*<br>*Phone Number: {PhoneNo}*<br>*Email Address: {Email}* |
| 13 | OK/Close the message-box. |  |
| 14 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Tutor not selected**

| Step | Manager | System |
|:---:|---|---|
| 9 |  | Unique Tutor not selected. |
| 10 |  | Display an appropriate error message<br>*A unique tutor must be chosen to display his/her details, please select a single tutor before continuing.* |
| 11 |  | Reset the UI. |
| 12 |  | Return to Step 4. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the selected tutor has been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.2.4 Use Case: Update Tutor Details

This function allows the details associated with a Tutor to be updated. Tutors can be identified by their unique identification number {TutorID} or by using their first and last name {FirstName, Surname}. All updates will be saved in the Tutors File and can be viewed via the Display Tutor Details function.

![Use Case: Update Tutor Details diagram](images/uc-update-tutor-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC004 |
| **Priority** | Medium |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function updates details associated with a chosen tutor. |
| **Preconditions** | A Tutor must exist on the system before his/her details can be amended. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Update Tutor Details function. |  |
| 2 |  | Retrieve the relevant details from the Tutors File<br>• TutorID<br>• FirstName<br>• Surname |
| 3 |  | Load them into the corresponding selection boxes on the UI. |
| 4 |  | Display the UI. |
| 5 | Select the appropriate data fields to identify the Tutor that you seek. |  |
| 5 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have TutID’s and LastName values that match the FirstName ‘John’ remaining as options.* |
| 6 | Confirm the details are those of whom you seek by clicking the ‘Find Tutor’ button. |  |
| 7 |  | Ensure a unique tutor has been selected.<br>• TutorID selection box must only contain one item.<br>• FirstName selection box must only contain one item.<br>• Surname selection box must only contain one item. |
| 8 |  | Retrieve the RateCodes from the TutorRates file. |
| 9 |  | Load them into the corresponding selection box. |
| 10 |  | Retrieve the SubjectCodes from the Subjects File. |
| 11 |  | Load them into the corresponding selection box. |
| 12 |  | Locate the chosen Tutor in the Tutors File. |
| 13 |  | Retrieve the remaining details from the Tutors File for the chosen Tutor<br>• RateCode<br>• Email<br>• PhoneNo<br>• SubjectCode |
| 14 |  | Load these details into the corresponding boxes on the UI. |
| 15 |  | Make this section of the UI visible (it is initially hidden on load until a tutor is chosen and found). |
| 16 | Make the necessary changes to the information shown. |  |
| 17 | Confirm these changes by clicking the ‘Update Tutor Details’ button. |  |
| 18 |  | Invoke the Validate Tutor Details Function. |
| 19 |  | Update any changed data in the Tutors file. |
| 20 |  | Save any changes made to the Tutors File. |
| 21 |  | Display a confirmation message:<br>*Tutor {FirstName, LastName}’s details have been successfully updated.* |
| 22 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Tutor Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 7 |  | Unique Tutor not selected. |
| 8 |  | Display an appropriate error message<br>*A unique tutor must be chosen to update his/her details, please select a single tutor before continuing.* |
| 9 |  | Reset the UI. |
| 10 |  | Return to Step 4. |

**Tutor Not Found**

| Step | Manager | System |
|:---:|---|---|
| 12 |  | The chosen Tutor could not be located in the Tutors File. |
| 13 |  | Display an appropriate error message<br>*Tutor could not be found please check that you have the correct tutor details and try again.* |
| 14 |  | Reset the UI. |
| 15 |  | Return to Step 4. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the selected tutor has been updated. Changes made have been saved in the Tutors File. |
| **Post conditions** | The updated data can now be viewed via the Display Tutor Details function. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.2.5 Use Case: Validate Tutor Details

This function validates any details provided before adding or updating a tutor. This function will ensure that data integrity is upheld and that inconsistent data is not saved to the system. This function will invoke the Handle Invalid Tutor Details function if invalid data is detected.

![Use Case: Validate Tutor Details diagram](images/uc-validate-tutor-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC005 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function validates any data provided before adding or updating a tutor. |
| **Preconditions** | — |
| **Trigger** | Add Tutor Function, Update Tutor Details Function |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke Validate Tutor Details Function. |  |
| 2 |  | Retrieve all details associated with the given tutor<br>• TutorID<br>• FirstName<br>• Surname<br>• RateCode<br>• SubjectCode<br>• Email<br>• PhoneNo |
| 3 |  | Validate the data<br>• FirstName must not be empty.<br>• FirstName must be made up of alphabetic characters only.<br>• Surname must not be empty.<br>• Surname must be made up of alphabetic characters only.<br>• RateCode must not be empty<br>• RateCode must match one of the RateCodes from the TutorRates File.<br>• SubjectCode must not be empty.<br>• SubjectCode must match one of the RateCodes from the Subjects File.<br>• Email must not be empty.<br>• Email must be in the correct format<br>• PhoneNo must not be empty.<br>• PhoneNo must be in the correct format: *XXX – XXX XXXX*<br>• PhoneNo must contain only digits and one dash. |
| 4 |  | Confirm the Data has been validated by returning ‘valid’ to the program. |

#### Alternate Scenarios

**Invalid Data Detected**

| Step | Manager | System |
|:---:|---|---|
| 3 |  | Invalid data detected. |
| 4 |  | Determine which item of Data was the first invalid item encountered. |
| 5 |  | Invoke the Handle Invalid Tutor Details Function. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the tutor has been validated. |
| **Post conditions** | The chosen tutor can now be added or updated. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.2.6 Use Case: Handle Invalid Tutor Details

This function handles any errors provided by the Validate Tutor Details function. This function will take the invalid data provided by the Validate Tutor Details Function and it will display an appropriate error message. It will remove the invalid data from the UI and place the user’s cursor in the offending field.

![Use Case: Handle Invalid Tutor Details diagram](images/uc-handle-invalid-tutor-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC006 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function handles any invalid data detected by the Validate Tutor Details Function. |
| **Preconditions** | — |
| **Trigger** | Validate Tutor Details Function |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Handle Invalid Tutor Details Function. |  |
| 2 |  | Retrieve the invalid data information from the Validate Tutor Details Function. |
| 3 |  | Clear the offending field. |
| 4 |  | Place the cursor in the offending field. |
| 5 |  | Display an appropriate Error Message outlining which piece of data was invalid. Example:<br>*“Invalid Data Detected! FirstName must contain only alphabetic characters, no digits or special characters will be accepted. Please re-enter the data and try again.”* |

#### Alternate Scenarios

**Alternate Scenario**

| Step | Manager | System |
|:---:|---|---|

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The user has been notified of his/her mistake. The invalid data has been removed from the UI and the user has been prompted to re-enter the data. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

### 4.3 Manage Students

This Module will handle all functions related to the students. It will allow the user to add students to the system or remove students from the system, show the user students details upon request and provide a means to update the students’ details when necessary. This Module will interact with the Students File to retrieve information and update information within the file.

#### 4.3.1 Use Case: Add Student

This function adds a student to the Grind Booking System. A grind cannot be booked by the student until he/she has been added to the system. Their details must be recorded in the student’s file. A student has an associated Student ID {StudentID} which acts as a unique identifier for them.

![Use Case: Add Student diagram](images/uc-add-student.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC007 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function adds a new student to the grinds booking system. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Add Student function. |  |
| 2 |  | Display the UI. |
| 3 | Enter the required data:<br>• FirstName<br>• Surname<br>• Email<br>• PhoneNo |  |
| 4 | Confirm the addition of the student by clicking the ‘Add Student’ button. |  |
| 5 |  | Invoke the Validate Student Details Function. |
| 6 |  | Ensure this student does not already exist in the Students File. |
| 7 |  | Generate the next StudentID and assign it to this new student. |
| 8 |  | Save the details in the Students File:<br>• FirstName<br>• LastName<br>• StudentID<br>• Email<br>• PhoneNo |
| 9 |  | Display a confirmation message: *Student {FirstName LastName} has been successfully added to the system.* |
| 10 |  | Reset the UI. |

#### Alternate Scenarios

**Duplicate Student Detected**

| Step | Manager | System |
|:---:|---|---|
| 6 |  | Student with matching details located in the Students File. |
| 7 |  | Display an Error Message: *A Student {FirstName LastName} has already been added to our records. Please ensure the details you have entered are not ones of a student we already have saved before proceeding.* |
| 8 |  | Reset the UI. |
| 9 |  | Return to Step 2. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | A student has been added to the Grind Booking System. Their details have been recorded in the Students file. |
| **Post conditions** | Grinds can now be booked for this Student. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.3.2 Use Case: Remove Student

This function removes a student from the Grind Booking System. Their details must be removed from the Students file. Any future bookings that have been made by the student must be cancelled and any refunds owed to the student must be processed.

![Use Case: Remove Student diagram](images/uc-remove-student.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC008 |
| **Priority** | Medium |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function removes a student from the grinds booking system |
| **Preconditions** | A student must already have been added to the grinds booking system, using the ‘Add Student’ use case, to be removed. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke Remove Student function. |  |
| 2 |  | Retrieve the relevant Student Details from the Students File<br>• StudentID<br>• FirstName<br>• Surname |
| 3 |  | Load the retrieved details onto the system. |
| 4 |  | Display all the retrieved details in a List View box. |
| 5 |  | Fill the selection boxes with the corresponding Student Details retrieved in Step 2. |
| 6 |  | Display the UI. |
| 7 | Use the selection boxes to filter through the Students. |  |
| 8 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have StudentID’s and Surname values that match the FirstName ‘John’ remaining as options.* |
| 9 | Select the appropriate Student. |  |
| 10 | Confirm the removal of the selected Student by pressing the ‘Remove Student’ button. |  |
| 11 |  | Ensure a single Student has been selected so he/she can be removed<br>• StudentID selection box must only contain one value<br>• FirstName selection box must only contain one value<br>• Surname selection box must only contain one value |
| 12 |  | Display a confirmation message-box:<br>*Are you sure you wish to remove {FirstName, Surname} from our system?* |
| 13 | Confirm the removal. |  |
| 14 |  | Remove all information associated with this student from the Students File:<br>• FirstName<br>• Surname<br>• StudentID<br>• Email<br>• PhoneNo |
| 15 |  | Cancel all future bookings associated with this student in the Bookings File. |
| 16 |  | Process any refunds due to the student. |
| 17 |  | Record any Refunds in the Refunds File with the appropriate information<br>• Generate the next RefundRef<br>• Use the selected StudentID<br>• Use the Tutor information on the associated booking to get the RateCode to find the appropriate Amount |
| 18 |  | Display a Confirmation Message:<br>*Student {FirstName LastName} successfully removed from the Grinds Booking system.* |
| 19 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Student not selected**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Unique Student not selected. |
| 12 |  | Display an appropriate error message<br>*A unique student must be chosen to remove him/her from the Grinds Booking System, please select a single student before continuing.* |
| 13 |  | Reset the UI. |
| 14 |  | Return to Step 6. |

**User Does Not Confirm Removal**

| Step | Manager | System |
|:---:|---|---|
| 13 |  | ‘No’ selected on the Confirmation window indicating the user does not wish to remove this student. |
| 14 |  | Reset the UI. |
| 15 |  | Return to Step 6. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | A student has been removed from the Grind Booking System. Their details have been removed from the Students file. |
| **Post conditions** | Grinds can no longer be booked for this Student.<br>All future bookings that this student had made will be cancelled and any refunds due will be processed. |
| **Business Rules** | Only bookings cancelled more than 7 days in advance will be refunded. |
| **Implementation Constraints** | — |

#### 4.3.3 Use Case: Display Student Details

This function allows the details associated with a Student to be displayed. Students can be identified by their unique identification number {StudentID} or by using their first and last name {FirstName, LastName}. All details will be displayed to the user in a pop-up information message-box.

![Use Case: Display Student Details diagram](images/uc-display-student-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC009 |
| **Priority** | Low |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function displays all information associated with a particular student that is stored in the Students File on the Grind Booking System. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Display Student Details function. |  |
| 2 |  | Retrieve the relevant Student details from the Students File<br>• StudentID<br>• FirstName<br>• Surname |
| 3 |  | Load the details into the corresponding selection boxes on the UI. |
| 4 |  | Display the UI. |
| 5 | Select the appropriate data fields to identify the student that you seek. |  |
| 6 |  | As the data fields are being selected, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have TutID’s and LastName values that match the FirstName ‘John’ remaining as options.* |
| 7 | Select the unique student that you seek. |  |
| 8 | Click the ‘Show Student Details’ button to display the details. |  |
| 9 |  | Ensure a unique student has been selected<br>• StudentID selection box must only contain one item.<br>• FirstName selection box must only contain one item.<br>• Surname selection box must only contain one item. |
| 10 |  | Locate the chosen student in the Students File. |
| 11 |  | Retrieve the remaining details for the chosen student from the Students File.<br>• Email<br>• PhoneNo |
| 12 |  | Display an Information Window containing the retrieved details:<br>*The Details of the chosen student are:*<br>*Student ID: {StudentID}*<br>*First Name: {FirstName}*<br>*Surname: {Surname}*<br>*Email Address: {Email}*<br>*Phone Number: {PhoneNo}* |
| 13 | OK/Close the message-box. |  |
| 14 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Student Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 9 |  | Unique Student not selected. |
| 10 |  | Display an appropriate error message<br>*A unique student must be chosen to display his/her details, please select a single tutor before continuing.* |
| 11 |  | Reset the UI. |
| 12 |  | Return to Step 4. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the selected student has been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.3.4 Use Case: Update Student Details

This function allows the details associated with a Student to be updated. Students can be identified by their unique identification number {StudentID} or by using their first and last name {FirstName, Surname}. All updates will be saved in the Students File and can be viewed via the Display Student Details function.

![Use Case: Update Student Details diagram](images/uc-update-student-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC010 |
| **Priority** | Medium |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function updates details associated with a chosen student. |
| **Preconditions** | A Student must exist on the system before his/her details can be amended. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Update Student Details function. |  |
| 2 |  | Retrieve the required details from the Students File:<br>• StudentID<br>• FirstName<br>• LastName |
| 3 |  | Load the retrieved details into the corresponding selection boxes on the UI. |
| 4 |  | Display the UI. |
| 5 | Select the appropriate data fields to identify the student that you seek. |  |
| 6 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have StudentID’s and LastName values that match the FirstName ‘John’ remaining as options.* |
| 7 | Confirm the details are those of whom you seek by clicking the ‘Find Student’ button. |  |
| 8 |  | Ensure a unique student has been selected.<br>• StudentID selection box must only contain one item.<br>• FirstName selection box must only contain one item.<br>• Surname selection box must only contain one item. |
| 9 |  | Locate the chosen student in the Students File. |
| 10 |  | Retrieve the required remaining details associated with this student from the Students File<br>• Email<br>• PhoneNo |
| 11 |  | Load these details into the corresponding boxes on the UI. |
| 12 |  | Make this section of the UI visible (it is initially hidden on load until a tutor is chosen and found). |
| 13 | Make the necessary changes to the information shown. |  |
| 14 | Confirm these changes by clicking the ‘Update Student Details’ button. |  |
| 15 |  | Invoke the Validate Student Details Function. |
| 16 |  | Update any changed data in the Students File. |
| 17 |  | Save any changes made to the Students File. |
| 18 |  | Display a confirmation message:<br>*Student {FirstName, LastName}’s details have been successfully updated.* |
| 19 |  | Reset the UI. |

#### Alternate Scenarios

**Unique Student Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 7 |  | Unique Student not selected. |
| 8 |  | Display an appropriate error message<br>*A unique student must be chosen to update his/her details, please select a single tutor before continuing.* |
| 9 |  | Reset the UI. |
| 10 |  | Return to Step 4. |

**Student Not Found**

| Step | Manager | System |
|:---:|---|---|
| 12 |  | The chosen Student could not be located in the Students File. |
| 13 |  | Display an appropriate error message<br>*Student could not be found please check that you have the correct student details and try again.* |
| 14 |  | Reset the UI. |
| 15 |  | Return to Step 4. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the selected student has been updated. Changes made have been saved in the Students File. |
| **Post conditions** | The updated data can now be viewed via the Display Student Details function. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.3.5 Use Case: Validate Student Details

This function validates any details provided before adding or updating a student. This function will ensure that data integrity is upheld and that inconsistent data is not saved to the system. This function will invoke the Handle Invalid Student Details function if invalid data is detected.

![Use Case: Validate Student Details diagram](images/uc-validate-student-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC011 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function validates any data provided before adding or updating a student. |
| **Preconditions** | — |
| **Trigger** | Add Student Function, Update Student Details Function |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke Validate Student Details Function. |  |
| 2 |  | Retrieve all details associated with the given student<br>• StudentID<br>• FirstName<br>• Surname<br>• Email<br>• PhoneNo |
| 3 |  | Validate the data<br>• FirstName must not be empty.<br>• FirstName must be made up of alphabetic characters only.<br>• Surname must not be empty.<br>• Surname must be made up of alphabetic characters only.<br>• Email must not be empty.<br>• Email must be in the correct format<br>• PhoneNo must not be empty.<br>• PhoneNo must be in the correct format: *XXX – XXX XXXX*<br>• PhoneNo must contain only digits and one dash. |
| 4 |  | Confirm the Data has been validated by returning ‘valid’ to the program. |

#### Alternate Scenarios

**Invalid Data Detected**

| Step | Manager | System |
|:---:|---|---|
| 3 |  | Invalid data detected. |
| 4 |  | Determine which item of Data was the first invalid item encountered. |
| 5 |  | Invoke the Handle Invalid Student Details Function. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The data for the student has been validated. |
| **Post conditions** | The chosen student can now be added or updated. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.3.6 Use Case: Handle Invalid Student Details

This function handles any errors provided by the Validate Student Details function. This function will take the invalid data provided by the Validate Student Details Function and it will display an appropriate error message. It will remove the invalid data from the UI and place the user’s cursor in the offending field.

![Use Case: Handle Invalid Student Details diagram](images/uc-handle-invalid-student-details.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC012 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function handles any invalid data detected by the Validate Student Details Function. |
| **Preconditions** | — |
| **Trigger** | Validate Student Details Function |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Handle Invalid Student Details Function. |  |
| 2 |  | Retrieve the invalid data information from the Validate Student Details Function. |
| 3 |  | Clear the offending field. |
| 4 |  | Place the cursor in the offending field. |
| 5 |  | Display an appropriate Error Message outlining which piece of data was invalid. Example:<br>*“Invalid Data Detected! FirstName must contain only alphabetic characters, no digits or special characters will be accepted. Please re-enter the data and try again.”* |

#### Alternate Scenarios

**Alternate Scenario**

| Step | Manager | System |
|:---:|---|---|

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The user has been notified of his/her mistake. The invalid data has been removed from the UI and the user has been prompted to re-enter the data. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

### 4.4 Manage Schedule

This Module handles all functions that relate to and interact with the Grinds Booking Systems Schedule. It will display the Schedule to the user and allow the user to add grinds to the schedule or remove grinds from the schedule. This module will interact directly with the Schedule File, Tutors File, Students File and Bookings File.

#### 4.4.1 Use Case: View Schedule

This function displays the upcoming schedule to the user in chronological order. This function will not display any classes that occurred before the current day. This function will allow the user to click on the TutorID column in the schedule and when clicked, the function will display the corresponding tutor details.

![Use Case: View Schedule diagram](images/uc-view-schedule.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC013 |
| **Priority** | Low |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | Business Owner |
| **Description** | This function displays the Schedule of any upcoming grinds. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the View Schedule function. |  |
| 2 |  | Generate a list view box on the UI. |
| 3 |  | Add the appropriate column headers to the list view box<br>• Date<br>• Time<br>• Max Attendance<br>• Current Enrolment<br>• Room No<br>• Tutor ID |
| 4 |  | Retrieve all schedule item details from the Schedules File |
| 5 |  | Determine which schedule items are from today onwards. |
| 6 |  | Generate a new row in the list view for each item which falls after today’s date. |
| 7 |  | For each schedule item the time and date of the grind is stored as one item, before displaying the system will split this into a separate date and time item. |
| 8 |  | Populate each row with the required data.<br>• Date<br>• Time<br>• Max Attendnace<br>• Current Enrolment<br>• Room No<br>• TutorID |
| 9 |  | Load each row into the list view as it is created. |
| 10 |  | Order the rows in date and time order. |
| 11 |  | Display the UI. |
| 12 |  | Reset the UI. |

#### Alternate Scenarios

**TutorID Clicked**

| Step | Manager | System |
|:---:|---|---|
| 12 |  | TutorID column clicked, indicating that the manager would like to view the selected tutors’ details. |
| 13 |  | Retrieve the TutorID from the column, on the row that has been clicked. |
| 14 |  | Using this TutorID value as a unique identifier, locate this tutor in the Tutors File. |
| 15 |  | Retrieve all relevant details for this tutor from the Tutors File<br>• FirstName<br>• Surname<br>• SubjectCode<br>• PhoneNo<br>• Email |
| 16 |  | Display the retrieved details in a message-box<br>*The details of the tutor with the ID number {TutorID} are*<br>*First Name: {FirstName}*<br>*Surname: {Surname}*<br>*Subject: {SubjectCode}*<br>*Phone Number: {PhoneNo}*<br>*Email Address: {Email}* |
| 17 | OK/Close the message-box. |  |
| 18 |  | Return to Step 11. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The upcoming Schedule has been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.4.2 Use Case: Upload Grinds To Schedule

This function allows the user to upload any upcoming grinds to the schedule. The manager can add as many classes as they would like to the schedule at any given time. A grind cannot be added with a start time outside 9am – 5pm. Every grind is one hour long. Grinds cannot be added on Saturdays or Sundays. The attendance limit must be provided at the time of adding the grind and cannot be less than 1 person or more than 20 people. Room and Tutor details must also be supplied.

![Use Case: Upload Grinds To Schedule diagram](images/uc-upload-grinds-to-schedule.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC014 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function uploads grinds to the schedule. |
| **Preconditions** | The manager must have had the schedule approved by higher management before proceeding with the Upload Grinds To Schedule Function |
| **Trigger** | ‘Add Grind’ button on the View Schedule window. |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Upload Grinds to Schedule function by pressing the ‘Add Grind’ button on the View Schedule window. |  |
| 2 |  | Retrieve all relevant details from the Tutors File<br>• TutorID<br>• FirstName<br>• Surname |
| 3 |  | Load these details into the ‘Tutor’ selection box on the UI. |
| 4 |  | Load the room numbers into the ‘RoomNo’ selection box on the UI. |
| 5 |  | Ensure the ‘Time’ selection box only holds the numeric values between 9 and 17 for the hours. |
| 6 |  | Ensure the ‘Time’ selection box’s minutes cannot be altered as every grind must start on the hour and must be one hour long. |
| 7 |  | Ensure no dates before todays date are loaded into the ‘Date’ selection box. |
| 8 |  | Display the UI. |
| 9 | Enter the required data into the fields provided on the UI. |  |
| 10 | Click the ‘Add Grind’ button to add the grind to the system. |  |
| 11 |  | Validate the data<br>• Ensure time selected is between 9am and 5pm<br>• Ensure date selected is in the future<br>• Ensure date selected is not a Saturday or Sunday<br>• Ensure Attendance limit entered is numeric<br>• Ensure attendance limit is between 1 and 20 inclusive<br>• Ensure RoomNo is selected<br>• Ensure Tutor is selected<br>• Ensure the selected Tutor does not have a grind at the time selected.<br>• Ensure the selected room is not occupied at the time selected.<br>• Ensure a grind with the same date, time and tutor does not already exist in the system. |
| 12 |  | Create a new Schedule item with the details supplied. |
| 13 |  | Save the Schedule item to the Schedule File. |
| 14 |  | Display a message box with an appropriate message<br>*New Grind has Successfully been added to the system* |
| 15 |  | Reset the UI. |
| 16 |  | Return to the view Schedule Function. |

#### Alternate Scenarios

**Invalid Time Detected.**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Invalid time detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Time entered must be between 9am and 5pm, please re-enter.* |
| 13 |  | Clear the offending field |
| 14 |  | Place the cursor in the offending field. |
| 15 |  | Return to Step 9. |

**Invalid Date Detected – Date before today’s date selected**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Invalid date detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Date entered must be in the future, please re-enter.* |
| 13 |  | Clear the offending field |
| 14 |  | Place the cursor in the offending field. |
| 15 |  | Return to Step 9. |

**Invalid Day Detected – date chosen falls on a Saturday or Sunday**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Invalid day detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Day chose cannot be a Saturday or Sunday, please re-enter.* |
| 13 |  | Clear the offending field |
| 14 |  | Place the cursor in the offending field. |
| 15 |  | Return to Step 9. |

**Invalid Attendance Limit Detected.**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Invalid attendance limit detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Attendance limit entered must be numeric and be between 1 and 20 inclusive, please re-enter.* |
| 13 |  | Clear the offending field |
| 14 |  | Place the cursor in the offending field. |
| 15 |  | Return to Step 9. |

**Room No not selected**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | No Room No detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Room number must be selected, please try again.* |
| 13 |  | Place the cursor in the offending field. |
| 14 |  | Return to Step 9. |

**Tutor not selected**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | No tutor detected. |
| 12 |  | Display an Error Message:<br>*Invalid! Tutor must be selected, please try again.* |
| 13 |  | Place the cursor in the offending field. |
| 14 |  | Return to Step 9. |

**Tutor already booked**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Tutor selected already has a booking at the time chosen |
| 12 |  | Display an Error Message:<br>*Invalid! Chosen tutor already booked at this time, please choose another time and try again.* |
| 13 |  | Clear the time field. |
| 14 |  | Place the cursor in the time field. |
| 15 |  | Return to Step 9. |

**Room occupied**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | Room selected already has a booking at the time chosen |
| 12 |  | Display an Error Message:<br>*Invalid! Chosen room already booked at this time, please choose another time and try again.* |
| 13 |  | Clear the time field. |
| 14 |  | Place the cursor in the time field. |
| 15 |  | Return to Step 9. |

**Grind already exists**

| Step | Manager | System |
|:---:|---|---|
| 11 |  | A Grind with the same details already exists in the Schedule File. |
| 12 |  | Issue a warning message to the user<br>*This grind will not be added to the system as a grind with the same details already exists on the system, please ensure you have the correct details and try again.* |
| 13 |  | Clear the UI. |
| 14 |  | Return to Step 9. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The upcoming Schedule has been updated. |
| **Post conditions** | Grinds added can now be booked.<br>Grinds added can now be viewed on the Schedule. |
| **Business Rules** | Classes can only be added between the hours of 9:00 and 17:00, Monday - Friday.<br>Maximum number of students per class is 20. Minimum number of students per class is 1. |
| **Implementation Constraints** | — |

#### 4.4.3 Use Case: Remove Grinds From Schedule

This function allows the manager to remove grinds from the schedule. It will display the current schedule and allow the manager to choose which grind they would like to remove, only one grind can be removed at a time. It will alter the Schedule File and save any changes made. It will notify any students, who had booked the grind, of the cancellation via Email and process any refunds due to them.

![Use Case: Remove Grinds From Schedule diagram](images/uc-remove-grinds-from-schedule.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC015 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function removes grinds from the schedule. This function handles any administrative tasks that must be performed upon removal of a grind from the Grinds Booking System. |
| **Preconditions** | Reason for removing grinds must be approved by higher management before proceeding. |
| **Trigger** | ‘Remove Grind’ button on the View Schedule window. |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Remove Grinds from Schedule function by clicking the ‘Remove Grind’ button on the View Schedule window. |  |
| 2 |  | Generate a list view box on the UI. |
| 3 |  | Add the appropriate column headers to the list view box<br>• Date<br>• Time<br>• Room No<br>• Tutor ID |
| 4 |  | Retrieve all relevant schedule item details from the Schedules File |
| 5 |  | Determine which schedule items are from today onwards. |
| 6 |  | Generate a new row in the list view for each item which falls after today’s date. |
| 7 |  | For each schedule item the time and date of the grind is stored as one item in the system, before displaying the UI the system will split this into a separate date item and a time item. |
| 8 |  | Populate each row with the required data.<br>• Date<br>• Time<br>• Room No<br>• TutorID |
| 9 |  | Load each row into the list view as it is created. |
| 10 |  | Order the rows in date and time order. |
| 11 |  | Display the UI. |
| 12 | Select the grind that you would like to remove from the system by clicking it in the list view. |  |
| 13 | Confirm your selection by clicking the ‘Remove Grind’ button. |  |
| 14 |  | Ensure that a grind has been selected. |
| 15 |  | Ensure that the grind is more than 7 days in the future otherwise, ensure the current enrolment is less than 1. |
| 16 |  | Locate the selected grind in the Schedule File. |
| 17 |  | Remove the selected grind from the Schedule File. |
| 18 |  | Save the changes made to the Schedule File. |
| 19 |  | Notify all students associated with the selected grind of its cancellation via email. (Use the students array connected to the selected grind to get each students StudentID, this StudentID can be used to locate each students Email address in the Students File). |
| 20 |  | Process any refunds due to the students associated with the selected grind. |
| 21 |  | Generate a new RefundRef for each refund owed. |
| 22 |  | Create a new Refund item for each refund owed using the appropriate details.<br>• RefundRef (generated in Step 20)<br>• StudentID<br>• Amount (determined by using the TutorID associated with the grind to locate the Tutor in the Tutors File and then using the corresponding RateCode to determine the amount paid for the grind.) |
| 23 |  | Record these refunds in the Refunds File. |
| 24 |  | Remove all Booking associated with this grind from the Bookings File. |
| 25 |  | Display a message-box with an appropriate message<br>*Grind removed successfully from the Grinds Booking System, Thank you!* |
| 26 |  | Reset the UI. |

#### Alternate Scenarios

**No Grind Selected**

| Step | Manager | System |
|:---:|---|---|
| 14 |  | No grind has been selected before the user clicked the ‘Remove Grind’ button. |
| 15 |  | Generate an appropriate error message<br>*A grind must be selected to remove it from the system, please select a grind before continuing.* |
| 16 |  | Return to Step 11. |

**Violation detected**

| Step | Manager | System |
|:---:|---|---|
| 16 |  | The grind selected is less than 7 days away and the current enrolment is more than 0. |
| 17 |  | Generate an appropriate error message<br>*You can only remove a grind that is less than 7 days away if it has no students enrolled, please check with higher management if this grind must be removed.* |
| 18 |  | Reset the UI. |
| 19 |  | Return to Step 11. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The upcoming Schedule has been updated and changes made have been saved in the Schedule File.<br>All Students associated with the cancelled grind have been notified of its cancellation.<br>All refunds due have been processed and recorded in the Refunds File.<br>All Bookings made for this grind have been removed from the Bookings File. |
| **Post conditions** | This grind can no longer be booked. This grind will no longer be displayed on the Schedule. |
| **Business Rules** | A grind cannot be removed from the system with less than 7 days’ notice unless it has no bookings. |
| **Implementation Constraints** | — |

### 4.5 Manage Bookings

This Module will handle all functions related to the bookings. It will allow the user to add a booking to the system or remove a booking from the system and show the user upcoming bookings details upon request. This Module will interact with the Bookings File, Students File, Refunds File and Schedule File to retrieve and update information within the files.

#### 4.5.1 Use Case: Make a Booking

This function allows the manager to make a booking on behalf of a student. The student must contact the practice to make a booking. The manager will take payment at the time of making a booking. This function will interact with the Bookings File, Schedule File, Tutors File, Students File and TutorRates File. This function will update the files mentioned accordingly.

![Use Case: Make a Booking diagram](images/uc-make-a-booking.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC016 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | Student |
| **Description** | This function books a grind for a student. |
| **Preconditions** | The student must exist on the Grinds Booking System for a booking to be made on their behalf. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Make a Booking function. |  |
| 2 |  | Invoke the Load Bookings Pages Function. |
| 3 |  | Retrieve the relevant details from the Schedule File<br>• DateTime<br>• MaxAttendance<br>• CurrentEnrollment<br>• RoomNo<br>• TutorID |
| 4 |  | The DateTime attribute will be formatted for each booking so that it will be split into two separate items<br>• Date<br>• Time |
| 5 |  | Generate a list view box on the UI. |
| 6 |  | Add the appropriate column headings to the list box<br>• Date<br>• Time<br>• MaxAttendance<br>• CurrentEnrollment<br>• RoomNo<br>• TutorID |
| 7 |  | Each schedule item will be tested to ensure that it is after today’s date before being displayed, this function will only allow bookings to be made if the grind is in the future. |
| 8 |  | Generate a row in the list view box for each schedule item and populate it with the appropriate information<br>• Date<br>• Time<br>• MaxAttendance<br>• CurrentEnrollment<br>• RoomNo<br>• TutorID |
| 9 |  | Order the list view rows in chronological order. (Date, Time) |
| 10 |  | Make this section of the UI visible (it is initially hidden on load until a tutor is chosen and found). |
| 11 | Select the grind that needs to be booked on the chosen students’ behalf. |  |
| 12 | Confirm the selection by clicking the ‘Make Booking’ button. |  |
| 13 |  | Ensure a row in the list view box has been selecting, i.e. A single schedule item has been selected. |
| 14 |  | Ensure that the current enrolment of the chosen schedule item is less than the max attendance. |
| 15 |  | Increment the current enrolment of the chosen booking by 1. |
| 16 |  | Display a message box to confirm that payment has been received<br>*Has student {FirstName, Surname} provided payment for this grind?* |
| 17 | Confirm the payment has been received by pressing YES. |  |
| 18 |  | Ensure the user has clicked YES on the confirmation window. |
| 19 |  | Locate the student in the Students File that corresponds to the chosen student in the selection boxes using the StudentID from the StudentID selection box. |
| 20 |  | Ensure the Student does not already exist in the Students Array of the Schedule Item in the Schedule File. |
| 21 |  | Add the details of this student to the Students Array of the Schedule Item in the Schedule File.<br>• StudentID<br>• FirstName<br>• Surname<br>• Email<br>• PhoneNo |
| 22 |  | Save any changes made to the Schedule File. |
| 23 |  | Locate the chosen tutor for the new grind in the Tutors File, using the TutorID from the selected grind. |
| 24 |  | Use the chosen Tutors Rate Code to determine the cost of the grind from the TutorRates File. |
| 25 |  | Generate the next BookingRef. |
| 26 |  | Generate a new booking using the information generated above<br>• BookingRef<br>• StudentID<br>• DateOfBooking<br>• GrindTime<br>• TutorID<br>• Amount |
| 27 |  | Add the new booking to the Bookings File. |
| 28 |  | Save any changes made to the Bookings File. |
| 29 |  | Add the new booking to the selected students Bookings Array in the Students File. |
| 30 |  | Save any changes made to the Students File. |
| 31 |  | Generate an email message to the student to notify him/her of the booking. |
| 32 |  | Display a message box to confirm the new booking<br>*This grind has been successfully booked for student {FirstName, Surname}* |
| 33 |  | Reset the UI. |

#### Alternate Scenarios

**Grind Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 13 |  | No grind selected prior to clicking the ‘Make Booking’ button. |
| 14 |  | Display an appropriate error message<br>*A grind must be selected to make a booking, please try again.* |
| 15 |  | Return to Step 20. |

**Grind Fully Booked**

| Step | Manager | System |
|:---:|---|---|
| 14 |  | When checked the MaxAttendance was equivalent to the current enrolment. |
| 15 |  | Generate an appropriate error message<br>*The grind you have selected is fully booked, please choose a different grind.* |
| 16 |  | Return to Step 20. |

**Grind has been filled**

| Step | Manager | System |
|:---:|---|---|
| 15 |  | When the selected student was added to the class the class is now full. |
| 16 |  | Display an information pop-up to let the user know this grind is now full<br>*Just to let you know, by adding this student to the class list you have filled this grind and no more students can be added.* |
| 17 |  | Return to Step 26. |

**Payment Not Confirmed**

| Step | Manager | System |
|:---:|---|---|
| 18 |  | ‘NO’ detected as the result of the confirmation window indicating that the student has not provided payment. |
| 19 |  | Display an appropriate error message<br>*Error! Student cannot book a grind without providing payment at the time of booking.* |
| 20 |  | Decrement the current enrolment by 1. |
| 21 |  | Return to Step 20. |

**Student Already Booked Chosen Grind**

| Step | Manager | System |
|:---:|---|---|
| 20 |  | Selected Student found in the Students List of the chosen grind in the Schedule File. |
| 21 |  | Display an appropriate error message<br>*The student you have chosen has already booked this grind.* |
| 22 |  | Reset the UI. |
| 23 |  | Return to Step 9. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The grind has been booked for the student.<br>The student has paid for the grind.<br>The Bookings File, Schedule File and Students File have been updated accordingly. |
| **Post conditions** | The student may now attend this grind. |
| **Business Rules** | A class cannot be booked for a student unless payment is processed. |
| **Implementation Constraints** | — |

**Activity Diagram – Make a Booking**

![Use Case: Make a Booking](images/image1.png)

#### 4.5.2 Use Case: Cancel a Booking

This function allows the manager to cancel a booking on behalf of a student. The student must contact the practice to cancel a booking. This function will also handle any administrative tasks associated with cancelling a booking. This function will interact with the Bookings File, Schedule File, Tutors File, Refunds File and Students File.

![Use Case: Cancel a Booking diagram](images/uc-cancel-a-booking.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC017 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | Student |
| **Description** | This function cancels a booking for a student. This function handles all administrative tasks associated with the cancelation of a booking. This function will handle Refunds if necessary. |
| **Preconditions** | The booking must have already been made for it to be cancelled. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Cancel a Booking function. |  |
| 2 |  | Invoke the Load Booking Pages function. |
| 3 |  | The DateOfBooking attribute will be formatted for each booking in the selected students list of bookings, so that it will only represent the date in the format MM/DD/YYYY |
| 4 |  | The GrindTime attribute will be formatted for each booking in the selected students list of bookings, so that it will only represent the start time of the grind in the format HH:MM |
| 5 |  | Generate a list view box on the UI. |
| 6 |  | Add the appropriate column headings to the list box<br>• Booking Date<br>• Grind Time<br>• Booking Reference<br>• TutorID<br>• Amount |
| 7 |  | Each booking item in the selected students list of bookings, will be tested to ensure that it is after today’s date before being displayed, this function will only allow bookings to be displayed if the grind is in the future. |
| 8 |  | Generate a row in the list view box for each booking item and populate it with the appropriate information<br>• DateOfBooking<br>• GrindTime<br>• BookingRef<br>• TutorID<br>• Amount |
| 9 |  | Order the list view rows in chronological order. (Date, Time) |
| 10 |  | Make this section of the UI visible (it is initially hidden on load until a tutor is chosen and found). |
| 11 | Select the grind that needs to be cancelled on the chosen students’ behalf. |  |
| 12 | Confirm the selection by clicking the ‘Cancel Booking’ button. |  |
| 13 |  | Ensure a row in the list view box has been selected, i.e. A single booking has been selected. |
| 14 |  | Using the selected booking locate the corresponding schedule item in the Schedule File. |
| 15 |  | Decrement the current enrolment of the schedule item by 1 in the Schedule File. |
| 16 |  | Remove the selected Student from the students list of the associated Schedule Item. |
| 17 |  | Save any changes made to the Schedule File. |
| 18 |  | Remove the chosen booking from the Bookings List associated with the chosen student in the Students File. |
| 19 |  | Save the changes made to the Students File. |
| 20 |  | Remove the chosen booking from the Bookings File. |
| 21 |  | Save any changes made to the Bookings File. |
| 22 |  | Check that the grind was 7 or more days away. |
| 23 |  | Generate the next RefundRef. |
| 24 |  | Generate a new Refund item with the details from above<br>• RefundRef<br>• StudentID<br>• Amount |
| 25 |  | Add this Refund item to the Refunds File. |
| 26 |  | Save any changes made to the Refunds File. |
| 27 |  | Generate an email message to the selected student confirming the cancellation. |
| 28 |  | Display a confirmation message<br>*Your selected Booking has now been cancelled, if a refund was due, it will be processed.* |
| 29 |  | Reset the UI. |

#### Alternate Scenarios

**Booking Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 13 |  | No booking selected prior to clicking the ‘Cancel Booking’ button. |
| 14 |  | Display an appropriate error message<br>*A grind must be selected to cancel a booking, please try again.* |
| 15 |  | Return to Step 10. |

**Grind less than 7 days away – Student still cancels**

| Step | Manager | System |
|:---:|---|---|
| 22 |  | The grind that the booking is being cancelled for has been detected as being less than 7 days away. |
| 23 |  | Display an appropriate information message<br>*Note: No refund will be granted for this cancellation as it is less than 7 days away, would you like to proceed with the cancellation?* |
| 24 | Confirm the cancellation by clicking OK on the message-box. |  |
| 25 |  | Continue from Step 27. |

**Grind less than 7 days away – Student doesn’t cancel**

| Step | Manager | System |
|:---:|---|---|
| 22 |  | The grind that the booking is being cancelled for has been detected as being less than 7 days away. |
| 23 |  | Display an appropriate information message<br>*Note: No refund will be granted for this cancellation as it is less than 7 days away, would you like to proceed with the cancellation?* |
| 24 | User clicks ‘cancel’ on the message-box. |  |
| 25 |  | ROLLBACK |
| 26 |  | Return to Step 6. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The grind has been cancelled for the student.<br>If a refund was due, it has been processed and recorded in the Refunds File. |
| **Post conditions** | The student can no longer attend the cancelled grind. |
| **Business Rules** | If a cancellation is requested with over 7 days’ notice, a full refund will be granted.<br>Otherwise, no refund will be granted. |
| **Implementation Constraints** | — |

#### 4.5.3 Use Case: View Bookings

This function allows the user to view all bookings for a selected Student. This function will interact with the Students File.

![Use Case: View Bookings diagram](images/uc-view-bookings.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC018 |
| **Priority** | Low |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | Student |
| **Description** | This function displays the bookings for a selected student. |
| **Preconditions** | The student must exist on the Grinds Booking System to view his/her bookings. |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the View Bookings function. |  |
| 2 |  | Invoke the Load Booking Pages function. |
| 3 |  | Retrieve the Bookings List from the Students File that corresponds with the chosen Student. |
| 4 |  | The DateOfBooking attribute will be formatted for each booking in the selected students list of bookings, so that it will only represent the date in the format MM/DD/YYYY |
| 5 |  | The GrindTime attribute will be formatted for each booking in the selected students list of bookings, so that it will only represent the start time of the grind in the format HH:MM |
| 6 |  | Generate a list view box on the UI. |
| 7 |  | Add the appropriate column headings to the list box<br>• Booking Date<br>• Grind Time<br>• Booking Reference<br>• TutorID<br>• Amount |
| 8 |  | Generate a row in the list view box for each booking item and populate it with the appropriate information<br>• DateOfBooking<br>• GrindTime<br>• BookingRef<br>• TutorID<br>• Amount |
| 9 |  | Order the list view rows in chronological order. (Date, Time) |
| 10 |  | Make this section of the UI visible (it is initially hidden on load until a tutor is chosen and found). |
| 11 |  | Reset the UI upon exit/refresh/return. |

#### Alternate Scenarios

**Alternate Scenario**

| Step | Manager | System |
|:---:|---|---|

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The Bookings for the selected Student have been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.5.4 Use Case: Load Booking Pages

This function loads the relevant Student details on the UI and fills the corresponding selection boxes with said details. This function is used within the Add Booking, Remove Booking and View Bookings Modules

![Use Case: Load Booking Pages diagram](images/uc-load-booking-pages.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC019 |
| **Priority** | High |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | Student |
| **Description** | This function loads the selection boxes and the relevant information for those boxes onto the UI. This function ensures the user has only selected one students details and returns these to the parent function. |
| **Preconditions** | — |
| **Trigger** | The invoking of the Add Booking Function, Remove Booking Function and View Bookings Function. |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Load Bookings Pages function. |  |
| 2 |  | Retrieve all relevant details from the Students File<br>• StudentID<br>• FirstName<br>• Surname |
| 3 |  | Load the StudentID values into the Student ID selection box. |
| 4 |  | Load the FirstName values into the First Name selection box. |
| 5 |  | Load the Surname values into the Surname selection box. |
| 6 |  | Display the UI. |
| 7 | Use the selection boxes to filter through the Students. |  |
| 8 |  | As the data fields are being filled, filter out the data to match what has been entered. Example:<br>*If FirstName ‘John’ is selected, only have StudentID’s and Surname values that match the FirstName ‘John’ remaining as options.* |
| 9 | Select the appropriate Student. |  |
| 10 | Confirm your selection by pressing the button on the UI. |  |
| 11 |  | Ensure all selection boxes can no longer be altered. |
| 12 |  | Ensure a single Student has been selected so a booking can be made on his/her behalf<br>• StudentID selection box must only contain one value<br>• FirstName selection box must only contain one value<br>• Surname selection box must only contain one value |
| 13 |  | Return the chosen student details to the function that has called the Load Bookings Pages Function. |

#### Alternate Scenarios

**Single Student Not Selected**

| Step | Manager | System |
|:---:|---|---|
| 12 |  | More than one option detected in one or more of the selection boxes after clicking the ‘Show Bookings’ button. |
| 13 |  | Display an appropriate error message<br>**If the Add Booking function is being called:**<br>*A single unique student must be selected before continuing with the booking, please ensure you have the correct student details and try again*<br>**If the Remove Booking function is being called:**<br>*A single unique student must be selected before continuing with the cancellation, please ensure you have the correct student details and try again*<br>**If the View Bookings function is being called:**<br>*A single unique student must be selected before continuing to view their bookings, please ensure you have the correct student details and try again* |
| 14 |  | Reset the UI. |
| 15 |  | Return to Step 6. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | A Single student has been selected. His/her details have been retrieved and returned. |
| **Post conditions** | The function that called this function can now proceed with its tasks using the selected students details. |
| **Business Rules** | — |
| **Implementation Constraints** | — |

### 4.6 Perform Administrative Reporting

This module will handle all administrative functions. This module will interact with the Bookings File, Refunds File and Tutors File to generate a yearly revenue analysis and to generate a graphical report on Tutors Earnings.

#### 4.6.1 Use Case: Perform Yearly Revenue Analysis

This function generates a summary of the yearly revenue for a selected year. This function will retrieve all of the Payments made and Refunds processed for a given year and display the total revenue for that year to the user.

![Use Case: Perform Yearly Revenue Analysis diagram](images/uc-perform-yearly-revenue-analysis.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC020 |
| **Priority** | Medium |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function displays the yearly revenue for a selected year. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Perform Yearly Analysis function. |  |
| 2 |  | Generate the year values from the year of business opening to this year. |
| 3 |  | Load the values generated in Step 2 into the ‘Year’ selection box on the UI. |
| 4 |  | Display the UI. |
| 5 | Select the year for which you would like to see the Yearly Revenue. |  |
| 6 | Confirm Selection by clicking the ‘Show Total Yearly Revenue’ button. |  |
| 7 |  | Ensure a year value has been selected. |
| 8 |  | Retrieve all Bookings from the Bookings File where the date falls in the selected year. |
| 9 |  | Create a new Total item and let its value = 0 |
| 10 |  | For every Booking in the retrieved Bookings add its ‘Amount’ value to the new Total item. |
| 11 |  | Display an information message-box with an appropriate message<br>*Total Revenue for the year {YYYY} is €{Total}* |
| 12 |  | Reset the UI. |

#### Alternate Scenarios

**Alternate Scenario**

| Step | Manager | System |
|:---:|---|---|

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The Yearly Revenue Figure has been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

#### 4.6.2 Use Case: Produce Tutor Earnings Analysis

This function generates a graphical representation of the revenue earned by each tutor. This function interacts with the Bookings File to produce a bar graph to represent the total earnings of each tutor since working at the practice.

![Use Case: Produce Tutor Earnings Analysis diagram](images/uc-produce-tutor-earnings-analysis.png)

| Field | Details |
|---|---|
| **Use Case Id** | UC021 |
| **Priority** | Medium |
| **Source** | Manager |
| **Primary Business Actor** | Manager |
| **Other Participating Actors** | — |
| **Description** | This function generates a graphical representation of the revenue earned by each tutor. |
| **Preconditions** | — |
| **Trigger** | — |

#### Expected Scenario

| Step | Manager | System |
|:---:|---|---|
| 1 | Invoke the Produce Tutor Earnings Analysis function. |  |
| 2 |  | Retrieve details from the Tutors File<br>• FirstName<br>• TutorID |
| 3 |  | Retrieve relevant details from the Bookings File<br>• Amount<br>• TutorID |
| 4 |  | Create a bar chart item. |
| 5 |  | Set the bar chart Title to ‘Tutor Earnings Analysis’ |
| 6 |  | Set the X-Axis title to ‘Tutor First Name’ |
| 7 |  | Set the Y-Axis title to ‘Earnings €’ |
| 8 |  | Generate a new Total item and let its value = 0 |
| 9 |  | Go through the Tutors one by one. |
| 9 |  | Load the bar chart onto the UI. |
| 10 |  | Go through every Booking retrieved and if its associated TutorID matches the current Tutor that is being calculated, add the ‘Amount’ to the ‘Total’ item. |
| 10 |  | Display the UI. |
| 11 |  | Add a new bar to the bar chart with the following information<br>• Y-axis value is the Tutor FirstName<br>• Bar Height will be the Total Value. |
| 11 |  | Reset the UI upon exit/refresh/return. |
| 12 |  | Repeat Steps 8 - 11 for each Tutor retrieved. |

#### Outcomes

| Field | Details |
|---|---|
| **Conclusions** | The Yearly Revenue Analysis has been displayed. |
| **Post conditions** | — |
| **Business Rules** | — |
| **Implementation Constraints** | — |

## 5 System Model

The following dataflow diagrams have been produced for the system:

### 5.1 Level-0 DFD – System Level

![Level-0 DFD – System Level](images/image2.png)

### 5.2 Level-1 DFD – System Level

![Level-1 DFD – System Level](images/image3.png)

### 5.3 Level-2 DFD

### 5.4 Level-2 DFD (Process P1: Manage Tutors)

![Level-2 DFD (Process P1: Manage Tutors)](images/image4.png)

### 5.5 Level-2 DFD (Process P2: Manage Students)

![Level-2 DFD (Process P2: Manage Students)](images/image5.png)

### 5.6 Level-2 DFD (Process P3: Manage Schedule)

![Level-2 DFD (Process P3: Manage Schedule)](images/image6.png)

### 5.7 Level-2 DFD (Process P4: Manage Bookings)

![Level-2 DFD (Process P4: Manage Bookings)](images/image7.png)

### 5.8 Level-2 DFD (Process P5: Perform Administrative Reporting)

![Level-2 DFD (Process P5: Perform Administrative Reporting)](images/image8.png)

### 5.9 Level-3 DFD (Process P4.1: Make a Booking)

![Level-3 DFD (Process P4.1: Make a Booking)](images/image9.png)

## 6 Data Model (UML Class Diagram)

The following data model has been produced for the Grinds Booking System. In the UML Class Diagram the relationships between the entities within the system are illustrated.

We can clearly see that a Tutor can have one or more Schedule items associated with him/her. A tutor must have one, and only one, Subject associated with him/her. The business rules of the Grinds Booking System state that each Tutor must specialize in only one subject so that he/she can give his/her all to that one subject and the students get the best education possible. Equally, a Tutor must have one, and only one, RateCode item associated with him/her. A Schedule item may have none or many students associated with it, this is because when a Schedule item is created it has no students enrolled but over time the aim is to fill the Schedule items to their capacity (MaxAttendance). A Student will begin with zero Booking items associated with him/her but can have many Booking items. A Student will also begin with zero Refund items and may never have any Refund items, or he/she may end up with many Refund items.

I have also developed a bracket notation relational schema for the Grinds Booking System outlining the different entities that would be stored in the database for this system and their attributes. Along with this, a database scheme has been developed which outlines the entities and their attributes again, along with the datatype of the attributes and the primary and foreign key relationships within the entities.

### 6.1 Class Diagram

![Class Diagram](images/image10.png)

### 6.2 Relational Schema

Tutor (<ins>TutorID</ins>, FirstName, Surname, RateCode, SubjectCode, Email, PhoneNo)

TutorRate (<ins>RateCode</ins>, HourlyRate, Description)

Subject (<ins>SubjectCode</ins>, Description)

Student (<ins>StudentID</ins>, FirstName, Surname, Email, PhoneNo)

Booking (<ins>BookingRef</ins>, StudentID, DateOfBooking, GrindTime, TutorID, Amount)

Refund (<ins>RefundRef</ins>, StudentID, Amount)

Schedule (<ins>TimeAndDate</ins>, <ins>TutorID</ins>, MaxAttendance, CurrentEnrollment, RoomNo)

### 6.3 Database Schema

**Relation Tutors**

| Attribute | Type | Constraints |
|---|---|---|
| TutorID | NUMERIC (3) |  |
| FirstName | VARCHAR2 (15) | NOT NULL |
| Surname | VARCHAR2 (20) | NOT NULL |
| RateCode | NUMERIC (3) | NOT NULL |
| SubjectCode | NUMERIC (3) | NOT NULL |
| Email | VARCHAR2 (50) | NOT NULL UNIQUE |
| PhoneNo | CHAR (10) | NOT NULL UNIQUE |

- Primary Key TutorID
- Foreign Key RateCode References TutorRates
- Foreign Key SubjectCode References Subjects

**Relation TutorRates**

| Attribute | Type | Constraints |
|---|---|---|
| RateCode | CHAR (3) |  |
| HourlyRate | NUMBER (4,2) | DEFAULT 50.00 |
| Description | VARCHAR2(30) | NOT NULL |

- Primary Key RateCode

**Relation Subjects**

| Attribute | Type | Constraints |
|---|---|---|
| SubjectCode | CHAR (3) |  |
| Description | VARCHAR2(30) | NOT NULL |

- Primary Key SubjectCode

**Relation Students**

| Attribute | Type | Constraints |
|---|---|---|
| StudentID | NUMERIC (3) |  |
| FirstName | VARCHAR2 (15) | NOT NULL |
| Surname | VARCHAR2 (20) | NOT NULL |
| Email | VARCHAR2 (50) | NOT NULL UNIQUE |
| PhoneNo | CHAR (10) | NOT NULL UNIQUE |

- Primary Key StudentID

**Relation Bookings**

| Attribute | Type | Constraints |
|---|---|---|
| BookingRef | NUMERIC (3) |  |
| StudentID | NUMERIC (3) | NOT NULL |
| DateOfBooking | DATE | NOT NULL |
| GrindTime | DATE | NOT NULL |
| TutorID | NUMERIC (3) | NOT NULL |
| Amount | NUMBER (4,2) | DEFAULT 50.00 NOT NULL |

- Primary Key BookingRef
- Foreign Key StudentID References Students (StudentID)
- Foreign Key (GrindTime, TutorID) References Schedules (TimeAndDate, TutorID)

**Relation Refunds**

| Attribute | Type | Constraints |
|---|---|---|
| RefundRef | NUMERIC (3) |  |
| StudentID | NUMERIC (3) | NOT NULL |
| Amount | NUMBER (4,2) | DEFAULT 50.00 NOT NULL |

- Primary Key RefundID
- Foreign Key StudentID References Students (StudentID)

**Relation Schedules**

| Attribute | Type | Constraints |
|---|---|---|
| TimeAndDate | NUMERIC (3) |  |
| TutorID | NUMERIC (3) | NOT NULL |
| MaxAttendance | — |  |
| CurrentEnrollment | — |  |
| RoomNo | CHAR (4) | DEFAULT ‘R200’ NOT NULL |

- Primary Key (TimeAndDate, TutorID)
- Foreign Key TutorID References Tutors (TutorID)

## 7 Conclusion

This document has presented a complete requirements specification for the Grinds Booking System, detailing the functional behaviour, system processes and data structures required to support the management of tutors, students, schedule, bookings and administrative reporting. Through clearly defined use cases, structured data models and layered data flow diagrams the document provides a thorough understanding of how the system must operate to ensure accuracy, efficiency and reliability within a real-world tutoring environment.

Each module has been designed to uphold data integrity and support the practical needs of both managerial staff and system users. From validating Tutor and Student information, to preventing scheduling conflicts, processing bookings and cancellations, and generating revenue and earnings reports, the system is equipped to handle all core administrative functions seamlessly. The inclusion of business rules, constraints and alternate scenarios ensures that the system behaves predictably under both standard and exceptional conditions.

Overall, the requirements captured in this document establish a strong foundation for subsequent design, development and testing phases. By translating the processes of a tutoring practice into a structured software specification, the Grinds Booking System is positioned to deliver improved operational efficiency, enhanced user experience and greater organisational oversight upon implementation.
