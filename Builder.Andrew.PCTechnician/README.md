# Andrew's Builder

This example of the Builder pattern uses an abstract ComputerBuilder class to define the process for
which any given concrete type that inherits it should be built. Rather than creating a constructor,
the Builder class outlines the functions necessary for the child Builder for the concrete type.
This Builder acts as a delegate for the construction of the Computer object, which is Encapsulation
and benefits the reliability and maintainability of the code. The workshop class exists to execute
these functions, so that the concrete object can be constructed step-by-step, regardless of how
complex it may be.

The main use case for this pattern is to construct variations of a complex object that requires
some procedure to create. 

# Review (experience)

Finding an example for the Builder pattern was easy. This is due in part to the terminology of the
pattern having an obvious connection to real-world jobs. Builders build products that are separate
from the builders themselves, and a director tells the builders what to do. Real-world examples
of this relationship between builders, products, and directors can be found at the creation stage
of just about any product that can be bought.

The Builder pattern was easier to get started with than my previous AbstractFactory implementation.
Beyond the example being easier to come up with, Builder uses a bit less abstraction, but I also
found the concept of abstraction much easier to work with the second time around. My familiarity
with the available resources also aided in a smoother development experience.

The Builder problem can apply to this problem, but I think in this current form it does not fit
well only because the complexity of assigning to a private dictionary parameter doesn't seem to
meet the required complexity to warrant a Builder. This example may due just fine as an Abstract
Factory in its current state, however if more complicated procedures were concocted to put
together these Computer objects then it may fall squarely into the realm of problems that
a Builder is meant to solve.

# Review (pattern)

The Builder pattern is somewhat useful as a design tool. It has a more narrow use case than an
Abstract Factory because it is meant to execute a sequence of construction-related operations and
arrive at a conclusion, while Abstract Factories lend more to constructing an object instantly
like any other constructor. The similarities in these patterns allow for flexibility during
development. If a developer determines that their factory method requires greater complexity than
would be practical for a constructor, a Builder pattern implementation is within arm's reach