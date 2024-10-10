// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using System;
using UdemyEFCore.DatabaseFirstByScaffold.Models;

Console.WriteLine("Hello, World!");

using (var _context = new UdemyEfcoeDatebaseFirstDbContext())
//AppDbContext içerisine DbContextInitializer.OptionsBuilder.Options yazdığımızda birden fazla  db ile baglantı kuracağımızı söyler
// ikinci bir overloadım olucak veritabanıyla ilgili optionsları belirteceğimiz sınıf belirtecegım 
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} : {p.Price} - {p.Price}");
    });
}