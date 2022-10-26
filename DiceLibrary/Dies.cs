namespace DiceLibrary
{
    /// <summary>
    /// Describes the contents of a die object
    /// </summary>
    public class Dies
    {
        /// <summary>Die ID number</summary>
        public int Id { get; set; }
        /// <summary>Number of dies (1 ti 1000</summary>
        public int Qty { get; set; }
        /// <summary>Number of sides (0 to 1000)</summary>
        public int Sides { get; set; }
        /// <summary>Adjustment to be made to the end total</summary>
        public int Adjustment { get; set; }
        /// <summary>Individual roll result</summary>
        public int Result { get; set; }
        /// <summary>End total (running total)</summary>
        public int Total { get; set; }
    }

    /// <summary>
    /// Define the maximum sides and dies for the library. This is an
    /// arbitrary and conservitive value to keep memory usage to a 
    /// reasonable level and to keep us from overflowing an int.
    /// Reference in code as Max.MAX_DIES
    /// </summary>
    public class Max
    {
        /// <summary>
        /// Defines the maximuim number of dies allowed
        /// </summary>
        public const int MAX_DIES = 1000;
        /// <summary>
        /// Defines the maximum number of sides a die can have
        /// </summary>
        public const int MAX_SIDES = 1000;
    }
}
