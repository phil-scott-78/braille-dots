# Braille Dots 

Simple library for converting strings, bytes, or bitarrays into a braille character with the appropriate dots turned on

Returns a char with the dots displayed for the requested character

![The number one turned on](https://upload.wikimedia.org/wikipedia/commons/thumb/b/bb/Braille8dotCellNumbering.svg/100px-Braille8dotCellNumbering.svg.png)

```csharp
Assert.Equal('⠇', DotPattern.Get("123"));
Assert.Equal('⣠', DotPattern.Get("678"));
```