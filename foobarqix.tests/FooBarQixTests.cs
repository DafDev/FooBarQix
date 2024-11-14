using FluentAssertions;

namespace foobarqix.tests;

public class FooBarQixTests
{
    // 1 renvoi 1
    [Theory]
    [MemberData(nameof(Data))]
    public void GivenOneReturnsOne(int input, string output)
    {
        var actual = FooBarQix.Display(input);

        actual.Should().Be(output);
    }

    public static TheoryData<int, string> Data()
    {
        return new TheoryData<int, string>
        {
            { 1, "1"},
            { 2, "2"},
            { 3, "FooFoo"},
            { 5, "BarBar"},
            { 9, "Foo" },
            { 13, "Foo" },
            { 15, "FooBarBar" },
            { 33 , "FooFooFoo" },
            { 55, "BarBarBar" },
            { 77, "QixQixQix" }
        };
    }
}