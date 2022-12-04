internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 30;

        sayi1 = sayi2;
        sayi2 = 65;

        //sayi1 i yazdırmak isteseydik cevap 30 olurdu. 
        // int, decimal, double, float, boolean = bu tipler DEĞER (VALUE) tiplerdir
        // sayi1 ve sayi2 stact de tek tek tutulur
        // sayi1=sayi2 dediğimizde artık sayi1 in valuesi artık sayi2 nin valuesi olur

        int[] sayilar1 = new int[] {10,20,30};
        int[] sayilar2 = new int[] {100,200,300};

        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        
        //sayilar1[0] i yazdırmak istediğimizde 0. index cevap 999 olur.
        // array, class, interface = REFERANCE tiplerdir
        //sayilar1 ve sayilar2 stact de tutulur
        // new dediğimiz anda heap de yeni bir alan oluşturur. stack ve heap arasında bir adres oluşur
        // sayilar1 = sayilar2 dediğimizde sayilar1 in ve sayilar2 nin referans numaralarını eşitlemiş oluruz
        // sayilar1 in artık heapte tuttuğu alan değişir ve sayilar2 nin heapte tuttuğu alanı tutmaya başlar
        // artık sayilar1 in heapte tuttuğu alan bellekten atılır.






    }
}