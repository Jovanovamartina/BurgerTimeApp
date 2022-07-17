

using BurgerTimeApp.Domain.Entities;

namespace BurgerTimeApp.DataAccsess.Database
{
    public static class BurgerDatabase
    {
        public static List<Burger> BURGERS = new List<Burger>()
        {
            new Burger(1, "Hamburger", 7, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Cheese"),
                    new Ingredient(3, "Onion"),
                    new Ingredient(4, "Beef"),
                    new Ingredient(5, "Tomato")
                },
                "https://th.bing.com/th/id/R.78c446c8a8e21ee3f0f2002ae11171c9?rik=1cp72ANB%2fks3pg&pid=ImgRaw&r=0"
                ),
            new Burger(2, "CheeseBurger", 5, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Bacon"),
                    new Ingredient(3, "Cheddar"),
                    new Ingredient(4, "Garlic"),
                    new Ingredient(5, "Beef")
                },
                "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-tall-FS-38.webp"
                ),
            new Burger(3, "Chicken Burger", 9, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Chicken"),
                    new Ingredient(3, "Cheese"),
                    new Ingredient(4, "Bacon"),
                    new Ingredient(5, "Sauce")

                },
                  "https://i1.wp.com/gofry.com.fj/wp-content/uploads/2019/04/Chicken_Burger-scaled-e1624614963511.jpg?fit=600%2C583&ssl=1"
                ),
            new Burger(4, "Double Burger", 12, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Double Beef"),
                    new Ingredient(3, "Double Cheese"),
                    new Ingredient(4, " Sauce"),
                    new Ingredient(5, "Tomato")
                },
                 "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-tall-FS-38.webp"
                ),
            new Burger(5, "Veggie Burger", 3, true, true, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Tomato"),
                    new Ingredient(3, "Onion"),
                    new Ingredient(4, "Cheddar"),
                    new Ingredient(5, "Egg")
                },
                 "https://runningonrealfood.com/wp-content/uploads/2022/01/Best-Vegan-Chickpea-Veggie-Burger-Patties-Recipe.jpg"
                ),
        };

        public static List<Order> ORDERS = new List<Order>()
        {
            new Order(1, "Martina Jovanova", "Gligor Prlicev 67", true, new List<Burger>()
            {
                BURGERS[0],
                BURGERS[3],
            },"Gligor Prlivec 67"),
            new Order(2, "Sofia Stojanova", "Kliment Ohridski 36", true, new List<Burger>()
            {
                BURGERS[2]
            },"Kliment Ohridski 36"),
            new Order(3, "Ana Josifovska", "Tose Sazdov 94", false, new List<Burger>()
            {
                BURGERS[0],
                BURGERS[1],
            },"Tose Sazdov 94"),
        };
    }
}
