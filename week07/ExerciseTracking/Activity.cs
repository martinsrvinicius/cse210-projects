using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date; 
    private int _minutes;  

   
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    
    protected DateTime Date => _date;
    protected int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        string activityType = GetType().Name;
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);
        return $"{dateStr} {activityType} ({_minutes} min)- Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}