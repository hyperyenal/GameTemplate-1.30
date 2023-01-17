using System;
using System.Collections;
using System.Collections.Generic;


public class FSM
{
    private List<FSMState> states = new List<FSMState>();
    private FSMState initialState;
    private FSMState currentState;

    // Logic
    private FSMTransition triggeredTansition;
    private Queue<Action> actions = new Queue<Action>();

    public FSM(FSMState initialState)
    {
        this.initialState = initialState;
        currentState = initialState;
        AddAction(initialState.entryAction);
    }

    public void AddState(FSMState s)
    {
        states.Add(s);
    }

    public void AddStates(params FSMState[] statesArray)
    {
        foreach (FSMState s in statesArray)
        {
            states.Add(s);
        }
    }

    public Queue<Action> Tick()
    {
        triggeredTansition = null;

        foreach (FSMTransition transition in currentState.transitions)
        {
            if (transition.IsTriggered())
            {
                triggeredTansition = transition;
                break;
            }

        }

        if (triggeredTansition != null)
        {
            FSMState targetState = triggeredTansition.targetState;
            AddAction(currentState.exitAction);
            AddAction(triggeredTansition.action);
            AddAction(targetState.entryAction);

            currentState = targetState;
        }
        else
        {
            AddAction(currentState.updateAction);
        }

        return actions;
    }

    private void AddAction(Action a)
    {
        if (a != null)
        {
            this.actions.Enqueue(a);
        }
    }

    public void ExecuteActions(Queue<Action> actions)
    {
        if (actions == null)
            return;

        Action a;
        while (actions.Count > 0)
        {
            a = actions.Dequeue();
            a();
        }
    }

}
