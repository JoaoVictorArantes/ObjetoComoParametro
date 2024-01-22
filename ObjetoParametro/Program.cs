namespace ObjetoParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Mustang", "Vermelho");             

            Carro meuCarro1 = copiar(meuCarro);

            MudarCor(meuCarro, "Prata");

            Console.WriteLine($"{meuCarro.modelo} {meuCarro.cor}");
            Console.WriteLine($"{meuCarro1.modelo} {meuCarro1.cor}");

            Console.ReadKey();
            Console.Beep();
        }
        public static void MudarCor(Carro carro, String cor)
        {
            carro.cor = cor;
        }
        public static Carro copiar(Carro meuCarro)  
        {
            return new Carro(meuCarro.modelo, meuCarro.cor);
        }   
    }
    class Carro
    {
        public string modelo;
        public string cor;

        public Carro(String modelo, String cor)
        {
            this.modelo = modelo;
            this.cor = cor;
        }
    }
}
