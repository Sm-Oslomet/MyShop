using System; // Includes System namepsace, provides basic lasses and base classes that define commonly used values and reference data types,
            // events and event handlers, interfaces atrtibutes and processing exceptions.
namespace MyShop.Models
{

    public class Item
    {

        public int ItemId { get; set; } //memeber values must begin with upper case ti follow C#
        public string Name { get; set; } = string.Empty; // String and class must be declared with default values string.Empty or default! for class
        public decimal Price { get; set; }
        public string? Description { get; set; } // question mark required to state it is nullable
        public string? ImageUrl { get; set; } 

    }
}