using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;
using P03_Wild_Farm.Children;
using P03_Wild_Farm.Children.Felines;
using P03_Wild_Farm.Children.Mammals;

namespace P03_Wild_Farm.Factories
{
    public static class AnimalFactory
    {
        public static Animal Create(string[] input)
        {
            var animalType = input[0];
            var animalName = input[1];
            double animalWeight = double.Parse(input[2]);
            switch (animalType)
            {
                case "Hen":

                    double henWingSize = double.Parse(input[3]);
                    return new Hen(animalName, animalWeight, 0, henWingSize);
                case "Owl":
                    double owlWingSize = double.Parse(input[3]);
                    return new Owl(animalName, animalWeight, 0, owlWingSize);
                case "Mouse":
                    string MouseLivingRegion = input[3];
                    return new Mouse(animalName, animalWeight, 0, MouseLivingRegion);
                case "Cat":
                    string catLivingRegion = input[3];
                    string catBreed = input[4];
                    return new Cat(animalName, animalWeight, 0, catLivingRegion, catBreed);
                case "Dog":
                    string dogLivingRegion = input[3];
                    return new Dog(animalName, animalWeight, 0, dogLivingRegion);
                case "Tiger":
                    string tigerLivbingRegion = input[3];
                    string tigerBreed = input[4];
                    return new Tiger(animalName, animalWeight, 0, tigerLivbingRegion, tigerBreed);
            }
            return null;
        }
    }
}
