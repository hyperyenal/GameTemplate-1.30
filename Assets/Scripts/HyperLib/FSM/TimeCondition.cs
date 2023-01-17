using System;
using System.Collections;
using System.Collections.Generic;


public class TimeCondition
{
    private DateTime start;
    private float timeLimit;
    private bool fullfilled = true;

    public TimeCondition(float timeLimit)
    {
        this.timeLimit = timeLimit;
    }

    public bool isFullFilled()
    {
        //Reset
        if (fullfilled)
        {
            start = DateTime.Now;
            fullfilled = false;
            return false;
        }

        // Fullfilled
        if ((DateTime.Now - start).TotalSeconds >= timeLimit)
        {
            fullfilled = true;
        }
        return fullfilled;
    }


}
