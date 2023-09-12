namespace ElonsAdventure.DAL
{
    /// <summary>
    /// <c>Display</c> models the cars Display.
    /// </summary>
    public class Display
    {
        private int _batteryCapacity = 100;
        private int _distanceDriven = 0;

        #region Properties
        /// <summary>
        /// Holds the value of the current battery capacity.
        /// </summary>
        public int BatteryCapacity
        {
            get { return _batteryCapacity; }
            set { _batteryCapacity = value; }
        }

        /// <summary>
        /// The distance driven.
        /// </summary>
        public int DistanceDriven
        {
            get { return _distanceDriven; }
            set { _distanceDriven = value; }
        }
        #endregion

        /// <summary>
        /// overrides <c>"ToString"</c> to output it's variables.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Remaining Battery: {BatteryCapacity}, Distance Driven {DistanceDriven}";
        }

        public void Reset()
        {
            BatteryCapacity = 100;
            DistanceDriven = 0;
        }
    }
}