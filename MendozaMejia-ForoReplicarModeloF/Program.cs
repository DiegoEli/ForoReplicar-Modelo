using MendozaMejia_ForoReplicarModeloF.Models;

class Program
{
    static void Main(string[] args)
    {
        //agregarCliente();
        //consultarClientes();
        //consultarCliente();
        //modificarCliente();
        //eliminarCliente();
        consultarClientesFunciones();
    }

    //agregar cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ForoDbModeloContext context = new ForoDbModeloContext();
        Cliente std = new Cliente();
        std.Nombre = "Danilo";
        std.Apellido = "Ramirez";
        std.Direccion = "Manabi";
        std.Telefono = "1234567890";
        std.FechaNacimiento = Convert.ToDateTime("1999-10-15");
        std.Estado = true;
        context.Clientes.Add(std);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);

    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar clientes");
        ForoDbModeloContext context = new ForoDbModeloContext();
        List<Cliente> listClientes = context.Clientes.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.Nombre);
        }

    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        ForoDbModeloContext context = new ForoDbModeloContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(4);

        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre + " Apellido: " + std.Apellido +
            " Direccion: " + std.Direccion + " Telefono: " + std.Telefono + " FechaNacimiento: " + std.FechaNacimiento +
            " Estado: " + std.Estado);

    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        ForoDbModeloContext context = new ForoDbModeloContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(5);

        std.Nombre = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);

    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar cliente");
        ForoDbModeloContext context = new ForoDbModeloContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(5);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);

    }
    public static void consultarClientesFunciones()
    {
        Console.WriteLine("Metodo consultar clientes con el uso de funciones");
        ForoDbModeloContext context = new ForoDbModeloContext();
        List<Cliente> listClientes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente std = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla:" + std.ClienteId + "-" + std.Nombre);

        //listClientes = context.Clientes.Where(s => s.ClienteId > 2 && s.Name == "Anita").ToList();

        //listClientes = context.Clientes.Where(s => s.Nombre == "Patty" || s.Name == "Anita").ToList();

        listClientes = context.Clientes.Where(s => s.Nombre.StartsWith("A")).ToList();

        /*
        var query = context.Clientes.GroupBy( s => s.Name) 
        .Select(g => new
        {
            Nombre = g.Key,
            Cantidad = g.Count()
        }). ToList();

        foreach (var result in query)
        {
            Console.WriteLine($"Nombre: {result.Nombre}, Cantidad: {result.Cantidad}");
        }
        */


        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.Nombre);
        }


    }
}
