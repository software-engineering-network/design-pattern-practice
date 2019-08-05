## Purpose

The Tiny Types pattern works by wrapping domain concepts that could be handled by primitives in simple wrapper classes. 
The pattern essentially asserts that concepts that *can* be represented by primitives (such as `Price` and `ProductName`)
should still get their own class, just like `Product` does.
This comes with a few benefits:

* **More readable code:** When working with a domain that has a lot of primitive variables, it can get difficult to keep track of what string
or integer represents what concept, especially if the people who wrote that code did a poor job of naming the variables. With Tiny Types, you
are always aware of what each variable is, even if it has a terrible variable name like `a`.
* **Better method signatures:** Imagine a method with the signature `SaveFullName(String, String)`. Going off the signature alone, it is
impossible to tell if the method expects you to give it a first name followed by a last name or a last name followed by a first name. With
Tiny Types, you can have clearer method signatures like `SaveFullName(LastName, FirstName)`.
* **More flexible code:** Suppose you wanted `SaveFullName` to work regardless of what order you gave it the names in. When you use Tiny Types,
you gain the ability to have a greater variety of method signatures like `SaveFullName(LastName, FirstName)` and `SaveFullName(FirstName, LastName)`.
Using primitives, this would not be possible as you would have a duplicate signature of `SaveFullName(String, String)`.
* **Type safety:** Tiny Types allow you to take full advantage of the benefits of statically typed languages with your domain concepts. As
above, if you have two strings `firstName` and `lastName`, nothing is stopping you from doing something like `firstName = lastName;`. If you
instead have two variables `FirstName firstName` and `LastName lastName`, the compiler will prevent such mistakes.
* **Validation:** In my opinion, this is the most important benefit of Tiny Types. Many programs are bogged down by validation logic because
the state of their programs is allowed to contain invalid data. A simple example would be a program that has a variable `int ageInYears` for
a person's age. The use of an integer in this case allows you to have someone with a negative age as well as somebody who is thousands of years
old. A Tiny Type called `Age` would let you restrict the allowed range to something much more reasonable - perhaps 0 years to 150 years, given
that the oldest person to ever live was 122 years old. Examples of this validation can be found in `ProductName` and `Price`.

## Application

Personally, I think Tiny Types should be implemented in any application that is likely to see any significant level of scale or collaboration on it.
The pattern is almost entirely beneficial with the only real drawback being boilerplate and setup time, but many languages have libraries that
can automatically set up Tiny Types for you instead of you having to make the class yourself every time.

## Review (experience)

The Tiny Types pattern was relatively easy to implement and test. I started by writing the two types, `Price` and `ProductName`. Though I already
knew about this pattern and had seen it in action before, this was my first time implementing it from scratch. I was actually surprised at how
easily `Product`, `ProductService` and all of the tests came together after `Price` and `ProductName` were ready - I personally felt that,
after dealing with the boilerplate of the two tiny types, having them implemented actually significantly sped up the process of making the rest
of my demo.

## Review (pattern)

I really value this pattern and, whenever I find myself working on code that doesn't use it, I find myself wishing it did. It brings a lot
of benefits to your codebase at very little cost (especially if you use a library to avoid dealing with so much boilerplate). It's a pretty
unique pattern that challenges an assumption tons of developers make, but the benefits are very clear once you've worked with it.
