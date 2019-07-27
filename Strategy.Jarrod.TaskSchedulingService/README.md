## Purpose

The Strategy design pattern deals with the abstraction of algorithms.  To my understanding, its purpose is to enable client objects to execute an algorithm ignorant of which implementation is necessary.

In my example, I built a simple service that accepts a collection of unscheduled tasks and schedules them (the algorithm).  I'm imagining truck maintenance or something similar.  There exists some business logic (probably related to properties of an `UnscheduledTask`) that determines the urgency of a task's execution (which I've simulated by creating `PseudoCriteria`).  For each unscheduled task, a factory provides the `TaskSchedulingService` (the client) an `ITaskScheduler` implementation (a concrete strategy) based on that criteria.  Then, the service utilizes the criteria-specific scheduler to schedule the task's execution.  The end result is a scheduling service that is concerned with a high-level process - scheduling unscheduled tasks - that is loosely coupled from the implementation details of actually scheduling a task.  Changes to an existing  strategy, the criteria for choosing a strategy, or even the addition/removal of alternate implementations will not affect the `TaskSchedulingService`.

Note:  The factory is unnecessary for this to work.  An implementation could be injected into the service.  The important thing is that the service is written against the `ITaskScheduler` interface rather than any number of implementations.

## Application

I consider using the Strategy pattern when alternate implementations of the same high-level process are required.  The above is actually a use case for an addition I made to a P&G application.  Some potential other uses:

* movement of a Chess piece (e.g. move diagonally, move like a knight, en passant)
* attack of an enemy monster (e.g. stab, bite, breathe fire)
* storage of data (e.g. in memory, in a SQL database, in MS Access)

## Review (experience)

I actually enjoyed the simplification of the business logic into two separate pseudo enums.  I've done the pattern enough that its implementation wasn't a problem - illustrating the point without the code becoming too convoluted was the primary goal.

I really hate the classic "choose a sorting strategy example" because the end result is the same and it betrays the point of the pattern.  It doesn't matter if you bubble sort or quick sort - the list ends up in the same state afterwards (ignoring stability).  In my opinion, a better sorting example would be to sort a collection of objects off of a different property (e.g. last name vs first name).

## Review (pattern)

The Strategy pattern is my favorite design pattern.  It clearly demonstrates the value of programming to interfaces by preventing clients from being tightly coupled to implementations.  It can be used to demonstrate the preference of composition over inheritance (e.g. imagine a monster class that can have different strategies for moving, attacking, and defending).  It is a great tool for satisfying the 'S' in SOLID.  I use it all the time - usually coupled with a factory, builder, or dependency injection.
