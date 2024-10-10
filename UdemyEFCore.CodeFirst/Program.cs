// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Console.WriteLine("Hello, World!");


Initalizer.Build();
using (var _context = new AppDbContext())
//AppDbContext içerisine DbContextInitializer.OptionsBuilder.Options yazdığımızda birden fazla  db ile baglantı kuracağımızı söyler
// ikinci bir overloadım olucak veritabanıyla ilgili optionsları belirteceğimiz sınıf belirtecegım 
{
    //efcore veritabanından ilk okuduğunda Unchanged 
    //eğer memoriyede olmayan  bir şeyi okumaya calısırsa detached oluyor
    var newProduct = new Product { Name = "Kalem 200", Price = 200,Stock = 100, Barcode = 333 };

    Console.WriteLine($"İlk state:{ _context.Entry(newProduct).State}");

    await _context.AddAsync( newProduct );
    Console.WriteLine($"son state:{_context.Entry(newProduct).State}");

    await _context.SaveChangesAsync();
    Console.WriteLine($"state save changes:{_context.Entry(newProduct).State}");


    //var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{ 
    //    var state = _context.Entry(p).State;

    //    Console.WriteLine($"{p.Id} : {p.Name} : {p.Price} - {p.Price} State: {state}");
    //});

}