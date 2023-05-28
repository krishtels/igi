using System.Text.Json.Serialization;

namespace WEB_053501_Krishtafovich.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } 
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } 
    }

}
