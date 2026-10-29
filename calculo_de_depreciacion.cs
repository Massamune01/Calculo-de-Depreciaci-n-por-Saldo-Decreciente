//Variables
double v = 1500; // Costo Inicial
double d = 15; // Porcentaje
double r = 1-d/100; // Factor de retención de valor 
int t = 10; // Tiempo en años

int contador = 1; // Contador para el año

// No se admiten valores negativos para el tiempo
if(t<0)
{
    System.Console.WriteLine("El tiempo no puede ser negativo");
}
else
{
    System.Console.WriteLine($"Depreciación por Saldo Decreciente: Costo Inicial: ${v}, Porcentaje: {d}%, Tiempo: {t} años");
    Recursivo(t);
}


// Cálculo de Depreciación por Saldo Decreciente
double Recursivo(int T)
{

    // Caso base
    if(T == 0)
    {
        //Informe
        System.Console.WriteLine($"Año 0: El valor actual es: ${Math.Round(v, 2)}");

        return v;
    }


    // Caso Recursivo (Estado Recursivo)
    if(T > 0)
    {

        v = Recursivo(T - 1) * r;
        System.Console.WriteLine($"Año {contador}: El valor actual es: ${Math.Round(v, 2)}");
        contador++;
    }

    return v;
}