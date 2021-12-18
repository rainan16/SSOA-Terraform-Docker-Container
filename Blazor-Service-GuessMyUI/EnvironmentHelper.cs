using System;

public abstract class EnvironmentHelper 
{
    public static bool IsDevelopment;

    public static string GetNationServiceIP() 
    {
        if (IsDevelopment) {
            return "localhost";
        } else
        {
            return Environment.GetEnvironmentVariable("NATIONSERVICEIP");
        }
    }

    public static int GetNationServicePort() 
    {
        if (IsDevelopment) {
            return 3001;
        } else
        {        
            return int.Parse(Environment.GetEnvironmentVariable("NATIONSERVICEPORT"));
        }
    }    

    public static string GetGenderServiceIP() 
    {
        if (IsDevelopment) {
            return "localhost";
        } else
        {        
            return Environment.GetEnvironmentVariable("GENDERSERVICEIP");
        }
    }

    public static int GetGenderServicePort() 
    {
        if (IsDevelopment) {
            return 3002;
        } else
        {           
            return int.Parse(Environment.GetEnvironmentVariable("GENDERSERVICEPORT"));
        }
    }       
}