namespace MyLibrary;

/// <summary>
/// Can print "Hello World" to the user.
/// </summary>
public class HelloWorldPrinter
{
    /// <summary>
    /// Returns "Hello World" <paramref name="times"/> on the Console.
    /// </summary>
    /// <param name="times">How many times Hello World should be displayed.</param>
    /// <returns>"Hello World" multiple times delimited by a newline.</returns>
    public string GetHellWorld(int times)
    {
        var hello = Enumerable.Range(0, times).Select(_ => new string("Hello World"));
        return string.Join(Environment.NewLine, hello);
    }
}