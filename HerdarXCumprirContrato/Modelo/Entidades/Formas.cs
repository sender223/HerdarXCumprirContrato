//SEGUNDA CLASSE A SER CRIADA
using HerdarXCumprirContrato.Modelo.Enums;

namespace HerdarXCumprirContrato.Modelo.Entidades {
    //classe abstrata
    abstract class Formas {
        //propriedade autoimplementada get set
        public Cores Cores { get; set; }
        //declaração do metodo abstrato Area
        public abstract double Area();
        
    }
}
