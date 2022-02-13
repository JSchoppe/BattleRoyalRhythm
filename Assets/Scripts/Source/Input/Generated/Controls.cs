// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace CindyBrock.Input.Generated
{
    public class @Controls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MenuControl"",
            ""id"": ""24e73525-cc02-41b7-9a65-cc901d08ac81"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""ad589b62-c51c-4847-a721-030061368fd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ebf6ff26-d7d6-46f0-9d59-bde482210e5f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControl"",
            ""id"": ""d747d11f-5726-4baf-8fd8-c0cd5fee3f74"",
            ""actions"": [
                {
                    ""name"": ""Move Left"",
                    ""type"": ""Button"",
                    ""id"": ""b3941df7-bdc7-46ea-8f64-ae020827873b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Right"",
                    ""type"": ""Button"",
                    ""id"": ""8cc0b389-d83c-436a-8664-1016efc35759"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""68f1a823-0f01-49bb-83aa-bf41f80537b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0d3f5d5d-d6ce-40db-b05f-8518ca0c7f75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Set Genre A"",
                    ""type"": ""Button"",
                    ""id"": ""175901fc-f441-4d06-bc17-42d28bcd7194"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Set Genre B"",
                    ""type"": ""Button"",
                    ""id"": ""2eff8a73-f939-4684-b1ce-0719e700909c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Set Genre C"",
                    ""type"": ""Button"",
                    ""id"": ""e25b4473-d625-48f7-9f85-c96b227b61de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Set Genre D"",
                    ""type"": ""Button"",
                    ""id"": ""04ad53a3-2fb3-451a-8d6f-dd082dc02df1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""23cef2f1-9190-45a5-9397-a7fc15761aaf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability"",
                    ""type"": ""Button"",
                    ""id"": ""5ea647d3-c699-487c-ad54-dfbbbe81f334"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0fd1082e-c2ff-4cb0-a2af-ddc228632a33"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9280d571-1fc7-4dc1-a199-c92b93fe6e48"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b0f32ce-2288-421f-907b-e81d521fae6b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21a1be53-1093-4b91-a0b2-97447de2cbf5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c50b2c61-28ad-49be-b2dc-02e7772e19da"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daf510a5-3c84-4dca-94b2-1dd1be5b9728"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b539893f-800d-49e5-b531-4aed6ca55c5c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b616d68-40b6-414f-881b-71bb3fbc0a42"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18034880-1b74-4803-b3f0-06b199c92c9b"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad1e8799-ef3a-4c56-bb69-f68c73693606"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f42f19df-4bcf-472a-969e-9986762447db"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5cd5704-5214-485f-95f2-63a103492952"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbb29edf-b0a8-4cab-96dc-e61db0208bf3"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Set Genre A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de9b193f-5a48-4f9f-9ca8-795e17b402c9"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Set Genre A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e720ec92-2bfa-4210-afc8-6c70962f989f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Set Genre B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47ffc8dd-6e70-414d-96df-8b9c6a4f6d2f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Set Genre B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""900e46e7-bfab-422b-9045-481ad197023e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Set Genre C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e7edd3b-6815-45f7-a83c-7b09a11a1109"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Set Genre C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7145bde-d87b-4327-8aa8-5f6bad4d8732"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Set Genre D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b2bbfd7-cd4d-4459-a565-018108a2f388"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Set Genre D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cb639bd-1b7c-4c37-a710-ceea19756e61"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e43da8aa-eb55-4b17-b2dc-5b55687cc55d"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31fc84e0-7219-4fa8-b1f4-76f4497ac0bb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0c98d49-29e0-4842-960f-61e7a5b51054"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c508ec93-a730-4904-b6a2-6146b2225690"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b61fab0-12ec-48ea-a317-632e37cd82c6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
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
            // MenuControl
            m_MenuControl = asset.FindActionMap("MenuControl", throwIfNotFound: true);
            m_MenuControl_Newaction = m_MenuControl.FindAction("New action", throwIfNotFound: true);
            // PlayerControl
            m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
            m_PlayerControl_MoveLeft = m_PlayerControl.FindAction("Move Left", throwIfNotFound: true);
            m_PlayerControl_MoveRight = m_PlayerControl.FindAction("Move Right", throwIfNotFound: true);
            m_PlayerControl_Duck = m_PlayerControl.FindAction("Duck", throwIfNotFound: true);
            m_PlayerControl_Jump = m_PlayerControl.FindAction("Jump", throwIfNotFound: true);
            m_PlayerControl_SetGenreA = m_PlayerControl.FindAction("Set Genre A", throwIfNotFound: true);
            m_PlayerControl_SetGenreB = m_PlayerControl.FindAction("Set Genre B", throwIfNotFound: true);
            m_PlayerControl_SetGenreC = m_PlayerControl.FindAction("Set Genre C", throwIfNotFound: true);
            m_PlayerControl_SetGenreD = m_PlayerControl.FindAction("Set Genre D", throwIfNotFound: true);
            m_PlayerControl_Attack = m_PlayerControl.FindAction("Attack", throwIfNotFound: true);
            m_PlayerControl_Ability = m_PlayerControl.FindAction("Ability", throwIfNotFound: true);
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

        // MenuControl
        private readonly InputActionMap m_MenuControl;
        private IMenuControlActions m_MenuControlActionsCallbackInterface;
        private readonly InputAction m_MenuControl_Newaction;
        public struct MenuControlActions
        {
            private @Controls m_Wrapper;
            public MenuControlActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_MenuControl_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_MenuControl; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuControlActions set) { return set.Get(); }
            public void SetCallbacks(IMenuControlActions instance)
            {
                if (m_Wrapper.m_MenuControlActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_MenuControlActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public MenuControlActions @MenuControl => new MenuControlActions(this);

        // PlayerControl
        private readonly InputActionMap m_PlayerControl;
        private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
        private readonly InputAction m_PlayerControl_MoveLeft;
        private readonly InputAction m_PlayerControl_MoveRight;
        private readonly InputAction m_PlayerControl_Duck;
        private readonly InputAction m_PlayerControl_Jump;
        private readonly InputAction m_PlayerControl_SetGenreA;
        private readonly InputAction m_PlayerControl_SetGenreB;
        private readonly InputAction m_PlayerControl_SetGenreC;
        private readonly InputAction m_PlayerControl_SetGenreD;
        private readonly InputAction m_PlayerControl_Attack;
        private readonly InputAction m_PlayerControl_Ability;
        public struct PlayerControlActions
        {
            private @Controls m_Wrapper;
            public PlayerControlActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveLeft => m_Wrapper.m_PlayerControl_MoveLeft;
            public InputAction @MoveRight => m_Wrapper.m_PlayerControl_MoveRight;
            public InputAction @Duck => m_Wrapper.m_PlayerControl_Duck;
            public InputAction @Jump => m_Wrapper.m_PlayerControl_Jump;
            public InputAction @SetGenreA => m_Wrapper.m_PlayerControl_SetGenreA;
            public InputAction @SetGenreB => m_Wrapper.m_PlayerControl_SetGenreB;
            public InputAction @SetGenreC => m_Wrapper.m_PlayerControl_SetGenreC;
            public InputAction @SetGenreD => m_Wrapper.m_PlayerControl_SetGenreD;
            public InputAction @Attack => m_Wrapper.m_PlayerControl_Attack;
            public InputAction @Ability => m_Wrapper.m_PlayerControl_Ability;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlActions instance)
            {
                if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
                {
                    @MoveLeft.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveLeft;
                    @MoveRight.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveRight;
                    @MoveRight.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveRight;
                    @MoveRight.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveRight;
                    @Duck.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDuck;
                    @Duck.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDuck;
                    @Duck.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDuck;
                    @Jump.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                    @SetGenreA.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreA;
                    @SetGenreA.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreA;
                    @SetGenreA.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreA;
                    @SetGenreB.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreB;
                    @SetGenreB.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreB;
                    @SetGenreB.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreB;
                    @SetGenreC.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreC;
                    @SetGenreC.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreC;
                    @SetGenreC.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreC;
                    @SetGenreD.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreD;
                    @SetGenreD.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreD;
                    @SetGenreD.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetGenreD;
                    @Attack.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAttack;
                    @Ability.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAbility;
                    @Ability.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAbility;
                    @Ability.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnAbility;
                }
                m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveLeft.started += instance.OnMoveLeft;
                    @MoveLeft.performed += instance.OnMoveLeft;
                    @MoveLeft.canceled += instance.OnMoveLeft;
                    @MoveRight.started += instance.OnMoveRight;
                    @MoveRight.performed += instance.OnMoveRight;
                    @MoveRight.canceled += instance.OnMoveRight;
                    @Duck.started += instance.OnDuck;
                    @Duck.performed += instance.OnDuck;
                    @Duck.canceled += instance.OnDuck;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @SetGenreA.started += instance.OnSetGenreA;
                    @SetGenreA.performed += instance.OnSetGenreA;
                    @SetGenreA.canceled += instance.OnSetGenreA;
                    @SetGenreB.started += instance.OnSetGenreB;
                    @SetGenreB.performed += instance.OnSetGenreB;
                    @SetGenreB.canceled += instance.OnSetGenreB;
                    @SetGenreC.started += instance.OnSetGenreC;
                    @SetGenreC.performed += instance.OnSetGenreC;
                    @SetGenreC.canceled += instance.OnSetGenreC;
                    @SetGenreD.started += instance.OnSetGenreD;
                    @SetGenreD.performed += instance.OnSetGenreD;
                    @SetGenreD.canceled += instance.OnSetGenreD;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Ability.started += instance.OnAbility;
                    @Ability.performed += instance.OnAbility;
                    @Ability.canceled += instance.OnAbility;
                }
            }
        }
        public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        public interface IMenuControlActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface IPlayerControlActions
        {
            void OnMoveLeft(InputAction.CallbackContext context);
            void OnMoveRight(InputAction.CallbackContext context);
            void OnDuck(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnSetGenreA(InputAction.CallbackContext context);
            void OnSetGenreB(InputAction.CallbackContext context);
            void OnSetGenreC(InputAction.CallbackContext context);
            void OnSetGenreD(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnAbility(InputAction.CallbackContext context);
        }
    }
}
