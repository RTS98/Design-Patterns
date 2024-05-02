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
            <ul>
                <li>Copy existing objects without making the code dependent on classes</li>
                <li>Copying from outside is not always possible because of private fields that may exist</li>
                <li>The cloning action comes from inside object</li>
                <li>It is also possible to create a Prototype Registry for storing frequently used prototypes - Hash Map is the easiest solution</li>
                <li>Use when code should not depend on the concrete classes of objects that need to be copied</li>
                <li>Pros: Avoid coupling with concrete implementations</li>
                <li>Pros: It gets rid of repeated initialization</li>
                <li>Cons: Cloning objects that have circular dependencies is tricky</li>
            </ul>                   
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
            <ul>
                <li>Ensures that a class has only one instance providing global access</li>
                <li>Real world analogy - a country have only one government and is globally accessible</li>
                <li>Once that object is created it will be always returned in further calls</li>
                <li>The object is lazy initialized</li>
                <li>Use when a class should have only one instance - database object</li>
                <li>Pros: Guarantees that a class has only one instance</li>
                <li>Pros: Global access to that instance</li>
                <li>Cons: Requires special treatement in a multithreaded environment</li>
                <li>Cons: Difficult to test because of the private constructor</li>
            </ul>               
        </details>
    </blockquote>
</details>
<details>
    <summary>Structural Patterns</summary>
    <blockquote style="background:none;">
        <details>
            <summary>Adapter</summary>
            <ul>
                <li>Allows 2 objects with compatible interfaces to communicate</li>
                <li>Besides converting the object an adapter makes communication possible between 2 different interfaces</li>
                <li>Real world example: Adapter from european plug to uk socket</li>
                <li>Pros: Adheres to Single Responsability and Open Closed principles</li>
                <li>Cons: Increased complexity because of the extra layer that is added</li>
            </ul>            
        </details>
        <details>
            <summary>Bridge</summary>
            <ul>
                <li>It is a way to split a set of closely related classed into 2 separate hierarchies - abstraction and implementation</li>
                <li>The abstraction(Remote in our case) is a high-level control that delegates the work to implementation</li>
                <li>The implementation(Devices) does the concrete work according to each device</li>
                <li>Use bridge when changing the implementation at runtime is needed</li>
                <li>Use when dividing a monolithic class that has several variants of some functionality</li>
                <li>Pros: Platform independent classes and apps - cross platform apps</li>
                <li>Pros: Adheres to Single Responsability and Open Closed principles</li>
                <li>Cons: Increased complexity when dividing a cohesive class</li>
            </ul>    
        </details>
        <details>
            <summary>Composite</summary>     
        </details>
        <details>
            <summary>Decorator</summary>     
        </details>
        <details>
            <summary>Facade</summary>     
        </details>
        <details>
            <summary>Flyweight</summary>     
        </details>
        <details>
            <summary>Proxy</summary> 
        </details>
    </blockquote>
</details>

# Reference

As a reference I used this [site](https://refactoring.guru/design-patterns).\
GoF book is available [here](https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8).\
You can find the pdf [here](https://github.com/media-lib/prog_lib/blob/master/general/Gang%20of%20Four%20-%20Design%20Patterns%20-%20Elements%20of%20Reusable%20Object-Oriented%20Software.pdf).
