// GENERATED AUTOMATICALLY FROM 'Assets/scripts/controladorPlayer.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControladorPlayer : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControladorPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controladorPlayer"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""2e82772a-20d7-4e79-9009-75362cfed800"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""e65e9774-f483-4815-9a01-2a7498614e84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""adws"",
                    ""id"": ""f3325f35-3337-43af-9364-d0dc2308ba19"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""25959f97-c4be-4685-8d35-1a5235b1faa6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""57a20f82-0151-4761-ace4-5584761c6011"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Flechitas"",
                    ""id"": ""44a801e0-eac8-4b11-90ba-7162ebdab269"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd7ac35c-937f-41b4-8f27-4f1da2c3c1f8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8412f0e-d89c-48f7-bfd7-704a43e0b741"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamePad flechas"",
                    ""id"": ""1df1e2c9-63f5-4c35-9460-be7138c3a250"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e1b2d469-f735-431a-ab9b-05a0a9ba0449"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""624075bd-925e-4be7-9099-1d5a6c3d0691"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamePad joystick"",
                    ""id"": ""51315023-9e82-4984-9d52-0aaa9255dcf8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""01c68f29-4cf2-45af-a1b5-c9da4a895471"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a6f69c38-00be-4db9-9001-b701a9d6653f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_move = m_Normal.FindAction("move", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_move;
    public struct NormalActions
    {
        private @ControladorPlayer m_Wrapper;
        public NormalActions(@ControladorPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Normal_move;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface INormalActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
