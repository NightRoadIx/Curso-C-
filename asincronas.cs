using System.Diagnostics;

Console.WriteLine("SECUENCIAL: uno tras otro\n");

// Crear una lista de objetos SensorAsync
var sensores = new List<SensorAsync>
{
    new SensorAsync(1, "Temperatura del motor"),
    new SensorAsync(2, "Temperatura del anticongelante"),
    new SensorAsync(3, "RPM del motor"),
    new SensorAsync(4, "Presion del multiple (MAP)"),
    new SensorAsync(5, "Flujo de masa de aire (MAF)"),
    new SensorAsync(6, "Nivel de combustible"),
    new SensorAsync(7, "Sonda oxigenación (O2)")
};

// Inicia el cronómetro para medir el tiempo
// creando un objeto del tipo StopWatch
var reloj = Stopwatch.StartNew();

// Recorrer los sensores
foreach (var s in sensores)
{
    // await permite ejecutar cada lectura una tras otra
    // esperando a que la anterior termine
    double v = await s.LeerAsync();
    // Revisar cuanto tiempo tarda cada uno en ejecutarse
    Console.WriteLine($"  [{s.Id}] {s.Nombre}: {v:F1}");
}

// Detener el reloj para la lectura total
reloj.Stop();
Console.WriteLine($"\n  Tiempo total: {reloj.Elapsed.TotalSeconds:F2} s");


Console.WriteLine("\nCONCURRENTE: todos a la vez\n");

// Reiniciar el reloj
reloj.Restart();

// Select lanza todas las tareas sin esperar; ToList las materializa
// Observar que se manda a Select una función
var tareas = sensores.Select(s => s.LeerAsync()).ToList();
// Task.WhenAll espera a que TODAS terminen y devuelve el arreglo de resultados en orden
double[] valores = await Task.WhenAll(tareas);

// Detiene el reloj
reloj.Stop();

// Imprime los valores respetando el orden original de los sensores
for (int i = 0; i < sensores.Count; i++)
    Console.WriteLine($"  [{sensores[i].Id}] {sensores[i].Nombre}: {valores[i]:F1}");

Console.WriteLine($"\n  Tiempo total: {reloj.Elapsed.TotalSeconds:F2} s");

// CAMBIO DE HILO DESPUÉS DEL AWAIT 
// Demuestra que tras un await el código puede continuar en otro hilo del pool
Console.WriteLine("\n¿En que hilo corre cada parte?\n");

Console.WriteLine($"  antes del await:  hilo {Environment.CurrentManagedThreadId}");
await Task.Delay(100);
Console.WriteLine($"  despues del await: hilo {Environment.CurrentManagedThreadId}");
await Task.Delay(100);
Console.WriteLine($"  despues del otro:  hilo {Environment.CurrentManagedThreadId}");

// EXCEPCIONES EN TAREAS
// Muestra que una tarea que falla NO lanza al momento de invocarla: la excepción queda "guardada" en la Task
Console.WriteLine("\n¿Cuando truena una tarea que falla?\n");

Console.WriteLine(" Llamar al metodo SIN await:");
// La excepción ocurre en segundo plano, pero no se propaga aquí
Task tareaQueFalla = FallarAsync();
Console.WriteLine("     ...y el programa siguio como si nada.\n");

Console.WriteLine(" Ahora con la instrucción await:");
try
{
    // Al hacer await, la excepción almacenada se relanza y puede atraparse
    await tareaQueFalla;
}
catch (IOException e)
{
    Console.WriteLine($"     excepcion atrapada al hacer await: {e.Message}");
}

// MÚLTIPLES FALLAS CON WhenAll
// Cuando varias tareas fallan, await lanza solo la PRIMERA, pero todas quedan en Task.Exception
Console.WriteLine("\nWhenAll cuando fallan varias tareas\n");

var mixtas = new List<Task>
{
    // La tarea termina bien
    Task.Delay(50),
    // Y estas fallan
    FallarAsync("sensor 11 sin respuesta"),
    FallarAsync("sensor 12 sin respuesta")
};

Task todas = Task.WhenAll(mixtas);

try
{
    // Lanza solo la primera excepción encontrada
    await todas;
}
catch (IOException e)
{
    Console.WriteLine($"  await lanzo solo la PRIMERA: {e.Message}");
}

// Sin embargo, la Task agregada conserva TODAS las excepciones producidas
Console.WriteLine($"  pero la tarea guarda todas: " +
                  $"{todas.Exception?.InnerExceptions.Count} excepciones");

foreach (var ex in todas.Exception!.InnerExceptions)
    Console.WriteLine($"    - {ex.Message}");


// Método auxiliar que simula un fallo después de 50 ms
static async Task FallarAsync(string mensaje = "sin respuesta del bus")
{
    await Task.Delay(50);
    throw new IOException(mensaje);
}

/// <summary>
/// Clase SensorAsync
/// </summary>
class SensorAsync
{
    private int id;
    private string nombre;

    public int Id { get; }
    public string Nombre { get; }

    /// <summary>
    /// Constructor SensorAsync()
    /// </summary>
    /// <param name="id"></param>
    /// <param name="nombre"></param>
    public SensorAsync(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    /// <summary>
    /// public async Task<double> LeerAsync
    /// Simula una lectura que tarda: en el bloque 2 esto sera BLE o serie.
    /// </summary>
    /// <returns></returns>
    public async Task<double> LeerAsync()
    {
        // "el dispositivo responde en 500 ms"
        await Task.Delay(500);                       
        return 80 + Random.Shared.NextDouble() * 35;
    }
}
