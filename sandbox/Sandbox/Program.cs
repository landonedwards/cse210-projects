using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine($"Howdy World");
        Costume nurse = new();

        nurse.headWear = "face mask";
        nurse.gloves = "latex gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();

        detective.headWear = "fedora";
        detective.gloves = "leather gloves";
        detective.shoes = "loafers";
        detective.upperGarment = "trench coat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}