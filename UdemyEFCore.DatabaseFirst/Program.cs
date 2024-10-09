using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DAL;

DbContextInitializer.Build();
using (var _context= new AppDbContext(DbContextInitializer.OptionsBuilder.Options))// ikinci bir overloadım olucak veritabanıyla ilgili optionsları belirteceğimiz sınıf belirtecegım 
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name}");
    });

} 