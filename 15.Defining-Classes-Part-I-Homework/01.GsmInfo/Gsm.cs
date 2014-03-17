using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
public class Gsm
{
    private static readonly Gsm iPhone4S = new Gsm("IPhone4S", "Apple", 1300, "Martin",
                                                                            new Battery("Apple", new TimeSpan(48,0,0), new TimeSpan(12,0,0), BatteryType.LiIon),
                                                                            new Display(15, 256000));
    private const decimal pricePerMinute = 0.37m;
    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;
    private Battery battery = new Battery();
    private Display display = new Display();
    private List<Call> callHistory;
    public Gsm(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = null;
        this.owner = null;
        this.battery = null;
        this.display = null;
        this.callHistory = new List<Call>();
    }
    public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
        this.callHistory = new List<Call>();
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid manufacturer: " + value);
            this.manufacturer = value;
        }
    }
    public decimal? Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid price: " + value);
            }
            price = value;
        }
    }
    public string Owner
    {
        get { return owner; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name: " + value);
            }
            owner = value;
        }
    }
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }
    public static Gsm IPhone4S
    {
        get { return iPhone4S; }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(new string('-', 79));
        sb.Append("Gsm Specification: \n");
        sb.AppendLine(new string('-', 79));
        sb.AppendFormat("Model->{0}", this.model);
        sb.AppendLine();
        sb.AppendFormat("Manufacturer->{0}", this.manufacturer);
        sb.AppendLine();
        sb.AppendFormat("Price->{0:c}", this.price);
        sb.AppendLine();
        sb.AppendFormat("Owner->{0}", this.owner);
        sb.AppendLine();
        sb.AppendLine(new string('-', 79));
        sb.AppendLine("Battery Specification: ");
        sb.AppendLine(new string('-', 79));
        sb.AppendFormat("Battery Model->{0}", this.battery.Model);
        sb.AppendLine();
        sb.AppendFormat("Battery HoursIdle->{0}", this.battery.HoursIdle);
        sb.AppendLine();
        sb.AppendFormat("Battery HoursTalk->{0}", this.battery.HoursTalk);
        sb.AppendLine();
        sb.AppendFormat("Battery Type->{0}", this.battery.Type);
        sb.AppendLine();
        sb.AppendLine(new string('-', 79));
        sb.AppendLine("Display Specification: ");
        sb.AppendLine(new string('-', 79));
        sb.AppendFormat("Display Size->{0}", this.display.Size);
        sb.AppendLine();
        sb.AppendFormat("Dispay Number of colours->{0}\n", this.display.NumberOfColours);
        sb.AppendLine(new string('-', 79));
        return sb.ToString();
    }
    public void AddCall(Call testCall)
    {
        this.callHistory.Add(testCall);
    }
    public void DeleteCall(int position)
    {
        this.callHistory.RemoveAt(position - 1);
    }
    public void ShowCallHistory()
    {
        Console.WriteLine("Current call history:");
        int counter = 1;
        if (this.callHistory.Count > 0)
        {
            foreach (var item in this.callHistory)
            {
                Console.WriteLine("{1}.{0}", item.ToString(), counter);
                counter++;
            }
        }
        else
        {
            Console.WriteLine("Call history is empty!!!");
        }
    }
    public void ClearHistory()
    {
        this.callHistory.Clear();
    }
    public decimal PriceOfCalls()
    {
        decimal sum = 0;
        foreach (var item in callHistory)
        {
            sum += item.Duration;
        }
        return (pricePerMinute / 60) * sum;
    }
}
