# IS7024
XML Project

## Real Estate - Smart Move!

**Team Members**
- Kishore Kumar T
- Pranav Naphad
- Sairam Akuthota
- Amar Hadagali
- Maheshwara Reddy

## Introduction 

This website aims at providing users a one stop portal for finding their dream home and land to setup their business in the city of Chicago
- Enter zipcodes in Chicago city 
- View the apartments/houses list
- Also find the empty spaces nearby to setup your business (At lowest cost provided by the City Government itself) 


## Data Feeds
[City Owned Land Inventory](https://data.cityofchicago.org/resource/aksk-kvfp.json)

[Affordable Rental Housing](https://data.cityofchicago.org/resource/s6ha-ppgi.json)


## 

### Requirement_1: Find your Housing

#### Scenario

As a business owner when I move from different city to Chicago or I being a resident needs to set up a business, I want to be able to search places in chicago for affordable  housing for my workforce or myself.


#### Assumptions

The search term is ZipCode pertaining to the city of Chicago only.  
ZipCode is a 5 digit number.

#### Examples
1.1  

**Given** a zip code 60624  

**When**  I search for Housing/Aprtments in that area

**Then** I should receive list of all available Housing and its details in that area.

Humboldt Park
23
Multifamily
Nelson Mandela Apts.
607 N. Sawyer Ave.
60624
773-227-6332
Bickerdike Apts.
6
1154639.548
1903911.993
41.89215341
-87.70752657
(41.8921534052465°, -87.7075265659001°)

Humboldt Park
23
Multifamily
Rosa Parks Apts.
526 N. St. Louis Ave.
60624
773-227-6332
Bickerdike Apts.
12
1152910.964
1903460.212
41.8909481
-87.71388693
(41.8909480951075°, -87.7138869272678°)

 
### Requirement_2: Find the land to setup your business

#### Scenario

As a business owner when I move from different city to Chicago or I being a resident needs to set up a business, I want to be able to search places in chicago for setting up my business at affordable prices. So I will check the city owned land inventory data.
I may also use community number to find the land for my business.


#### Assumptions

The search term is ZipCode pertaining to the city of Chicago only.  
ZipCode is a 5 digit number.

The search term is Community Area Number pertaining to the city of Chicago only.  
Community Area Number is a 2 digit number.

#### Examples
1.1  

**Given** a Community Area Number is 23 

**When**  I search for land details in that community

**Then** I should receive list of all available land details in that community

58819
16-11-223-003-0000
545 N SAWYER AVE
None
Owned by City
11/23/1981
0
27
23
HUMBOLDT PARK
RT-4
60624
03/05/2019
1154679.818
1903728.089
41.8916479
-87.7073836
(41.891647948878486°, -87.7073835963769°)

34273
16-11-116-015-0000
615 N LAWNDALE AVE
None
Owned by City
04/24/2003
0
27
23
HUMBOLDT PARK
RT-4
60624
10/14/2021
1151703.860
1903950.550
41.8923175
-87.7183071
(41.892317458654595°, -87.71830714205326°)



 
## Scrum Roles

- DevOps/Product Owner/Scrum Master: Kishore Kumar T  
- Frontend Developer: Sairam Akuthota  
- Integration Developer: Amar Hadagali 
- Backend Developer/API: Pranav Naphad
- Webmaster: Maheswara Reddy

## Weekly Meeting

Monday at 6-7 PM on Teams






