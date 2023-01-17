using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class InputManager : GenericSingletonClass<InputManager>
{
    #region TouchEvents
    // Tap
    public delegate void StartTap();
    public event StartTap OnStartTap;
    public delegate void EndTap();
    public event EndTap OnEndTap;
    public delegate void PerformedTap();
    public event PerformedTap OnPerformedTap;
    // DoubleTap
    public delegate void PerformedDoubleTap();
    public event PerformedDoubleTap OnPerformedDoubleTap;
    #endregion

    #region GKeyboardEvents
    public delegate void KeyUp();
    public event KeyUp OnKeyUp;
    public delegate void KeyLeft();
    public event KeyLeft OnKeyLeft;
    public delegate void KeyDown();
    public event KeyDown OnKeyDown;
    public delegate void KeyRight();
    public event KeyRight OnKeyRight;

    public delegate void KeySpace();
    public event KeySpace OnKeySpace;
    public delegate void KeyJ();
    public event KeyJ OnKeyJ;
    public delegate void KeyK();
    public event KeyK OnKeyK;
    public delegate void KeyL();
    public event KeyL OnKeyL;
    #endregion

    #region GMouseEvents
    public delegate void LeftClick();
    public event LeftClick OnLeftClick;
    public delegate void rightClick();
    public event rightClick OnrightClick;
    #endregion

    private TouchAct touchControls;

    public override void Awake()
    {
        base.Awake();
        touchControls = new TouchAct();
    }

    private void OnEnable()
    {
        touchControls.Touch.Enable();
        touchControls.GKeyboard.Enable();
        touchControls.GMouse.Enable();
    }

    private void OnDisable()
    {
        touchControls.Touch.Disable();
        touchControls.GKeyboard.Disable();
        touchControls.GMouse.Disable();
    }
    
    void Start()
    {
        // Tap
        touchControls.Touch.Tap.started += _ => { if (OnStartTap != null) OnStartTap(); };
        touchControls.Touch.Tap.canceled += _ => { if (OnEndTap != null) OnEndTap(); };
        touchControls.Touch.Tap.performed += ctx => { if (OnPerformedTap != null) OnPerformedTap(); };
        touchControls.Touch.DoubleTap.performed += _ => { if (OnPerformedDoubleTap != null) OnPerformedDoubleTap(); };
        // Gkeyboard
        touchControls.GKeyboard.W.performed += ctx => { if (OnKeyUp != null) OnKeyUp(); };
        touchControls.GKeyboard.A.performed += ctx => { if (OnKeyLeft != null) OnKeyLeft(); };
        touchControls.GKeyboard.S.performed += ctx => { if (OnKeyDown != null) OnKeyDown(); };
        touchControls.GKeyboard.D.performed += ctx => { if (OnKeyRight != null) OnKeyRight(); };
        touchControls.GKeyboard.Space.performed += ctx => { if (OnKeySpace != null) OnKeySpace(); };
        touchControls.GKeyboard.J.performed += ctx => { if (OnKeyJ != null) OnKeyJ(); };
        touchControls.GKeyboard.K.performed += ctx => { if (OnKeyK != null) OnKeyK(); };
        touchControls.GKeyboard.L.performed += ctx => { if (OnKeyL != null) OnKeyL(); };
        // GMouse
        touchControls.GMouse.LeftClick.performed += ctx => { if (OnLeftClick != null) OnLeftClick(); };
        touchControls.GMouse.RightClick.performed += ctx => { if (OnrightClick != null) OnrightClick(); };
        
        //Cursor.lockstate = CursorLockMode.Confined;
    }

    public Vector2 GetTouchDelta()
    {
        return touchControls.Touch.Move.ReadValue<Vector2>();
    }
    public Vector2 GetTouchPosition()
    {
        return touchControls.Touch.Position.ReadValue<Vector2>();
    }
    public Vector2 GetMouseDelta()
    {
        return touchControls.GMouse.Move.ReadValue<Vector2>();
    }
    public Vector2 GetMousePosition()
    {
        return touchControls.GMouse.Position.ReadValue<Vector2>();
    }
}
