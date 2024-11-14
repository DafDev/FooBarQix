using System.Text;

namespace foobarqix;

public class FooBarQix
{
    public const string Foo = "Foo";
    public const string Bar = "Bar";
    public const string Qix = "Qix";

    private readonly Dictionary<int, string> _fooBarQixDictionary;

    public FooBarQix()
    {
        _fooBarQixDictionary = new()
        {
            { 3, "Foo" },
            { 5, "Bar" },
            { 7, "Qix" }
        };      
    }

    public string Display(int input)
    {
        StringBuilder sb = new ();
        foreach (var key in _fooBarQixDictionary.Keys)
        {
            if (input % key == 0)
                sb.Append(_fooBarQixDictionary[key]);
        }

        var inputString = input.ToString();
        foreach (var item in inputString)
        {
            if (_fooBarQixDictionary.TryGetValue(int.Parse(item.ToString()), out string? value))
                sb.Append(value);
        }        
        
        var result = sb.ToString();
        return !string.IsNullOrWhiteSpace(result) ? result : inputString;
    }

}
