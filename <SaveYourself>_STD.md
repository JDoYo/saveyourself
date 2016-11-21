# **Software Testing Document**

## for

# SAVE YOURSELF

**Version 1.0 approved**

**Prepared by 
* Tyler Baronet
* Joshua Do
* Kalyn Odom
* Kristofer Oubre
* Melva Matthews
* Jody Toms

**Tap2Win Inc.**

**11/16/16**

**Table of Contents**


1.) Introduction

2.) Test Items

3.) Features Not to be Tested

4.) Approach

5.) Test Deliverables

6.) Responsiblities

7.) Risks and Contigencies

8.) Apendix



## 1.) Introduction

This Software Testing Document is designed and intended to test all of the features for the Save Yourself mobile game. The document is intended to fully explore the user experience as well as explore features for full utilization of the application.

## 2.) Test Items
*************TEMPLATE TEST**************************

(Use this as template for now, unless I find an alternative to it(I prolly won't) just use this for the test cases. Yeah there's nothing in the header, when you put something in the header it bolds it and bumps the size up and I dont want that for the first table so that's why that's there...)

| | | | |
|:---:|---|---|---|
|    Test Case #:    | aaa | Test Case Name  |   |
| System:            |     | Subsystem       |   |
| Designed by:       |     | Design Date:    |   |
| Executed by:       |     | Execution Date: |   |
| Short Description: |     |                 |   |

Pre-condtions: I'm guessing precondition would be something along the lines of what needs to occur before the test happens.

| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|-----------|---------|
| 1    |        |                          |           |         |
| 2    |        |                          |           |         |
| 3... |        |                          |           |         |

Post-conditions: Post condition would be the end result of what the feature should do


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #: 1   | aaa | Test Case Name: Select Car  |   |
| System:            |     | Subsystem       |   |
| Designed by:       |     | Design Date:    |   |
| Executed by:       |     | Execution Date: |   |
| Short Description: |     |                 |   |

Pre-condtions: I'm guessing precondition would be something along the lines of what needs to occur before the test happens.

| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|-----------|---------|
| 1    |        |                          |           |         |
| 2    |        |                          |           |         |
| 3... |        |                          |           |         |

Post-conditions: Post condition would be the end result of what the feature should do


********************************************************

| | | | |
|---|:---|:---|:---|
| Test Case #: 2    | | Test Case Name: Play Singleplayer |   |
| System:  Mobile App|     | Subsystem:       |   |
| Designed by: Kristofer Oubre       |     | Design Date:  11/01/2016  |   |
| Executed by: Melva Mathhews      |     | Execution Date: 11/21/2016|   |
| Short Description: Test Game's Singleplayer Feature|     |   |   |

####Preconditions:
The player has a compatible mobile device.
The player clicks the 'Play' button.
The system displays the 'Select Your Car' screen.  

| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1 | Click onscreen arrow| The screen navigates through an option of cars| Pass| |
|2 | Click 'Single Play' button| The system starts gameplay mode| Pass | |
|3| Game begins| Rocks gravitate towards player's car| Pass| |
|4 | Tap Rocks| Rocks disappear when player taps them before the rocks reach the car|Pass | |
|5| Allow car value to decrease| The player's car should start to emite smoke when the 'Value' decreases below $10000, then emit fire when 'Value' decreases below $4000, and game sends when 'Value' equals $0  | Pass| |
|6| Game Ends| The system displays 'Game Over' screen | Pass| |
|7| Check post-condition 1| | | |

####Post-conditions:
The player score is saved.


********************************************************

| | | | |
|---|:---|:---|:---|
| Test Case #: 3    | | Test Case Name: Play Turn-Based Multiplayer |   |
| System:  Mobile App|     | Subsystem:       |   |
| Designed by:Kristofer Oubre       |     | Design Date:  11/01/2016  |   |
| Executed by: Kalyn Odom       |     | Execution Date: 11/21/2016|   |
| Short Description: Test Game's Multiplayer Feature|     |   |   |

####Preconditions:
The player has a compatible mobile device.
The player clicks the 'Play' button.
The system displays the 'Select Your Car' screen. 
 

| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1 | Click onscreen arrow| The screen navigates through an option of cars| Pass| |
|2 | Click 'Multi Play' button| The system starts gameplay mode| Pass | |
|3| Game begins| Rocks gravitate towards player's car| Pass| |
|4 | Tap Rocks| Rocks disappear when player taps them before the rocks reach the car|Pass | |
|5| Allow car value to decrease| The player's car should start to emite smoke when the 'Value' decreases below $10000, then emit fire when 'Value' decreases below $4000, and game sends when 'Value' equals $0  | Pass| |
|6| Game Ends| The system displays 'Game Over' screen. Player 1 turn is over | Pass| |
|7| Click "Play Button"| The system starts gameplay mode for player 2| Pass| |
|8 | Tap Rocks| Rocks disappear when player taps them before the rocks reach the car|Pass | |
|9| Allow car value to decrease| The player's car should start to emite smoke when the 'Value' decreases below $10000, then emit fire when 'Value' decreases below $4000, and game sends when 'Value' equals $0  | Pass| |
|10| Game Ends| The system displays 'Game Over' screen. Player 2 turn is over | Pass| |
|11| Check post-condition 1| | | |                  |           |         |

####Post-conditions:
Both players scores are saved.


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #: 4   | aaa | Test Case Name: Pause Gameplay  |   |
| System:  Mobile App|     | Subsystem:       |   |
| Designed by:Kristofer Oubre       |     | Design Date:  11/01/2016  |   |
| Executed by: Kalyn Odom       |     | Execution Date: 11/21/2016|   |
| Short Description: |     |                 |   |

Pre-condtions: 
The player has a compatible mobile device.
The player clicks the 'Play' button.
The system displays the 'Select Your Car' screen. 
The player clicks "Single Play"/"Multi Play".

| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1| Game begins| Rocks gravitate towards player's car| Pass| |
|2 | Tap Rocks| Rocks disappear when player taps them before the rocks reach the car|Pass | |
|3| Allow car value to decrease| The player's car should start to emite smoke when the 'Value' decreases below $10000, then emit fire when 'Value' decreases below $4000, and game sends when 'Value' equals $0  | Pass| |
|4|Clicks "Pause"| Pauses the game|Pass| |
|5| Game paused| Player should not be able to play while game is paused|Fail| |
|6|Clicks "Play"| The game resumes|Pass| |
|7| Allow car value to decrease| The player's car should start to emite smoke when the 'Value' decreases below $10000, then emit fire when 'Value' decreases below $4000, and game sends when 'Value' equals $0  | Pass| |
|8| Game Ends| The system displays 'Game Over' screen. Player 2 turn is over | Pass| 
|9| Check post-condition 1| | | |                  |           |         |

Post-conditions: 
The player score is saved.


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #: 5   | aaa | Test Case Name: Save Scores  |   |
| System:            |     | Subsystem       |   |
| Designed by:       |     | Design Date:    |   |
| Executed by:       |     | Execution Date: |   |
| Short Description: |     |                 |   |

Pre-condtions: I'm guessing precondition would be something along the lines of what needs to occur before the test happens.

| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|-----------|---------|
| 1    |        |                          |           |         |
| 2    |        |                          |           |         |
| 3... |        |                          |           |         |

Post-conditions: Post condition would be the end result of what the feature should do


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #: 6   | aaa | Test Case Name: View Scores  |   |
| System:  Mobile App|     | Subsystem:       |   |
| Designed by:Kristofer Oubre       |     | Design Date:  11/01/2016  |   |
| Executed by: Kalyn Odom       |     | Execution Date: 11/21/2016|   |
| Short Description: |     |                 |   |

Pre-condtions:
The player has a compatible mobile device.

| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1| Player clicks "Achievements"| View the best time and score| Pass| |


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #: 7   | aaa | Test Case Name: Change Volume  |   |
| System:            |     | Subsystem       |   |
| Designed by:       |     | Design Date:    |   |
| Executed by:       |     | Execution Date: |   |
| Short Description: |     |                 |   |

Pre-condtions: I'm guessing precondition would be something along the lines of what needs to occur before the test happens.

| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|-----------|---------|
| 1    |        |                          |           |         |
| 2    |        |                          |           |         |
| 3... |        |                          |           |         |

Post-conditions: Post condition would be the end result of what the feature should do


********************************************************
  

## 3.) Features Not to be Tested

Unity libraries

## 4.) Approach

## 5.) Test Deliverables

## 6.) Responsibilities 

-While all parties in the group will assist with the various parts of testing through the entire testing process, specific parts have been dedicated to certain persons:
Test Execution (Unit Testing, Integration Testing)
Responsible Members:

Test Execution (“User” Acceptance testing)
Responsible Members:

Test Execution (Load Testing, Operational Testing)
Responsible Members:

Test Analysis (Analysis of test log information, Determination of defect severity)
Responsible Members:

Hardware & Software
Responsible Members:

## 7.) Risks and Contigencies

## 8.) Apendix

