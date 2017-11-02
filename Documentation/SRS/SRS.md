# SGFA
# Software Requirements Specification

## Version 1.1

# Table of Contents

- [Introduction](#introduction)
  * [PURPOSE](#purpose)
  * [SCOPE](#scope)
  * [DEFINITIONS, ACRONYMS AND ABBREVIATIONS](#definitions--acronyms-and-abbreviations)
  * [REFERENCES](#references)
  * [OVERVIEW](#overview)
- [Overall Description](#overall-description)
  * [PRODUCT PERSPECTIVE](#product-perspective)
  * [PRODUCT FUNCTIONS](#product-functions)
  * [USER CHARACTERISTICS](#user-characteristics)
  * [CONSTRAINTS](#constraints)
  * [ASSUMPTIONS AND DEPENDENCIES](#assumptions-and-dependencies)
- [Specific Requirements](#specific-requirements)
  * [FUNCTIONALITY](#functionality)
  * [USABILITY](#usability)
  * [RELIABILITY](#reliability)
  * [PERFORMANCE](#performance)
  * [SUPPORTABILITY](#supportability)
  * [DESIGN CONSTRAINTS](#design-constraints)
  * [ON-LINE USER DOCUMENTATION AND HELP SYSTEM REQUIREMENTS](#on-line-user-documentation-and-help-system-requirements)
  * [PURCHASED COMPONENTS](#purchased-components)
  * [INTERFACES](#interfaces)
  * [COMPLEXITY](#complexity)
  * [LICENSING REQUIREMENTS](#licensing-requirements)
  * [LEGAL, COPYRIGHT AND OTHER NOTICES](#legal--copyright-and-other-notices)
  * [APPLICABLE STANDARDS](#applicable-standards)
- [Supporting Information](#supporting-information)

<small><i><a href='http://ecotrust-canada.github.io/markdown-toc/'>Table of contents generated with markdown-toc</a></i></small>


# Revision Histoy

| Date          | Version  | Description       | Author |
| ------------- |----------| ------------------|--------|
| 20.10.2017    | 1.0      | Initialization    |Florian Jochem; Leon Sauer|
| 02.11.2017    | 1.1      | converted to MD  |Sauer	:sunglasses:|

# Introduction

## PURPOSE

This SRS provides documentation for Souls Gathering: First Alliance (SGFA). SGFA is a computer
game based on the Unity Engine. It allows two users to play together on one computer using the
same keyboard and screen. Players will solve riddles to get from level to level, until they reach the
last level. Including a boss fight.
The final build will be compatible with Windows, Linux and Mac.

## SCOPE

This document is designed for internal use only and will outline the development of the project.

## DEFINITIONS, ACRONYMS AND ABBREVIATIONS

| Term / Acronym / Abbreviation | Definition |
|-------------------------------|------------|
| IDE | Integrated Development Environment|
| Unity | Open Source Game Engine |
| UML | Unified Modeling Language |
| SRS | Software Requirement Specification |
| OS | Operating System |

## REFERENCES

|Reference|Link|
|---------|----|
|Blog | https://sgfaweb.wordpress.com |
|GitHub | https://github.com/joachim747/SGFA |
|Use Case Diagram ||

## OVERVIEW

Following chapters will deliver an overall description of the project, containing usability, reliability,
performance and functionality aspects.

# Overall Description

The final build will be delivered as executable file for each OS. Users will simply have to doubleclick
the file to start the game.
After that, the game starts and the users can instantly play.

## PRODUCT PERSPECTIVE

![UseCaseDiagram][UC]

[UC]: UseCaseDiagram.png "UseCaseDiagram for standard User"



[Click here to acess the useCase Diagram for Moving][MUC]

[MUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/Move/Move.md "UseCaseDiagram Move"


[Click here to acess the useCase Diagram for Starting the Game][SGUC]

[SGUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/StartGame/StartGame.md "UseCaseDiagram Start Game"

## PRODUCT FUNCTIONS

Allowing a more fluent development of the product, we decided to subdivide the project into two
phases (each with a time-limit of one semester)
1st semester:
- Game
    - Implementation of basic character controller
    - Basic main menu which offers the possibilities to start and quit the game
    - First levels which gives the users an overview of the individual abilities of the in game
characters and the game-behavior
- Modelling
    - Creation of Heros and Villains
    - Creation of Environment
    - Simple Animations for abilities
- Concept
    - Which graphics should the game support
    - How are the levels structured
    - What are the possible riddles players will have to solve
    - Individual abilities for each character
    - Focus on teamplay —> does influence the gameplay behavior

2nd semester:
- Game
    - Implementing riddles, defined in concept —> populate game with more levels
    - Expanding game logic with abilities of the characters
    - Enrich levels with more detailed structures, graphics, abilities and gameplay behavior
    - Finalizing gameplay behavior
- Modelling
    - Finalizing models for final build
    - Enhancing animations (more fluent playbacks)
    - Adding new models and objects if needed for specific levels
- Concept
    - Comparison: how does the concept really work in the game
    - How have changes to the gameplay behavior changed the concept design
    - Have reworks on the concept been necessary

## USER CHARACTERISTICS

Users should have a compatible Computer. Furthermore they should like games, in which team
play is a key part.

## CONSTRAINTS
//regarding what

## ASSUMPTIONS AND DEPENDENCIES
In general, several Dependencies / Assumptions will be needed to guarantee a successful
implementation.
- IDE: 	 	 	 	      Unity
- Version-Control:		 	 GitHub
- Programming Language: C#
- Modeling and Animation: Blender, Autodesk
- Further Tools:	 	 	 Wordpress, Targetprocess, GarageBand

# Specific Requirements

## FUNCTIONALITY

1. Main Menu:  Within the Main Menu, the User has the option to start / quit the game, or to
             	 	 navigate to a another panel, to change some predefined settings.

2. Play
3. Settings Menu
4. About

## USABILITY

1. Installation
    : The user should know how to download a file from the internet and how to run
      	 	 such.

2. Play
    : The user should have a working computer with keyboard, mouse and screen.

## RELIABILITY

1. Availability
    :As long as the user does not delete the application from the device, it will be
     	 	 playable all the time.
     If deleted, it can be downloaded from the website.

2. Bugs
    :By now, no bugs are known. If bugs occur, there is the possibility to contact the
     	 	 developers via E-Mail or using the blog.

## PERFORMANCE

1. CPU / GPU
   	 	 :Due to the fact that we are dealing with low poly graphics and the game complexity
   	 	 has not a huge impact on the processing power of the computer, the game should
   	 	 be able to run very smooth on nearly every device

## SUPPORTABILITY

1. Coding Standards
2. Naming Conventions
3. Libraries

## DESIGN CONSTRAINTS

## ON-LINE USER DOCUMENTATION AND HELP SYSTEM REQUIREMENTS

A simple guide will be placed within the game itself. For further questions and / or help visiting the
blog or sending mails to the support will be necessary.

## PURCHASED COMPONENTS

None

## INTERFACES

1. User Interfaces
   	 	 :Starting the application, the user will see a short list of pictures / videos before
   	 	 getting to the main menu.
   	 	 There the user will have the possibility to start / end the game, get further
   	 	 information or to change some settings.
   	 	 Starting the game will load the depending scenes and make the game playable for
   	 	 two players.

2. Hardware Interfaces
        :There will be no need for Hardware Interfaces.

3. Software Interfaces
   	 	 :to be determined.

4. Communications Interfaces
   	 	 :to be determined. (keyboard/mouse interaction?)

## COMPLEXITY
## LICENSING REQUIREMENTS
## LEGAL, COPYRIGHT AND OTHER NOTICES
## APPLICABLE STANDARDS

# Supporting Information