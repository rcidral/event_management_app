using System;
using System.Collections.Generic;
using Models;

public class Values
{

    public static void store(DateOnly date, double value, int sponsorId, int eventId)
    {
        if (String.IsNullOrEmpty(date))
        {
            throw new Exception("Date cannot be empty");
        }
        if (String.IsNullOrEmpty(value))
        {
            throw new Exception("Value cannot be empty");
        }
        if (String.IsNullOrEmpty(sponsorId))
        {
            throw new Exception("Sponsor cannot be empty");
        }
        if (String.IsNullOrEmpty(eventId))
        {
            throw new Exception("Event cannot be empty");
        }

        Models.Values.store(date, value, sponsorId, eventId);
    }


    public static update(int id, string date, string value, string sponsorId, string eventId)
    {
        if (id < 0 || id > Models.Values.Last().Id)
        {
            throw new Exception("Id not found");
        }
        DateOnly date = DateOnly.Parse(date);
        if (date == null)
        {
            throw new Exception("Date cannot be empty");
        }
        double value = Convert.ToDouble(value);
        if (value == null)
        {
            throw new Exception("Value cannot be empty");
        }
        int sponsorId = Convert.ToInt32(sponsorId);
        int eventId = Convert.ToInt32(eventId);
        if (sponsorId < 0 || sponsorId > Models.Sponsor.Last().Id)
        {
            throw new Exception("Sponsor id cannot be empty");
        }
        if (eventId < 0 || eventId > Models.Event.Last().Id)
        {
            throw new Exception("Event id cannot be empty");
        }


    }

    public static void delete(string StringId)
    {
        int id = Convert.ToInt32(StringId);
        try
        {
            Models.Values.delete(id);
        }
        catch (System.Exception e)
        {
            throw e;
        }   
    }


}
