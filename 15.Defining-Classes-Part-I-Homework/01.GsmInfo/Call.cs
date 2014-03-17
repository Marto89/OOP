using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Call
{
    private DateTime timeOfCall;
    private string dialedNumber;
    private int duration;

    public Call(string dialedNumber, int duration)
    {
        this.timeOfCall = DateTime.Now;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }

    public DateTime TimeOfCall
    {
        get { return this.timeOfCall; }
        set { this.timeOfCall = value; }
    }
    public string DialedNumber
    {
        get { return this.dialedNumber; }
        set { this.dialedNumber = value; }
    }
    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }
    public override string ToString()
    {
        StringBuilder stringCreator = new StringBuilder();
        stringCreator.AppendFormat("{0} : Duaration - {1} , made on {2}", this.dialedNumber, this.duration, this.timeOfCall);
        stringCreator.AppendLine();
        return stringCreator.ToString();
    }
}