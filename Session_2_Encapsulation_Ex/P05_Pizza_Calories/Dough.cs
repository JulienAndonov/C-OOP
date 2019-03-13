using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Pizza_Calories
{
    public class Dough
    {



        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        private double Calories()
        {
            var caloriesPerGram = 2 * this.Weight;
            double modifierFlourType = this.FlourType.ToUpper() == "WHITE" ? 1.5 : 1.0;
            double modifierBakingTechnique = this.BakingTechnique.ToUpper() == "CRISPY" ? 0.9 : this.BakingTechnique.ToUpper() == "CHEWY" ? 1.1 : 1.0;
            var totalDoughCalories = caloriesPerGram * modifierFlourType * modifierBakingTechnique;
            return totalDoughCalories;
        }


        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToUpper() == "WHITE" || value.ToUpper() == "WHOLEGRAIN")
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToUpper() == "CRISPY" || value.ToUpper() == "CHEWY" || value.ToUpper() == "HOMEMADE")
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

            }
        }

        public int Weight
        {
            get
            {
                return this.weight; ;
            }
            private set
            {
                if (value >= 1 && value <= 200)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

            }
        }

        public double getCalories()
        {
            return this.Calories();
        }


        private string flourType;
        private string bakingTechnique;
        private int weight;
    }
}
