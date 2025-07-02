namespace LectureOOP
{
    public class Human
    {
        public string firstName;
        public string lastName;
        public int age;
        public string personalNumber;
        public string phoneNumber;
        public string email;

        public Human(string firstName, string lastName, int age, string personalNumber, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.personalNumber = personalNumber;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string Talk()
        {
            return $"{firstName} {lastName} {age}";
        }
    }
}
