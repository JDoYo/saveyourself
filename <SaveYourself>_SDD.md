#Save Yourself SDD

**Version 1.0 approved**

**Prepared by 
* Tyler Baronet
* Joshua Do
* Kalyn Odom
* Kristofer Oubre
* Melva Matthews
* Jody Toms


# Table of Contents

1. Introduction

    1.1 Purpose
    
    1.2 Intended Audience

    1.3 Scope

    1.4 Design Summary
    
2. Design Considerations

    2.1 Assumptions
    
    2.2 Contraints
    
    2.3 System Environment
    
    2.4 Risks and Volatile Areas

3. Conceptual System Architecture

    3.1 Overview

    3.2 Playstyle
    
    3.3 Single-Player
    
    3.4 Multi-Player

    3.5 Help
    
4. Technical System Architecture

    4.1 Overview
    
    4.2 Design

    4.3 Database and Objects

5. Application Views

    5.1 Logical View

    5.2 Physical View

    5.3 Development View
    
    5.4 Work-Assignment View

6. User Interface Design

    6.1 User Interface Description

    6.2 User Interface Diagram

7. Database Design

    7.1 Database Design Description
    
    7.2 Database Diagram

8. Element Catalog
    
    8.1 Logical View Diagram
    
    8.2 Physical View Diagram
    
    8.3 Development View Diagram
    
    8.4 User Interface Diagram
    
    8.5 Database Diagram




# 1. Introduction

1.1 Purpose
    
This Software Design Document is designed and intended to detail the implementation of the requirments  as defined in the Software Requirments Specification for the Save Yourself mobile game. The document is intended to fully explore the user experience as well as explore features for full utilization of the application.

1.2 Intended Audience
    
This software design document is specifically intended for those who are stakeholders for the mobile game application, Save Yourself. For any potential stakeholders, we included section 2, which is a section dedicated to design considerations for anyone who is interested in possibly investing in Save Yourself. Section 3 is about the conceptual system architecture, which would be for any team that isn't apart of the actual development of the application, such as a support team. Section 4 is about the technical system architecture, this section is intended for the developevers of the application. There's section 5, 6 and 8 which contain various diagrams as well as the design views, these would be intented for all steakholders in the application. Finally section 7 is about databse design which would be intended for the core design team as well as the database team.

1.3 Scope

The scope of the SDD was creatd to give the people who are working closely with the application to get an in-depth idea of the concept. Everything the conceptual architecture, to the design views, to the database design will be contained within this document. The application is intended for users who want to have an enjoyable mobile game experience without any problem. 

1.4 Design Summary

At its core, Save Yourself is a simple and addicting mobile game that will give users an escape from their lives. We want users to feel like the game isn't going to cheat them with overly expensive in-game purchases that don't do a lot for you. With a simple concept of tapping a screen you're able to enjoy a fun and custom experience. Time permitting, we intend to make different senarios to fight different types of foes. Also in the backlog is the multiplayer feature which would let you and a friend join together to defeat enimemies, or play against them. We intend to make this a rather simple concept idea at first and then from there this idea can be fully fleshed out adding more subsystems, time permitting. Unity will be our primary building tool, allowing us to control everything to our exact design specifications.

# 2. Design Considerations

2.1 Assumptions
   
We, the designers, assume that all users are in possesion of either an iPhone updated to iOS8 or higher or an Android device which has been updated to 5.0 or higher. Without that, many of our application features would not be possible or the phone will be too outdated to it.

2.2 Constraints

The application will be contrained to only users who have an iPhone, iPad, or Android mobile device.

2.3 System Environment

The application will reside within the user's mobile device. Both iPhone and Android devices will store the various statistics that are accumulated from the game into a simple database. Unity will take care of a lot of the porting to each of the devices. While we're not sure what kind of database we're using, we will most likely be using a SQL database.

2.4 Risks and Volatile Areas

There could be possible secruity risks using this software. Any undocumented OS risks could potentially cause a data leak or a memory leak. If implemented, the multiplayer aspect of the game could be a risk of a potential risk from a third party.

# 3. Conceptual System Architecture

3.1 Overview

Save Yourself is a mobile game with a concept and playstyle that is easy for the user to learn and partake in. The mobile game is a tap-survival game similar to others available on various mobile application stores, but offers new features to encourage one-on-one social interaction with its users. The mobile game will have a homescreen that allows the user to select from several playstyles. The user can choose to play the game by themselves by selecting the Single-Player option on the homescreen. The user can also play the game with others (maximum of four players) by selecting the Multi-Player option on the homescreen. The basics of how to play the game as well as how to take advantage of its features will be outlined on a page accessible by selecting the Help option on the homescreen as well.

3.2 Playstyle

The user's character will be represented by an avatar located in the center of the screen. Surrounding the user's avatar will be various enemy avatars generated by the mobile-game that will make their way towards the user's avatar. The user must tap the screen corresponding to the location of the enemy avatar in order to destroy them. If an enemy avatar makes contact with the user's avatar, damage will be dealt to the user's avatar. Once a certain amount of damage is dealt to the user's avatar, the round ends and the user's total score is displayed on screen. The user will then be displayed the option of restarting the round, or exiting to the mobile game's homescreen.

3.3 Single-Player

The user can play alone by selecting the Single-Player option available on the mobile game's homescreen. This option will allow to user to play by themselves against the mobile-game's AI. The user can then play a round of the game as outlined in 3.2.

3.4 Multi-Player

The user can choose to play with others by selecting the Multi-Player option available to them on the mobile game's homescreen. This option will allow the user to play with others against the mobile game's AI. Once this option is selected, the user is presented with a screen that will allow them to select the number of players that will be participating. With Save Yourself's initial release, the maximum number of players allowed with this feature will be four. The user as Player One then plays a round of the game as outlined in 3.2. Once Player One's round has ended and the score has been displayed, their score is then saved to be used later. Control of the game then moves over to Player Two, which repeats the same process as with Player One. This process also repeats for Players Three and Four depending on the user's player count selected at the beginning of the match. Once each player has played one round, each of the player's scores are displayed on screen from highest to lowest. The players will then be presented the option of restarting the match, or exiting to the mobile game's homescreen.
>Note: The description above will make up the Multi-Player feature of Save Yourself's initial release. In the future, it is possible that Save Yourself will take advantage of WiFi or Bluetooth connectivity to link multiple devices together. With this version of Multi-Player, each player can play a match against each other simultaneously by allowing one player to launch enemy avatar's at the other player while trying to defend themselves from the other.

3.5 Help

The user can choose to view the help screen by selecting the Help option available to them on the mobile game's homescreen. This screen will display the directions on how to properly play the game, as outlined in 3.2. Also, the screen will provide information to the user on how to use the Multi-Player feature of the mobile game.

# 4. Technical System Architecture

4.1 Overview

Since the game will be programmed in the Unity environment, much of the technical system architecture is handled internally within this environment itself.

4.2 Design

The design will be loosely object oriented, but as mentioned earlier, integration betwen all objects is handled within Unity.

4.3 Database and Objects

These are all naturally integrated parts of the Unity environment and we will be using that which is already in place.

# 5. Application Views

5.1 Logical View

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/4330_logicalview.PNG)

5.2 Physical View

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/Physical%20View%20Diagram%20NEW.png)
 
5.3 Development View


5.4 Work-Assignment View

-The delegation of work will be as follows:
 - * User Interface Design: Kristofer Oubre, Jody Toms
 - * Implementation: Kristofer Oubre, Tyler Baronet
 - * Integration: Melva Matthews, Kalyn Odom
 - * Documentation: Jody Toms, Joshua Do

# 6. User Interface Design

The following two sections provide a description of the User Interface flow and an example diagram of the interface.

6.1 User Interfaces Description

Once the user opens the system, they are approached by three options. Those options are single player, multiplayer and start new round. Choosing Single Player will start the game where the player will have the option to tap to kill the enemies that approach them and to pause the game. Choosing Multiplayer will start the game with the same features as single player but it will also have a pass play option. Lastly, if the user picks new round it starts the game over leading the user to once again pick either single player or multiplayer.

6.2 User Interface Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/user%20interface.png)


# 7. Database Design

7.1 Database Description

The database is a pretty basic game database. Unity will be handling most of the database design by itself. For the game data, Unity has a function that allows us to store game data such as high scores or specific things like kills.

7.2 Database Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/Database.png)

# 8. Element Catalog

8.1 Logical View Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/ELEMENTS%20Logical%20View%20Diagram.PNG)
    
8.2 Physical View Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/ELEMENTS%20Physical%20View%20Diagram.PNG)
    
8.3 Development View Diagram
    
8.4 User Interface Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/ELEMENTS%20User%20Interface%20Diagram.PNG)

8.5 Database Diagram

![alt-text] (https://github.com/JDoYo/saveyourself/blob/master/ELEMENTS%20Database%20Diagram.PNG)
