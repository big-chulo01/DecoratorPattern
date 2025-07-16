
class Program
{
    static void Main(string[] args)
    {
        // Create the base component
        var component = new ConcreteComponent();
        Console.WriteLine("Base component: " + component.GetText());

        // Create decorators
        var plainDecorator = new PlainDecorator(component);
        Console.WriteLine("Plain decorator: " + plainDecorator.GetText());

        var colorDecorator = new ColorDecorator(component);
        Console.WriteLine("Color decorator: " + colorDecorator.GetText());

        var upperCaseDecorator = new UpperCaseDecorator(component);
        Console.WriteLine("Upper case decorator: " + upperCaseDecorator.GetText());

        // Demonstrate stacking decorators
        var stackedDecorator = new UpperCaseDecorator(
                                new ColorDecorator(
                                new PlainDecorator(component)));
        Console.WriteLine("Stacked decorators: " + stackedDecorator.GetText());
    }
}