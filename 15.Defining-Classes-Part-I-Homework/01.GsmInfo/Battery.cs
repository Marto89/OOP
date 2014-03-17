using System;

public enum BatteryType { LiIon, NiMH, NiCd }
public class Battery
{
    private string model;
    private TimeSpan? hoursIdle;
    private TimeSpan? hoursTalk;
    private BatteryType? type;

    public Battery()
    {
        this.model = null;
        this.hoursIdle = null;
        this.hoursTalk = null;
        this.type = null;

    }
    public Battery(string model, TimeSpan? hoursIdle, TimeSpan? hoursTalk, BatteryType? type)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.type = type;
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public TimeSpan? HoursIdle
    {
        get { return hoursIdle; }
        set { hoursIdle = value; }
    }
    public TimeSpan? HoursTalk
    {
        get { return hoursTalk; }
        set { hoursTalk = value; }
    }
    public BatteryType? Type
    {
        get { return type; }
        set { type = value; }
    }
}
