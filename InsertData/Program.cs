
using InsertData;

var wallet = new Wallet()
{
    Holder = "Salah",
    Balance = 4000m
};


using (var context = new AppDbContext())
{
    context.Wallets.Add(wallet);
    context.SaveChanges();
}