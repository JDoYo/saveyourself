# **Software Requirements Specification**

#
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

**10/10/16**

**Table of Contents**

**Table of Contents       **

**Revision History       **

**1.        Introduction       **

1.1        Purpose

1.2        Document Conventions

1.3        Intended Audience and Reading Suggestions

1.4        Product Scope

1.5        References

**2.        Overall Description       **

2.1        Product Perspective

2.2        Product Functions

2.3        User Classes and Characteristics

2.4        Operating Environment

2.5        Design and Implementation Constraints

2.6        User Documentation

2.7        Assumptions and Dependencies

**3.        External Interface Requirements       **

3.1        User Interfaces

3.2        Hardware Interfaces

3.3        Software Interfaces

3.4        Communications Interfaces

**4.        System Features       **

4.1        Save Scores

4.2        Play Singleplayer

4.3        Start New Round

4.4        Play Turn-Based Multiplayer

4.5        Pause Gameplay

**5.        Other Nonfunctional Requirements       **

5.1        Performance Requirements

5.2        Safety Requirements

5.3        Security Requirements

5.4        Software Quality Attributes

5.5        Business Rules

**Appendix A: Glossary       **

**Appendix B: Analysis Models       **

**Appendix C: To Be Determined List       **

**Revision History**

| **Name** | **Date** | **Reason For Changes** | **Version** |
| --- | --- | --- | --- |
| Tap to Win | 10/10 | Initial Commit | 1.0 |
| Save Yourself | 10/20 | Make Edits | 1.0 |
| Save Yourself | 10/21 | Make Finalizations | 1.0 |
|   |   |   |   |



   **1.**** Introduction**
     **1.1**** Purpose**

  The purpose of this Software Requirments Document(SRS) is to provide a full, detailed description of the "Save Yourself" application. The document will cover each feature as well as how each feature is used. It will show the complete design specifactions for our application. The document will contain an overview of everything down to design contraints, interaction with interfaces, system features, and so on. 

  **1.2**** Document Conventions**

Features here may be code named. Please refer to the glossary for the complete definition.

  **1.3**** Intended Audience and Reading Suggestions**

  Our intended audience would be for anyone who has an interest in a mobile gaming application that you could play with your friends. For an overall description of our application, please see **Part 2**. This section is intended to give a general guide of the document. **Part 3** contains our external interface requirments. **Part 4** contains the full feature list. **Part 5** and **Part 6** contains miscellaneous information. 

  **1.4**** Product Scope**

This application will be a mobile game which involves tapping at a screen to defeat enemies. These enemies will be moving toward the player's character located in the center of the screen, and in order to defeat these enemies, the player must tap them to defeat them. A user will load up the game and have an option to play against a simple AI or the option of playing against other players. Adding a social element to this game can be benifical to users who might be looking for a new social outlet or challenging entertainment. The application will be easy to use by incorporating a simple and effective interface.

  **1.5**** References**
  
The application is intended to follow Apple, Google and Unity guidelines, which can be found below.

  Apple:
  https://developer.apple.com/ios/human-interface-guidelines/
  
  Google:
  https://material.google.com/
  
  Unity:
  https://docs.unity3d.com/Manual/index.html

   **2.**** Overall Description**
    **2.1**** Product Perspective**

The product specified in this document is a new, self-contained mobile game. It takes a gaming concept featured in previous games, and hopes to expand upon them with new features.

  **2.2**** Product Functions**

The following is a list summarizing the requirements our mobile game must feature:
 - The game must be comprised of rounds that are made up of these components:
    - The player's avatar which remains stationary in the center of the screen.
    - In-game generated enemies which congregate and swarm the player from all directions of the screen.
 - The game must allow a player to start a new round.
 - The game must allow a player to play rounds alone.
 - The game must allow for multiple players to play rounds on a turn-by-turn basis.
 - The game must save each player's score for a particular round to be used at a later time.
   - Used to compare player scores when multiple players are involved.
 - The game must allow the player to pause the game at any point during the round.

**2.3**** User Classes and Characteristics**

The game will be appropriate for all ages. The game will be available for all users who own a mobile device running the featured operating systems specified in the following section (2.4) of this document through their respective mobile application stores. The game is intended to be played by all users who play mobile games with a device running those specified operating systems.

  **2.4**** Operating Environment**

The application will operate on Apple devices running iOS 8.0 or higher and Android devices running version 5.0 or higher. The game would not conflict with any features the mobile device provides to its users outside of the gaming environment.

  **2.5**** Design and Implementation Constraints**

The design and implementation of the application will be limited to the tools, content, and programming languages that are available for use within the Unity environment. Potential updates to the game will be available through the mobile device's respective mobile appllication stores.

  **2.6**** User Documentation**

On the main screen of the game, a "Help" button will navigate the user to a help section that will explain the basics of the gameplay and the use of the game. The description section for the game on the mobile application stores can be used to provide information to users on any update information of future releases. With our initial release, we will utilize the comments sections of the mobile application stores to observe user issues with the game.

  **2.7**** Assumptions and Dependencies**

Since the application will be developed using Unity and made for Apple devices, once the implementation is complete, it will have to be transferred to Xcode to finish the final steps. If the application can't be moved to Xcode, it won't be able to reach those users.

  **3.**** External Interface Requirements**

**3.1**** User Interfaces**

The following image is a prototype of what the invisioned gameplay as well as the homescreen could look like while in use, respectively:

![alt-text](https://github.com/JDoYo/saveyourself/blob/master/Save%20Yourself%20Gameplay%20Screengrab%20Prototype%20RESIZED%20BORDERED.png)

![alt-text](https://github.com/JDoYo/saveyourself/blob/master/Save%20Yourself%20Homescreen%20Screengrab%20Prototype%20NEW.png)

  **3.2**** Hardware Interfaces**

  Hardware interfacing will mostly be handled by the native operating system of the device in use.  Both iOS and Android natively support the touch screen feature, as well as intergrated graphics controllers, so additional features will not require additional software for hardware interfacing.  The physical storage of user data will be handled by the app itself to access physical store media on the device.

  **3.3**** Software Interfaces**
  
  As mentioned earlier, the application will operate on Apple devices running iOS 8.0 or higher and Android devices running version 5.0 or higher. Updates for the app will be issued in line with new operating system releases from both Android and Apple to ensure compatibility at all times.  The game's touch and tap feature will make use of the native touch interface to both operating systems.  Player data will be assigned to a default name of Player 1 and Player 2 when multiplayer mode is being used.  The high scores for each will be saved in free memory space on the device itself.  A database will be used to keep track of player scores and this database will be contained within the app.  Since the game is offline only currently, no network protocols will be needed; however, in later releases, bluetooth and wifi networking protocols will be implemented for local network play.

 
  **3.4**** Communications Interfaces**

Save yourself is an offline mobile application. The application will only access and save data to the device. The application will not interface with a database or the internet.

  **4.**** System Features**

  **4.1**** Save Scores**

**4.1.1****        Description and Priority

The application must save the User's score so that it can be retrieved at a later time.

Priority Level: High

**4.1.2****        Stimulus/Response Sequences

- User clicks the Play button
- The game starts.
- User loses the game.
- The game stops.
- The Application saves the User's score on their device.

**4.1.3****        Functional Requirements

REQ-1: The application must have a Play button so the User can start the game.

REQ-2: The application must start the game when the User clicks the Play button.

REQ-3: The application must increment the User's score during the game.

REQ-4: The application must stop the game when the User dies.

REQ-5: The application must save the User's score to their device.

**4.2**** Play Singleplayer**

**4.2.1****        Description and Priority

The application must allow the User to play alone.

Priority Level: High

**4.2.2****       Stimulus/Response Sequences

- User clicks the Play Single-Player button.
- The Game starts.
- Player plays the game.
- Player dies within game.
- Player's final score is displayed.
- Player is given the option to restart game or exit to main menu.

**4.2.3****       Functional Requirements

REQ-6 The application must have a 'Single-Player' button so the user can play without another user.

REQ-7 The application must start when the user presses the 'Single-Player button.

REQ-4 from 4.1.3 Functional Requirements.

REQ-8 The application must display score when the player dies and the game has ended.

REQ-9 The application must give the user the option to restart the game once the game has ended.

REQ-10 The application must give the user the option to exit to the main menu when the game has ended.

**4.3**** Start New Round**

**4.3.1****       Description and Priority

The application must allow the User to start a new round.

Priority Level: High

**4.3.2****        Stimulus/Response Sequences

- User clicks the Play button.
- The game starts.
- User loses the game.
- The game stops.
- User clicks the Start Over button.

**4.3.3****     Functional Requirements

REQ-1 from 4.1.3 Functional Requirements.

REQ-2 from 4.1.3 Functional Requirements.

REQ-4 from 4.1.3 Functional Requirements.

REQ-11: The application must have a Start Over button so the User can start a new round.

REQ-12: The application must start another round when the User clicks the Start Over button.

  **4.4**** Play Turn-Based Multiplayer**

**4.4.1****        Description and Priority

The application must allow users to play against each other with a turn-by-turn system. The users must be able to play against each other on one device and compare their final scores.

Priority Level: Medium

**4.4.2****       Stimulus/Response Sequences

- User clicks the Play Multiplayer button.
- The game asks for the number of players.
- User enters the number of players.
- The game starts.
- Player 1 plays the game.
- Player 1 dies.
- The game stops.
- Player 1's score is displayed.
- The game starts.
- Player 2 plays the game.
- Player 2 dies.
- The game stops.
- Player 1 and Player 2's scores are compared.
- (repeat steps 9-13 if there's a Player 3 and Player 4)

**4.4.3****       Functional Requirements

REQ-13: The application must have a Play Multiplayer button so multiple players can play on one device.

REQ-14: The application must ask for the number of players when the User clicks the Play Multiplayer button.

REQ-15: The application must start the game when the User enters the number of players.

REQ-4 from 4.1.3 Functional Requirements.

REQ-16: The application must display Player 1's score when the game stops.

REQ-17: The applcation must restart the game after displaying Player 1's score.

REQ-18: The application must compare all of the player's scores.


**4.5**** Pause Gameplay**

**4.5.1****       Description and Priority

The application must pause gameplay upon player’s request.

Priority Level: Low

**4.5.2****       Stimulus/Response Sequences

- User clicks the Play button
- The game starts.
- User clicks the pause button.
- The game stops.
- User clicks the resume button.
- Game resumes.

**4.5.3****      Functional Requirements

REQ-19: The application must have a Pause button so the User can pause the game.

REQ-20: The application must have a Resume button so the User can resume the game.

REQ-21: The application must unpause the game when the User clicks the Resume button.

   **5.**** Other Nonfunctional Requirements**

**5.1**** Performance Requirements**

  Being an Android and iPhone gaming application, the application has the likelihood of being computationally heavy. The spawning and subsequent deletion of in game objects or sprites, depending on the amount spawned in, may or may not be computationally heavy. In order for the game to work properly, optimization must be a key factor in making sure the game will not slow down or crash.

  **5.2**** Safety Requirements**

  SY's operation does not require any communication with any data outide of the application itself. The application will not change the phone itself in any way when being installed onto and Andriod or iPhone. It should be noted however that SY will not be responsible for any harm caused by interating with other users while playing the game. SY is not responsible for any injuries that occured to due the use of the application while operating a motor vehicle. Finally, SY will not be responsible for any harm or injuries to due poor judgement or lack of attention when operating the applcation.

  **5.3**** Security Requirements**

  The application would not keep a lot of data on the user besides in game statistics for Player 1 and Player 2. Access to this application is given through logging into a secured mobile device with a passcode or some type of security enabled. Malicious parties will not be able to access the data that is contained within the application without the proper log-in information. If a user were to have their mobile device unlocked and the device is not in the possession of said user, the unknown user could potenially have full access to the data stored within the application. SY also has a multiplayer aspect to the game, where packets will be sent over the internet or bluetooth which contain game data. This data is not sensitive therefore it is not required to encrypt the game packets. The game packets would contain only data related to the game, this would only inculde what each user has spawned into the game world via tapping, or the deletion of game objects via tapping. A malicious user could potenially listen to the game packets however the only thing that they would be able to identify someone with would be a username. SY will not send location data over the internet, howvever it is possible someone could snoop around and find this data.

  **5.4**** Software Quality Attributes**

The primary non-functional requirments that Save Yourself will focus on are reliablity and usability. 

  The application will be displayed in a way that will make it very easy for the user to understand everything that is going on. It will guide a user's eyes to points of interests in the application. The application will be basic enough that users of all ages would be able to properly navigate their way through the application. An interface that's too complex would be a large pitfall for Save Yourself, the point of the application is for it to open quickly so you're able to jump into a game as fast as possible. Due to this we will be limiting loading times and the loading times to load into a game with another player will take a minimal amount of time to load.

  In regards to reliability, Save Yourself will be using a simeple database for statistics that involves the game data. The game needs to also be reliable in a sense that when a user opens it, it will open without delay or crashing. Since certain people will be using this application almost daily, it is imperative that the application does not crash and interrupt the user's daily routine.

  **5.5**** Business Rules**
  
Save Yourself is a gaming application that will be a similar experience for all users that play this game. Each user has full control over the application and are welcome to modify and use each of the game's features to its fullest. One of our main non-functional requirments stated in section 5.4 is usability. With that being said, there is no function that will be disabled to any user, at any time.

**Appendix A: Glossary**

It should be noted that the words "user" and "player" are used interchangably in this document, as anyone who uses the app does so in such a fashion that they are a player of the mobile game.

**Appendix B: Analysis Models**

Use Case Diagram:

![alt-text](https://github.com/JDoYo/saveyourself/blob/master/Use%20Case%20Diagram.png)


**Appendix C: To Be Determined List**

The game will eventually include local network co-op mode, but it has low priority and will be in a much later release.
