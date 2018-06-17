# SGFA

# Testplan


## Revision History

| Date          | Version  | Description       | Author |
| ------------- |----------| ------------------|--------|
| 03.05.2017    | 1.0      | Creation of Document    | Jochem :apple:|
| 17.06.2017    | 1.1      | Switched to Markdown    |Sauer	:sunglasses: |

- [1. Introduction](#1-introduction)
  * [1.1 PURPOSE](#11-purpose)
  * [1.2 SCOPE](#12-scope)
  * [1.3 INTENDED AUDIENCE](#13-intended-audience)
  * [1.4 DOCUMENT TERMINOLOGY AND ACRONYMS](#14-document-terminology-and-acronyms)
  * [1.5 REFERENCES](#15-references)
- [2. Evaluation Mission and Test Motivation](#2-evaluation-mission-and-test-motivation)
  * [2.1 BACKGROUND](#21-background)
  * [2.2 EVALUATION MISSION](#22-evaluation-mission)
  * [2.3 TEST MOTIVATORS](#23-test-motivators)
- [3. Target Test Items](#3-target-test-items)
- [4. Outline of Planned Tests](#4-outline-of-planned-tests)
  * [4.1 OUTLINE OF TEST INCLUSIONS](#41-outline-of-test-inclusions)
  * [4.2 OUTLINE OF OTHER CANDIDATES FOR POTENTIAL INCLUSION](#42-outline-of-other-candidates-for-potential-inclusion)
- [5. Test Approach](#5-test-approach)
  * [5.1 INITIAL TEST-IDEA CATALOGS AND OTHER REFERENCE SOURCES](#51-initial-test-idea-catalogs-and-other-reference-sources)
  * [5.2 TESTING TECHNIQUES AND TYPES](#52-testing-techniques-and-types)
    + [5.2.1 DATA AND DATABASE INTEGRITY TESTING](#521-data-and-database-integrity-testing)
    + [5.2.2 FUNCTION TESTING](#522-function-testing)
    + [5.2.3 BUSINESS CYCLE TESTING](#523-business-cycle-testing)
    + [5.2.4 USER INTERFACE TESTING](#524-user-interface-testing)
    + [5.2.5 PERFORMANCE PROFILING](#525-performance-profiling)
    + [5.2.6 LOAD TESTING](#526-load-testing)
    + [5.2.7 STRESS TESTING](#527-stress-testing)
    + [5.2.8 VOLUME TESTING](#528-volume-testing)
    + [5.2.9 SECURITY AND ACCESS CONTROL TESTING](#529-security-and-access-control-testing)
    + [5.2.10 FAILOVER AND RECOVERY TESTING](#5210-failover-and-recovery-testing)
    + [5.2.11 CONFIGURATION TESTING](#5211-configuration-testing)
    + [5.2.12 INSTALLATION TESTING](#5212-installation-testing)
- [6. Entry and Exit Criteria](#6-entry-and-exit-criteria)
  * [6.1 TEST PLAN](#61-test-plan)
    + [6.1.1 TEST PLAN ENTRY CRITERIA](#611-test-plan-entry-criteria)
    + [6.1.2 TEST PLAN EXIT CRITERIA](#612-test-plan-exit-criteria)
  * [6.2 TEST CYCLES](#62-test-cycles)
- [7. Deliverables](#7-deliverables)
  * [7.1 TEST EVALUATION SUMMARIES](#71-test-evaluation-summaries)
  * [7.2 REPORTING ON TEST COVERAGE](#72-reporting-on-test-coverage)
  * [7.3 PERCEIVED QUALITY REPORTS](#73-perceived-quality-reports)
  * [7.4 INCIDENT LOGS AND CHANGE REQUESTS](#74-incident-logs-and-change-requests)
  * [7.5 SMOKE TEST SUITE AND SUPPORTING TEST SCRIPTS](#75-smoke-test-suite-and-supporting-test-scripts)
  * [7.6 ADDITIONAL WORK PRODUCTS](#76-additional-work-products)
- [8. Testing Workflow](#8-testing-workflow)
- [9. Environmental Needs](#9-environmental-needs)
  * [9.1 BASE SYSTEM HARDWARE](#91-base-system-hardware)
  * [9.2 BASE SOFTWARE ELEMENTS IN THE TEST ENVIRONMENT](#92-base-software-elements-in-the-test-environment)
  * [9.3 PRODUCTIVITY AND SUPPORT TOOLS](#93-productivity-and-support-tools)
- [10. Responsibilities, Staffing and Training Needs](#10-responsibilities--staffing-and-training-needs)
  * [10.1 PEOPLE AND ROLES](#101-people-and-roles)
  * [10.2 STAFFING AND TRAINING NEEDS](#102-staffing-and-training-needs)
  * [11. Iteration Milestones](#11-iteration-milestones)
  * [12. Risks, Dependencies, Assumptions and Constraints](#12-risks--dependencies--assumptions-and-constraints)
- [13. Management Process and Procedures](#13-management-process-and-procedures)
  * [13.1 MEASURING AND ASSESSING THE EXTENT OF TESTING](#131-measuring-and-assessing-the-extent-of-testing)
  * [13.2 ASSESSING THE DELIVERABLES OF THIS TEST PLAN](#132-assessing-the-deliverables-of-this-test-plan)
  * [13.3 PROBLEM REPORTING, ESCALATION AND ISSUE RESOLUTION](#133-problem-reporting--escalation-and-issue-resolution)
  * [13.4 MANAGING TEST CYCLES](#134-managing-test-cycles)
  * [13.5 TRACEABILITY STRATEGIES](#135-traceability-strategies)
  * [13.6 APPROVAL AND SIGNOFF](#136-approval-and-signoff)

## 1. Introduction
### 1.1 PURPOSE
The purpose of the Iteration Test Plan is to gather all of the information necessary to plan and
control the test effort for a given iteration. It describes the approach to testing the software. This
test plan for SGFA - Souls Gathering First Alliance supports the following Objectives:


- Specification of the scope, which game objects or behaviors should be tested
- Why those should be tested

### 1.2 SCOPE
Since the Team is developing the game in Unity, special Test Tools must be used to run Unit Tests.
Therefore Unity allows developers to create Unit Tests right in its engine, using the build-in Unity
Test Tools. These tools allow the developers to subdivide their tests in
- Edit Mode Tests
	 	 These kind of tests „only“ run logical methods
- Play Mode Tests
	 	 Whereas the play mode tests also allow tests regarding the behavior of
	 	 gameobjects while running the game
Although we will focus on Edit Mode Testing, we will try to implement Play Mode Tests as well.

### 1.3 INTENDED AUDIENCE
This test plan is intended for developers and interested readers. Further descriptions on the game
itself can be found on the GitHub Repository. Therefore only active developers should use this
document to work on the project.

### 1.4 DOCUMENT TERMINOLOGY AND ACRONYMS

|Abbr.| Abbreviation |
|-----|--------------|
| n/a |not applicable|
| CI | Continuous Integration|
|SRS| Software Requirements Specification|
|UI| User Interface|

### 1.5 REFERENCES

|Documents|
|----------|
|[SRS][SRS]|
|[SAD][SAD]|
|[Blog][blo]|
|[UseCaseMove][MUC]|
|[UseCaseGainAbility][GAUC]|
|[UseCaseChangeVolume][CVUC]|
|[UseCaseSelectLevel][SLUC]|
|[UseCaseFreeSoul][FSUC]|
|[UseCaseOpenMenu][OMUC]|
|[UseCaseFinishLevel][FLUC]|
|[UseCaseEndGame][EGUC]|
|[UseCaseStartGame][SGUC]|

[SRS]:https://github.com/joachim747/SGFA/blob/master/Documentation/SRS/SRS.md
[SAD]:https://github.com/joachim747/SGFA/blob/master/Documentation/SRS/SAD.md
[blo]:sgfaweb.wordpress.com
[MUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/Move/Move.md "UseCaseDiagram Move"
[GAUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/GainAbility/GainAbility.md "UseCaseDiagram Gain Ability"
[CVUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/ChangeVolume/ChangeVolume.md "UseCaseDiagram Change Volume"
[SLUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/SelectLevel/SelectLevel.md "UseCaseDiagram Select Level"
[FSUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/FreeSoul/FreeSoul.md "UseCaseDiagram Free Soul"
[OMUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/OpenMenu/OpenMenu.md "UseCaseDiagram Open Menu"
[FLUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/StartGame/FinishLevel.md "UseCaseDiagram FinishLevel"
[EGUC]: https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/EndGame/EndGame.md "UseCaseDiagram End Game"
[SGUC]:https://github.com/joachim747/SGFA/blob/master/Documentation/UseCases/StartGame/StartGame.md

## 2. Evaluation Mission and Test Motivation

### 2.1 BACKGROUND
Ongoing development makes it hard to determine, whether further changes might cause serious
damage. Using Tests we ensure, that future changes does not have a negative effect on our
source code.
By later integrating the test process in our deployment process we also make sure, that only
successfully tested versions are deployed.

### 2.2 EVALUATION MISSION
Testing is necessary to recognize potential bugs early and to be able to fix such. The mission is to
reduce the amount of errors caused by code as early as possible, avoiding possible crashes while
someone is playing the game.

### 2.3 TEST MOTIVATORS
Our testing is motivated by technical risks as well as quality. This shall help us providing stability
to our game.

## 3. Target Test Items
The listing below identifies those test items that have been identified as targets for testing. This
list represents what items will be tested.
- Code-Components
- Behavior of individual GameObjects and their behavior to other Objects
Please Note: Although we will try to write as many tests as possible for SGFA, it is unclear how far
we can get without spending too much resources on it which are needed to finish SGFA as
planned and described in the scope.

## 4. Outline of Planned Tests

### 4.1 OUTLINE OF TEST INCLUSIONS
Creation of unit tests for all target test items.

### 4.2 OUTLINE OF OTHER CANDIDATES FOR POTENTIAL INCLUSION
n/a

## 5. Test Approach

### 5.1 INITIAL TEST-IDEA CATALOGS AND OTHER REFERENCE SOURCES
n/a

### 5.2 TESTING TECHNIQUES AND TYPES
#### 5.2.1 DATA AND DATABASE INTEGRITY TESTING
	 	 n/a
#### 5.2.2 FUNCTION TESTING

||Description|
|----|-----------|
|Technique Objective| Correct behavior of unit tests for tested functionalities |
|Technique|Creation of unit tests using Unity Test Tools |
|Oracles|Succesfull execution of unit tests in Unity Test Runner, later sucessfull execution on build|
|Required Tools|Unity, Unity Test Runner, Unity Test Tools|
|Success Criteria||
|Special Considerations|Complex tests when trying to reach private variables and check behavior between different objects communicating via multiple scripts|

#### 5.2.3 BUSINESS CYCLE TESTING
	 	 n/a

#### 5.2.4 USER INTERFACE TESTING
	 	 n/a

#### 5.2.5 PERFORMANCE PROFILING
	 	 n/a

#### 5.2.6 LOAD TESTING
	 	 n/a

#### 5.2.7 STRESS TESTING
	 	 n/a

#### 5.2.8 VOLUME TESTING
	 	 n/a

#### 5.2.9 SECURITY AND ACCESS CONTROL TESTING
	 	 n/a

#### 5.2.10 FAILOVER AND RECOVERY TESTING
	 	 n/a

#### 5.2.11 CONFIGURATION TESTING
	 	 n/a

#### 5.2.12 INSTALLATION TESTING

||Description|
|----|-----------|
|Technique Objective| Successfull Installation of SGFA on Linux, Mac and Windows |
|Technique|Manual download. There is no further installation needed since Unity automatically creates a depending executable |
|Oracles| Manual launch of downloaded software|
|Required Tools|Unity, TravisCI|
|Success Criteria|Successful Installation on named platforms with the possibility to run the application without crash|
|Special Considerations| - |

## 6. Entry and Exit Criteria
### 6.1 TEST PLAN

#### 6.1.1 TEST PLAN ENTRY CRITERIA
	 	 Building a new version of the software will execute the testprocess.
	 	 Installation testing has to follow after build.

#### 6.1.2 TEST PLAN EXIT CRITERIA
	 	 All tests pass without throwing an error.

### 6.2 TEST CYCLES
n/a

## 7. Deliverables
### 7.1 TEST EVALUATION SUMMARIES
n/a

### 7.2 REPORTING ON TEST COVERAGE
n/a

### 7.3 PERCEIVED QUALITY REPORTS
n/a

### 7.4 INCIDENT LOGS AND CHANGE REQUESTS
n/a

### 7.5 SMOKE TEST SUITE AND SUPPORTING TEST SCRIPTS
n/a

### 7.6 ADDITIONAL WORK PRODUCTS
n/a

## 8. Testing Workflow
Adding new functionalities to the build, new Unit-Tests will be written by the developer as well. All
unit tests are, as mentioned earlier, automatically executed on build.

## 9. Environmental Needs

### 9.1 BASE SYSTEM HARDWARE
The following table sets forth the system resources for the test effort presented in this test plan.
System Resources

|Resource|Quantity|Name and Type|
|--------|--------|-------------|
|PC| 2| Laptop, Windows 10|
|Mac| 1| Desktop, MacOS High Sierra|
|Mac| 1| Book Pro, MacOS High Sierra|

### 9.2 BASE SOFTWARE ELEMENTS IN THE TEST ENVIRONMENT

|Software Element Name| Version| Type and Other Notes|
|Windows| 10| OS|
|MacOS| High |Sierra OS|
|Linux |— |OS|
|Internet Browser |Any |Any Browser possible|
|Unzipping Software|Any| Comes with most Operating Systems|

### 9.3 PRODUCTIVITY AND SUPPORT TOOLS
The following tools will be employed to support the test process for this test plan.

|Tool Category or Type |Tool Brand Name |Vendor or In-House |Version|
|----------------------|----------------|-------------------|-------|
|GameEngine & Testing Tools |Unity |Vendor |2017.02.0f3|
|IDE |Visual Studio Code |Vendor |2017|
|IDE |Visual Studio |Vendor |2015|
|Project Management |TargetProcess |Vendor |2018|
|CI Service |Travis CI |Vendor |2018|

## 10. Responsibilities, Staffing and Training Needs
### 10.1 PEOPLE AND ROLES
This table shows the staffing assumptions for the test effort.

|Role| Minimum Resources Recommended (number of full-time roles allocated)| Specific Responsibilities or Comments|
|----|--------------------------------------------------------------------|--------------------------------------|
|Implementer| 1 |Creates the test components to support testability requirements as defined by the designer|
|Tester| 1 |Implements tests and test suites Executes test suites Log results Analyze and fix test failures Document incidents|
|Test Designer| 1 |Defines test approach Verifies test techniques Define testability elements Structuring test implementation|

### 10.2 STAFFING AND TRAINING NEEDS
Necessary roles are staffed by project members. Unit Testing within the Unity Test Tools is not as
well documented due to the fact, that tests are very specific and individual. Some research must
be done before proper tests can be written and executed

### 11. Iteration Milestones
Due to the fact that we just started using and working with the Unity Test Tools and we need
some more research on it, there are no milestones we could define right now.

### 12. Risks, Dependencies, Assumptions and Constraints
n/a
Please check our Risk Management Document on GitHub for further information.

## 13. Management Process and Procedures
### 13.1 MEASURING AND ASSESSING THE EXTENT OF TESTING
Test coverage can be calculated using the Unity Test Tools.

### 13.2 ASSESSING THE DELIVERABLES OF THIS TEST PLAN
Assessment is checked by monitoring the success of running tests. Failures can be assessed by
checking the log.

### 13.3 PROBLEM REPORTING, ESCALATION AND ISSUE RESOLUTION
Issues will be fixed by the Implementer directly. If a serious issue occurs, a bug will be created in
TargetProcess and resolved in a future sprint.

### 13.4 MANAGING TEST CYCLES
n/a

### 13.5 TRACEABILITY STRATEGIES
n/a

### 13.6 APPROVAL AND SIGNOFF
n/a