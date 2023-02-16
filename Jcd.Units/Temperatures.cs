namespace Jcd.Units;

public static class Temperatures
{
    public static Temperature Celcius = new ("Celcius", "°C",1,0);
    public static Temperature Kelvin = new ("Kelvin", "°K", Celcius,1,-273.15);
    public static Temperature Fahrenheit = new ("Fahrenheit", "°F",5.0/9.0,-32.0);
    public static Temperature Rankine = new ("Rankine", "°R",Celcius,5.0/9.0, -491.67);
    public static Temperature Delisle = new ("Delisle", "°De",Celcius,1.5,100.0);
    public static Temperature Newton = new ("Newton", "°N",Celcius,33.0/100.0);
    public static Temperature Réaumur = new ("Réaumur", "°Ré",Celcius,4.0/5.0);
    public static Temperature Rømer = new ("Rømer", "°Rø",Celcius,0.52500,-7.5);
}