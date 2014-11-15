#BeaDyeyeD

## Introduction
This is a very simple .Net class to help with [BDD](http://en.wikipedia.org/wiki/Behavior-driven_development) tests

##The Problems
Writting tests is a must for modern development but how do we ensure our tests are readible and in 5 years 
when a test fails how can we quickly identify the fault.

Unit tests do not match the languange of the business

##Implementation
It's only one class and can simple be added to any test project or test library as follows
```
	[TestFixture]
	public class MyClass : BDD<MyClass
```

##Usage
There are 4 key words that can now be used in your test class
```
Given
When
Than
And
```
Following the AAA Arange=>Act=>Assert approach.  

Arrange = ```Given``` some prerequisite ```And ``` some other prerequisite

Act = ```When`` something happens

Assert = ```Then``` an expected outcome occurs ```And``` another expected outcome occurs

Clone the project to see as simple example
