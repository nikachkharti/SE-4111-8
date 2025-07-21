namespace LectureDataStructures
{
    public delegate bool Predicate(int value);

    public class Algorithms
    {
        //მოვძებნოთ პირველივე ელემენტი
        public static int CustomFirstOrDefault(List<int> intList, Predicate comparerDelegate) //<< piroba
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (comparerDelegate(intList[i]))
                {
                    return intList[i];
                }
            }

            return default;
        }

        public static int CustomLastOrDefault(int[] numbersArray, Predicate predicate)
        {
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                if (predicate(numbersArray[i]))
                {
                    return numbersArray[i];
                }
            }

            return default;
        }


    }
}
