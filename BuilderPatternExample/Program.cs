public class Pizza
{
    public string Masa { get; set; }
    public string Salsa { get; set; }
    public string Ingredientes { get; set; }

    public override string ToString()
    {
        return $"Pizza con {Masa}, {Salsa} y los siguientes ingredientes: {Ingredientes}.";
    }
}

// Interfaz Builder
public interface IPizzaBuilder
{
    void DefinirMasa();
    void DefinirSalsa();
    void DefinirIngredientes();
    Pizza ObtenerPizza();
}

// Constructor concreto para Pizza personalizada
public class PizzaPersonalizadaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();
    private string _tipoMasa;
    private string _tipoSalsa;
    private string _tipoIngredientes;

    public PizzaPersonalizadaBuilder(string tipoMasa, string tipoSalsa, string tipoIngredientes)
    {
        _tipoMasa = tipoMasa;
        _tipoSalsa = tipoSalsa;
        _tipoIngredientes = tipoIngredientes;
    }

    public void DefinirMasa() => _pizza.Masa = _tipoMasa;
    public void DefinirSalsa() => _pizza.Salsa = _tipoSalsa;
    public void DefinirIngredientes() => _pizza.Ingredientes = _tipoIngredientes;

    public Pizza ObtenerPizza() => _pizza;
}

// Director que controla el proceso de construcción
public class DirectorDePizzas
{
    private IPizzaBuilder _builder;

    public void SetBuilder(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void ConstruirPizza()
    {
        _builder.DefinirMasa();
        _builder.DefinirSalsa();
        _builder.DefinirIngredientes();
    }

    public Pizza ObtenerPizza()
    {
        return _builder.ObtenerPizza();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancia del director
        var director = new DirectorDePizzas();

        // Interacción con el usuario
        Console.WriteLine("¡Bienvenido al creador de pizzas!");
        Console.WriteLine("Vamos a construir una pizza personalizada.");

        // Elegir masa
        Console.WriteLine("Elige el tipo de masa:");
        Console.WriteLine("1. Masa fina");
        Console.WriteLine("2. Masa gruesa");
        string masa = Console.ReadLine() == "1" ? "Masa fina" : "Masa gruesa";

        // Elegir salsa
        Console.WriteLine("Elige el tipo de salsa:");
        Console.WriteLine("1. Salsa de tomate");
        Console.WriteLine("2. Salsa barbacoa");
        string salsa = Console.ReadLine() == "1" ? "Salsa de tomate" : "Salsa barbacoa";

        // Elegir ingredientes
        Console.WriteLine("Elige los ingredientes:");
        Console.WriteLine("1. Queso mozzarella");
        Console.WriteLine("2. Pepperoni");
        Console.WriteLine("3. Vegetales");
        string ingredientes = Console.ReadLine() switch
        {
            "1" => "Queso mozzarella",
            "2" => "Pepperoni",
            "3" => "Vegetales",
            _ => "Sin ingredientes"
        };

        // Usar el Builder con las elecciones del usuario
        var pizzaBuilder = new PizzaPersonalizadaBuilder(masa, salsa, ingredientes);
        director.SetBuilder(pizzaBuilder);

        // Construir la pizza
        director.ConstruirPizza();

        // Mostrar la pizza final
        Pizza pizza = director.ObtenerPizza();
        Console.WriteLine($"Has creado la siguiente pizza: {pizza}");

        Console.WriteLine("¡Gracias por usar el creador de pizzas!");
    }
}
