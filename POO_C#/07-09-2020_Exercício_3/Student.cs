using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3_07_09_2020
{
    class Student
    {
        private string _name;
        private float _grade1, _grade2, _grade3;
        public Student(string name, float grade1, float grade2, float grade3)
        {
            _name = name;
            _grade1 = grade1;
            _grade2 = grade2;
            _grade3 = grade3;
        }

        private float FinalGrade()
        {
            return _grade1 + _grade2 + _grade3;
        }
        private float PointsToMin()
        {
            return 60 - FinalGrade();
        }
        private string Situation()
        {
            if (PointsToMin() < 0)
            {
                return "Aprovado.";
            }
            else 
            {
                return "Reprovado. Faltam " + PointsToMin() + " pontos.";
            }
        }
        public override string ToString()
        {
            return new string
                (
                "\nNota do primeiro trimestre - "   + _grade1       +
                "\nNota do segundo trimestre - "    + _grade2       +
                "\nNota do terceiro trimestre - "   + _grade3       +
                "\nNota final - "                   + FinalGrade()  +
                "\n"                                + Situation()
                );
        }
    }
}
