//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Controles/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""77b41ee4-6482-4e01-92b3-d96aa3f18835"",
            ""actions"": [
                {
                    ""name"": ""MovimientoHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""9e309c9a-54c1-4076-b690-ebcbbe6237c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Saltar"",
                    ""type"": ""Button"",
                    ""id"": ""2c69b549-ed3a-4414-ae13-7d9115e89233"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Atacar"",
                    ""type"": ""Button"",
                    ""id"": ""d8c435c7-1f31-4ec3-ae31-d54a98aa160d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Agachar"",
                    ""type"": ""Button"",
                    ""id"": ""32cf2d0d-7d86-4fdf-a577-62adf09837b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AtacarFuerte"",
                    ""type"": ""Button"",
                    ""id"": ""8dab83d7-a806-4ef2-b8ee-588635b58b35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""78119f43-464f-4e86-a576-cf4b9dac37d6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1a6392a5-c930-49f1-abb4-4f617e18ee9b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c934b35f-6a89-4717-9827-69adb842e988"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a661e36d-0fa7-45bc-a0fc-e99e65db7fdc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""285e8cc3-a032-4a99-b43f-5acd77b5d756"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""d4bbb2ee-a693-48f8-a112-911d456be1bb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b38cfd4a-0dd9-4cdc-9266-a10ccc508e0b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""112e833c-9c5d-44f2-a377-6724f5db9843"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""811c2edd-aa68-4926-b56f-0ed70f088bb4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b656b3d8-3092-4829-9f56-a9aa7f42d78f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MovimientoHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e1609304-975b-4c75-ac1c-38c007dfaea1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da8ccae5-a1a6-4825-9b87-ad8e6bbe4896"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fcf3f90-625c-48ab-af0a-c295696b87d2"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Atacar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5e2115f-31c2-4887-bbbe-9c59219dba01"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""Atacar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4746bcb8-2ecc-436e-a7eb-2eddd8271681"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c4c67ee-9573-429d-b482-cc2c1d189ac3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""Agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ca1ee02-fdaa-4e45-b479-2dc0aa23fcbd"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""AtacarFuerte"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11cae4f3-c2b4-4b37-a59e-d65188f97189"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""AtacarFuerte"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""5a3afeb6-0e6d-4ec3-a522-2525e6a7a61e"",
            ""actions"": [
                {
                    ""name"": ""MoverCursor"",
                    ""type"": ""Value"",
                    ""id"": ""1fc071d8-cc68-4209-87f8-2a5ed2a9dac9"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""47cad3ca-5960-4910-8b2d-b394f0803f4a"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""371bc8a0-0eca-4f92-a70a-379e98eed060"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""96acb86e-187c-4b73-ad67-b96b04372c0a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""aa0c4c71-c014-4ac2-b86f-0e761bdd1d62"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""d3930cdc-ff58-4e32-a938-9ada23def8f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""a23fa4e6-904b-4f11-9951-1ec87685087e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""f203b7bf-a984-4811-b7c6-84dc9ba15420"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""9f405c6e-1eda-46f9-8071-7b8fbd9398f9"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""59d3ea38-ff58-4e98-83c6-fecfb301ebfa"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""9345c32b-cf3b-4ad4-8990-0a66dccab6cc"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""7a71aea1-1107-4335-984c-9ea7bab7e06b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""883a9509-acf8-4f01-aa8d-c9303663363e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control"",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""1d494029-b515-4674-a683-a2159cf9605f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""27a0a948-8660-4a73-bca4-a7bf192a67fa"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoverCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Teclado"",
            ""bindingGroup"": ""Teclado"",
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
        },
        {
            ""name"": ""Control"",
            ""bindingGroup"": ""Control"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_MovimientoHorizontal = m_Gameplay.FindAction("MovimientoHorizontal", throwIfNotFound: true);
        m_Gameplay_Saltar = m_Gameplay.FindAction("Saltar", throwIfNotFound: true);
        m_Gameplay_Atacar = m_Gameplay.FindAction("Atacar", throwIfNotFound: true);
        m_Gameplay_Agachar = m_Gameplay.FindAction("Agachar", throwIfNotFound: true);
        m_Gameplay_AtacarFuerte = m_Gameplay.FindAction("AtacarFuerte", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_MoverCursor = m_Menu.FindAction("MoverCursor", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_MovimientoHorizontal;
    private readonly InputAction m_Gameplay_Saltar;
    private readonly InputAction m_Gameplay_Atacar;
    private readonly InputAction m_Gameplay_Agachar;
    private readonly InputAction m_Gameplay_AtacarFuerte;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovimientoHorizontal => m_Wrapper.m_Gameplay_MovimientoHorizontal;
        public InputAction @Saltar => m_Wrapper.m_Gameplay_Saltar;
        public InputAction @Atacar => m_Wrapper.m_Gameplay_Atacar;
        public InputAction @Agachar => m_Wrapper.m_Gameplay_Agachar;
        public InputAction @AtacarFuerte => m_Wrapper.m_Gameplay_AtacarFuerte;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @MovimientoHorizontal.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimientoHorizontal;
                @MovimientoHorizontal.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimientoHorizontal;
                @MovimientoHorizontal.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimientoHorizontal;
                @Saltar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSaltar;
                @Saltar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSaltar;
                @Saltar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSaltar;
                @Atacar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacar;
                @Atacar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacar;
                @Atacar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacar;
                @Agachar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAgachar;
                @Agachar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAgachar;
                @Agachar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAgachar;
                @AtacarFuerte.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacarFuerte;
                @AtacarFuerte.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacarFuerte;
                @AtacarFuerte.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtacarFuerte;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovimientoHorizontal.started += instance.OnMovimientoHorizontal;
                @MovimientoHorizontal.performed += instance.OnMovimientoHorizontal;
                @MovimientoHorizontal.canceled += instance.OnMovimientoHorizontal;
                @Saltar.started += instance.OnSaltar;
                @Saltar.performed += instance.OnSaltar;
                @Saltar.canceled += instance.OnSaltar;
                @Atacar.started += instance.OnAtacar;
                @Atacar.performed += instance.OnAtacar;
                @Atacar.canceled += instance.OnAtacar;
                @Agachar.started += instance.OnAgachar;
                @Agachar.performed += instance.OnAgachar;
                @Agachar.canceled += instance.OnAgachar;
                @AtacarFuerte.started += instance.OnAtacarFuerte;
                @AtacarFuerte.performed += instance.OnAtacarFuerte;
                @AtacarFuerte.canceled += instance.OnAtacarFuerte;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_MoverCursor;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoverCursor => m_Wrapper.m_Menu_MoverCursor;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @MoverCursor.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoverCursor;
                @MoverCursor.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoverCursor;
                @MoverCursor.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoverCursor;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoverCursor.started += instance.OnMoverCursor;
                @MoverCursor.performed += instance.OnMoverCursor;
                @MoverCursor.canceled += instance.OnMoverCursor;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_TecladoSchemeIndex = -1;
    public InputControlScheme TecladoScheme
    {
        get
        {
            if (m_TecladoSchemeIndex == -1) m_TecladoSchemeIndex = asset.FindControlSchemeIndex("Teclado");
            return asset.controlSchemes[m_TecladoSchemeIndex];
        }
    }
    private int m_ControlSchemeIndex = -1;
    public InputControlScheme ControlScheme
    {
        get
        {
            if (m_ControlSchemeIndex == -1) m_ControlSchemeIndex = asset.FindControlSchemeIndex("Control");
            return asset.controlSchemes[m_ControlSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMovimientoHorizontal(InputAction.CallbackContext context);
        void OnSaltar(InputAction.CallbackContext context);
        void OnAtacar(InputAction.CallbackContext context);
        void OnAgachar(InputAction.CallbackContext context);
        void OnAtacarFuerte(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMoverCursor(InputAction.CallbackContext context);
    }
}
