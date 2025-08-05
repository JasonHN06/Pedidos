namespace Pedidos.herencia
{
    public class Electronico : Producto
    {
        public int GarantiaMeses { get; set; }
        public string Voltaje { get; set; }
        public override void MostrarInformacion()
        {
            Console.WriteLine();
            Console.WriteLine("***** Datos del Producto *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine($"Voltaje: {Voltaje}");
        }
    }
}