﻿using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DAL;

DbContextInitializer.Build();
using (var _context = new AppDbContext())
//AppDbContext içerisine DbContextInitializer.OptionsBuilder.Options yazdığımızda birden fazla  db ile baglantı kuracağımızı söyler
// ikinci bir overloadım olucak veritabanıyla ilgili optionsları belirteceğimiz sınıf belirtecegım 
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} : {p.Price} - {p.Price}");
    });

} 