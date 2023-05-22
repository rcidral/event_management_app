using System;
using System.Collections.Generic;
using Models;

public class Values
{

    public static store(DateOnly date, double value, int sponsorId, int eventId)
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

        return new Values(date, value, sponsorId, eventId);
    }


    public static update(int id, DateOnly date, double value, int sponsorId, int eventId)
    {
        Values values = Models.Values.show(id);
        if (!String.IsNullOrEmpty(values.date))
        {
            date = date;
        }
        if (!String.IsNullOrEmpty(values.value))
        {
            value = value;
        }
        if (!String.IsNullOrEmpty(values.sponsorId))
        {
            sponsorId = sponsorId;
        }
        if (!String.IsNullOrEmpty(values.eventId))
        {
            eventId = eventId;
        }
        return values;


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
