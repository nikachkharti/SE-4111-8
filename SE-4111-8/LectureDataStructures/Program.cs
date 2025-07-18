namespace LectureDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LIST
            int[] ar = [98, 11, 44, -10];

            List<int> intList = new List<int>();
            intList.Add(10); // ამატებს ერთ ელემენტს
            intList.Add(300); // ამატებს ერთ ელემენტს
            intList.Add(788); // ამატებს ერთ ელემენტს
            intList.Add(9); // ამატებს ერთ ელემენტს
            intList.Add(19); // ამატებს ერთ ელემენტს
                             //intList.AddRange(ar); // ამატებს რამდენიმე ელემენტს
                             //intList.Remove(10);
                             //intList.RemoveRange(0, 2); // წაშალე პირველი ორი ელემენტი ლისტში
                             //intList.Clear(); // ასუფთავებს ლისტს
                             //intList.Insert(0, 99); // ლისტის ნებისმიერ ინდექსზე ნებისმიერი მნიშვნელობის ჩამატება
                             //intList.InsertRange(0, [7, 7, 7]);
                             //bool contains = intList.Contains(7);
                             //int idx = intList.IndexOf(-10);
                             //intList.TrimExcess(); // გაამადგურებს ტყუილად გამოყოფილ ადგილებს

            //int listCount = intList.Count; // ზომა
            //int listCapacity = intList.Capacity; // მოცულობა
            // 
            #endregion

        }
    }
}