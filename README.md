# Topic: Property Investment
## (Finding a property near good helathcare centers & low crime incidents)
---

![neighborhood1](https://user-images.githubusercontent.com/47906013/111054373-31003980-843a-11eb-8a5f-7c090de88f7c.jpg)

-------

##### Design Document

- Shashi Rautela

- Ioana Guna

## Introduction

Do you want to find the best location for your future investment? Do you know how to search properties that are located in a safe location with healthcare facilities? MyFutureInvestment can help you:

-	Check location with crime incidents reported 

-	Know potential growth of specific locations such as future projects.
 
- Decide which neighborhood you want to invest



***Search***  neighborhood / street address / zipcode

***View***  Crime incident / healthcare center

***Search***  Project type (Residential / Office / Mixed use)

***View***  Street Address in Cincinnati 

________________________________________
## Data Feeds

- [Commercial Economic Incentives- City of Cincinnati](https://data.cincinnati-oh.gov/Growing-Economic-Opportunities/Commercial-Economic-Incentives-City-of-Cincinnati/m76i-p5p9)

- [PDI (Police Data Initiative) Crime Incidents](https://data.cincinnati-oh.gov/Safety/PDI-Police-Data-Initiative-Crime-Incidents/k59e-2pvf)

- [Cincinnati Health Department Health Care Centers](https://data.cincinnati-oh.gov/Thriving-Neighborhoods/Cincinnati-Health-Department-Health-Care-Centers/v8yh-wpss)

________________________________________

## Functional Requirements

### Requirement 1: 

***Search for type of property***


#### Scenario

As a user interested in investing in a particular property type in Cincinnati,  he/she can search property address based on his/ her selection type. 

#### Dependencies

- Different type of Property projects in Cincinnati data are available and accessible.

#### Assumptions


***Property type***


#### Examples 1.1 

**Search for property type : Residential / Office / Mixed use in interested street/town in Cincinnati**

- **Given**  Street address/ town

- **When**  Residential

- **Then**  receive list of Residential property details


### Requirement 2: 

***Property investment in the safe Neighborhood with Healthcare facilities nearyby***

#### Scenario 1:

- As a user interested in investing in property in the safe neighborhood

#### Dependencies

- Crime incidents/Healthcare centers based on street address are available and accessible.

#### Assumptions

- **Neighborhood name is correct.**



####  Example 1.1  

**search safe neighborhood for property investment**

- **Given**  Neighborhood

- **When**  Crime incident

-  **Then**  List of crime reported in the given neighborhood 


##### Example 1.2 

**Search for healthcare centers around neighborhood street address**

- **Given**   Neighborhood address

- **When** 	 healthcare centers

- **Then** list of healthcare centers in the given neighborhood 


#### Scenario 2:

**A person wants to search for a property type in Cincinnati which has low crime incidents and healthcare centers facilities nearby**

***Dependencies***

- Crime incidents in Cincinnati data source is available

- Cincinnati Healthcare Centers data is available 


***Assumptions***

- Neighborhood with Low crime incidents

- Healthcare center nearby

**Example 1.1**

- ***Given***  Neighborhood 

- ***When***  crime incidents 

- ***Then*** List of Neighborhoods with reported number of crime incidents 

**Example 1.2**

- ***Given***  Neighborhood 

- ***When***  Healthcare centers 

- ***Then***  List of Neighborhoods near Healthcare centers

________________________________________

## Roles

- Frontend Developer/Integration Developer/ Backend Development: **Shashi Rautela & Ioana Guna**

## Weekly Meeting 

-Monday at 2 pm on Teams

-Friday at 3 pm on Teams


