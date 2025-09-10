using System;
class Program
{
    static void Main()
    {
        Carro meucarro = new Carro("Gol", 2000, 2);
        meucarro.ReciboCarro();
        meucarro.Ligar();
        meucarro.StatusCarro();
        meucarro.Buzinar();
        meucarro.Desligar();

        Carro meucarro2 = new Carro("Uno", 1990, 4);
        meucarro2.ReciboCarro();
        meucarro2.Ligar();
        meucarro2.StatusCarro();
        meucarro2.Buzinar();
        meucarro2.Desligar();

        meucarro.Acelerar();
        meucarro.Acelerar();
        meucarro.StatusCarro();

        meucarro2.Acelerar();
        meucarro2.Acelerar();
        meucarro2.Frear();
        meucarro2.StatusCarro();

        CarroEletrico meucarroeletrico = new CarroEletrico("Tesla", 2000, 4, "Branco");
        meucarroeletrico.ReciboCarro();
        meucarroeletrico.Ligar();
        meucarroeletrico.StatusCarro();
        meucarroeletrico.Buzinar();
        meucarroeletrico.Desligar();

        meucarroeletrico.Acelerar();
        meucarroeletrico.Acelerar();
        meucarroeletrico.StatusCarro();
        

        
    }
}
    public class Carro
    {
        public string Marca;
        public int Ano;
        public int Numerosdeportas;
        protected double velocidade_atual;


        public Carro(string marca, int ano, int np)
         {
            Marca = marca;
            Ano = ano;
            Numerosdeportas = np;   
         }
         public  virtual void ReciboCarro()
         {
            Console.WriteLine("-------------------");
            Console.WriteLine("Recibo Carro:");
            Console.WriteLine("-------------------");
            Console.WriteLine(Marca);
            Console.WriteLine(Ano);
            Console.WriteLine(Numerosdeportas);
            Console.WriteLine("-------------------");
         }
         public void StatusCarro()
         {
            Console.WriteLine(velocidade_atual);
         }

         public void Ligar()
         {
            Console.WriteLine("Carro Ligado");
         }
         public  virtual void Acelerar()
         {
          velocidade_atual += 50.00;
         }
         public virtual void Frear()
         {
           velocidade_atual -= 25.00;

           if (velocidade_atual <= 0)
           {
            velocidade_atual = 0;
           }
           else
           {
            velocidade_atual = velocidade_atual;
           }


         }
         public void Desligar()
         {
            Console.WriteLine("Carro desligado");
         }
         public  virtual  void Buzinar()
         {
            Console.WriteLine("biiiiiiiiiiiiiiiiiiiiiiiiiiiii");
         }
    }

    public class CarroEletrico : Carro
    {
        public string Cor;

        public CarroEletrico(string marca, int ano, int np, string cor) : base(marca,  ano,  np)
        {
            
            Cor = cor;

        }
            public  override  void Buzinar()
            {
                Console.WriteLine("iiiiiiiiiiiiiii");
            }

            public void LigarMultimidia()
            {
                Console.WriteLine("Multimidia ligado...");
            }
            public override void Acelerar()
            {
                velocidade_atual += 75.00;
            }
            public override void Frear()
            {
                velocidade_atual -= 55.00;
            }
            public  override void ReciboCarro()
         {
            Console.WriteLine("-------------------");
            Console.WriteLine("Recibo Carro:");
            Console.WriteLine("-------------------");
            Console.WriteLine(Marca);
            Console.WriteLine(Ano);
            Console.WriteLine(Numerosdeportas);
            Console.WriteLine(Cor);
            Console.WriteLine("-------------------");
         }
        

    }
