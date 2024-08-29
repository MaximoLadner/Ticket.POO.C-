class Libro
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Autor {  get; set; }
    public decimal Precio { get; set; }

    public Libro(int Codigo, string Nombre, string Autor, decimal Precio)
    {
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        this.Autor = Autor;
        this.Precio = Precio;
    }

}

class SolicitudPrestamo
{

    private List<Libro> _libros;

    public SolicitudPrestamo()
    {
        _libros = new List<Libro>();
    }
    public void AgregarLibrosBiblioteca(Libro libros)
    {
        _libros.Add(libros);
    }
    public decimal CostoTotalPrestamo()
    {
        decimal Total = 0;
        foreach (var libro in _libros)
        {
            Total += libro.Precio;
        }
        return Total;
    }
     
    public void Mostrar_detalles()
    { Console.WriteLine("DETALLLES DE LA SOLICITUD");
        foreach (var libro in _libros)
        {
            Console.WriteLine($"Codigo del libro: {libro.Codigo}\nNombre del libro: {libro.Nombre}\nNombre del autor: {libro.Autor}\nPrecio dellibro: {libro.Precio}");
            Console.WriteLine("______________________________________________");
        }
        Console.WriteLine($"El precio total a abonar es: {CostoTotalPrestamo()}");
    }

}

class Progam
{
    static void Main()
    {
        Libro lafelicidad = new Libro(001, "La felicidad", "Gabriel Rolon", 25500);
        Libro babel = new Libro(002, "La biblioteca de Babel", "Jorge Luis Borges", 30432);
        Libro ficciones = new Libro(3, "Ficciones", "Jorge Luis Borges",22000);

        SolicitudPrestamo miSolicitud = new SolicitudPrestamo();

        miSolicitud.AgregarLibrosBiblioteca(lafelicidad);
        miSolicitud.AgregarLibrosBiblioteca(babel);
        miSolicitud.AgregarLibrosBiblioteca(ficciones);
        miSolicitud.Mostrar_detalles();

    }
}