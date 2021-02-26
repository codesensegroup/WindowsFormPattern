# MVP

![image](https://user-images.githubusercontent.com/20264622/109277297-1df24480-7852-11eb-9801-3ba08b3da650.png)


## Model

In an application with a good layered architecture, this model would only be the gateway to the domain layer or business logic. See it as the provider of the data we want to display in the view. Model’s responsibilities include using APIs, caching data, managing databases and so on.

## View

The View, usually implemented by an Form, will contain a reference to the presenter. The only thing that the view will do is to call a method from the Presenter every time there is an interface action.

## Presenter
The Presenter is responsible to act as the middle man between View and Model. It retrieves data from the Model and returns it formatted to the View. But unlike the typical MVC, it also decides what happens when you interact with the View.

# Simple Demo

![image](https://user-images.githubusercontent.com/20264622/109278681-c359e800-7853-11eb-9ec5-cc4f0a97dc0d.png)
