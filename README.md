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
    </blockquote>
</details>

# Reference

As a reference I used this [site](https://refactoring.guru/design-patterns).\
GoF book is available [here](https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8).\
You can find the pdf [here](https://github.com/media-lib/prog_lib/blob/master/general/Gang%20of%20Four%20-%20Design%20Patterns%20-%20Elements%20of%20Reusable%20Object-Oriented%20Software.pdf).
