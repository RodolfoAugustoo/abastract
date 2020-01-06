
using System.Globalization;

namespace Abstract_ex.Entities
{
    class Individual : TaxPayer
    {
        public double AnualExpenditures { get; set; }

        public Individual() { }

        public Individual(double anualExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            AnualExpenditures = anualExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                if (AnualExpenditures > 0)
                {
                    return AnualIncome * 0.15 - AnualExpenditures * 0.5;
                }
                else
                    return 20000 * 0.15;
            }

            else
            {
                if (AnualExpenditures > 0)
                {
                    return AnualIncome * 0.25 - AnualExpenditures * 0.5;
                }
                else
                    return AnualIncome * 0.25;
            }            
        }

        public override string ToString()
        {
            return Name
                    + ": $"
                    + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
