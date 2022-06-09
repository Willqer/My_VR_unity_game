// GENERATED AUTOMATICALLY FROM 'Assets/MyAssets/MyScripts/Control/ControlsMapping/ControlsMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlsMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlsMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlsMap"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""dae1c825-327f-4ae7-8eeb-ba66774c3f76"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b90e25f-c2d8-4d6a-821b-a97f2819eff8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pads"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5b017e69-4e1c-48fd-a49d-dc12b6cb06b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""86c9e9a7-90bf-4a96-aeed-ab989d51a51f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9726ab95-69f3-46bf-b6cf-8da07e9c8005"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""431f9cfc-88cf-42ad-b335-39cefde6c8ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3be033e4-097c-486e-8ca3-76beb07c7cd7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d3175b5f-fb0d-42fe-9961-fbec3aef4030"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e93c65e3-601b-478a-b3da-583cad7f31e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""60ae4e5f-4858-4f2a-b5a5-6bc9bb18f592"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a62038e6-e190-4f8a-bfde-b1822d4ae31a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a746079-3ab1-4e93-a45a-ccd8080b22a6"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0ed5c21c-554b-4154-bad2-919aec52a523"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc933db-7bfa-4ea7-9011-f077db6ac9ae"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pads"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Object"",
            ""id"": ""878b7b7a-6403-481c-9917-c31f824d87e8"",
            ""actions"": [
                {
                    ""name"": ""Cross"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e11c156d-a4ca-4aec-bda2-30fb0a484ca1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f985b1b9-5374-4ac2-90e6-9b6de9b4aa9c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""NumpadArrows"",
                    ""id"": ""fd6e30f3-294c-4afb-a3fb-fa73826f318a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""230e575c-c5d4-4e58-8cf7-d72bacab2595"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""54067cae-6e0c-4d12-8a1e-233418c812b4"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4305f7cc-a680-41d1-ab6d-f1bcc07e93f6"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9518b340-1423-4892-8433-e64343a769d0"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6303a700-83de-4925-abf7-1561f4f14701"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PhysicalCamera"",
            ""id"": ""8c92a43b-7928-4404-86db-e93ce4738a83"",
            ""actions"": [
                {
                    ""name"": ""Screenshot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b08bc4d-d7d3-4f97-a3b3-36561d4c4339"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4a8c60a-3b05-4392-8015-59c3bc3a1006"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Screenshot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""a7832e1b-95d6-42f4-b0f3-4459c64425fa"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""3abddd27-962d-49d2-8623-b79cb5278f80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b527c4e-0d78-4060-90f5-f44a65ed5ac8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Pad"",
            ""bindingGroup"": ""Pad"",
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
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_Pads = m_Character.FindAction("Pads", throwIfNotFound: true);
        // Object
        m_Object = asset.FindActionMap("Object", throwIfNotFound: true);
        m_Object_Cross = m_Object.FindAction("Cross", throwIfNotFound: true);
        m_Object_Trigger = m_Object.FindAction("Trigger", throwIfNotFound: true);
        // PhysicalCamera
        m_PhysicalCamera = asset.FindActionMap("PhysicalCamera", throwIfNotFound: true);
        m_PhysicalCamera_Screenshot = m_PhysicalCamera.FindAction("Screenshot", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Continue = m_Menu.FindAction("Continue", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_Pads;
    public struct CharacterActions
    {
        private @ControlsMap m_Wrapper;
        public CharacterActions(@ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @Pads => m_Wrapper.m_Character_Pads;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Pads.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPads;
                @Pads.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPads;
                @Pads.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPads;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Pads.started += instance.OnPads;
                @Pads.performed += instance.OnPads;
                @Pads.canceled += instance.OnPads;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Object
    private readonly InputActionMap m_Object;
    private IObjectActions m_ObjectActionsCallbackInterface;
    private readonly InputAction m_Object_Cross;
    private readonly InputAction m_Object_Trigger;
    public struct ObjectActions
    {
        private @ControlsMap m_Wrapper;
        public ObjectActions(@ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cross => m_Wrapper.m_Object_Cross;
        public InputAction @Trigger => m_Wrapper.m_Object_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_Object; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ObjectActions set) { return set.Get(); }
        public void SetCallbacks(IObjectActions instance)
        {
            if (m_Wrapper.m_ObjectActionsCallbackInterface != null)
            {
                @Cross.started -= m_Wrapper.m_ObjectActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_ObjectActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_ObjectActionsCallbackInterface.OnCross;
                @Trigger.started -= m_Wrapper.m_ObjectActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_ObjectActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_ObjectActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_ObjectActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public ObjectActions @Object => new ObjectActions(this);

    // PhysicalCamera
    private readonly InputActionMap m_PhysicalCamera;
    private IPhysicalCameraActions m_PhysicalCameraActionsCallbackInterface;
    private readonly InputAction m_PhysicalCamera_Screenshot;
    public struct PhysicalCameraActions
    {
        private @ControlsMap m_Wrapper;
        public PhysicalCameraActions(@ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Screenshot => m_Wrapper.m_PhysicalCamera_Screenshot;
        public InputActionMap Get() { return m_Wrapper.m_PhysicalCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PhysicalCameraActions set) { return set.Get(); }
        public void SetCallbacks(IPhysicalCameraActions instance)
        {
            if (m_Wrapper.m_PhysicalCameraActionsCallbackInterface != null)
            {
                @Screenshot.started -= m_Wrapper.m_PhysicalCameraActionsCallbackInterface.OnScreenshot;
                @Screenshot.performed -= m_Wrapper.m_PhysicalCameraActionsCallbackInterface.OnScreenshot;
                @Screenshot.canceled -= m_Wrapper.m_PhysicalCameraActionsCallbackInterface.OnScreenshot;
            }
            m_Wrapper.m_PhysicalCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Screenshot.started += instance.OnScreenshot;
                @Screenshot.performed += instance.OnScreenshot;
                @Screenshot.canceled += instance.OnScreenshot;
            }
        }
    }
    public PhysicalCameraActions @PhysicalCamera => new PhysicalCameraActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Continue;
    public struct MenuActions
    {
        private @ControlsMap m_Wrapper;
        public MenuActions(@ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_Menu_Continue;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Continue.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnContinue;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_PadSchemeIndex = -1;
    public InputControlScheme PadScheme
    {
        get
        {
            if (m_PadSchemeIndex == -1) m_PadSchemeIndex = asset.FindControlSchemeIndex("Pad");
            return asset.controlSchemes[m_PadSchemeIndex];
        }
    }
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPads(InputAction.CallbackContext context);
    }
    public interface IObjectActions
    {
        void OnCross(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
    public interface IPhysicalCameraActions
    {
        void OnScreenshot(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnContinue(InputAction.CallbackContext context);
    }
}
