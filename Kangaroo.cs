class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // x1 + n*v1 = x2 + n*v2
        // x1 - x2 = n*(v2 - v1)
        // (x1 - x2)/(v2 - v1) = n
        //int n;

        if (v1 == v2)
        {
			// En el casi ínfimo caso que x1 y x2 sean iguales
			// y que las velocidades sean iguales, pues se regresa un "YES"
			// en otro caso, cuando las velocidades son iguales
			// pero inician en puntos diferentes, jamás se van a encontrar
            return x1 == x2 ? "YES" : "NO";
        }
        else
        {
			// Se obtiene la relación que se planteo desde un inicio
            int n = (x2 - x1) / (v1 - v2);
			// Se revisa que n sea positivo (si no, es que ambos canguros 
			// se encontraron previamente, esto luego lo verán en señales y sistemas, 
			// se conoce como sistema causal)
			// Y también, que se cumpla la igualdad propuesta
            if (n >= 0 && (x1 + v1 * n == x2 + v2 * n))
            {
                return "YES";
            }
			// en otro caso, nunca se encontrarán
            else
            {
                return "NO";
            }
        }

    }
}

class Kangaroo
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
