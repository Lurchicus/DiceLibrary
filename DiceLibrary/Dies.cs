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
}
