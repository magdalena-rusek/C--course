using System;

interface IWeatherAlert
{
    string CurrentDate { get; set; }
    void Alert();
}

class NoAlert : IWeatherAlert
{
    public string CurrentDate { get; set; }
    public void Alert() 
    {
        Console.WriteLine("Today expexted: - ");

    }
}

class RainAlert : IWeatherAlert
{
    public string CurrentDate { get; set; }
    public void Alert()
    {
        Console.WriteLine("Today expexted: rain");
    }
}

class FogAlert : IWeatherAlert
{
    public string CurrentDate { get; set; }
    public void Alert()
    {
        Console.WriteLine("Today expexted: fog");
    }
}

class SnowAlert : IWeatherAlert
{
    public string CurrentDate { get; set; }
    public void Alert()
    {
        Console.WriteLine("Today expexted: snow");
    }
}

class WindAlert : IWeatherAlert
{
    public string CurrentDate { get; set; }
    public void Alert()
    {
        Console.WriteLine("Today expexted: wind");
    }
}

abstract class Decorator : IWeatherAlert
{
    public string CurrentDate { get; set; }

    protected IWeatherAlert weathAlert;

    public Decorator(IWeatherAlert w)
    {
        weathAlert = w;
    }

    public virtual void Alert()
    {
        weathAlert.Alert();
    }
}

class WindDecorator : Decorator
{

    public WindDecorator(IWeatherAlert weathAlert) : base(weathAlert) { }
    
    public override void Alert()
    {
        base.Alert();
        Console.WriteLine("and wind");
    }
}

class FogDecorator : Decorator
{

    public FogDecorator(IWeatherAlert weathAlert) : base(weathAlert) { }

    public override void Alert()
    {
        base.Alert();
        Console.WriteLine("and fog");
    }
}

class SnowDecorator : Decorator
{

    public SnowDecorator(IWeatherAlert weathAlert) : base(weathAlert) { }

    public override void Alert()
    {
        base.Alert();
        Console.WriteLine("and snow");
    }
}