using System;

public class Residence
{
    public enum ResidenceType
    {
        House = 1_000_000,
        Flat = 100_000,
        Bungalow = 10_000,
        Apartment = 100_000
    }

    public static int contractAmount = 0;
    private int contractID;
    private ResidenceType type;
    private int numberOfBedrooms;
    private bool hasGarage;
    private bool hasGarden;

    public void Deconstruct(out ResidenceType type, out int numberOfBedrooms, out bool hasGarage, out bool hasGarden)
    {
        type = this.type;
        numberOfBedrooms = this.numberOfBedrooms;
        hasGarage = this.hasGarage;
        hasGarden = this.hasGarden;
    }

    public Residence(ResidenceType type, int numberOfBedrooms, bool hasGarage)
    {
        contractID = ++contractAmount;
        Type = type;
        NumberOfBedrooms = numberOfBedrooms;
        HasGarage = hasGarage;
    }
    public Residence(ResidenceType type, int numberOfBedrooms, bool hasGarage, bool hasGarden) : this(type, numberOfBedrooms, hasGarage)
    {
        HasGarden = hasGarden;
    }

    public ResidenceType Type
    {
        get => type;
        set => type = value;
    }

    public int NumberOfBedrooms
    {
        get => numberOfBedrooms;
        set => numberOfBedrooms = value >= 0 ? value : 0;
    }

    public bool HasGarage
    {
        get => hasGarage;
        set => hasGarage = value;
    }

    public bool HasGarden
    {
        get => hasGarden;
        set => hasGarden = value;
    }

    public double CalculateBuildingCost()
    {
        double cost = (int)type;

        double additionalCostToNumberOfBedrooms = 1.1;
        double additionalCostIfHasGarden = 1.2;
        double additionalCostIfHasGarage = 1.3;

        if (numberOfBedrooms > 3) cost *= additionalCostToNumberOfBedrooms;

        if (hasGarage) cost *= additionalCostIfHasGarage;

        if (hasGarden) cost *= additionalCostIfHasGarden;

        return cost;
    }

    public double CalculateSalePrice()
    {
        return CalculateBuildingCost() * 1.6;
    }

    public void Print()
    {
        Console.WriteLine($"{contractID}. {type}\nCost: {CalculateSalePrice()}$\nNumber of bedrooms: {numberOfBedrooms}\nHas garage: {(hasGarage ? "Yes" : "No")}\nHas garden: {(hasGarden ? "Yes" : "No")}");
    }
}

