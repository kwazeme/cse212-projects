public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary

    //create custom classes to map json data appropriately
    // The "features" key in JSON is an array of objects
    
    public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        // Each feature has a "properties" dictionary/object
    public Properties Properties { get; set; }
    }

    public class Properties
    {
        // We only need 'mag' and 'place' from the properties
        public double? Mag { get; set; } // magnitude is nullable. the data occasionally has null values in mag
        public string Place { get; set; }
    }
