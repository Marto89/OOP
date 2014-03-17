using System;

public class Display
{
    private decimal? size;
    private int? numberOfColours;

    public Display()
    {
        this.size = null;
        this.numberOfColours = null;
    }
    public Display(decimal? size, int? numberOfColours)
    {
        this.size = size;
        this.numberOfColours = numberOfColours;
    }
    public decimal? Size
    {
        get { return size; }
        set { size = value; }
    }
    public int? NumberOfColours
    {
        get { return numberOfColours; }
        set { numberOfColours = value; }
    }

}
