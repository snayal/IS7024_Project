# IS7024_Project

# Topic
-------

#### Group members

-  Shashi

-  Ioana

### Introduction
Do you remember when you enjoyed a good time at a restaurant? Do you know how to search for restaurants based on your preferences? (Name of the website) can help you:
- Record dates and locations where you went to a restaurant.
- Take and view photos of food and drinks.  
- Record when you visited the restaurant and what your order was.
- Be aware of upcoming events for a restaurant: live performance, specialties, deals, etc.

Use your web browser to decide on your next restaurant you want to try. Preview the restaurant you visited in the past. Receive alerts about upcoming events. 


## Functional Requirements

#### Requirement 1: Search for Restaurants

**Scenario**


As a user interested in restaurants, I want to be able to search restaurants based on name, location, deals, choices for food allergy/restriction, or reviews. 
##### Dependencies

Restaurant search data available and accessible.

### Assumptions

**Examples**

1.1
Given a name of city data is available
When I search for “Cincinnati”
Then I should receive all restaurants available in Cincinnati.

1.2 

Given a food restriction data is available.
When I search “vegetarian”
Then I should receive at least one result with these attributes:
Food restriction: Vegetarian.


## Requirement 2: Save Restaurants

**Scenario**

As a user interested in restaurants, I want to be able to enter and save details of a restaurant: date visited, photos, and locations, so that I can review a history of this restaurant.

##### Dependencies

Restaurant search data available and accessible.

### Assumptions

**Examples**

1.1

Given a feed of restaurant data is available
Given location details is available

When Select the Restaurant ZulaAdd notes: “visited by Ioana Guna”

when I navigate to the Restaurant History view, I should see at least one restaurant with the notes, “visited by Ioana Guna”.

1.2

Given a feed of restaurant data is available
Given location details is available
When
Select the Restaurant ZulaUpload a photo of the restaurant/meal/drink.
Then when I navigate to the Restaurant History view, I should see at least one restaurant Zula with a photo of that restaurant/meal/drink.








## Data Sources

## Class Diagram

#### Class Diagram Discription




![Garden](https://user-images.githubusercontent.com/47906013/111018074-eb356980-8384-11eb-9aed-8680c6f80fce.jpg)

