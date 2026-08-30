# Calculator TDD

A small **test-driven development** exercise in C#: a domain class, a test project written against it, and an ASP.NET Core Web API exposing it.

The calculator itself is deliberately trivial. The point is the workflow — write the failing test first, then the code that satisfies it — and the separation between domain logic and the web layer.

---

## Structure

```
Domain/         Calculator.cs             - the logic under test, no dependencies
CalculatorTDD/  UnitTest1.cs              - xUnit tests using FluentAssertions
Web/            CalculateController.cs    - ASP.NET Core Web API over the domain
```

`Domain` has no reference to the web project, so the logic is testable without spinning up a server.

---

## The test

```csharp
[Fact]
public void Sum_Of_2_and_2_should_be_4()
    => new Calculator()
        .Sum(2, 2)
        .Should().Be(4);
```

`FluentAssertions` is used so failures read as sentences rather than as `Assert.Equal` argument order.

---

## The API

```
GET /Calculate/Add/{left}/{right}
```

Example: `GET /Calculate/Add/2/2` returns `4`.

---

## Running it

```bash
dotnet test    # run the tests
dotnet run --project Web    # start the API
```

---

## Built with

C# · .NET · xUnit · FluentAssertions · ASP.NET Core Web API

---

## Author

**Hanré Koen** — [@Hanrekoen](https://github.com/Hanrekoen)
