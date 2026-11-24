using System;

class Islemci
{
    public string Model {get; set;}
    public int CekirdekSayisi {get; set;}
    
    public Islemci(string m, int cs)
    {
        Model = m;
        CekirdekSayisi = cs;
    }

    public void Calistir ()
    {
        Console.WriteLine($"{Model} çalıştı!");
    }
    
}

class Bilgisayar                    //Composition ilişkisi örneği!
{
    private Islemci islemci;
    public string Marka {get; set;}

    public Bilgisayar(string marka, string model, int c)
    {
        Marka = marka;
        islemci = new Islemci(model, c);
    }

    public void Ac()
    {
        Console.WriteLine($"{Marka} bilgisayar açıldı!");
        islemci.Calistir();         //Ayrıca Encapsulation örneği! Çalıştır fonksiyonu kodu ayrı
    }
    
    public void BilgileriGoster()
    {
        Console.WriteLine($"Islemci: {islemci.Model}\nÇekirdek: {islemci.CekirdekSayisi}");
    }

}

class Program
{
    static void Main()
    {
        Bilgisayar bilg1 = new Bilgisayar("Dell", "Intel i7", 8);
        bilg1.BilgileriGoster();
        bilg1.Ac();
    }
}



