# **Software Requirements Specification**

#
## for

# THIS TAPPING GAME

**Version 1.0 approved**

**Prepared by &lt;author&gt;**

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

4.1        System Feature 1

4.2        System Feature 2 (and so on)

**5.        Other Nonfunctional Requirements       **

5.1        Performance Requirements

5.2        Safety Requirements

5.3        Security Requirements

5.4        Software Quality Attributes

5.5        Business Rules

**6.        Other Requirements       **

**Appendix A: Glossary       **

**Appendix B: Analysis Models       **

**Appendix C: To Be Determined List       **

**Revision History**

| **Name** | **Date** | **Reason For Changes** | **Version** |
| --- | --- | --- | --- |
| Tap to Win | 10/10 | Initial Commit | 1.0 |
|   |   |   |   |



   **1.**** Introduction**
     **1.1**** Purpose**

_&lt;Identify the product whose software requirements are specified in this document, including the revision or release number. Describe the scope of the product that is covered by this SRS, particularly if this SRS describes only part of the system or a single subsystem.&gt;_

  The purpose of this Software Requirments Document(SRS) is to provide a full, detailed description of the "Save Yourself" application. The document will cover each feature as well as how each feature is used. It will show the complete design specifactions for our application. The document will contain an overview of everything down to design contraints, interaction with interfaces, system features, and so on. 

  **1.2**** Document Conventions**

_&lt;Describe any standards or typographical conventions that were followed when writing this SRS, such as fonts or highlighting that have special significance. For example, state whether priorities  for higher-level requirements are assumed to be inherited by detailed requirements, or whether every requirement statement is to have its own priority.&gt;_

Features here may be code named. Please refer to the glossary for the complete definition.

  **1.3**** Intended Audience and Reading Suggestions**

_&lt;Describe the different types of reader that the document is intended for, such as developers, project managers, marketing staff, users, testers, and documentation writers. Describe what the rest of this SRS contains and how it is organized. Suggest a sequence for reading the document, beginning with the overview sections and proceeding through the sections that are most pertinent to each reader type.&gt;_

  Our intended audience would be for anyone who has an interest in a mobile gaming application that you could play with your friends. For an overall description of our application, please see **Part 2**. This section is intended to give a general guide of the document. **Part 3** contains our external interface requirments. **Part 4** contains the full feature list. **Part 5** and **Part 6** contains miscellaneous information. 

  **1.4**** Product Scope**

_&lt;Provide a short description of the software being specified and its purpose, including relevant benefits, objectives, and goals. Relate the software to corporate goals or business strategies. If a separate vision and scope document is available, refer to it rather than duplicating its contents here.&gt;_

This application will be a mobile game which involves tapping at a screen to defeat enemies. These enemies will be moving toward the player's character located in the center of the screen, and in order to defeat these enemies, the player must tap them to defeat them. A user will load up the game and have an option to play against a simple AI or the option of playing against other players. Adding a social element to this game can be benifical to users who might be looking for a new social outlet or challenging entertainment. The application will be easy to use by incorporating a simple and effective interface.

  **1.5**** References**

_&lt;List any other documents or Web addresses to which this SRS refers. These may include user interface style guides, contracts, standards, system requirements specifications, use case documents, or a vision and scope document. Provide enough information so that the reader could access a copy of each reference, including title, author, version number, date, and source or location.&gt;_

The application is intended to follow Apple, Google and Unity guidelines, which can be found below.

  Apple:
  https://developer.apple.com/ios/human-interface-guidelines/
  
  Google:
  https://material.google.com/
  
  Unity:
  https://docs.unity3d.com/Manual/index.html

   **2.**** Overall Description**
   
    **2.1**** Product Perspective**

_&lt;Describe the context and origin of the product being specified in this SRS. For example, state whether this product is a follow-on member of a product family, a replacement for certain existing systems, or a new, self-contained product. If the SRS defines a component of a larger system, relate the requirements of the larger system to the functionality of this software and identify interfaces between the two. A simple diagram that shows the major components of the overall system, subsystem interconnections, and external interfaces can be helpful.&gt;_

  The product specified in this document is a new, self-contained mobile game. It takes a gaming concept featured in previous games, and hopes to expand upon them with new features.

  **2.2**** Product Functions**

_&lt;Summarize the major functions the product must perform or must let the user perform. Details will be provided in Section 3, so only a high level summary (such as a bullet list) is needed here. Organize the functions to make them understandable to any reader of the SRS. A picture of the major groups of related requirements and how they relate, such as a top level data flow diagram or object class diagram, is often effective.&gt;_

  The following is a list of the basic requirements that our mobile game must feature:
  - The game must allow for multiple players to play rounds on a turn-by-turn basis.
  - The game must allow the multiple rounds to be played by each player.
  - The game must save scores from previous rounds for each player.

  **2.3**** User Classes and Characteristics**

_&lt;Identify the various user classes that you anticipate will use this product. User classes may be differentiated based on frequency of use, subset of product functions used, technical expertise, security or privilege levels, educational level, or experience. Describe the pertinent characteristics of each user class. Certain requirements may pertain only to certain user classes. Distinguish the most important user classes for this product from those who are less important to satisfy.&gt;_

  The game will be appropriate for all ages. The game will be available for all users who own a mobile device running the featured operating systems specified in the following section (2.4) of this document through their respective mobile application stores. The game is intended to be played by all users who play mobile games with a device running those specified operating systems.

  **2.4**** Operating Environment**

_&lt;Describe the environment in which the software will operate, including the hardware platform, operating system and versions, and any other software components or applications with which it must peacefully coexist.&gt;_

  The application will operate on Apple devices running iOS 8.0 or higher and Android devices running version 5.0 or higher.

  **2.5**** Design and Implementation Constraints**

_&lt;Describe any items or issues that will limit the options available to the developers. These might include: corporate or regulatory policies; hardware limitations (timing requirements, memory requirements); interfaces to other applications; specific technologies, tools, and databases to be used; parallel operations; language requirements; communications protocols; security considerations; design conventions or programming standards (for example, if the customer&#39;s organization will be responsible for maintaining the delivered software).&gt;_

  The design and implementation of the application will be limited to the tools, content, and programming languages that are available for use within the Unity environment.

  **2.6**** User Documentation**

_&lt;List the user documentation components (such as user manuals, on-line help, and tutorials) that will be delivered along with the software. Identify any known user documentation delivery formats or standards.&gt;_

  On the main screen of the mobile game, a "Help" button will navigate the user to a help section that will explain the basics of the gameplay. With our initial release, we will utilize the comments sections of the mobile app stores to observe user issues with the game. The descriptions section for the game on the mobile app stores can be used to provide information to users on any update information.

  **2.7**** Assumptions and Dependencies**

_&lt;List any assumed factors (as opposed to known facts) that could affect the requirements stated in the SRS. These could include third-party or commercial components that you plan to use, issues around the development or operating environment, or constraints. The project could be affected if these assumptions are incorrect, are not shared, or change. Also identify any dependencies the project has on external factors, such as software components that you intend to reuse from another project, unless they are already documented elsewhere (for example, in the vision and scope document or the project plan).&gt;_

  Since the application will be developed using Unity and made for Apple devices, once the implementation is complete, it will have to be transferred to Xcode to finish the final steps. If the application can't be moved to Xcode, it won't be able to reach the users.

  **3.**** External Interface Requirements**
    **3.1**** User Interfaces**

_&lt;Describe the logical characteristics of each interface between the software product and the users. This may include sample screen images, any GUI standards or product family style guides that are to be followed, screen layout constraints, standard buttons and functions (e.g., help) that will appear on every screen, keyboard shortcuts, error message display standards, and so on. Define the software components for which a user interface is needed. Details of the user interface design should be documented in a separate user interface specification.&gt;_

The following image is a prototype of what the invisioned game could look like while in use:

![alt-text](https://github.com/JDoYo/saveyourself/blob/master/Save%20Yourself%20Gameplay%20Screengrab%20Prototype%20RESIZED%20BORDERED.png)

  **3.2**** Hardware Interfaces**

_&lt;Describe the logical and physical characteristics of each interface between the software product and the hardware components of the system. This may include the supported device types, the nature of the data and control interactions between the software and the hardware, and communication protocols to be used.&gt;_
 
 Hardware connections to the software will be handled by the operating system of the player's mobile device. The mobile device must be running on an Android or iOS operating system.

  **3.3**** Software Interfaces**

_&lt;Describe the connections between this product and other specific software components (name and version), including databases, operating systems, tools, libraries, and integrated commercial components. Identify the data items or messages coming into the system and going out and describe the purpose of each. Describe the services needed and the nature of communications. Refer to documents that describe detailed application programming interface protocols. Identify data that will be shared across software components. If the data sharing mechanism must be implemented in a specific way (for example, use of a global data area in a multitasking operating system), specify this as an implementation constraint.&gt;_

 
  **3.4**** Communications Interfaces**

_&lt;Describe the requirements associated with any communications functions required by this product, including e-mail, web browser, network server communications protocols, electronic forms, and so on. Define any pertinent message formatting. Identify any communication standards that will be used, such as FTP or HTTP. Specify any communication security or encryption issues, data transfer rates, and synchronization mechanisms.&gt;_

Save yourself is an offline mobile application. The application will only access and save data to the device. The application will not interface with a database or the internet.

  **4.**** System Features**

_&lt;This template illustrates organizing the functional requirements for the product by system features, the major services provided by the product. You may prefer to organize this section by use case, mode of operation, user class, object class, functional hierarchy, or combinations of these, whatever makes the most logical sense for your product.&gt;_

  **4.1**** Save Scores**

_&lt;Don&#39;t really say &quot;System Feature 1.&quot; State the feature name in just a few words.&gt;_

4.1.1        Description and Priority

_&lt;Provide a short description of the feature and indicate whether it is of High, Medium, or Low priority. You could also include specific priority component ratings, such as benefit, penalty, cost, and risk (each rated on a relative scale from a low of 1 to a high of 9).&gt;_
The application must save the User's score so that it can be retrieved at a later time.

Priority Level: High

4.1.2        Stimulus/Response Sequences

_&lt;List the sequences of user actions and system responses that stimulate the behavior defined for this feature. These will correspond to the dialog elements associated with use cases.&gt;_

- User clicks the Play button
- The game starts.
- User loses the game.
- The game stops.
- The Application saves the User's score on their device.

4.1.3        Functional Requirements

_&lt;Itemize the detailed functional requirements associated with this feature. These are the software capabilities that must be present in order for the user to carry out the services provided by the feature, or to execute the use case. Include how the product should respond to anticipated error conditions or invalid inputs. Requirements should be concise, complete, unambiguous, verifiable, and necessary. Use &quot;TBD&quot; as a placeholder to indicate when necessary information is not yet available.&gt;_

_&lt;Each requirement should be uniquely identified with a sequence number or a meaningful tag of some kind.&gt;_

REQ-1: The application must have a Play button so the User can start the game.

REQ-2: The application must start the game when the User clicks the Play button.

REQ-3: The application must increment the User's score during the game.

REQ-4: The application must stop the game when the User dies.

REQ-5: The application must save the User's score to their device.

**4.2**** Play Singleplayer**

_&lt;Don&#39;t really say &quot;System Feature 1.&quot; State the feature name in just a few words.&gt;_

4.2.1        Description and Priority

_&lt;Provide a short description of the feature and indicate whether it is of High, Medium, or Low priority. You could also include specific priority component ratings, such as benefit, penalty, cost, and risk (each rated on a relative scale from a low of 1 to a high of 9).&gt;_

The application must allow the User to play alone.

Priority Level: HIGH

4.2.2        Stimulus/Response Sequences

_&lt;List the sequences of user actions and system responses that stimulate the behavior defined for this feature. These will correspond to the dialog elements associated with use cases.&gt;_

- User clicks the Play Single-Player button.
- The Game starts.
- Player plays the game.
- Player dies within game.
- Player's final score is displayed.
- Player is given the option to restart game or exit to main menu.

4.2.3        Functional Requirements

_&lt;Itemize the detailed functional requirements associated with this feature. These are the software capabilities that must be present in order for the user to carry out the services provided by the feature, or to execute the use case. Include how the product should respond to anticipated error conditions or invalid inputs. Requirements should be concise, complete, unambiguous, verifiable, and necessary. Use &quot;TBD&quot; as a placeholder to indicate when necessary information is not yet available.&gt;_

_&lt;Each requirement should be uniquely identified with a sequence number or a meaningful tag of some kind.&gt;_

REQ-6 The application must have a 'Single-Player' button so the user can play without another user.

REQ-7 The application must start when the user presses the 'Single-Player button.

REQ-4 from 4.1.3 Functional Requirements.

REQ-8 The application must display score when the player dies and the game has ended.

REQ-9 The application must give the user the option to restart the game once the game has ended.

REQ-10 The application must give the user the option to exit to the main menu when the game has ended.

**4.3**** Start New Round**

_&lt;Don&#39;t really say &quot;System Feature 1.&quot; State the feature name in just a few words.&gt;_

4.3.1        Description and Priority

_&lt;Provide a short description of the feature and indicate whether it is of High, Medium, or Low priority. You could also include specific priority component ratings, such as benefit, penalty, cost, and risk (each rated on a relative scale from a low of 1 to a high of 9).&gt;_

The application must allow the User to start a new round.

Priority Level: High

4.3.2        Stimulus/Response Sequences

_&lt;List the sequences of user actions and system responses that stimulate the behavior defined for this feature. These will correspond to the dialog elements associated with use cases.&gt;_

- User clicks the Play button.
- The game starts.
- User loses the game.
- The game stops.
- User clicks the Start Over button.

4.3.3        Functional Requirements

_&lt;Itemize the detailed functional requirements associated with this feature. These are the software capabilities that must be present in order for the user to carry out the services provided by the feature, or to execute the use case. Include how the product should respond to anticipated error conditions or invalid inputs. Requirements should be concise, complete, unambiguous, verifiable, and necessary. Use &quot;TBD&quot; as a placeholder to indicate when necessary information is not yet available.&gt;_

_&lt;Each requirement should be uniquely identified with a sequence number or a meaningful tag of some kind.&gt;_

REQ-1 from 4.1.3 Functional Requirements.

REQ-2 from 4.1.3 Functional Requirements.

REQ-4 from 4.1.3 Functional Requirements.

REQ-11: The application must have a Start Over button so the User can start a new round.

REQ-12: The application must start another round when the User clicks the Start Over button.

  **4.4**** Play Turn-Based Multiplayer**

_&lt;Don&#39;t really say &quot;System Feature 1.&quot; State the feature name in just a few words.&gt;_

4.4.1        Description and Priority

_&lt;Provide a short description of the feature and indicate whether it is of High, Medium, or Low priority. You could also include specific priority component ratings, such as benefit, penalty, cost, and risk (each rated on a relative scale from a low of 1 to a high of 9).&gt;_

The application must allow users to play against each other with a turn-by-turn system. The users must be able to play against each other on one device and compare their final scores.

Priority Level: Medium

4.4.2        Stimulus/Response Sequences

_&lt;List the sequences of user actions and system responses that stimulate the behavior defined for this feature. These will correspond to the dialog elements associated with use cases.&gt;_

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

4.4.3        Functional Requirements

_&lt;Itemize the detailed functional requirements associated with this feature. These are the software capabilities that must be present in order for the user to carry out the services provided by the feature, or to execute the use case. Include how the product should respond to anticipated error conditions or invalid inputs. Requirements should be concise, complete, unambiguous, verifiable, and necessary. Use &quot;TBD&quot; as a placeholder to indicate when necessary information is not yet available.&gt;_

_&lt;Each requirement should be uniquely identified with a sequence number or a meaningful tag of some kind.&gt;_

REQ-13: The application must have a Play Multiplayer button so multiple players can play on one device.

REQ-14: The application must ask for the number of players when the User clicks the Play Multiplayer button.

REQ-15: The application must start the game when the User enters the number of players.

REQ-4 from 4.1.3 Functional Requirements.

REQ-16: The application must display Player 1's score when the game stops.

REQ-17: The applcation must restart the game after displaying Player 1's score.

REQ-18: The application must compare all of the player's scores.

    **4.2**** System Feature 2 (and so on)**
   **5.**** Other Nonfunctional Requirements**
    **5.1**** Performance Requirements**

_&lt;If there are performance requirements for the product under various circumstances, state them here and explain their rationale, to help the developers understand the intent and make suitable design choices. Specify the timing relationships for real time systems. Make such requirements as specific as possible. You may need to state performance requirements for individual functional requirements or features.&gt;_

  Being an Android and iPhone gaming application, the application has the likelihood of being computationally heavy. The spawning and subsequent deletion of in game objects or sprites, depending on the amount spawned in, may or may not be computationally heavy. In order for the game to work properly, optimization must be a key factor in making sure the game will not slow down or crash.

  **5.2**** Safety Requirements**

_&lt;Specify those requirements that are concerned with possible loss, damage, or harm that could result from the use of the product. Define any safeguards or actions that must be taken, as well as actions that must be prevented. Refer to any external policies or regulations that state safety issues that affect the product&#39;s design or use. Define any safety certifications that must be satisfied.&gt;_

  SY's operation does not require any communication with any data outide of the application itself. The application will not change the phone itself in any way when being installed onto and Andriod or iPhone. It should be noted however that SY will not be responsible for any harm caused by interating with other users while playing the game. SY is not responsible for any injuries that occured to due the use of the application while operating a motor vehicle. Finally, SY will not be responsible for any harm or injuries to due poor judgement or lack of attention when operating the applcation.

  **5.3**** Security Requirements**

_&lt;Specify any requirements regarding security or privacy issues surrounding use of the product or protection of the data used or created by the product. Define any user identity authentication requirements. Refer to any external policies or regulations containing security issues that affect the product. Define any security or privacy certifications that must be satisfied.&gt;_

  The application would not keep a lot of data on the user besides a username, and some of their in-game statistics. Access to this application is given through logging into a secured mobile device with a passcode or some type of security enabled. Malicious parties will not be able to access the data that is contained within the application without the proper log-in information. If a user were to have their mobile device unlocked and the device is not in the possession of said user, the unknown user could potenially have full access to the data stored within the application. SY also has a multiplayer aspect to the game, where packets will be sent over the internet or bluetooth which contain game data. This data is not sensitive therefore it is not required to encrypt the game packets. The game packets would contain only data related to the game, this would only inculde what each user has spawned into the game world via tapping, or the deletion of game objects via tapping. A malicious user could potenially listen to the game packets however the only thing that they would be able to identify someone with would be a username. SY will not send location data over the internet, howvever it is possible someone could snoop around and find this data.

  **5.4**** Software Quality Attributes**

_&lt;Specify any additional quality characteristics for the product that will be important to either the customers or the developers. Some to consider are: adaptability, availability, correctness, flexibility, interoperability, maintainability, portability, reliability, reusability, robustness, testability, and usability. Write these to be specific, quantitative, and verifiable when possible. At the least, clarify the relative preferences for various attributes, such as ease of use over ease of learning.&gt;_

The primary non-functional requirments that Save Yourself will focus on are reliablity and usability. 

  The application will be displayed in a way that will make it very easy for the user to understand everything that is going on. It will guide a user's eyes to points of interests in the application. The application will be basic enough that users of all ages would be able to properly navigate their way through the application. An interface that's too complex would be a large pitfall for Save Yourself, the point of the application is for it to open quickly so you're able to jump into a game as fast as possible. Due to this we will be limiting loading times and the loading times to load into a game with another player will take a minimal amount of time to load.

  In regards to reliability, Save Yourself will be using a simeple database for statistics that involves the game data. The game needs to also be reliable in a sense that when a user opens it, it will open without delay or crashing. Since certain people will be using this application almost daily, it is imperative that the application does not crash and interrupt the user's daily routine.

  **5.5**** Business Rules**

_&lt;List any operating principles about the product, such as which individuals or roles can perform which functions under specific circumstances. These are not functional requirements in themselves, but they may imply certain functional requirements to enforce the rules.&gt;_

Save Yourself is a gaming application that will be a similar experience for all users that play this game. Each user has full control over the application and are welcome to modify and use each of the game's features to its fullest. One of our main non-functional requirments stated in section 5.4 is usability. With that being said, there is no function that will be disabled to any user, at any time.

  **6.**** Other Requirements**

_&lt;Define any other requirements not covered elsewhere in the SRS. This might include database requirements, internationalization requirements, legal requirements, reuse objectives for the project, and so on. Add any new sections that are pertinent to the project.&gt;_

**Appendix A: Glossary**

_&lt;Define all the terms necessary to properly interpret the SRS, including acronyms and abbreviations. You may wish to build a separate glossary that spans multiple projects or the entire organization, and just include terms specific to a single project in each SRS.&gt;_

**Appendix B: Analysis Models**

_&lt;Optionally, include any pertinent analysis models, such as data flow diagrams, class diagrams, state-transition diagrams, or entity-relationship diagrams_.&gt;

Use Case Diagram:
![alt-text](https://github.com/JDoYo/saveyourself/blob/master/Photo%20Oct%2021%2C%2010%2041%2006%20AM.jpg)


**Appendix C: To Be Determined List**

_&lt;Collect a numbered list of the TBD (to be determined) references that remain in the SRS so they can be tracked to closure.&gt;_
