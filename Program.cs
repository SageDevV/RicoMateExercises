using System.Globalization;

var cultura = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = cultura;

Console.WriteLine("INSIRA UM VALOR");

string[] values = Console.ReadLine().Split(" ");
double[] valuesConvert = Array.ConvertAll(values, double.Parse);

if (!ValidaValoresDoubles(valuesConvert))
{
    throw new ArgumentException("PRECISA INFORMAR UM NÚMERO VÁLIDO.");
}

Console.WriteLine("INSIRA UM NOME");
string [] names = Console.ReadLine().Split(" ");

if (!ValidaNomes(names))
{
    throw new ArgumentException("OS NOMES NÃO PODEM SER MAIORES QUE 26 CARACTERES.");
}

Random r = new();
int numberRandom = Randomiza(r);

if (numberRandom >= 1 && numberRandom <= 10)
{
    Console.WriteLine($"{names[0]} {RandomizaComIntervalos(r, 2) * valuesConvert[2]} ");
}

else if (numberRandom >= 10 && numberRandom <= 20)
{
    Console.WriteLine($"{names[1]} {RandomizaComIntervalos(r, 1) * valuesConvert[2]} ");
}

else if (numberRandom >= 20 && numberRandom <= 30)
{
    Console.WriteLine($"{names[2]} {(RandomizaComIntervalos(r, 2) * valuesConvert[2])} ");
}


static int Randomiza(Random randomizer){
    return randomizer.Next(30);

}

static int RandomizaComIntervalos(Random randomizer, int intervalos){
    return randomizer.Next(intervalos);
}

static bool ValidaNomes(params string[] names){
    foreach (var name in names)
    {
        if (name.Length > 26)
        {
            return false;
        }
    }

    return true;
}


static bool ValidaValoresDoubles(params double[] numbers){
    if (!(numbers[0] > 0 && numbers[0] <= 10))
    {
        return false;
    }
    if (!(numbers[1] > 0 && numbers[1] <= 20))
    {
        return false;
    }
    if (!(numbers[2] > 0 && numbers[2] < 1))
    {
        return false;
    }
    
    return true;
}


