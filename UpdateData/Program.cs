
using UpdateData;

using (var context = new AppDbContext())
{
    var wallet = context.Wallets.Single(x => x.Id == 4);
    wallet.Balance += 1000;
    context.SaveChanges();
}