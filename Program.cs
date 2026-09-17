namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Bia";
            Console.WriteLine(p.Nome);

            //Atividade 2 

            Produto t = new Produto();

            t.preco = 1;
            Console.WriteLine(t.preco);

            t.preco = -1;
            Console.WriteLine(t.preco);

            //Atividade 3

            Carro c = new Carro();
            c.Acelerar();
            Console.WriteLine(c.VelocidadeAtual);
            c.Acelerar();
            Console.WriteLine(c.VelocidadeAtual);
            c.Frear();
            Console.WriteLine(c.VelocidadeAtual);
            c.Acelerar();
            Console.WriteLine(c.VelocidadeAtual);
            c.Frear();
            Console.WriteLine(c.VelocidadeAtual);

            //Atividade 4

            Termometro temperatura = new Termometro();
            temperatura.celcius = 25;
            Console.WriteLine(temperatura.celcius);
            Console.WriteLine(temperatura.fahrenheit);
            Console.WriteLine(temperatura.kelvin);
        }
    }
}
