# Topic: Property Investment
## (Finding a property near good helathcare centers & low crime incidents)
---

![neighborhood1](https://user-images.githubusercontent.com/47906013/111054373-31003980-843a-11eb-8a5f-7c090de88f7c.jpg)

-------

##### Design Document

- Shashi Rautela

- Ioana Guna

- Damon Nicholas

## Introduction

Do you want to find the best location for your future investment? Do you know how to search properties that are located in a safe location with healthcare facilities? MyFutureInvestment can help you:

-	Check location with crime incidents reported 

-	Know potential growth of specific locations such as future projects.
 
- Decide which neighborhood you want to invest

***Search***  Property Details

***View***  Property Details in Cincinnati, OH

***Search***   Crime Details 

***View***  Crime Details in Cincinnati, OH

***Search***  Healthcare 

***View***  Healthcare Details in Cincinnati, OH

________________________________________
## Data Feeds

- [Commercial Economic Incentives- City of Cincinnati](https://data.cincinnati-oh.gov/Growing-Economic-Opportunities/Commercial-Economic-Incentives-City-of-Cincinnati/m76i-p5p9)

- [PDI (Police Data Initiative) Crime Incidents](https://data.cincinnati-oh.gov/Safety/PDI-Police-Data-Initiative-Crime-Incidents/k59e-2pvf)

- [Cincinnati Health Department Health Care Centers](https://data.cincinnati-oh.gov/Thriving-Neighborhoods/Cincinnati-Health-Department-Health-Care-Centers/v8yh-wpss)

________________________________________

## Functional Requirements

### Requirement 1: 

***Search for property***

#### Scenario

As a user interested in investing in a  property  in Cincinnati (OH), he/she can search property deatils by searching Property.
#### Dependencies

- Property details in Cincinnati data are available and accessible.
-

#### Assumptions


***Search for Crime details***

#### Scenario

As a user interested in crime details in particulat zipcode in Cincinnati (OH), he/she can search crime deatils by searching Crime information.
#### Dependencies

- Crime details in Cincinnati data are available and accessible.

***Search for Healthcare details***


#### Scenario

As a user interested in healthcare location and services detials in Cincinnati (OH), he/she can search Healthcare deatils by searching Healthcare.

#### Dependencies

- Healthcare details in Cincinnati data are available and accessible.

#### Examples 1.1 

**Search for property in Cincinnati**

- **Given**  Property search button

- **When**  Click search button

- **Then**  It will show all the property-projects details in Cincinnati.

- **Given**  Zipcode search box

 **When**  key in zipcode

- **Then**  It will show all the detials about property-projects in given zipcode (Cincinnati).


#### Examples 1.2 

**Search for Crime in Cincinnati**

- **Given**  Crime search button

- **When**  Click search button

- **Then**  It will show all the crime reported details in Cincinnati.

- **Given**  Zipcode search box

 **When**  key in zipcode

- **Then**  It will show all the detials about crime incidents in given zipcode (Cincinnati).

#### Examples 1.3

**Search for Neighborhood in Cincinnati**

- **Given**  Neighborhood search button

- **When**  Click search button

- **Then**  It will show all the healthcares details in Cincinnati.

- **Given**  Zipcode search box

 **When**  key in zipcode

- **Then**  It will show all the detials about healthcare in given zipcode (Cincinnati).

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

- **Given**  Zipcode Search box

- **When**  45202

-  **Then**  List of crime reported in the given zipcode


##### Example 1.2 

**Search for healthcare centers around neighborhood street address**

- **Given**   Zipcode

- **When** 	 45204

- **Then** list of healthcare centers in the given Zipcode


#### Scenario 2:

**A person wants to search for a property type in Cincinnati which has low crime incidents and healthcare centers facilities nearby**

***Dependencies***

- Crime incidents in Cincinnati data source is available

- Cincinnati Healthcare Centers data is available 


***Assumptions***

- Neighborhood with Low crime incidents

- Healthcare center nearby

**Example 1.1**

- ***Given***  Zipcode

- ***When***  45236

- ***Then*** List of Neighborhoods with reported number of crime incidents 


________________________________________

## Roles

- Frontend Developer/Integration Developer/ Backend Development: **Shashi Rautela, Ioana Guna & Damon Nicholas**

## Weekly Meeting 

-Monday at 2 pm on Teams

-Friday at 3 pm on Teams


