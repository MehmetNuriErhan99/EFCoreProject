using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{

    public class DbContextInitializer
    {
        public static IConfigurationRoot Configuration; // appsetting.json dosyalarını okuyabılmemızı saglar
       public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder;
        //optionsbuilderi inşaa edecegım bir sınıfım var ve nesne ornegı olusturacagım
        //üstteki kod veri tabanıyla optionsları    belirtecegımız yer
        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile ("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext> ();
            //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
            // Configuration sınıfı sayesındesın appsettings.json ın  hepsini okuyor
        }
        //Bu kod, uygulamanın ayarlarını appsettings.json dosyasından alıyor. Eğer bu dosya bulunmazsa, hata vermez (çünkü optional: true), ve dosyada değişiklik olursa ayarlar otomatik olarak güncellenir (çünkü reloadOnChange: true)

       

  
    }
}
