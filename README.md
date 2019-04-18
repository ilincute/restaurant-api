# FIIPracticAPI

The app I created is based on 3 main layers:

#### Data layer

  On this layer:
  * I created a class that inherits DbContext;
  * I also created a folder where I store the models used for EntityFramework;
  * based on the relationships from the database, I created a generic class for Ingredient and 2 classes for IngredientSupplier and IngredientStock, in order to make sure that the transaction between the supplier and my stock is appropriate;
  * I also created repositories for each entity, which perform CRUD operations on the models.
  
#### Business Logic Layer
  
  On this layer:
  * I added functional services for Ingredients and IngredientsSupplier (and should've also implemented functionality for Meal, Order, Balance, IngredientStock services);
  * each service perform CRUD operations received from the controller's requests;
  * I also added some logic for operations such as ordering certain ingredients from the suppliers and receiving a bill.
 
#### API Layer
  
  On this layer:
  * I added controllers for Ingredient and IngredientSupplier (and should've also implemented controllers for Meal, Order and Balance)
  * each controller executes CRUD operations on the models;
  * I created a folder, called ViewModels, whose aim is to map the JSON received from the request to the objects that are being used in the controller;
  * in the Startup section, I registered the services and repositories used for the Dependecy Injection Principle.
  
### Other mentions

* If you'd like to see how the architecture of the application looks like in a much prettier way than in lines and lines of code, you can check it out [here](https://raw.githubusercontent.com/ilincute/restaurant-api/master/Architecture.jpeg).
* I implemented the Code First paradigm.
* Moreover, the structure of the models, as well as the structure of the database changed in the process of creating the app, by adding migrations to it. 
* I used Postman in order to test my APIs; I also exported the collection I had created in Postman, which can be found in the main folder.
* When trying to run the program for the first time, you need to type in the Package Manager Console ```Update-Database```. 
