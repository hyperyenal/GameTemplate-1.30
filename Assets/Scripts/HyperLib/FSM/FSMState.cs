using System;
using System.Collections;
using System.Collections.Generic;


public class FSMState
{
    public List<FSMTransition> transitions = new List<FSMTransition>();
    public Action entryAction;
    public Action updateAction;
    public Action exitAction;

    string stateName { set; get; }

    public FSMState(Action entryAction, Action updateAction, Action exitAction)
    {
        this.entryAction = entryAction;
        this.updateAction = updateAction;
        this.exitAction = exitAction;
    }

    public void When(Func<bool> condition, FSMState targetState, Action action)
    {
        FSMTransition t = new FSMTransition(condition, targetState, action);
        transitions.Add(t);
    }

}
