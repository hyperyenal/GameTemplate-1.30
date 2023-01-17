using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class InputTestScript : MonoBehaviour
{
    private InputManager inputManager;
    private bool mouseDown = false;
    private float speed = 5;
    private int totalPoints = 0;
    #region GamePatterns
    private GlobalGameParams globalGameParams;
    private UIBroker uiBroker;
    #endregion
    void Awake()
    {
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);

        inputManager = InputManager.Instance;
        Assert.IsNotNull(inputManager);
        GameObject.Find("ClickedObj").SetActive(true);
    }
    void Start()
    {

    }
    private void OnEnable()
    {
        inputManager.OnStartTap += OnStartTap;
        inputManager.OnPerformedTap += SelectObject;
        inputManager.OnEndTap += OnEndTap;
        inputManager.OnPerformedDoubleTap += OnPerformedDoubleTap;

        inputManager.OnKeyUp += OnKeyUp;
        inputManager.OnKeyLeft += OnKeyLeft;
        inputManager.OnKeyDown += OnKeyDown;
        inputManager.OnKeyRight += OnKeyRight;
        inputManager.OnKeySpace += OnKeySpace;
        inputManager.OnKeyJ += OnKeyJ;
        inputManager.OnKeyK += OnKeyK;
        inputManager.OnKeyL += OnKeyL;

        inputManager.OnLeftClick += OnLeftClick;
        inputManager.OnrightClick += OnrightClick;

    }

    private void OnDisable()
    {
        inputManager.OnStartTap -= OnStartTap;
        inputManager.OnPerformedTap -= SelectObject;
        inputManager.OnEndTap -= OnEndTap;
        inputManager.OnPerformedDoubleTap -= OnPerformedDoubleTap;

        inputManager.OnKeyUp -= OnKeyUp;
        inputManager.OnKeyLeft -= OnKeyLeft;
        inputManager.OnKeyDown -= OnKeyDown;
        inputManager.OnKeyRight -= OnKeyRight;
        inputManager.OnKeySpace -= OnKeySpace;
        inputManager.OnKeyJ -= OnKeyJ;
        inputManager.OnKeyK -= OnKeyK;
        inputManager.OnKeyL -= OnKeyL;

        inputManager.OnLeftClick -= OnLeftClick;
        inputManager.OnrightClick -= OnrightClick;
    }

    private void OnStartTap()
    {
        Debug.Log ("Action: StartTap");
        mouseDown = true;
        uiBroker.SetTotalPoints(totalPoints++);
    }

    private void SelectObject()
    {
        Debug.Log ("Action: PerformedTap");
        RaycastHit hit;
        Vector2 pos = inputManager.GetTouchPosition();
        if (Physics.Raycast(Camera.main.ScreenPointToRay(pos), out hit))
        {
            hit.collider.GetComponent<IClickable>()?.OnClick();
        }
    }
    private void OnEndTap()
    {
        Debug.Log ("Action: EndTap");
        mouseDown = false;
    }

    private void OnPerformedDoubleTap()
    {
        Debug.Log("Action : PerformedDoubleTap");
    }

    private void OnKeyUp() {
        Debug.Log ("Action: KeyUp");
    }
    private void OnKeyLeft() {
        Debug.Log ("Action: KeyLeft");
    }
    private void OnKeyDown() {
        Debug.Log ("Action: KeyDown");
    }
    private void OnKeyRight() {
        Debug.Log ("Action: KeyRight");
    }
    private void OnKeySpace() {
        Debug.Log ("Action: KeySpace");
    }
    private void OnKeyJ() {
        Debug.Log ("Action: KeyJ");
    }
    private void OnKeyK() {
        Debug.Log ("Action: KeyK");
    }
    private void OnKeyL() {
        Debug.Log ("Action: KeyL");
    }
    // Mouse Click
    private void OnLeftClick() {
        Debug.Log ("Action: KeyLeftClick");
    }
    private void OnrightClick() {
        Debug.Log ("Action: OnrightClick");
    }
    void Update()
    {
        if (!mouseDown) return;
        Vector2 move2D = inputManager.GetTouchDelta() * speed * Time.deltaTime;
        Vector3 move = new Vector3(move2D.x, 0, move2D.y);
        Transform t = GameObject.Find("ClickedObj").transform;
        Assert.IsNotNull(t);
        t.Translate(move, Space.World);
    }
}
