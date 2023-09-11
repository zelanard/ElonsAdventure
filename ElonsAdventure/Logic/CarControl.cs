using ElonsAdventure.DAL;
using ElonsAdventure.View;

namespace ElonsAdventure.Logic
{
    /// <summary>
    /// <c>CarControl</c> controls the program.
    /// </summary>
    public class CarControl
    {
        private Car _car = new Car();
        private CarView _carGUI = new CarView();

        #region Properties
        /// <summary>
        /// The car.
        /// </summary>
        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }

        /// <summary>
        /// The Cars Graphical User Interface.
        /// </summary>
        public CarView CarGUI
        {
            get { return _carGUI; }
            set { _carGUI = value; }
        }
        #endregion

        /// <summary>
        /// Run the program
        /// </summary>
        public void Start()
        {
            while (true)
            {
                CarGUI.Reset();
                Car.CarColour = CarGUI.GetCarColour();
                CarGUI.CarToConsole("Welcome madam/sir. I am your AI driver for the day.", Car.CarColour);

                //drive the car until it's empty and the user refuse to charge it.
                while (true)
                {
                    //promt the user for a distance to drive.
                    CarGUI.CarToConsole("How far do you want to drive?", Car.CarColour);
                    int distnace = CarGUI.GetDistance();
                    for (int i = 0; i < distnace; i++)
                    {
                        if (Car.Battery.Capacity > 0)
                        {
                            Car.Drive();
                        }
                        else if (distnace > 0)
                        {
                            CarGUI.CarToConsole("You're out of Power and need to charge so that you can reach your destination! (Y/N)", Car.CarColour);
                            if (CarGUI.YesNo())
                            {
                                Car.Battery.Charge();
                                Car.Display.DistanceDriven = 0;
                            }
                            else
                            {
                                Car = new Car();
                                break; //if the user refuse to charge the car, we can drive no further so we leave.
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    //when the car is empty, prompt the user to paint and charge the car.
                    CarGUI.CarToConsole(Car.Display.ToString(), Car.CarColour);
                    if (Car.Battery.Capacity == 0)
                    {
                        CarGUI.CarToConsole("Do you want to paint your car? (Y/N)", Car.CarColour);
                        if (CarGUI.YesNo())
                        {
                            Car.CarColour = CarGUI.GetCarColour();
                        }

                        CarGUI.CarToConsole("Do you want to charge your car? (Y/N)", Car.CarColour);
                        if (CarGUI.YesNo())
                        {
                            Car.Battery.Charge();
                            Car.Display.DistanceDriven = 0;
                        }
                        else
                        {
                            Car = new Car();
                            break; //if the user refuse to charge the car, we can drive no further so we leave.
                        }
                    }
                }
            }
        }
    }
}
