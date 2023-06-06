using System;
interface Food

{
    string getType();
}

class Pizza : Food
{
    public string getType()
    {
       return "Someone ordered Fast Food";
    }

}
class Cake : Food

{
    public string getType()

    {
        return "Someone ordered a Dessert!";
    }

}

class FoodFactory

{
    public Food getFood(string order)

    {
          if (order.Equals("pizza"))

        {
            return new Pizza();
        }

        else if (order.Equals("cake"))
        {
            return new Cake();
        }
        else

        {
            return null;
        }

    }

}

class MainClass

{

    public static void Main(string[] args)

    {

        FoodFactory myFactory = new FoodFactory();
        Food myFood = myFactory.getFood(Console.ReadLine().Trim());
        Console.WriteLine("The factory returned class " + myFood.GetType().Name);
        Console.WriteLine(myFood.getType());

    }

}













