using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;
using DataAccessLibraray.UserModels;

namespace DataAccessLibraray.Data.Config
{
    public class CountryConfiguration : IEntityTypeConfiguration<TbCountry>
    {
        public void Configure(EntityTypeBuilder<TbCountry> builder)
        {

            builder.ToTable("TbCountries");


            builder
                .HasMany(e => e.TbCities)
                .WithOne(e => e.TbCountry)
                .HasForeignKey(e => e.CountryId)
                .IsRequired();

            // Seed data with 50 real countries
            var countries = GenerateCountries();


            //builder.HasData(countries);


        }

    private List<TbCountry> GenerateCountries()
    {
        return 
        new List<TbCountry>
            {
                new TbCountry { CountryAname = "أفغانستان", CountryEname = "Afghanistan", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "ألبانيا", CountryEname = "Albania", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الجزائر", CountryEname = "Algeria", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "أندورا", CountryEname = "Andorra", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "أنغولا", CountryEname = "Angola", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الأرجنتين", CountryEname = "Argentina", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "أرمينيا", CountryEname = "Armenia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "أستراليا", CountryEname = "Australia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "النمسا", CountryEname = "Austria", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "أذربيجان", CountryEname = "Azerbaijan", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بahamاس", CountryEname = "Bahamas", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "البحرين", CountryEname = "Bahrain", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بنغلاديش", CountryEname = "Bangladesh", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "باربادوس", CountryEname = "Barbados", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بيلاروسيا", CountryEname = "Belarus", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بلجيكا", CountryEname = "Belgium", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بليز", CountryEname = "Belize", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بنين", CountryEname = "Benin", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بوتان", CountryEname = "Bhutan", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بوليفيا", CountryEname = "Bolivia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "البوسنة والهرسك", CountryEname = "Bosnia and Herzegovina", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بوتسوانا", CountryEname = "Botswana", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "البرازيل", CountryEname = "Brazil", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بروناي", CountryEname = "Brunei", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بلغاريا", CountryEname = "Bulgaria", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بوركينا فاسو", CountryEname = "Burkina Faso", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "بوروندي", CountryEname = "Burundi", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "كمبوديا", CountryEname = "Cambodia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الكاميرون", CountryEname = "Cameroon", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "كندا", CountryEname = "Canada", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الرأس الأخضر", CountryEname = "Cape Verde", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "تشيلي", CountryEname = "Chile", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الصين", CountryEname = "China", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "كولومبيا", CountryEname = "Colombia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الكونغو", CountryEname = "Congo", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "كوستاريكا", CountryEname = "Costa Rica", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "كرواتيا", CountryEname = "Croatia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "قبرص", CountryEname = "Cyprus", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "التشيك", CountryEname = "Czech Republic", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الدنمارك", CountryEname = "Denmark", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "جيبوتي", CountryEname = "Djibouti", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "دومينيكا", CountryEname = "Dominica", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "جمهورية الدومينيكان", CountryEname = "Dominican Republic", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "الإكوادور", CountryEname = "Ecuador", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "مصر", CountryEname = "Egypt", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "السلفادور", CountryEname = "El Salvador", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "استوائي غينيا", CountryEname = "Equatorial Guinea", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "إريتريا", CountryEname = "Eritrea", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "إستونيا", CountryEname = "Estonia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "سوازيلند", CountryEname = "Eswatini", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "إثيوبيا", CountryEname = "Ethiopia", CreatedDate = DateTime.Now },
                new TbCountry { CountryAname = "فانواتو", CountryEname = "Vanuatu", CreatedDate = DateTime.Now },

             new TbCountry { CountryAname = "الإمارات العربية المتحدة", CountryEname = "United Arab Emirates", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "المملكة العربية السعودية", CountryEname = "Saudi Arabia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "مصر", CountryEname = "Egypt", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "العراق", CountryEname = "Iraq", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الأردن", CountryEname = "Jordan", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الكويت", CountryEname = "Kuwait", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "عمان", CountryEname = "Oman", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "قطر", CountryEname = "Qatar", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "البحرين", CountryEname = "Bahrain", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "سوريا", CountryEname = "Syria", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "لبنان", CountryEname = "Lebanon", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "فلسطين", CountryEname = "Palestine", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "اليمن", CountryEname = "Yemen", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "تركيا", CountryEname = "Turkey", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "إيران", CountryEname = "Iran", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "المغرب", CountryEname = "Morocco", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "تونس", CountryEname = "Tunisia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الجزائر", CountryEname = "Algeria", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "ليبيا", CountryEname = "Libya", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "السودان", CountryEname = "Sudan", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "موريتانيا", CountryEname = "Mauritania", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "جيبوتي", CountryEname = "Djibouti", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الصومال", CountryEname = "Somalia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الكاميرون", CountryEname = "Cameroon", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "فلسطين", CountryEname = "Palestine", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "مصر", CountryEname = "Egypt", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الولايات المتحدة", CountryEname = "United States", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "كندا", CountryEname = "Canada", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "إندونيسيا", CountryEname = "Indonesia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "ماليزيا", CountryEname = "Malaysia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "فيتنام", CountryEname = "Vietnam", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "الفلبين", CountryEname = "Philippines", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "سنغافورة", CountryEname = "Singapore", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "تشيلي", CountryEname = "Chile", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "أفغانستان", CountryEname = "Afghanistan", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "جزر القمر", CountryEname = "Comoros", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "جزر سليمان", CountryEname = "Solomon Islands", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "فانواتو", CountryEname = "Vanuatu", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "بابوا غينيا الجديدة", CountryEname = "Papua New Guinea", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "توغو", CountryEname = "Togo", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "توجو", CountryEname = "Togo", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "زامبيا", CountryEname = "Zambia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "موزمبيق", CountryEname = "Mozambique", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "جنوب أفريقيا", CountryEname = "South Africa", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "غينيا", CountryEname = "Guinea", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "ليبيريا", CountryEname = "Liberia", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "سيراليون", CountryEname = "Sierra Leone", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "كوت ديفوار", CountryEname = "Ivory Coast", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "النيجر", CountryEname = "Niger", CreatedDate = DateTime.Now },
            new TbCountry { CountryAname = "تشاد", CountryEname = "Chad", CreatedDate = DateTime.Now },


        };
    }
   
    }

  
}
