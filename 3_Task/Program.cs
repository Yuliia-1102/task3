class Converter
{
    private decimal usdToUahRate;
    private decimal eurToUahRate;

    public Converter(decimal usdToUahRate, decimal eurToUahRate)
    {
        this.usdToUahRate = usdToUahRate;
        this.eurToUahRate = eurToUahRate;
    }

    public decimal ConvertUahToUsd(decimal amountInUah)
    {
        return amountInUah / usdToUahRate;
    }

    public decimal ConvertUahToEur(decimal amountInUah)
    {
        return amountInUah / eurToUahRate;
    }

    public decimal ConvertUsdToUah(decimal amountInUsd)
    {
        return amountInUsd * usdToUahRate;
    }

    public decimal ConvertEurToUah(decimal amountInEur)
    {
        return amountInEur * eurToUahRate;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(37.1m, 39.0m); 

        Console.Write("Введіть суму в гривнях: ");
        decimal amountInUah = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Оберіть, 1 - перевести у долари, 2 - перевести у євро: ");
        int num = Convert.ToInt16(Console.ReadLine());

        if (num == 1)
        {
            decimal amountInUsd = converter.ConvertUahToUsd(amountInUah);
            Console.WriteLine($"Сума в USD: {amountInUsd}");
        }
        else if (num == 2)
        {
            decimal amountInEur = converter.ConvertUahToEur(amountInUah);
            Console.WriteLine($"Сума в EUR: {amountInEur}");
        }
        else Console.WriteLine("Неправильне введення");

        Console.Write("\nВведіть суму в доларах: ");
        decimal amountInUsdInput = Convert.ToDecimal(Console.ReadLine());
        decimal amountInUahFromUsd = converter.ConvertUsdToUah(amountInUsdInput);
        Console.WriteLine($"Сума в UAH: {amountInUahFromUsd}");

        Console.Write("\nВведіть суму в євро: ");
        decimal amountInEurInput = Convert.ToDecimal(Console.ReadLine());
        decimal amountInUahFromEur = converter.ConvertEurToUah(amountInEurInput);
        Console.WriteLine($"Сума в UAH: {amountInUahFromEur}");
    }
}