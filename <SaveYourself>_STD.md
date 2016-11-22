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

4.) Risks and Contigencies



## 1.) Introduction

This Software Testing Document is designed and intended to test all of the features for the Save Yourself mobile game. The document is intended to fully explore the user experience as well as explore features for full utilization of the application.

For more information regarding the Software Requirements Specification (SRS), please see the document. The SRS document to provide full descriptions for Save Yourself, the document also features descriptions on how to utilize each feature within the application.

For more information regarding the Software Design Document (SDD), please see the document. The Software Design Document (SDD) document was intended to help with user experiences as well as explore features for full utilization.  

## 2.) Test Items


| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  1| Test Case Name:   |   Start Mobile Game|
| System:            |     Mobile App| Subsystem:       |   None|
| Designed by:       |     Kristofer Oubre| Design Date:    |   11/01/16|
| Executed by:       |     Jody Toms| Execution Date: |   11/21/16|
| Short Description: |     Test if game starts.|                 |   |

####Pre-condtions: 

The player has a compatible mobile device.

The mobile game is installed on the mobile device.



| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|-----------|---------|
| 1| Click on app icon on phone app menu.| Mobile app loads on device.| Pass|         |



####Post-conditions: 

1.) The mobile game loads on mobile device.


********************************************************

| | | | |
|---|:---|:---|:---|
| Test Case #:     | 2| Test Case Name:  |   Play Singleplayer|
| System:  |     Mobile App| Subsystem:       |   Gameplay|
| Designed by:        |     Kristofer Oubre| Design Date:    |   11/01/2016|
| Executed by:       |     Melva Mathhews| Execution Date: |   11/21/2016|
| Short Description: |     Test game's Singleplayer Feature.|   |   |

####Pre-conditions:

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.

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



####Post-conditions:

1.) The player score is saved.


********************************************************

| | | | |
|---|:---|:---|:---|
| Test Case #:     | 3| Test Case Name:  |   Play Turn-Based Multiplayer|
| System:  |     Mobile App| Subsystem:       |   Gameplay|
| Designed by:       |     Kristofer Oubre| Design Date:    |   11/01/2016|
| Executed by:        |     Kalyn Odom| Execution Date: |   11/21/2016|
| Short Description: |     Test game's Multiplayer feature.|   |   |

####Preconditions:

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.

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



####Post-conditions:

1.) Both players scores are saved.


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  4| Test Case Name:  |   Pause Gameplay|
| System:  |     Mobile App| Subsystem:       |   Gameplay|
| Designed by:       |     Kristofer Oubre| Design Date:    |   11/01/2016|
| Executed by:        |     Kalyn Odom| Execution Date: |   11/21/2016|
| Short Description: | Test the pause feature.    |                 |   |

####Pre-conditions: 

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.

The player clicks the 'Play' button.

The system displays the 'Select Your Car' screen. 

The player clicks "Single Play"/"Multi Play".



| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1|Clicks "Pause"| Pauses the game|Pass| |
|2| Game paused| Player should not be able to play while game is paused|Pass| |
|3|Clicks "Play"| The game resumes|Pass| |



####Post-conditions: 

1.) The player score is saved.


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  5| Test Case Name:   |   Save Scores|
| System:            |     Mobile App| Subsystem       |   Gameplay|
| Designed by:     |     Kristofer Oubre| Design Date:     |   11/01/2016|
| Executed by:      |     Melva Matthews| Execution Date:  |   11/21/2016|
| Short Description:  |     Test 'Save Score' feature.|                 |   |

####Pre-conditions: 

The player has a compatible device.

The mobile game is installed and loaded on the mobile device.

The player has begun gameplay in either Singleplayer or Multiplayer mode.



| Step | Action | Expected System Response | Pass/Fail | Comment |
|:----:|--------|--------------------------|:-----------:|---------|
| 1    |Taps rocks | The system increments score by one per rock tapped | Pass          |         |
| 2    | End Game  | The sytem saves final score on device|Pass |         |



####Post-conditions: 

1.) Scores are now viewable by clicking the 'Achievements' button. 


********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  6| Test Case Name:   |   View Scores|
| System:  |     Mobile App| Subsystem:       |   Achievements|
| Designed by:       |     Kristofer Oubre| Design Date:    |   11/01/2016|
| Executed by:        |     Kalyn Odom| Execution Date: |   11/21/2016|
| Short Description: | Test the view score feature.    |                 |   |

####Pre-conditions:

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.



| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1| Player clicks "Achievements"| View the best time and score| Pass| |



####Post-conditions:

1.) The best time and score is displayed on screen.

********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  7| Test Case Name:   |  Change Volume |
| System: |      Mobile App| Subsystem:       |   Options|
| Designed by:       |     Kristofer Oubre| Design Date:  11/01/2016  |   11/01/2016|
| Executed by:        |     Kalyn Odom| Execution Date: |   11/21/2016|
| Short Description: | Test the volume controls. |               |   |

####Pre-condtions: 

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.



| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1| Player clicks "Options"| View music and souncds option| Pass| |
|2| Player moves bar for Music/Sounds| Changes the volume for music/sounds|Pass|  |



####Post-conditions:

1.) The game will properly change the volume.

********************************************************

| | | | |
|---|:---|:---|:---|
|    Test Case #:    |  8| Test Case Name:   |   Help Screen|
| System:  |     Mobile App| Subsystem       |   Help|
| Designed by:  |     Kristofer Oubre| Design Date:  |   11/01/2016|
| Executed by:  |     Jody Toms| Execution Date: |   11/21/2016|
| Short Description: |     Test the Help Screen button. |                 |   |

####Pre-condtions: 

The player has a compatible mobile device.

The mobile game is installed and loaded on the mobile device.



| Step| Action| Expected System Response| Pass/Fail| Comment|
|:---:|:---|:---|:---:|:---|
|1| Player clicks "Help"| Help Screen is displayed.| Pass| |



####Post-conditions: 

1.) The player is displayed a "help screen" that explains the gameplay and gamestyles of the mobile game.


********************************************************
  
## 3.) Features Not to be Tested

####Unity Libraries

All Unity libraries used in the Gainz application have been thoroughly tested by Unity itself as well as other developers and as such, there is no reason to test anything involving their libraries.

####OS Compatibility

The game is coded in libraries that are recognized by the operating system so that all files are readable in the fist place.

####Distribution

The user's ability to download the app from our source is not to be tested in this release as that issue will be addressed later in the software lifecycle.

## 4.) Risks and Contigencies

####Testing

Testing Save Yourself will be low risk. Some of the risks associated with the testing are below.

####Data Modification

During testing, data that should be otherwise never accessed by a function or library could be inadvertently modified, causing the application to slow, compute taps incorrectly, or crash.
Our contingency plan here would be to reset the mobile device as well as the application, it is very unlikely this occurs however.

####System Crashing

Due to unforeseen circumstances, the application may crash due to an error.
Our contingency plan would be to find a resolution accordingly. There could be many errors, and as such, we would have to find a resolution depending on the kind of critical error encountered.

