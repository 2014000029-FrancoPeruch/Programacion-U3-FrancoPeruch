internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADÉMICOS\nNombre: Franco Peruch"+
            "\nGrado: IV Bachillerato C"+
            "\nClave: 29");

        int[] edadPersonas = new int[7];
        int CantidadPersonasMayores = 0;
        int CantidadPersonasMenores = 0;

        for (int i = 0; i < edadPersonas.Length; i++)
        {
            Console.Write("Ingrese la edad de la Persona " + (i+1) + ":");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadPersonas[i] >= 18)
            {
                CantidadPersonasMayores++;
            }
            else
            {
                CantidadPersonasMenores++;
            }
        }
        Console.WriteLine("Cantidad de personas mayores de edad: " + CantidadPersonasMayores);
        Console.WriteLine("Cantidad de personas menores de edad: " + CantidadPersonasMenores);
        Console.WriteLine("Cantidad de personas ingresadas: " + (CantidadPersonasMayores + CantidadPersonasMenores));

    }
}
