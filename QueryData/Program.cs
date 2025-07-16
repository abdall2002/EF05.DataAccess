
using QueryData;

using (var context = new AppDbContext())
{
    var result = context.Wallets.Where(x => x.Balance > 5000);

    foreach (var wallet in result)
    {
        Console.WriteLine(wallet);
    }
}