//TERCEIRA CLASSE A SER CRIADA
using System;
using System.Globalization;

namespace HerdarXCumprirContrato.Modelo.Entidades {
    //classe herdada de Formas
    class Circulo : Formas {
        //propriedade autoimplementada
        public double Raio { get; set; }
        //operação de area do circulo
        public override double Area() {
            return Math.PI * Raio * Raio;
        }
        //operação de converter a classe em string
        public override string ToString() {
            return "Circle color = "
                + Cores
                + ", Raio = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
