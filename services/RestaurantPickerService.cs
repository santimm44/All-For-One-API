using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_API.model;

namespace All_For_One_API.services
{
    public class RestaurantPickerService
    {
        public List<RestaurantPickerModel> chineseRestaurants = 
        [
            new RestaurantPickerModel {Id = 1, RestaurantName = "Golden Dragon Palace"},
            new RestaurantPickerModel {Id = 2, RestaurantName = "Jade Lotus Kitchen"},
            new RestaurantPickerModel {Id = 3, RestaurantName = "Bamboo Garden Delight"},
            new RestaurantPickerModel {Id = 4, RestaurantName = "Dynasty Dumplings"},
            new RestaurantPickerModel {Id = 5, RestaurantName = "Szechuan Spice House"},
            new RestaurantPickerModel {Id = 6, RestaurantName = "Pearl of the Orient"},
            new RestaurantPickerModel {Id = 7, RestaurantName = "Dragonfly Dim Sum"},
            new RestaurantPickerModel {Id = 8, RestaurantName = "Mandarin Moon Cafe"},
            new RestaurantPickerModel {Id = 9, RestaurantName = "Red Latern Bistro"},
            new RestaurantPickerModel {Id = 10, RestaurantName = "Imperial Wok House"} 
        ];
        public List<RestaurantPickerModel> italianRestaurants = 
        [
            new RestaurantPickerModel {Id = 1, RestaurantName = "La Dolce Vita Bistro"},
            new RestaurantPickerModel {Id = 2, RestaurantName = "Mamma Mia's Kitchen"},
            new RestaurantPickerModel {Id = 3, RestaurantName = "Pasta e Basta"},
            new RestaurantPickerModel {Id = 4, RestaurantName = "Osteria del Sole"},
            new RestaurantPickerModel {Id = 5, RestaurantName = "Sapore di Napoli"},
            new RestaurantPickerModel {Id = 6, RestaurantName = "Vino & Vespa"},
            new RestaurantPickerModel {Id = 7, RestaurantName = "Trattoria Bella"},
            new RestaurantPickerModel {Id = 8, RestaurantName = "Papa Murphy"},
            new RestaurantPickerModel {Id = 9, RestaurantName = "Gusto di Roma"},
            new RestaurantPickerModel {Id = 10, RestaurantName = "Cucina Toscana"},
        ];
        public List<RestaurantPickerModel> mexicanRestaurants = 
        [
            new RestaurantPickerModel {Id = 1, RestaurantName = "Mi Tierra Mexicana"},
            new RestaurantPickerModel {Id = 2, RestaurantName = "Cantina del Sol"},
            new RestaurantPickerModel {Id = 3, RestaurantName = "Tierra y Fuego"},
            new RestaurantPickerModel {Id = 4, RestaurantName = "Casa de las Tacos"},
            new RestaurantPickerModel {Id = 5, RestaurantName = "La Frontera Grill"},
            new RestaurantPickerModel {Id = 6, RestaurantName = "Agave Azul Cantina"},
            new RestaurantPickerModel {Id = 7, RestaurantName = "Los Abuelos Cocina"},
            new RestaurantPickerModel {Id = 8, RestaurantName = "Pueblo y Paladar"},
            new RestaurantPickerModel {Id = 9, RestaurantName = "El Sabor Mexicano"},
            new RestaurantPickerModel {Id = 10, RestaurantName = "Taqueria El Corazon"},
        ];
        public string RestaurantPickerMethod(string? userInput)
        {
            Random rng = new Random();
            int randomNumber;

                userInput = userInput.ToLower();   

                //Validate user input
                if ((userInput != "a") && (userInput != "b") && (userInput != "c") && (userInput != "mexican") && (userInput != "chinese") && (userInput != "italian"))
                {
                    return "Invalid user input. Please try again." +"\nA. Mexican\nB. Chinese\nC. Italian";
                }

                //Generate random number to pass as index pointer
                randomNumber = rng.Next(10);

                if (userInput == "a" || userInput == "mexican") 
                    {
                        
                        return $"Here is a great Mexican restaurant \"{mexicanRestaurants[randomNumber].RestaurantName}\" you should try.";
                    }
                else if (userInput == "b" || userInput == "chinese") 
                    {
                        return $"Here is a great Chinese restaurant \"{chineseRestaurants[randomNumber].RestaurantName}\" you should try.";
                    }
                else if (userInput == "c" || userInput == "italian") 
                    {
                        return $"Here is a great Italian restaurant \"{italianRestaurants[randomNumber].RestaurantName}\" you should try.";
                    }
                else return "You somehow got out of the options... HOW?!?!?!";           
        }
    }
}