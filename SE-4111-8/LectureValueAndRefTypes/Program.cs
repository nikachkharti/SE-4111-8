using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Net.Http.Headers;

namespace LectureValueAndRefTypes
{
    //ყველა კლასი არის REFERENCE ტიპი
    //ყველა სტრუქტურა არის VALUE ტიპი

    public struct MoneyValue
    {
        public string Currency { get; set; }
        public double Value { get; set; }
    }

    public class MoneyReference /*: IEquatable<MoneyReference>*/
    {
        public string Currency { get; set; }
        public double Value { get; set; }

        //public bool Equals(MoneyReference other)
        //{
        //    if (other == null)
        //        return false;
        //    return Currency == other.Currency && Value == other.Value;
        //}

        public override bool Equals(object obj)
        {
            return new MoneyReferenceEquilityComparer().Equals(this, obj as MoneyReference);
        }

        public override int GetHashCode()
        {
            return new MoneyReferenceEquilityComparer().GetHashCode();
        }
    }


    public class MoneyReferenceEquilityComparer : IEqualityComparer<MoneyReference>
    {
        //2
        public bool Equals(MoneyReference x, MoneyReference y)
        {
            return x.Currency == y.Currency && x.Value == y.Value;
        }

        //1
        public int GetHashCode([DisallowNull] MoneyReference obj)
        {
            return (int)obj.Value;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            decimal usd = 100.22m;
            decimal eur = 91.22m;

            Console.WriteLine($"Before swap USD = {usd}, EUR = {eur}");

            Swap(ref usd, ref eur);

            Console.WriteLine($"After swap USD = {usd}, EUR = {eur}");




            #region REFERENCE TYPES
            //MoneyReference mr1 = new() { Currency = "GEL", Value = 10 };
            //MoneyReference mr2 = new() { Currency = "GEL", Value = 10 };
            //MoneyReference mr3 = new() { Currency = "USD", Value = 27 };

            //List<MoneyReference> moneyReferences = new() { mr1, mr2, mr3 };

            //var result = moneyReferences.Custom_Distinct(new MoneyReferenceEquilityComparer()); 
            #endregion





            #region VALUE TYPES
            //MoneyValue mv1 = new() { Currency = "GEL", Value = 10 };
            //MoneyValue mv2 = new() { Currency = "GEL", Value = 10 };
            //MoneyValue mv3 = new() { Currency = "USD", Value = 27 };

            //List<MoneyValue> moneyValues = new List<MoneyValue>() { mv1, mv2, mv3 };

            //var result = moneyValues.Custom_Distinct(); 
            #endregion

        }


        public static void Swap(ref decimal currencyA, ref decimal currecyB)
        {
            decimal temp = currencyA;
            currencyA = currecyB;
            currecyB = temp;
        }

    }
}
