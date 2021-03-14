# My Future Investment
---

![neighborhood1](https://user-images.githubusercontent.com/47906013/111054373-31003980-843a-11eb-8a5f-7c090de88f7c.jpg)

## Topic : "Finding a property near good helathcare centers & low crime incidents"
-------

##### Design Document

- Shashi Rautela

- Ioana Guna

## Introduction

Do you want to find the best location for your future investment? Do you know how to search properties that are located in a safe location with healthcare facilities? MyFutureInvestment can help you:

-	Check location with crime incidents reported 

-	Know potential growth of specific locations such as future projects.
 
- Decide which neighborhood you want to invest



***Search***  neighborhood / street address

***View***  Crime incident / healthcare center

***Search***  Project type (Residential / Office / Mixed use)

***View***  Street Address in Cincinnati 

________________________________________
## Data Feeds

[PDI (Police Data Initiative) Crime Incidents] (“https://data.cincinnati-oh.gov/Safety/PDI-Police-Data-Initiative-Crime-Incidents/k59e-2pvf”)


[Commercial Economic Incentives- City of Cincinnati] (“https://data.cincinnati-oh.gov/resource/m76i-p5p9.json”)

[Cincinnati Health Department Health Care Centers] (“https://data.cincinnati-oh.gov/Thriving-Neighborhoods/Cincinnati-Health-Department-Health-Care-Centers/v8yh-wpss”)

________________________________________
## Functional Requirements

### Requirement 1: 

***Search for type of property***


#### Scenario

As a user interested in investing in a particular property type in Cincinnati,  he/she can search property address based on his/ her selection type. 

#### Dependencies

Property type projects in Cincinnati data are available and accessible.

#### Assumptions


***Property type***


#### Examples

#### 1.1 Search for property type : Residential / Office / Mixed use in interested street/town in Cincinnati

**Given**  Street address/ town

**When**  Residential

**Then**  receive list of Residential property details




### Requirement 2: 

***Property investment in the safe Neighborhood with Healthcare facilities nearyby***

#### Scenario

As a user interested in investing in property in the safe neighborhood 

#### Dependencies

Crime incident/Healthcare centers in the particular street address are available and accessible.

#### Assumptions

Neighborhood name is correct.



#### Examples

##### 1.1  search safe neighborhood for property investment

**Given**  Neighborhood

**When**  Crime incident 


**Then** should see list of crime incidents in that neighborhood 


##### 1.2 Search for healthcare centers around neighborhood street address

**Given**   Neighborhood address

**When** 	 healthcare centers

**Then** list of healthcare centers in particular neighborhood 


#### Scenario

A person wants to search for a property type in Cincinnati which has low crime incidents and healthcare centers facilities nearby

***Dependencies***

- Commercial Economic Incentives- City of Cincinnati
 
- Commercial Economic Incentives- City of Cincinnati

- Cincinnati Health Department Health Care Centers



***Assumptions***

- Neighborhood with Low crime incidents

- Healthcare center nearby

**Example 1.1**

***Given***  Neighborhood 

***When***  Less crime incidents 

***Then*** Should receive at least one result with these attributes

- List of Neighborhoods in low crime incidents 

**Example 1.2**

***Given***  Neighborhood 

***When***  Healthcare centers 

***Then*** Should receive at least one result with these attributes

- List of Neighborhoods near Healthcare centers

________________________________________

## Roles
- Frontend Developer/Integration Developer/ Backend Development: Shashi Rautela & Ioana Guna 

## Weekly Meeting 

-Monday at 2 pm on Teams

-Friday at 3 pm on Teams


## Class Diagram


#### Class Diagram Discription




