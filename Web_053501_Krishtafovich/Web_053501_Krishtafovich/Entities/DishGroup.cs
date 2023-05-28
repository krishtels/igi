namespace Web_053501_Krishtafovich.Entities
{
    public class DishGroup
    {
        public int DishGroupId { get; set; }
        public string GroupName { get; set; }
        
        /// Навигационное свойство 1-ко-многим
        public List<Dish> Dishes { get; set; }
    }

}
