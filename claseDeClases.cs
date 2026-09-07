class Sensor
{
    /*
     * Clase que representa un sensor de temperatura de un componente del vehículo.
     * Contiene el nombre del componente, la unidad de medida, el umbral de alerta y las lecturas registradas.
     */

     // * * * * * * * ATRIBUTOS * * * * * * *
    public string Nombre;
    public string Unidad;
    public double Umbral;
    public double[] Lecturas;

    // * * * * * * * MÉTODOS * * * * * * *
    // CONSTRUCTOR
    public Sensor(string nombre, string unidad, double umbral)
    {
        /*
         * Inicia un nuevo sensor con el nombre del componente, la unidad de medida y el umbral de alerta.
         * Las lecturas se inicializan como un arreglo vacío.
         * El constructor realiza la asignación de un espacio en memoria para el objeto y de los valores de los atributos.
         * Debe tener el mismo nombre que la clase y no tiene tipo de retorno.
         */
        Nombre = nombre;
        Unidad = unidad;
        Umbral = umbral;
        // Inicia el arreglo de lecturas vacío
        // No inicia en null, sino en un arreglo de tamaño 0 para evitar errores al calcular promedio o máximo
        Lecturas = new double[0];
    }

    public double Promedio()
    {
        /*
         * Calcula el promedio de las lecturas registradas en el sensor.
         * Devuelve 0 si no hay lecturas para evitar división por cero.
         */
        if (Lecturas.Length == 0) return 0;
        double suma = 0;
        foreach (double l in Lecturas)
            suma += l;
        return suma / Lecturas.Length;
    }

    public double Maxima()
    {
        /*
         * Encuentra el valor máximo de las lecturas registradas en el sensor.
         * Devuelve 0 si no hay lecturas para evitar errores.
         */
        if (Lecturas.Length == 0) return 0;
        double max = Lecturas[0];
        foreach (double l in Lecturas)
            if (l > max) max = l;
        return max;
    }
}
