namespace LectureDataStructures
{
    //Predicate --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და აბრუნებს bool - ს
    //Func --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და დასაბრუნებელი ტიპს ვუთითებთ ჩვენ
    //Action --> შეუძლია მიინიჭოს ისეთი მეთოდი რომლის დასაბრუნებელი ტიპი არის void


    //public delegate bool Predicate(int value);
    //public delegate int Func(string value);
    //public delegate void Action(string value);

    public class Algorithms
    {
        public static int CustomFirstOrDefault(List<int> intList, Predicate<int> predicate) //<< piroba
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    return intList[i];
                }
            }

            return default;
        }
        public static int CustomLastOrDefault(int[] numbersArray, Predicate<int> predicate)
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
        public static List<int> CustomFindAll(List<int> intList, Func<int, bool> predicate)
        {
            List<int> result = new();

            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    result.Add(intList[i]);
                }
            }

            return result;
        }
        public static List<int> CustomSelect(List<string> stringList, Func<string, int> selector)
        {
            List<int> result = new();

            for (int i = 0; i < stringList.Count; i++)
            {
                result.Add(selector(stringList[i]));
            }

            return result;
        }
        public static void Log(string info, Action<string> action)
        {
            action(info);
        }


    }
}
