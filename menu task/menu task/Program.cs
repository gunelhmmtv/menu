using static System.Console;
using static System.Convert;

WriteLine("Restorana xos gelmisiniz!");
WriteLine("MENYU:");
WriteLine("1 - İsti yemekler");
WriteLine("2 - Qazan yemekleri");
WriteLine("3 - İçkiler");
WriteLine("4 - Desertler");
WriteLine("Kateqoriyani secin:");
int kateqoriya = ToInt32(ReadLine());

switch (kateqoriya)
{
    case 1:
        WriteLine("1 - Dolma");
        WriteLine("2 - Ev sayagi kartof");
        WriteLine("3 - Saurma");
        WriteLine("Istediyiniz yemeyi seçin:");
        int isti_yemek = ToInt32(ReadLine());

        switch (isti_yemek)
        {
            case 1:
                WriteLine("Nece eded dolma sifaris etmek isteyirsiniz?");
                int eded_dolma = ToInt32(ReadLine());
                WriteLine($"Siz {eded_dolma} eded Dolma sifaris etdiniz.");
                break;
            case 2:
                WriteLine("Nece eded Ev sayagi kartof sifaris etmek isteyirsiniz?");
                int eded_esk = ToInt32(ReadLine());
                WriteLine($"Siz {eded_esk} eded Ev sayagi kartof sifaris etdiniz.");
                break;
            case 3:
                WriteLine("Nece eded Saurma sifaris etmek isteyirsiniz?");
                int eded_saurma = ToInt32(ReadLine());
                WriteLine($"Siz {eded_saurma} eded Saurma sifaris etdiniz.");
                break;
            default:
                WriteLine("Sehv secim.");
                break;
        }
        break;

    case 2:
        WriteLine("1 - Buglama");
        WriteLine("2 - Piti");
        WriteLine("3 - Soyutma");
        WriteLine("Istediyiniz yemeyi secin:");
        int qazan_yemek = ToInt32(ReadLine());

        switch (qazan_yemek)
        {
            case 1:
                WriteLine("Nece eded Buglama sifaris etmek isteyirsiniz?");
                int eded_buglama = ToInt32(ReadLine());
                WriteLine($"Siz {eded_buglama} eded Buglama sifaris etdiniz.");
                break;
            case 2:
                WriteLine("Nece eded Piti sifaris etmek isteyirsiniz?");
                int eded_piti = ToInt32(ReadLine());
                WriteLine($"Siz {eded_piti} eded Piti sifaris etdiniz.");
                break;
            case 3:
                WriteLine("Nece eded Soyutma sifaris etmek isteyirsiniz?");
                int eded_soyutma = ToInt32(ReadLine());
                WriteLine($"Siz {eded_soyutma} eded Soyutma sifaris etdiniz.");
                break;
            default:
                WriteLine("Sehv secim.");
                break;
        }
        break;

    case 3:
        WriteLine("1 - Cay");
        WriteLine("2 - Kofe");
        WriteLine("3 - Cola");
        WriteLine("Istediyiniz deserti secin:");
        int icki = ToInt32(ReadLine());

        switch (icki)
        {
            case 1:
                WriteLine("Nece eded Cay sifaris etmek isteyirsiniz?");
                int eded_cay = ToInt32(ReadLine());
                WriteLine($"Siz {eded_cay} eded Cay sifaris etdiniz.");
                break;
            case 2:
                WriteLine("Nece eded Kofe sifaris etmek isteyirsiniz?");
                int eded_kofe = ToInt32(ReadLine());
                WriteLine($"Siz {eded_kofe} eded Kofe sifaris etdiniz.");
                break;
            case 3:
                WriteLine("Nece eded Cola sifaris etmek isteyirsiniz?");
                int eded_cola = ToInt32(ReadLine());
                WriteLine($"Siz {eded_cola} eded Cola sifaris etdiniz.");
                break;
            default:
                WriteLine("Sehv secim.");
                break;
        }
        break;
    case 4:
        WriteLine("1 - Tiramisu");
        WriteLine("2 - Cizkeyk");
        WriteLine("3 - Pirofitrol");
        WriteLine("Istediyiniz deserti secin:");
        int desert = ToInt32(ReadLine());

        switch (desert)
        {
            case 1:
                WriteLine("Nece eded Tiramisu sifaris etmek isteyirsiniz?");
                int eded_tiramisu = ToInt32(ReadLine());
                WriteLine($"Siz {eded_tiramisu} eded Tiramisu sifaris etdiniz.");
                break;
            case 2:
                WriteLine("Nece eded Cizkeyk sifaris etmek isteyirsiniz?");
                int eded_cizkeyk = ToInt32(ReadLine());
                WriteLine($"Siz {eded_cizkeyk} eded Cizkeyk sifaris etdiniz.");
                break;
            case 3:
                WriteLine("Nece eded Pirofitrol sifaris etmek isteyirsiniz?");
                int eded_pirofitrol = ToInt32(ReadLine());
                WriteLine($"Siz {eded_pirofitrol} eded Pirofitrol sifaris etdiniz.");
                break;
            default:
                WriteLine("Sehv secim.");
                break;
        }
        break;

    default:
        WriteLine("Yanlıs kateqoriya secimi.");
        break;
}
