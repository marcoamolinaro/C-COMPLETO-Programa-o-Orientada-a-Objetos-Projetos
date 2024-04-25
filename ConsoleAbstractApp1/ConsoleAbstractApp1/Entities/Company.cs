﻿
namespace ConsoleAbstractApp1.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = (NumberOfEmployees > 10) ? AnualIncome * 0.14 : AnualIncome * 0.16;

            return tax;
        }
    }
}
