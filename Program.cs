Ogrenci ogrenci = new Ogrenci{
    
    Isim = "MOUHAMED",
    Soyisim =   "FARDOUSI",
    OgrenciNo = "1810225538",
    Sınıf = 3
};
ogrenci.sınıfAtlat();
ogrenci.OgrenciBilgileriGetir();

Ogrenci ogrenci1 = new Ogrenci("Ali","velid","8975489",1);
ogrenci1.OgrenciBilgileriGetir();
ogrenci1.sınıfDusur();
class Ogrenci
{
    private string isim;
    private string soyisim;
    private string ogrenciNo;
    private int sınıf  ;

    public string Isim 
    { 
      get {return isim; } 
      set {isim = value; }
    }

    

    public string Soyisim { get => soyisim; set => soyisim = value; }

    public Ogrenci(string soyisim, string isim, string ogrrenciNo, int sınınf)
    {
        Soyisim = soyisim;
        Isim = isim;
        OgrenciNo = ogrrenciNo;
        Sınıf = sınınf;
    }

    public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sınıf 
    { 
        get => sınıf; 
        set 
        {
            if (value < 1)
            {
                System.Console.WriteLine("Sınıf en az 1 olmalıdır");
                sınıf = 1 ;
            }
            else
                sınıf = value ;
        } 
    }

    public void  OgrenciBilgileriGetir(){
        System.Console.WriteLine("**** Ogrenci Bilgileri ****");
        System.Console.WriteLine($"Öğrenci Adı : {this.Isim}");
        System.Console.WriteLine($"Öğrenci Soyadı : {this.Soyisim}");
        System.Console.WriteLine($"Öğrenci No : {this.OgrenciNo}");
        System.Console.WriteLine($"Öğrenci Sınıfı : {this.Sınıf}");
    }
    public void sınıfAtlat(){
        this.Sınıf = this.Sınıf+1;
    }
    public void sınıfDusur(){
        this.Sınıf = this.Sınıf - 1;
    }
    public Ogrenci(){}
}

