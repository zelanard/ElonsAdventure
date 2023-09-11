namespace ElonsAdventure.DAL
{
    /// <summary>
    /// <c>Battery</c> models the cars battery.
    /// </summary>
    public class Battery
    {
        private byte _capacity = 100;

        public byte Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public void DisCharge()
        {
            Capacity -= 1;
        }
        public void Charge()
        {
            Capacity = 100;
        }
    }
}
