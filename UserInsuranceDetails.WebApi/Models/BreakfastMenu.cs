using System.Xml.Serialization;

namespace UserInsuranceDetails.WebApi.Models
{
    [XmlRoot("breakfast_menu")]
    public class BreakfastMenu
    {
        [XmlElement("food")]
        public List<Food> Foods { get; set; }
    }

    public class Food
    {
        [XmlElement("name")]
        public string FoodName { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("calories")]
        public string Calories { get; set; }
    }
}
