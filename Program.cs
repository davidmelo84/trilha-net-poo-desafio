namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Nokia
            Nokia nokia = new Nokia("10102020", "Nokia Xurubim", "2021202223", 88);
            nokia.Ligar(); // Método da classe base
            nokia.ReceberLigacao(); // Método da classe base
            nokia.InstalarAplicativo("TikTok"); // Método da classe Nokia

            // Criando uma instância de iPhone
            iPhone iphone = new iPhone("587421897", "iPhone 80", "1441255263", 321);
            iphone.Ligar(); // Método da classe base
            iphone.ReceberLigacao(); // Método da classe base
            iphone.InstalarAplicativo("Instagram"); // Método da classe iPhone
        }
    }
}
