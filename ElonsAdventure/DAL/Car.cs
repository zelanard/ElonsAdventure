using System;

namespace ElonsAdventure.DAL
{
    /// <summary>
    /// <c>Car</c> models a car.
    /// </summary>
    public class Car
    {
        ConsoleColor _carColour = ConsoleColor.White;
        private Display _display = new Display();
        private Battery _battery = new Battery();

        const short RANGE = 20;

        #region Properties
        /// <summary>
        /// The cards colour.
        /// </summary>
        public ConsoleColor CarColour
        {
            get { return _carColour; }
            set { _carColour = value; }
        }

        /// <summary>
        /// The display of the car.
        /// </summary>
        public Display Display
        {
            get
            {
                _display.BatteryCapacity = Battery.Capacity;
                return _display;
            }
            set { _display = value; }
        }

        /// <summary>
        /// The battery of this car.
        /// </summary>
        public Battery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }
        #endregion

        /// <summary>
        /// Adjust the cars battery and distance driven.
        /// </summary>
        public void Drive()
        {
            Battery.DisCharge();
            Display.DistanceDriven += RANGE;
        }
    }
}
