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
            <ul>
                <li>It is a way to compose objects into tree structures and work with them as if it is only one objects</li>
                <li>Real-world analogy: armies and theirs hierarchy</li>
                <li>It makes senses to use this pattern when core model of the app can be represented as a tree</li>
                <li>Use when client code is supposed to treat complex and simple elements in the same way</li>
                <li>Pros: Work with complex data structure easier making use of polymorphism</li>
                <li>Pros: Adheres to Open Closed principle</li>
                <li>Cons: It is difficult to create a common interface for classes with different behaviour</li>
            </ul>         
        </details>
        <details>
            <summary>Decorator</summary>
             <ul>
                <li>Adds new functionality to existing objects</li>
                <li>Inheritance is not a viable solution therefore aggregation and compositon are used to overcome inheritance issues</li>
                <li>Real-world analogy: wearing multiple pieces of clothing</li>
                <li>Use when adding new behaviours to an onject at runtime</li>
                <li>Pros: Extension without inheritance</li>
                <li>Pros: Single Responsability Principle</li>
                <li>Pros: Combine several functionalities by wrapping an object into multiple decorators</li>
                <li>Cons: Hard to remove a nested decorators</li>
                <li>Cons: Hard to implement without depending on the order in the stack</li>
            </ul>          
        </details>
        <details>
            <summary>Facade</summary>
            <ul>
                <li>Provides a simplified interface to a library</li>
                <li>Avoids tight coupling to concrete implementation of the 3rd party library</li>
                <li>Real-world analogy: place an order on phone to a shop or restaurant</li>
                <li>Use when structuring a complex system into layers</li>
                <li>Pros: Isolates client code from complex subsystems</li>
                <li>Cons: A facade can become a <strong>God object</strong> coupled to many clases</li>
            </ul>            
        </details>
        <details>
            <summary>Flyweight</summary>
            <ul>
                <li>Shares common parts of state between multiple objects</li>
                <li>This pattern is simply an optimisation</li>
                <li>Apply this solution when the code has memory issues</li>
                <li>The Flyweight class(TreeType) has the object part that can be shared among other objects(Tree)</li>
                <li>Pros: Saves memory</li>
                <li>Cons: Trades memory over CPUs cycles</li>
                <li>Cons: The code becomes more complicated</li>
            </ul>             
        </details>
        <details>
            <summary>Proxy</summary>
            <ul>
                <li>Provides a placeholder for another object</li>
                <li>Proxy has the same interface as original object</li>
                <li>Proxy creates the original object and each request is delegated to it</li>
                <li>It can used for multiple purposes: lazy initialization, access control, logging and caching</li>
                <li>Pros: Proxy can work even if the object is not available yet</li>
                <li>Pros: Adheres to Open/Closed Principle</li>
                <li>Cons: The code becomes more complicated</li>
                <li>Cons: Response might take longer</li>
            </ul>         
        </details>
    </blockquote>
</details>
<details>
    <summary>Behavioral Patterns</summary>
    <blockquote style="background:none;">
        <details>
            <summary>Chain of Responsability</summary>
            <ul>
                <li>It is a way to pass requests along a chain of handlers</li>
                <li>Solves the issue of a big code with lots of checks</li>
                <li>Each check is independent and if it fails the other checks are not executed anymore</li>
                <li>Use when running multiple checks in a particular order is mandatory</li>
                <li>Use when the code should process lots of different requests</li>
                <li>Pros: The order of execution is controlled</li>
                <li>Pros: Adheres to Single Responsability and Open Closed Principles</li>
                <li>Cons: Some requests are not handled</li>
            </ul>            
        </details>
        <details>
            <summary>Command</summary>
            <ul>
                <li>Changes a request into a stand-alone object that contains all the information about request</li>
                <li>Avoids tight coupling between client and business logic</li>
                <li>It is able to link multiple clients to business logic</li>
                <li>Real-World analogy: make an order in a bar</li>
                <li>Use when object can be parametrized with operations</li>
                <li>Use when queing operations</li>
                <li>Pros: The order of execution is controlled</li>
                <li>Pros: Merge simple commands into a complex one</li>
                <li>Cons: The code becomes more complicated by adding a new layer</li>
            </ul>            
        </details>
        <details>
            <summary>Iterator</summary>
            <ul>
                <li>It is a way to parse elements of a collection hiding underlying represantation</li>
                <li>The underlying data structure can be changed without affecting the client code</li>
                <li>Parsing details are encapsulated by iterator object</li>
                <li>Use when collection has a complex data structure under the hood</li>
                <li>Use when iteration process can be reused across the app</li>
                <li>Pros: Adheres to Single Responsability and Open Closed Principles</li>
                <li>Pros: Iteration can be delayed and continue where was left</li>
                <li>Cons: Less efficient than collection parsers</li>
                <li>Cons: Could be overkill for simple collections</li>
            </ul>            
        </details>
        <details>
            <summary>Mediator</summary>
            <ul>
                <li>Reduces the dependencies between objects</li>
                <li>Limits the communication bettween objects and causes them to work using a mediator</li>
                <li>Real-World analogy: Pilots discuss only with tower control</li>
                <li>Use when it is hard to change a class because it has a lot of dependecies</li>
                <li>Use when it is hardly any chance to reuse a component because of its dependecies</li>
                <li>Pros: Adheres to Single Responsability and Open Closed Principles</li>
                <li>Pros: Reduces coupling between objects</li>
                <li>Cons: It can evolve into a <strong>God object</strong></li>
            </ul>            
        </details>
        <details>
            <summary>Memento</summary>
            <ul>
                <li>Restore the previous state of an object without revealing internal details</li>
                <li>Solves the issue of making all class properties publicly available</li>
                <li>There are 3 ways to implement this pattern. Here is implemented the option with nested classes</li>
                <li>Use when a previous snapshot of the object is needed</li>
                <li>Use when encapsulation principle is ommited</li>
                <li>Pros: Adheres to encapsulation</li>
                <li>Pros: Originator is not supposed to keep its history of states</li>
                <li>Cons: Not applicable to all programming languages, e.g. JS or PHP</li>
                <li>Cons: Memory inefficient when mementos are created too often</li>
            </ul>            
        </details>
        <details>
            <summary>Observer</summary>
            <ul>
                <li>Defines a subscription mechanism to notify multiple object about a new change</li>
                <li>Only the subscribed listeners are notified, nothing more or less</li>
                <li>Each listener must implement same interface to avoid any issues</li>
                <li>Real-World analogy: Email newsletter subscription</li>
                <li>Use when some objects need to observe other objects</li>
                <li>Use when state change of one object requires updates to other objects</li>
                <li>Pros: Adheres to Open/Closed Principle</li>
                <li>Pros: Establish relationships between objects at runtime</li>
                <li>Cons: Subscribers are notified in random order</li>
            </ul>            
        </details>
        <details>
            <summary>State</summary>
            <ul>
                <li>Defines a mechanism that allows an object to change its state when internal state changes</li>
                <li>Closely related to <strong>Finite State Machine</strong></li>
                <li>Avoids the highly usage of conditional statements</li>
                <li>Each state is now an object that hides the business logic</li>
                <li>Use when the object acts differently depending on current state</li>
                <li>Use when class has lots of conditionals about the state</li>
                <li>Pros: Adheres to Single Responsability and Open Closed Principles</li>
                <li>Pros: Simiplifies the code</li>
                <li>Cons: Overkill for a few state changes</li>
            </ul>            
        </details>
        <details>
            <summary>Strategy</summary>
            <ul>
                <li>Defines a family of algorithms and put each one in a separate class</li>
                <li>Avoids a huge algorithm with many cases that is hard to maintain and understand</li>
                <li>The client decides what strategy to use</li>
                <li>Each strategy must follow the same interface</li>
                <li>Use when different variants of an algorithm are used in the same object</li>
                <li>Use when a lot of classes are different in the way some behaviour is executed</li>
                <li>Pros: Swap between different algorithms at runtime</li>
                <li>Pros: Adheres to Open/Closed Principle</li>
                <li>Cons: Client must be aware of the different strategies</li>
                <li>Cons: Overkill for a few algorithms</li>
            </ul>            
        </details>
        <details>
            <summary>Template</summary>
            <ul>
                <li>Defines the skeleton of an algorithm in the superclass and lets the subclasses to override some steps</li>
                <li>Avoids code duplication in different variations of the algorithm</li>
                <li>The algorithm should be break down in steps and each one is method</li>
                <li>Use when the clients extend only few steps of the algorithm</li>
                <li>Use when some classes contain almost identical algorithm</li>
                <li>Pros: Move duplicate code in superclass</li>
                <li>Pros: Let clients to override only a part of the algorithm</li>
                <li>Cons: Hard to mantain for a template with a lot of steps</li>
            </ul>            
        </details>
        <details>
            <summary>Visitor</summary>
            <ul>
                <li>Separate algorithms from the objects on which they work</li>
                <li>Newly added behaviour is put in a separate class called visitor</li>
                <li>Use when performing an operation on all elements of complex object structure</li>
                <li>Use when clean up the business logic of auxiliary behaviours</li>
                <li>Pros: Adheres to Single Responsability and Open Closed Principles</li>
                <li>Pros: Accumulates useful information while working with various objects</li>
                <li>Cons: All visitors must be updated each time</li>
                <li>Cons: Does not access the private field and methods</li>
            </ul>            
        </details>
    </blockquote>
</details>

## What I learned?
C# features\
Refreshed Object-Oriented design principles\
Identyfing problems and choose the right approach

# Reference

As a reference I used this [site](https://refactoring.guru/design-patterns).\
GoF book is available [here](https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8).\
You can find the pdf [here](https://github.com/media-lib/prog_lib/blob/master/general/Gang%20of%20Four%20-%20Design%20Patterns%20-%20Elements%20of%20Reusable%20Object-Oriented%20Software.pdf).
