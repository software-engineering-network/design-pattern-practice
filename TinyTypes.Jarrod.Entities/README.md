## Purpose

A tiny type is a wrapper for a primitive or otherwise basic type. Gerhard's explanation is thorough, and you should read it.

I'll add that tiny types:
* make your code easier to use correctly and more difficult to use incorrectly
* can be every bit as flexible as the primitives they hide (e.g. you can override operators so you aren't calling `.Value` every time you want to make a comparison)
* expose domain logic around primitives (e.g. a `StreetNumber` that is a `TinyType<ushort>` could enforce constraints like min/max values or that they should all be odd
  * this places the domain logic around `StreetNumber` in the `StreetNumber` class instead of an `Address` class
  * this should lead to more granular, readable, and less-coupled implementations

## Application

As Gerhard points out, there are plenty of applications of the tiny type pattern. Frankly, any of them are good enough to justify using it. I'd suggest waiting until you have a domain rule you need to enforce before spinning up a tiny type though.

## Review (experience)

My example demonstrates a few ideas:
* Tiny types are essentially value objects, so they're equatable by value.
* `TinyTypeOfGuid` subclasses are always initialized the same way given an empty `Guid`, so I included that logic in the constructors. This means like primitives can now be `Classified` (pun intended)
* Type safety is something you reap the benefit of all the way from service to repo. Notice that the service speaks with the domain in terms of `PersonId` and `AddressId`. The repositories' `Find` methods are also typesafe. And if domain objects need to use them, they're obviously available.

## Review (pattern)

The tiny type pattern is simple, powerful, and elegant. I believe the key feature is that it relocates domain logic to a more appropriate place.

Although the benefits are numerous, I've encountered some notable drawbacks:

* Deciding when to use the corresponding primitive becomes really important. Always requiring the use of the tiny type (e.g. in a constructor) may cause unnecessary coupling because the client code must create another domain object. I'm currently pro-primitives-in-constructors but you can have as many overloads as you want so knock yourself out.
* In general, tiny types *will* expand your codebase - not just in their scaffolding, but also in your test projects. Ideally, each is a domain object and should be tested. My example mitigates a lot of this by use of inheritance.
* Some primitives are perfectly fine. They don't really have domain logic associated with them. But if you are a completionist, that lone `string Description { get; }` is going to be frustrating to look at. That, or you add unnecessary code.
