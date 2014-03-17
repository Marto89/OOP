namespace FurnitureManufacturer
{
    using System;
    using System.Threading;
    using System.Globalization;

    using Engine;

    public class FurnitureProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            FurnitureManufacturerEngine.Instance.Start();
        }
    }
}
