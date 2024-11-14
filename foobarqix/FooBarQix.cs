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
        
        if (input % 3 == 0)
            sb.Append(Foo);
        if (input % 5 == 0)
            sb.Append(Bar);
        if (input % 7 == 0)
            sb.Append(Qix);

        var inputString = input.ToString();
        foreach (char item in inputString)
        {
            if (_fooBarQixDictionary.ContainsKey(int.Parse(item.ToString())))
                sb.Append(_fooBarQixDictionary[int.Parse(item.ToString())]);
        }        
        
        var result = sb.ToString();
        return !string.IsNullOrWhiteSpace(result) ? result : input.ToString();
    }
}
