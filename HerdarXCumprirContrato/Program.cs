using System;
using HerdarXCumprirContrato.Modelo.Entidades;
using HerdarXCumprirContrato.Modelo.Enums;

namespace HerdarXCumprirContrato {
    class Program {
        static void Main(string[] args) {
            //instanciando Formas, iremos usar uma forma alternativa
            //ja que não tem construtor dentro das classes.
            //Formas f1 = new Circulo() { Raio = 2.0, Cores = Cores.Branco };
            //Formas f2 = new Retangulo() { Largura = 3.5, Altura = 4.2, Cores = Cores.Preto };
            
            //instanciamos a classe do tipo Interface FormasAbstratas pois removemos a Classe Formas. 
            FormasAbstratas f3 = new Circulo() { Raio = 2.0, Cores = Cores.Branco };
            FormasAbstratas f4 = new Retangulo() { Largura = 3.5, Altura = 4.2, Cores = Cores.Preto };

            Console.WriteLine(f3);
            Console.WriteLine(f4);

        }
    }
}
