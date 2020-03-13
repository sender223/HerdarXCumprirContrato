//SEXTA CLASSE A SER CRIADA
using System;
using HerdarXCumprirContrato.Modelo.Entidades;
using HerdarXCumprirContrato.Modelo.Enums;

namespace HerdarXCumprirContrato.Modelo.Entidades {
    //essa classe alem de ser abastrata 
    //é um subtipo da classe IFormas
    //ela implementa a classe IFormas
    abstract class FormasAbstratas : IFormas {

        public Cores Cores  { get; set; }

        //aqui temos que implementar o metodo abstrato
        public abstract double Area();

    }
}
