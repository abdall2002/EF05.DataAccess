

using RetrieveSingleItem;

var itemIdToRetrieve = 2;

using(var context = new AppDbContext())
{
    var item = context.Wallets
        .FirstOrDefault(x => x.Id == itemIdToRetrieve);

    Console.WriteLine(item);
}
