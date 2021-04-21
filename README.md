# Topic: Property Investment
## (Finding a property near good helathcare centers & low crime incidents)
---

![neighborhood1](https://user-images.githubusercontent.com/47906013/111054373-31003980-843a-11eb-8a5f-7c090de88f7c.jpg)


[Property_Investment] (https://shashirautela-propertyinvestment.azurewebsites.net/)
-------

##### Design Document

- Shashi Rautela , Ioana Guna & Damon

## Introduction

This website will help you to find best property location in Cincinnati based on your choice ( Propety type : Residential , Office , Retail, Hospital ), based on heathcare facilities nearby or low crime rate.   

-MyFutureInvestment can help you:

-	**Decide which type of property you are looking for your investment**

- **You can also find property based on your prefered neighborhood or zipcode**

-	**Onece you finalized the type of property in particular neighborhood, You can search healthcare facilitites and crime rate in location before investing in that property**


***Search***  Type of property ( Residential/ Retail/Office/ Healthcare)

***View***  Type of Propertity Details in Cincinnati, OH

***Search***  Type of property in particular neighborhood or zipcode

***Search***   Crime Details in choosen zipcode

***View***  Crime Details in given zipcode

***Search***  Healthcare loaction in choosen zipcode

***View***  Healthcare Details in given zipcode

________________________________________
## Data Feeds

- [Commercial Economic Incentives- City of Cincinnati](https://data.cincinnati-oh.gov/Growing-Economic-Opportunities/Commercial-Economic-Incentives-City-of-Cincinnati/m76i-p5p9)

- [PDI (Police Data Initiative) Crime Incidents](https://data.cincinnati-oh.gov/Safety/PDI-Police-Data-Initiative-Crime-Incidents/k59e-2pvf)

- [Cincinnati Health Department Health Care Centers](https://data.cincinnati-oh.gov/Thriving-Neighborhoods/Cincinnati-Health-Department-Health-Care-Centers/v8yh-wpss)


**Other Group data source:**

-[Covinator](https://shashirautela-propertyinvestment.azurewebsites.net/CovidVaccine)
________________________________________

## Functional Requirements

### Requirement 1: 

***Search for property Type***

#### Scenario

As a user interested in investing in a  property  in Cincinnati (OH), he/she can search property by its type.
#### Dependencies

- Different type of Property in Cincinnati,  data are available and accessible.


***Search for property type  in a particular zipcode or neighborhood ***

#### Scenario 1

As a user interested in investing in a  particulae property type in particular location  in Cincinnati (OH)

#### Dependencies

-Property deatils in particular zipcode or neighborhood in Cincinnati,  data are available and accessible.

#### Assumptions

***Search for Crime details in given zipcode, where used want to invest***

#### Scenario

As a user interested to know crime details in prefered location / neighborhood /  zipcode in Cincinnati (OH), he/she can search crime deatils by giving zipcode.

#### Dependencies

- Crime details by neighborhood/ zipcode / street details are available and accessible.

***Search for Healthcare details***

#### Examples 1.1 

**Search for property in Cincinnati**

- **Given**  Property search button

- **When**  Click search button

- **Then**  It will show all the property-projects details with its type in Cincinnati.

- **Given**  search box

 **When**  key in property type  (Residential)

- **Then**  It will show "Residential" property-projects and its locations.

-**User Selected "Residential Property" at zipcode (45202)

### Requirement 2: 

***Property investment in the safe Neighborhood ***

#### Scenario 1:

- As a user interested in investing in property in the safe neighborhood

#### Dependencies

- Crime incidents data are available and accessible.

#### Assumptions

- **zipcode belongs to cincinnati Ohio**

####  Example 1.1  

**search Crime incident details as choosen zipcode where user wants to investment in the  property**
 
- **Given**  Zipcode Search box

- **When**  45223

-  **Then**  details of the crimes reported in the given zipcode (45223)

### Requirement 2: 

#### Scenario :

**A person wants to search for healthcare centers near given zipcode**

***Dependencies***

***Healthcare facilities details at given zipcode***

##### Example

**Search for healthcare centers at given zipcode **

- **Given**   Zipcode

- **When** 	 45223

- **Then**  All healthcare centers  details at given Zipcode (45223)


**User wanted to invest in the Residential property and he found it at zipcode 45223.  He/ She checked Healthcare facilities and Crime details at zipcode 45202 and decided to 
invest as there are 3 heathcare nearby and crime incidents are  is low. **
________________________________________

## Roles

- Frontend Developer/Integration Developer/ Backend Development: **Shashi Rautela, Ioana Guna & Damon**

## Weekly Meeting 

-Monday at 2 pm on Teams

-Friday at 3 pm on Teams


