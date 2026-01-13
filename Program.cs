using System;

class Building
{
    public int Floors;
    public string Material;
    public bool Elevator;
    public string Type;

    public void Show()
    {
        Console.WriteLine("Тип будинку: " + Type);
        Console.WriteLine("Кількість поверхів: " + Floors);
        Console.WriteLine("Матеріал: " + Material);
        Console.WriteLine("Ліфт: " + (Elevator ? "Так" : "Ні"));
        Console.WriteLine("----------------------------");
    }
}

class Builder
{
    private Building building;

    public Builder()
    {
        building = new Building();
    }

    public void SetType(string type)
    {
        building.Type = type;
    }

    public void SetFloors(int floors)
    {
        building.Floors = floors;
    }

    public void SetMaterial(string material)
    {
        building.Material = material;
    }

    public void SetElevator(bool elevator)
    {
        building.Elevator = elevator;
    }

    public Building GetBuilding()
    {
        return building;
    }
}

class Program
{
    static void Main()
    {
        Builder officeBuilder = new Builder();
        officeBuilder.SetType("Офісна будівля");
        officeBuilder.SetFloors(8);
        officeBuilder.SetMaterial("Скло");
        officeBuilder.SetElevator(true);

        Building office = officeBuilder.GetBuilding();
        office.Show();

        Builder houseBuilder = new Builder();
        houseBuilder.SetType("Приватний будинок");
        houseBuilder.SetFloors(2);
        houseBuilder.SetMaterial("Цегла");
        houseBuilder.SetElevator(false);

        Building house = houseBuilder.GetBuilding();
        house.Show();

        Builder flatBuilder = new Builder();
        flatBuilder.SetType("Багатоквартирний будинок");
        flatBuilder.SetFloors(16);
        flatBuilder.SetMaterial("Бетон");
        flatBuilder.SetElevator(true);

        Building flat = flatBuilder.GetBuilding();
        flat.Show();

        Console.ReadLine();
    }
}
