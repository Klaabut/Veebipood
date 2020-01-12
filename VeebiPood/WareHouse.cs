using System;
using System.Collections.Generic;
using System.Text;

namespace VeebiPood
{
    class WareHouse
    {
        List<Article> InStock;

        //consructor
        public WareHouse()
        {
            InStock = new List<Article>();

            Article CinnamonBun = new Article(1, "Cinnamonbun", Category.PASTRY, 0.39);
            InStock.Add(CinnamonBun);

            Article Ciabatta = new Article(2, "Ciabatta", Category.PASTRY, 0.99);
            InStock.Add(Ciabatta);

            Article Piim = new Article(3, "Tere Piim", Category.DAIRY, 0.56);
            InStock.Add(Piim);

            Article Yogurt = new Article(4, "Alma", Category.DAIRY, 0.60);
            InStock.Add(Yogurt);

            Article Beer = new Article(5, "Walter", Category.BEWERAGES, 0.50);
            InStock.Add(Beer);

            Article Lemonade = new Article(6, "Limpa", Category.BEWERAGES, 0.76);
            InStock.Add(Lemonade);

            Article Geisha = new Article(7, "Geisha Chocolate", Category.SWEETS, 1.10);
            InStock.Add(Geisha);

            Article Haribo = new Article(8, "Haribo Gummybears", Category.SWEETS, 0.70);
            InStock.Add(Haribo);

            Article Beans = new Article(9, "4 Bean Mix", Category.CANNED_FOOD, 0.79);
            InStock.Add(Beans);

            Article Bolog = new Article(10, "Bolognese Sauce", Category.CANNED_FOOD, 1.26);
            InStock.Add(Bolog);

            Article Ham = new Article(11, "Ham", Category.MEAT, 0.99);
            InStock.Add(Ham);

            Article ChicCig = new Article(12, "Chicken Cigar", Category.MEAT, 1.26);
            InStock.Add(ChicCig);

            Article Trout = new Article(13, "Trout", Category.FISH, 1.00);
            InStock.Add(Trout);

            Article Salmon = new Article(14, "Salmon", Category.FISH, 2.00);
            InStock.Add(Salmon);

            Article Apple = new Article(15, "Apple", Category.FRUIT, 0.39);
            InStock.Add(Apple);

            Article Banana = new Article(16, "Banana", Category.FRUIT, 0.49);
            InStock.Add(Banana);

            Article Potato = new Article(17, "Potato", Category.VEGETABLES, 0.20);
            InStock.Add(Potato);

            Article Carrot = new Article(18, "Carrot", Category.VEGETABLES, 0.15);
            InStock.Add(Carrot);

            Article ToiletP = new Article(19, "Toilet Paper", Category.TOILETRIES, 1.59);
            InStock.Add(ToiletP);

            Article Shampoo = new Article(20, "Nivea", Category.TOILETRIES, 0.89);
            InStock.Add(Shampoo);


        }

        public void PrintInStock()
        {
            foreach (Article article in InStock)
            {
                Console.WriteLine($"Id: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();

            }
        }

        //Get an article object from the list

        public Article GetFromStock(int id)
        {
            return InStock[id - 1];
        }
        


    }
}
