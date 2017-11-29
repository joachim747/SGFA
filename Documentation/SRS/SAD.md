# SGFA

# Software Architecture Document

## Revision History

| Date          | Version  | Description       | Author |
| ------------- |----------| ------------------|--------|
| 22.11.2017    | 1.0      | Creation of Document    |Sauer	:sunglasses:; Jochem :apple:|
| 28.11.2017    | 1.1      | Updated Document    |Sauer	:sunglasses:; Jochem :apple:|

# Table of contents

- [Introduction](#introduction)
  * [Purpose](#purpose)
  * [Scope](#scope)
  * [Definitions, Acronyms and Abbreviations](#definitions--acronyms-and-abbreviations)
  * [References](#references)
  * [Overview](#overview)
- [Architectural Representation](#architectural-representation)
- [Architectural Goals and Constraints](#architectural-goals-and-constraints)
- [Use-Case View](#use-case-view)
  * [Use-Case Realizations](#use-case-realizations)
- [Logical View](#logical-view)
  * [Overview](#overview-1)
  * [Architecturally Significant Design Packages](#architecturally-significant-design-packages)
- [Process View](#process-view)
- [Deployment View](#deployment-view)
- [Implementation View](#implementation-view)
  * [Overview](#overview-2)
  * [Layers](#layers)
- [Data View](#data-view)
- [Size and Performance](#size-and-performance)
- [Quality](#quality)


## Introduction

### Purpose

This document provides a comprehensive architectural overview of the system, using a number of different architectural views to depict different aspects of the system.  It is intended to capture and convey the significant architectural decisions which have been made on the system.


### Scope

This SAD describes the Architecture of SGFA. For further information about the game, check out the [blog][blo].

### Definitions, Acronyms and Abbreviations

SGFA: Souls Gathering: First Alliance
Unity: Game Dev Tool / Engine / Framework
Dev: Development

### References

|Documents|
|----------|
|[SRS][SRS]|
|[Blog][blo]|
|[UseCaseMove][UCM]|
|[UseCaseStartGame][UCS]|

[SRS]:https://github.com/joachim747/SGFA/blob/master/Documentation/SRS/SRS.md
[blo]:sgfaweb.wordpress.com
[UCM]:https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/Move/Move.md
[UCS]:https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/StartGame/StartGame.md

### Overview

The following sections describe our architectural details regarding SGFA.
Please note, that we do not explain the Unity built-in functions. We focus on our own Code and Structures only.

##  Architectural Representation

Every object is a separate entity and therefore no typical architecture is represented by Unity. The used architecture is the component architecture.
The architecture with the most similarities for one entity would be MVC. The code represents the controller and the in-game objects can be compared to the view in MVC.

## Architectural Goals and Constraints

The final goal of this game would be a automatically generated world. Therefore we are building in game objects, so that they could be used by a level builder later.
Please note that the generation is not in scope for the software-engineering project.

## Use-Case View

![UseCaseView][UC]

[UC]: UseCaseDiagram.png "UseCaseDiagram for standard User"

For further information check out the [SRS][SRS] file.

### Use-Case Realizations

N/A

## Logical View

### Overview

A representation of the component architecture.

![Diagram][ContDia]

[ContDia]:http://cowboyprogramming.com/images/eyh/Fig-2.gif

### Architecturally Significant Design Packages

N/A

## Process View

N/A

## Deployment View

![Depoyment][DP]

[DP]:deployment.png

## Implementation View

### Overview

![Class Diagram][CD]

[CD]: ClassDiagram.png "Class Diagram"

### Layers

No Layers in the Project.

## Data View

Only very little persistent Data. A maximum of an optional options- or save-file.

## Size and Performance

The performance is limited by the number of vertices in an object or the number of Prticles in a system. Therefore it is not linked to the architecture.

## Quality

This is the recommended architecture to use with Unity. By using it the Quality should be at an optimum.