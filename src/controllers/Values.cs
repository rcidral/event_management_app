using System;
using System.Collections.Generic;
using Models;

public class Values
{

    public static store(DateOnly date, double value, int sponsorId, int eventId)
    {
        if (String.IsNullOrEmpty(date))
        {
            throw new Exception("Data não pode ser vazio");
        }
        if (String.IsNullOrEmpty(value))
        {
            throw new Exception("Valor não pode ser vazio");
        }
        if (String.IsNullOrEmpty(sponsorId))
        {
            throw new Exception("Patrocinador não pode ser vazio");
        }
        if (String.IsNullOrEmpty(eventId))
        {
            throw new Exception("Evento não pode ser vazio");
        }

        return new Values(date, value, sponsorId, eventId);
    }

    public List<Models.Values> index()
    {
        try
        {
            return Models.Values.index();
        }
        catch (System.Exception e)
        {
            throw e;
        }
    }

    public static Values show(int id)
    {
        Values values = (
              from Values in Values.index()
              where Values.id == id
              select Values
        ).First();

        if (values == null)
        {
            throw new Exception("Valor não encontrado");
        }

        return values;
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

    public static delete(int id)
    {
        Values values = Models.Values.show(id);
        Models.Values.delete(values);

        return values;
    }


}
