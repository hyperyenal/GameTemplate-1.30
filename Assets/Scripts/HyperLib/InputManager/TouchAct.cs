//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/HyperLib/InputManager/TouchAct.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TouchAct : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchAct()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchAct"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""eccab47f-ec38-4dee-90b2-c9735edb64ef"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""849ba76b-b21a-4337-b7b1-b8a869591dfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d2ca8247-0e40-4eda-8f7a-c1169c6c4080"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DoubleTap"",
                    ""type"": ""Button"",
                    ""id"": ""20b8b4a1-e9b9-469e-a1ba-466fea563c69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5df64dda-a4fe-4ab6-aac7-3f96ab3a78f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06fdcc14-9200-4df2-a6f8-22866d549cd6"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3b0b843-4003-4af0-a1f3-ae153c951a55"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3ab9f04-ed11-450b-99e0-73864a442716"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07c03f15-59ef-47de-8215-763aa4811cc0"",
                    ""path"": ""<Touchscreen>/primaryTouch/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GKeyboard"",
            ""id"": ""cc1b3fef-f4fa-4225-ac9d-fa61b38d96a9"",
            ""actions"": [
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""66e7449a-f58a-4c8a-932d-f0b8f6a5aca5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""d77d9714-fea2-43d9-b272-0c0948dd90e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""0dd19245-1c41-4963-868b-ea77a5caaa26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""aae3cfb1-89a7-419e-8014-18ba643a9ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""7990bc5d-667a-40c3-be63-2b94e714a113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""J"",
                    ""type"": ""Button"",
                    ""id"": ""03755c91-e0c4-4eea-8a67-9e26d6599d2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""K"",
                    ""type"": ""Button"",
                    ""id"": ""201e54b5-2a26-4a13-8e45-34bec4e8f7c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L"",
                    ""type"": ""Button"",
                    ""id"": ""f9bc25b3-e835-449e-87b4-41e0e71d8125"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9e7dbe15-78d1-422d-82df-b7df1fb936a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""004123e8-22e4-4d37-b3ee-4ab8984c8c87"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e63113b-ecea-44a9-ad8f-abcc45dcdb9b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""159b4f16-7175-4ece-afe7-6d923d4c090f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb0dd680-3e12-4fdb-ad83-ddb7ca17203c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd3194ff-87ba-42b9-aeb0-7fec29ffa4e8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec330a18-1f3f-4ee0-b43a-8785d031a15b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15aa0e52-ec5c-4670-9eac-df51b515ec1e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bc4899f-b037-4c35-ac50-40699cf825a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b84d57b6-82db-472d-b8ac-f7e66c91bdf3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d26989a7-a4dd-44a7-8d4c-3db17d2ef1fd"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""K"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e230622-592b-48e4-8f68-ad58ff25e754"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GMouse"",
            ""id"": ""c244a834-3286-4c1f-81c8-4c626c029ff8"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""1c0d3a41-bc14-4e72-9ea5-519e85521442"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""e6c843f2-78ee-4cac-a0f4-dfc401a1d813"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""10d48475-1d6d-441c-817d-da2bae1f32a7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c6cfc5e6-ff67-4f31-a77f-8526fa3c8adb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ae930b43-6294-4788-a08e-9d9ff3e365c2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fcbbf4c-1882-48b6-8d0b-09e4fab34358"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f577b47b-0a71-4f19-9dec-9877524e187c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b07d669-1947-4fcf-b498-e3a45f9527e1"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_Tap = m_Touch.FindAction("Tap", throwIfNotFound: true);
        m_Touch_Move = m_Touch.FindAction("Move", throwIfNotFound: true);
        m_Touch_DoubleTap = m_Touch.FindAction("DoubleTap", throwIfNotFound: true);
        m_Touch_Position = m_Touch.FindAction("Position", throwIfNotFound: true);
        // GKeyboard
        m_GKeyboard = asset.FindActionMap("GKeyboard", throwIfNotFound: true);
        m_GKeyboard_W = m_GKeyboard.FindAction("W", throwIfNotFound: true);
        m_GKeyboard_A = m_GKeyboard.FindAction("A", throwIfNotFound: true);
        m_GKeyboard_S = m_GKeyboard.FindAction("S", throwIfNotFound: true);
        m_GKeyboard_D = m_GKeyboard.FindAction("D", throwIfNotFound: true);
        m_GKeyboard_Space = m_GKeyboard.FindAction("Space", throwIfNotFound: true);
        m_GKeyboard_J = m_GKeyboard.FindAction("J", throwIfNotFound: true);
        m_GKeyboard_K = m_GKeyboard.FindAction("K", throwIfNotFound: true);
        m_GKeyboard_L = m_GKeyboard.FindAction("L", throwIfNotFound: true);
        // GMouse
        m_GMouse = asset.FindActionMap("GMouse", throwIfNotFound: true);
        m_GMouse_LeftClick = m_GMouse.FindAction("LeftClick", throwIfNotFound: true);
        m_GMouse_RightClick = m_GMouse.FindAction("RightClick", throwIfNotFound: true);
        m_GMouse_Move = m_GMouse.FindAction("Move", throwIfNotFound: true);
        m_GMouse_Position = m_GMouse.FindAction("Position", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_Tap;
    private readonly InputAction m_Touch_Move;
    private readonly InputAction m_Touch_DoubleTap;
    private readonly InputAction m_Touch_Position;
    public struct TouchActions
    {
        private @TouchAct m_Wrapper;
        public TouchActions(@TouchAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_Touch_Tap;
        public InputAction @Move => m_Wrapper.m_Touch_Move;
        public InputAction @DoubleTap => m_Wrapper.m_Touch_DoubleTap;
        public InputAction @Position => m_Wrapper.m_Touch_Position;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @Move.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnMove;
                @DoubleTap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @Position.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @DoubleTap.started += instance.OnDoubleTap;
                @DoubleTap.performed += instance.OnDoubleTap;
                @DoubleTap.canceled += instance.OnDoubleTap;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);

    // GKeyboard
    private readonly InputActionMap m_GKeyboard;
    private IGKeyboardActions m_GKeyboardActionsCallbackInterface;
    private readonly InputAction m_GKeyboard_W;
    private readonly InputAction m_GKeyboard_A;
    private readonly InputAction m_GKeyboard_S;
    private readonly InputAction m_GKeyboard_D;
    private readonly InputAction m_GKeyboard_Space;
    private readonly InputAction m_GKeyboard_J;
    private readonly InputAction m_GKeyboard_K;
    private readonly InputAction m_GKeyboard_L;
    public struct GKeyboardActions
    {
        private @TouchAct m_Wrapper;
        public GKeyboardActions(@TouchAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @W => m_Wrapper.m_GKeyboard_W;
        public InputAction @A => m_Wrapper.m_GKeyboard_A;
        public InputAction @S => m_Wrapper.m_GKeyboard_S;
        public InputAction @D => m_Wrapper.m_GKeyboard_D;
        public InputAction @Space => m_Wrapper.m_GKeyboard_Space;
        public InputAction @J => m_Wrapper.m_GKeyboard_J;
        public InputAction @K => m_Wrapper.m_GKeyboard_K;
        public InputAction @L => m_Wrapper.m_GKeyboard_L;
        public InputActionMap Get() { return m_Wrapper.m_GKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IGKeyboardActions instance)
        {
            if (m_Wrapper.m_GKeyboardActionsCallbackInterface != null)
            {
                @W.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnW;
                @A.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnA;
                @S.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnS;
                @D.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnD;
                @Space.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnSpace;
                @J.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnJ;
                @J.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnJ;
                @J.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnJ;
                @K.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnK;
                @K.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnK;
                @K.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnK;
                @L.started -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnL;
                @L.performed -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnL;
                @L.canceled -= m_Wrapper.m_GKeyboardActionsCallbackInterface.OnL;
            }
            m_Wrapper.m_GKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @J.started += instance.OnJ;
                @J.performed += instance.OnJ;
                @J.canceled += instance.OnJ;
                @K.started += instance.OnK;
                @K.performed += instance.OnK;
                @K.canceled += instance.OnK;
                @L.started += instance.OnL;
                @L.performed += instance.OnL;
                @L.canceled += instance.OnL;
            }
        }
    }
    public GKeyboardActions @GKeyboard => new GKeyboardActions(this);

    // GMouse
    private readonly InputActionMap m_GMouse;
    private IGMouseActions m_GMouseActionsCallbackInterface;
    private readonly InputAction m_GMouse_LeftClick;
    private readonly InputAction m_GMouse_RightClick;
    private readonly InputAction m_GMouse_Move;
    private readonly InputAction m_GMouse_Position;
    public struct GMouseActions
    {
        private @TouchAct m_Wrapper;
        public GMouseActions(@TouchAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_GMouse_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_GMouse_RightClick;
        public InputAction @Move => m_Wrapper.m_GMouse_Move;
        public InputAction @Position => m_Wrapper.m_GMouse_Position;
        public InputActionMap Get() { return m_Wrapper.m_GMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GMouseActions set) { return set.Get(); }
        public void SetCallbacks(IGMouseActions instance)
        {
            if (m_Wrapper.m_GMouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_GMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_GMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_GMouseActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_GMouseActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_GMouseActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_GMouseActionsCallbackInterface.OnRightClick;
                @Move.started -= m_Wrapper.m_GMouseActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GMouseActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GMouseActionsCallbackInterface.OnMove;
                @Position.started -= m_Wrapper.m_GMouseActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_GMouseActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_GMouseActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_GMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public GMouseActions @GMouse => new GMouseActions(this);
    public interface ITouchActions
    {
        void OnTap(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnDoubleTap(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
    public interface IGKeyboardActions
    {
        void OnW(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnJ(InputAction.CallbackContext context);
        void OnK(InputAction.CallbackContext context);
        void OnL(InputAction.CallbackContext context);
    }
    public interface IGMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
}
