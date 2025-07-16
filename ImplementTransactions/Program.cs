
using ImplementTransactions;

using (var context = new AppDbContext())
{
    using(var transaction = context.Database.BeginTransaction())
    {
        var fromWallet = context.Wallets.Single(x => x.Id == 5);
        var toWallet = context.Wallets.Single(x => x.Id == 6);

        var amountToTransfer = 500m;

        fromWallet.Balance -= amountToTransfer;
        context.SaveChanges();

        toWallet.Balance += amountToTransfer;
        context.SaveChanges();

        transaction.Commit();
    }
}