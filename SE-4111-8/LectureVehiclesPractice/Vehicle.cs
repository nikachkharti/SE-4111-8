namespace LectureVehiclesPractice
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public override string ToString() => $"{Make} {Model} {Cylinder} {Engine} {Drive} {Transmission} {City} {Combined} {Highway}";

        public static Vehicle Parse(string data)
        {
            string[] separatedData = data.Split(',');

            if (separatedData.Length != 9)
                throw new FormatException("Invalid argument passed");

            Vehicle result = new()
            {
                Make = separatedData[0],
                Model = separatedData[1],
                Cylinder = byte.Parse(separatedData[2]),
                Engine = float.Parse(separatedData[3]),
                Drive = separatedData[4],
                Transmission = separatedData[5],
                City = byte.Parse(separatedData[6]),
                Combined = byte.Parse(separatedData[7]),
                Highway = byte.Parse(separatedData[8])
            };

            return result;
        }

    }
}
