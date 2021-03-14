# My Future Investment
---

![neighborhood1](https://user-images.githubusercontent.com/47906013/111054373-31003980-843a-11eb-8a5f-7c090de88f7c.jpg)

## Topic : "Finding a property near good helathcare centers & low crime incidents) 
-------

Design Document

Shashi Rautela

Ioana Guna

## Introduction

Do you want to find the best location for your future investment? Do you know how to search properties that are located in a safe location? MyFutureInvestment can help you:

-	Record dates and location of incidents that happened. 
-	Take and view photos of a street/building/neighborhood.
-	Record when you visited the location and why you had interested in it.
-	Be aware of potential growth of specific locations such as future projects.
 
Use your web browser to decide your own future investment. Create reminders based on what you visited in the past. Receive alerts about upcoming projects.


Looking for ……   (Story)


***Search*** neighborhood / street address

***View*** Crime incident / healthcare center

***Search*** Project type (Residential / Office / Mixed use)
________________________________________
## Data Feeds

[PDI (Police Data Initiative) Crime Incidents] (“https://data.cincinnati-oh.gov/Safety/PDI-Police-Data-Initiative-Crime-Incidents/k59e-2pvf”)


[Commercial Economic Incentives- City of Cincinnati] (“https://data.cincinnati-oh.gov/resource/m76i-p5p9.json”)

[Cincinnati Health Department Health Care Centers] (“https://data.cincinnati-oh.gov/Thriving-Neighborhoods/Cincinnati-Health-Department-Health-Care-Centers/v8yh-wpss”)

________________________________________
## Functional Requirements

### Requirement 1: Search for Property

#### Scenario

As a user interested in investing in a particular neighborhood in Cincinnati, I want to be able to search properties that have low crime rate.

#### Dependencies

Incidents search data are available and accessible.

#### Assumptions

Location is accurate.

#### Examples

1.1

**Given** a name of street data is available
**When** I search for “Calhoun St”
**Then** I should receive all incidents that happened on Calhoun Street.

1.2 

**Given** a date reported data is available.
**When** I search “2020”
**Then** I should receive at least one result with these attributes:
Address: “Calhoun Street”
Date Reported: “2020”.

1.3 
**Given** a name of street data is available
**When** I search for “shbcuhcuihe”
**Then** I should receive zero results (an empty list)

### Requirement 2: Save Property/Land

#### Scenario

As a user interested in investing, I want to be able to enter and save details of a property/land: date visited, photos, and address, so that I can review a history of this neighborhood.

#### Dependencies

Property/Land search data are available and accessible.

#### Assumptions

Street name is stated correct.

#### Examples

1.1

**Given** a name of street data is available
**When** 
- Select the street name “Calhoun Street”
- Add notes: “visited by Ioana Guna”

**Then** when I navigate to the Street History view, I should see at least one property/land with the notes, “visited by Ioana Guna”.

1.2 

**Given** a name of street data is available
**When** 	
- Select the property
- Upload a photo of the property.

**Then** when I navigate to the Street History view, I should see at least one property with a photo of that building/land.


***Search***  Project type (Residential / Office / Mixed use)


***Scenario***

A person wants to search for a property in a particular neighborhood in Cincinnati which has low crime incident and healthcare centers nearby

***Dependencies***

-Commercial Economic Incentives- City of Cincinnati
 
-Commercial Economic Incentives- City of Cincinnati

-Cincinnati Health Department Health Care Centers


***Assumptions***

-Low crime rate
-Reasonable property tax
-Healthcare center nearby

**Example 1.1**

***Given***

***When***  property type 

***Then*** Should receive at least one result with these attributes

-Property details

-Crime incident

-Healthcare centers
________________________________________

## Scrum Roles

- DevOps/Product Owner/Scrum Master: Ioana Guna & Sashi Rautela
- Frontend Developer: Ioana Guna & Sashi Rautela
- Integration Developer: Ioana Guna & Sashi Rautela

## Weekly Meeting 

-Monday at 2 pm on Teams

-Friday at 3 pm on Teams


## Class Diagram

#### Class Diagram Discription




