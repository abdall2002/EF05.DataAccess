
using DeleteData;

using (var context = new AppDbContext)
{
    var wallet = context.Wallets.Single(x => x.Id == 5);
    context.Wallets.Remove(wallet);
    context.SaveChanges();
}