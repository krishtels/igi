using System.Text.Json.Serialization;

namespace WEB_053501_Krishtafovich.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } 
        [JsonPropertyName("description")]
        public string Description { get; set; } 
        [JsonPropertyName("calories")]
        public int Calories { get; set; } 
        [JsonPropertyName("image")]
        public string Image { get; set; } 
    }
}
