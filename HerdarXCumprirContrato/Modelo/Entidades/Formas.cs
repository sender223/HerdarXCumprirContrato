//SEGUNDA CLASSE A SER CRIADA - APÓS IMPLEMENTAR A CLASSE IFORMAS
//QUE É DO TIPO INTERFACE ESSA CLASSE NÃO SERA MAIS UTILIZADA
//PODENDO ASSIM EXCLUIR A MESMA...
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
