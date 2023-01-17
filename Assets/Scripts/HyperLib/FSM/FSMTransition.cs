using System;
using System.Collections;
using System.Collections.Generic;


public class FSMTransition
{
    private Func<bool> condition;
    public FSMState targetState;
    public Action action;

    public FSMTransition(Func<bool> condition, FSMState targetState, Action action)
    {
        this.condition = condition;
        this.targetState = targetState;
        this.action = action;
    }

    public bool IsTriggered()
    {
        if (condition == null)
        {
            return true;
        }

        return condition();

    }


}
