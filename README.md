# Design Patterns

A repository to use as a cheatsheet for all Design Patterns defined by the "Gang of Four"(Gof) in 1994\
For each design you are going to find a section with a summary explanation.\
Every design pattern has its pros and cons.\
Use cases are also defined for each pattern.\
A design pattern is basically a recipe to solve specific problem.

## Description

<details>
    <summary>Creational Patterns</summary>
    <blockquote style="background:none;">
        <details>
            <summary>Factory</summary>     
            <ul>
                <li>It provides an interface for creating objects in superclass, but allow children to alter the type of objects that will be created</li>
                <li>Use when the type of the objects are not known beforehand</li>
                <li>Use when the program is meant to be extended by its clients</li>
                <li>Use when the program should save resources by reusing existing objects</li>
                <li>Pros: Avoid tight coupling. Respects Single Responsability and Open/Closed Principles</li>
                <li>Cons: A lot of new classes are added</li>
            </ul>   
        </details>
        <details>
            <summary>Abstract Factory</summary>
            <ul>
                <li>It is way to create families of related objects without specifying their concrete class</li>
                <li>The client can work with any concrete factory as long as it communicates with their objects through interfaces</li>
                <li>The application is responsible to create the concrete factory and inject it into the client</li>
                <li>Use when creating cross-platform UI components without coupling client code to concrete components</li>
                <li>Pros: Avoid tight coupling. Respects Single Responsability and Open/Closed Principles</li>
                <li>Cons: A lot of new classes are added</li>
            </ul>           
        </details>
        <details>
            <summary>Prototype</summary>        
        </details>
        <details>
            <summary>Builder</summary>
            <ul>
                <li>It is way to create objects step by step</li>
                <li>It is possible to create different type of object using same construction code</li>
                <li>This pattern extracts object construction code out of its own class and move to a builder</li>
                <li>Avoids huge constructors and unnecessary properties for particular cases</li>
                <li>Use when construct Comoposite trees or other complex objects</li>
                <li>Pros: Reuses same construction logic when building different representations of objects</li>
                <li>Pros: Respects Single Responsability by detaching costruction code from business logic</li>
                <li>Cons: A lot of new classes are added</li>
            </ul>        
        </details>
        <details>
            <summary>Singleton</summary>        
        </details>
    </blockquote>
</details>

# Reference

As a reference I used this [site](https://refactoring.guru/design-patterns).\
GoF book is available [here](https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8).\
You can find the pdf [here](https://github.com/media-lib/prog_lib/blob/master/general/Gang%20of%20Four%20-%20Design%20Patterns%20-%20Elements%20of%20Reusable%20Object-Oriented%20Software.pdf).
