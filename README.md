# RoboDog

## Story

If tiny, friendly aliens came to Earth, they would definitely fall in love with dogs.
The only problem would be that they wouldn't have them on their home planet.
They would surely ask Codecool to help them automatize, by creating Robo-Dogs and populate their planet with four-legged friends.
Let's prepare for this case, and bring world peace to the universe! 🐾

## What are you going to learn?

- creating a new ASP.NET Core project
- working with HTTP requests
  - routing with ASP.NET Core
  - respond differently based on the HTTP request's method value
- organize your project into layers
- check your work using Postman

## Tasks

1. After you clone the repository of the project it only has a README.md file in it. Set up the project for RoboDogApplication.
    - ASP.NET MVC project has been created.
    - The project contains the automatically generated `Program` and `Startup` classes

2. The application can model a Dog by their age, name and breed. This class should be located in the `model` layer.
    - The application has a model class for Dog with properties of age, name, breed.
    - The model class is located in a `model` layer.
    - The `Breed` property has its own type (doesn't use strings).

3. There is a `DogCreator` class in the `service` layer, which contains a `CreateRandomDog()` method.
    - `CreateRandomDog()` returns a new instance of the `Dog` class with randomized values of the following properties: name, age, breed.

4. _Who let the dogs out?_ Let's shelter them! Create a `DogStorage` class for handling the dogs.
    - Dogs are stored in an ordered collection.
    - A dog can be added to the collection.
    - A randomly generated dog can be added to the collection
    - The collection of all dogs can be returned.
    - The first dog with given name can have its age and breed properties updated.

5. Create a `DogController` class in the a `controller` layer to let others interact with the dogs. containing methods for get all dogs, create a random dog, add a specific dog, or update the first dog of a given name. To achieve this behaviour, this class should not contain the full logic in itself. It should be rather _wired_ with another class responsible for _services_ like this.
    - Class has the `[ApiController]` attribute.
    - Class is dependent on `DogStorage` service.
    - Controller has a GET endpoint for returning all the stored dogs.
    - Controller has a GET endpoint for returning a randomly created dog.
    - Controller has a POST endpoint for adding a new dog (dog's data is kept in the Request Body)
    - Controller has a PUT endpoint for updating the first dog with given name, which is provided in the path variable (age and breed properties can be updated via Request Body)

6. Use Postman to check your endpoints! Create a new collection for this project, and create requests for testing __all__ your endpoints. Use JSON format for testing POST requests.
    - A collection of all dogs is returned after sending a GET request.
    - A randomly created dog is returned after sending a GET request.
    - A new dog is added to the collection after sending a POST request, with providing the dog's model in JSON format in the Request Body.
    - The first dog with given name, provided in the path variable, is modified by the values provided in the Request Body, after sending a PUT request.

## General requirements

None

## Hints

- you can handle variables in the request URL by using FromRoute attribute
- you can use the information coming from a POST request to use it as an object described by one of your model classes using FromBody attribute


## Background materials

- <i class="far fa-exclamation"></i> [ASP.NET Core getting started guide](https://docs.microsoft.com/en-us/aspnet/core/getting-started/)
- <i class="far fa-book-open"></i> [ASP.NET Core Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- <i class="far fa-book-open"></i> [Processing data from HTTP requests](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding#sources)
- <i class="far fa-book-open"></i> [Send your fist request in Postman](https://learning.postman.com/docs/getting-started/sending-the-first-request/)
- <i class="far fa-book-open"></i> [How to send data in Postman](https://www.youtube.com/watch?v=qyYAOty_bDs)
