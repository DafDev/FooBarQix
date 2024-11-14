using System.Text;

namespace foobarqix;

public class FooBarQix
{
    public const string Foo = "Foo";
    public const string Bar = "Bar";
    public const string Qix = "Qix";

    public static string Display(int input)
    {
        StringBuilder sb = new ();
        
        if (input % 3 == 0)
            sb.Append(Foo);
        if (input % 5 == 0)
            sb.Append(Bar);
        if (input % 7 == 0)
            sb.Append(Qix);

        var inputString = input.ToString();
        for (int i = 0; i < inputString.Length; i++)
        {
            _ = inputString[i] switch
            {
                '3' => sb.Append(Foo),
                '5' => sb.Append(Bar),
                '7' => sb.Append(Qix),
                _ => default,
            };
        }        
        
        var result = sb.ToString();
        return !string.IsNullOrWhiteSpace(result) ? result : input.ToString();
    }
}
