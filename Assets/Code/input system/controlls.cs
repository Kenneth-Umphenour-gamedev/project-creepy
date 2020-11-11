// GENERATED AUTOMATICALLY FROM 'Assets/input system/controlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controlls"",
    ""maps"": [
        {
            ""name"": ""Overworld"",
            ""id"": ""897171b7-072f-49b6-98f2-0a509a0e52a5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4788a67a-6cfc-4a09-9fcc-bebfcaa003ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""intractson butttons"",
                    ""type"": ""Button"",
                    ""id"": ""8f55c52c-b18e-4536-815c-071ff5d7231a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""921345a3-85a8-49b2-b697-086396c36279"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f66f0b1-1a59-470d-9ae6-c0ef1a9fe0f8"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""734bee10-9c30-4b41-8b71-6cb1d3619176"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59a0b89f-f428-4275-98bd-d3e58417fa69"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27abb087-6b1f-4596-aedd-82ad47a24c23"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eac1ffb-7702-40bb-8f1c-059a2615ce4b"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25947b4e-ca04-45c8-9d73-225f5632a4d0"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ea95ae4-6e51-4092-82f9-27cf227eae5b"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06990eac-1156-4d15-8d4c-43344efed2e3"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""intractson butttons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b8bd88d-e36f-4a10-8cf3-50a259c4b38c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb7aad65-1bf8-4f1e-bb89-b6d8259216d5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f27adfa-1bfb-4c7a-84db-d9c93610e8e5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cf774d8-ff56-464f-8439-e633e0301cd8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75020d34-b228-4ae6-b0c0-c7ce4eab428a"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db2884f2-4fda-497e-ba87-1aa73f55b94f"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16020ec9-b51c-429a-9d0d-bdace0c574e7"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6fe8a1e-4e92-41fd-af9d-8142f1885bf7"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""duleshock 4 controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""922d9962-4f1c-4ee1-ac29-9e75d8bed9f5"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79ac9953-ce3e-4a6b-be61-b4e03ecc84e5"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a78b01c4-8716-400f-9f37-5a6886f7073a"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c246391e-5938-49ef-af01-6c25e51ce058"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""duleshock 4 controller"",
            ""bindingGroup"": ""duleshock 4 controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox One controller"",
            ""bindingGroup"": ""Xbox One controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyBoard and mouse"",
            ""bindingGroup"": ""KeyBoard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Overworld
        m_Overworld = asset.FindActionMap("Overworld", throwIfNotFound: true);
        m_Overworld_Movement = m_Overworld.FindAction("Movement", throwIfNotFound: true);
        m_Overworld_intractsonbutttons = m_Overworld.FindAction("intractson butttons", throwIfNotFound: true);
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

    // Overworld
    private readonly InputActionMap m_Overworld;
    private IOverworldActions m_OverworldActionsCallbackInterface;
    private readonly InputAction m_Overworld_Movement;
    private readonly InputAction m_Overworld_intractsonbutttons;
    public struct OverworldActions
    {
        private @Controlls m_Wrapper;
        public OverworldActions(@Controlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Overworld_Movement;
        public InputAction @intractsonbutttons => m_Wrapper.m_Overworld_intractsonbutttons;
        public InputActionMap Get() { return m_Wrapper.m_Overworld; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OverworldActions set) { return set.Get(); }
        public void SetCallbacks(IOverworldActions instance)
        {
            if (m_Wrapper.m_OverworldActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMovement;
                @intractsonbutttons.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnIntractsonbutttons;
                @intractsonbutttons.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnIntractsonbutttons;
                @intractsonbutttons.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnIntractsonbutttons;
            }
            m_Wrapper.m_OverworldActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @intractsonbutttons.started += instance.OnIntractsonbutttons;
                @intractsonbutttons.performed += instance.OnIntractsonbutttons;
                @intractsonbutttons.canceled += instance.OnIntractsonbutttons;
            }
        }
    }
    public OverworldActions @Overworld => new OverworldActions(this);
    private int m_duleshock4controllerSchemeIndex = -1;
    public InputControlScheme duleshock4controllerScheme
    {
        get
        {
            if (m_duleshock4controllerSchemeIndex == -1) m_duleshock4controllerSchemeIndex = asset.FindControlSchemeIndex("duleshock 4 controller");
            return asset.controlSchemes[m_duleshock4controllerSchemeIndex];
        }
    }
    private int m_XboxOnecontrollerSchemeIndex = -1;
    public InputControlScheme XboxOnecontrollerScheme
    {
        get
        {
            if (m_XboxOnecontrollerSchemeIndex == -1) m_XboxOnecontrollerSchemeIndex = asset.FindControlSchemeIndex("Xbox One controller");
            return asset.controlSchemes[m_XboxOnecontrollerSchemeIndex];
        }
    }
    private int m_KeyBoardandmouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandmouseScheme
    {
        get
        {
            if (m_KeyBoardandmouseSchemeIndex == -1) m_KeyBoardandmouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and mouse");
            return asset.controlSchemes[m_KeyBoardandmouseSchemeIndex];
        }
    }
    public interface IOverworldActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnIntractsonbutttons(InputAction.CallbackContext context);
    }
}
