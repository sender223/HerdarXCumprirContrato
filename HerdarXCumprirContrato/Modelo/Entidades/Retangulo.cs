//QUARTA CLASSE A SER CRIADA
using System;
using System.Globalization;

namespace HerdarXCumprirContrato.Modelo.Entidades {
    //classe herdada de shape
    class Retangulo : Formas {
        
        //propriedade autoimplementada
        public double Largura { get; set; }
        public double Altura { get; set; }

        //operação para calcular Area do Retangulo
        public override double Area() {
            return Largura * Altura;
        }

        //operação para converter a classe em string
        public override string ToString() {
            return "Cores do Retangulo = "
                + Cores
                + ", Largura = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", Altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
