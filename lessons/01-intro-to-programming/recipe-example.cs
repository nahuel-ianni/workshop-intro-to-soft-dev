namespace Recipes
{
    class PizzaDough
    {
        string ingredient = "water";
        float  quantity   = 1.25f;
        int    minTemp    = 110;
        int    maxTemp    = 115;

        string yeast      = "yeast";
        string sugar      = "sugar";

        void Prepare(int standTime)
        {
            // Step 1 - Warm up the water
            AddHeat(ingredient, quantity, minTemp, maxTemp);

            // Step 2 - Dissolve yeast and sugar in water
            Dissolve(yeast, sugar, water);

            // Step 3 - Let it stand for a specific amount of time
            Stand(standTime);

            // Step 4 - Add oil and salt
            Finish("oil", "salt");
        }

        void AddHeat(string ingredient, float quantity, int minTemp, int maxTemp)
        { /* Function code goes here */ }

        void Dissolve(string i1, string i2, string dissolver)
        { /* Function code goes here */ }

        void Stand(int standTime)
        { /* Function code goes here */ }

        void Finish(string i1, string i2)
        { /* Function code goes here */ }
    }
}
