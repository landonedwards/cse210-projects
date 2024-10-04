using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine($"Howdy World");
        Costume nurse = new();

        nurse._headWear = "face mask";
        nurse._gloves = "latex gloves";
        nurse._shoes = "orthopedic sneakers";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._accessory = "stethoscope";

        Costume detective = new();

        detective._headWear = "fedora";
        detective._gloves = "leather gloves";
        detective._shoes = "loafers";
        detective._upperGarment = "trench coat";
        detective._lowerGarment = "slacks";
        detective._accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}