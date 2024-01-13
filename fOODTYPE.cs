// See https://aka.ms/new-console-template for more information
public class FoodType
{
    private String name;
    private int protein;
    private int carbs;
    private int fat;
    private static int counter = 0;

    public FoodType(String name, int protein, int carbs, int fat)
    {
        this.name = name;
        this.protein = protein;
        this.carbs = carbs;
        this.fat = fat;
        counter++;
    }

    public String getName()
    {
        return name;
    }

    public int getProtein()
    {
        return protein;
    }

    public int getCarbs()
    {
        return carbs;
    }

    public int getFat()
    {
        return fat;
    }

    public static int getNumberOfCreatedInstances()
    {
        return counter;
    }

    public String toString()
    {
        return name + ": p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%";
    }
}

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public FoodType getType()
    {
        return type;
    }

    public int getWeight()
    {
        return weight;
    }

    public double getProtein()
    {
        return type.getProtein() * weight / 100.0;
    }

    public double getCarbs()
    {
        return type.getCarbs() * weight / 100.0;
    }

    public double getFat()
    {
        return type.getFat() * weight / 100.0;
    }

    public String toString()
    {
        return type.toString() + ", w – " + weight + "g";
    }

    public String toStringInGrams()
    {
        return type.getName() + ": p – " + String.Format("%.1f", getProtein()) + "g, c – " +
                String.Format("%.1f", getCarbs()) + "g, f – " + String.Format("%.1f", getFat()) + "g, w – " + weight + "g";
    }
}

class Main
{
    public static void main(String[] args)
    {
        FoodType foodType = new FoodType("banana", 4, 93, 3);
        Food food = new Food(foodType, 110);

        System.out.println(food.toString());
        System.out.println("protein: " + food.getProtein() + "\ncarbs: " + food.getCarbs() + "\nfat: " + food.getFat());

        System.out.println(food.toStringInGrams());
    }
}
