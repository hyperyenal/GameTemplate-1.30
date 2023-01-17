using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class FsmTest : MonoBehaviour
{
    #region GamePatterns
    private GlobalGameParams globalGameParams;
    private UIBroker uiBroker;
    #endregion

    private bool walkOrNot = false; // Space
    private bool runOrNot = false; // W

    FSM fsm;

    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);
    }
    void Start()
    {
        FSMState idle = new FSMState(null, null, null);
        //FSMState walk = new FSMState(WalkEntryAction, WalkUpdateAction, WalkExitAction);
        FSMState walk = new FSMState(WalkEntryAction, null, WalkExitAction);
        //FSMState run = new FSMState(RunEntryAction, RunUpdateAction, RunExitAction);
        FSMState run = new FSMState(RunEntryAction, null, RunExitAction);

        idle.When(() => walkOrNot, walk, IdleToWalkAction);
        //idle.When(new TimeCondition(3f).isFullFilled, walk, IdleToWalkAction);
        walk.When(() => runOrNot, run, WalkToRunAction);
        walk.When(() => !walkOrNot, idle, WalkToIdleAction);
        run.When(() => !runOrNot, walk, RunToWalkAction);

        fsm = new FSM(idle);
        fsm.AddStates(idle, walk, run);

        GameMaster.Instance.DebugGameName(typeof(FsmTest).FullName);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            walkOrNot = !walkOrNot;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            runOrNot = !runOrNot;
        }

        fsm.ExecuteActions(fsm.Tick());
        */
    }

    public void WalkEntryAction()
    {
        Debug.Log("Walk Entry Action");
    }

    public void WalkUpdateAction()
    {
        Debug.Log("Walk Update Action");
    }

    public void WalkExitAction()
    {
        Debug.Log("Walk Exit Action");
    }

    public void RunEntryAction()
    {
        Debug.Log("Run Entry Action");
    }

    public void RunUpdateAction()
    {
        Debug.Log("Run Update Action");
    }

    public void RunExitAction()
    {
        Debug.Log("Run Exit Action");
    }

    public void IdleToWalkAction()
    {
        Debug.Log("I am going from Idle to Walk");
    }

    public void WalkToRunAction()
    {
        Debug.Log("I am going from Walk to Run");
    }

    public void WalkToIdleAction()
    {
        Debug.Log("I am going from Walk to Idle");
    }

    public void RunToWalkAction()
    {
        Debug.Log("I am going from Run to Walk");
    }
}

