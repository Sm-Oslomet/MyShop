using System; // Includes System namepsace, provides basic lasses and base classes that define commonly used values and reference data types,
            // events and event handlers, interfaces atrtibutes and processing exceptions.
namespace MyShop.Models // Defines namespace called myshop models
                        // Namespaces are used to organize code intoa hierarchical strucutre. This namespace suggests
                        // that the code bleongs to a models folder or a component within myshop app
{

    public class Item // declares a public class named item
                      // public keyword makes this class accessible form other clzsses and compnents
                     // class is a blueprint for objects taht contains fields, properties, methods and other members
    {

        public int ItemId { get; set; } //memeber values must begin with upper case ti follow C#
                                        // declares a property named ItemId of type int
                                        // public makes it accessible from outside the class
                                        // { get; set; } defines an auto implemented property with a public getter
                                        // and setter, allowing the value ot be read and written

        public string Name { get; set; }  // String and class must be declared with default 
                                                         // values string. Empty or default! for class
                                                         // string.Empty initializes the Name property with an 
                                                         // empty string by default. This ensures that Name
                                                        // is never null, preventing null ref issues.
        public decimal Price { get; set; } // decimal data type used for financial and monetary calcs. more precise
        public string? Description { get; set; } // question mark required to state it is nullable
        public string? ImageUrl { get; set; } 

    }
}