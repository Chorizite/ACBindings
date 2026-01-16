namespace ACBindings.Internal;


/// <summary>Power‑bar UI element that tracks the current mode and displays power levels during combat, jump, or DDD states. Holds a reference to a special recklessness field for advanced combat visual feedback.</summary>
public unsafe struct gmPowerbarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmPowerbarUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PowerBarMode m_pbmCurrentMode;
    public ACBindings.Internal.UIElement_Field* m_RecklessnessField;

    // Generated Constructor
    public gmPowerbarUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a power bar UI element from the supplied layout and element description, establishes input action callbacks and notice handling, and resets the current power‑bar mode to undefined.
    /// <code>Offset: 0x004DB000
    /// void __thiscall gmPowerbarUI::gmPowerbarUI(gmPowerbarUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display dimensions and related elements for the UI component.</param>
    /// <param name="full_desc">Element descriptor providing detailed configuration such as IDs, types, geometry, and state information for the power bar.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004DB000)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to the requested UI element type from a gmPowerbarUI instance based on a runtime type identifier.
    /// <code>Offset: 0x004DB040
    /// UIElement* __thiscall gmPowerbarUI::DynamicCast(gmPowerbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The unsigned integer identifying the desired type for casting.</param>
    /// <returns>Pointer to UIElement if the cast succeeds; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, uint, ACBindings.Internal.UIElement*>)0x004DB040)(ref this, i_eType);

    /// <summary>Retrieves the UI element type identifier for a power bar UI component.
    /// <code>Offset: 0x004DB060
    /// unsigned int __thiscall gmPowerbarUI::GetUIElementType(gmPowerbarUI*)</code>
    /// </summary>
    /// <returns>The unique integer ID representing the power bar UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, uint>)0x004DB060)(ref this);

    /// <summary>Destroys a gmPowerbarUI object, releasing resources and cleaning up its UI components.
    /// <code>Offset: 0x004DB070
    /// void __thiscall gmPowerbarUI::~gmPowerbarUI(gmPowerbarUI*)</code>
    /// </summary>
    /// <param name="this">The instance of gmPowerbarUI being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, void>)0x004DB070)(ref this);

    /// <summary>Creates a new power bar UI element configured by the supplied layout and element description.
    /// <code>Offset: 0x004DB0A0
    /// UIElement* __cdecl gmPowerbarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display dimensions and state definitions.</param>
    /// <param name="full_desc">Element descriptor defining visual properties, states, and hierarchy for the power bar.</param>
    /// <returns>Pointer to the initialized UIElement on success; otherwise nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004DB0A0)(layout, full_desc);

    /// <summary>Initializes the power bar UI by calling its base PostInit and searching for a child element identified by 0x100005EE to store as the recklessness field. If none is found, clears the recklessness field and invokes a global cleanup routine.
    /// <code>Offset: 0x004DB140
    /// void __thiscall gmPowerbarUI::PostInit(gmPowerbarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, void>)0x004DB140)(ref this);

    /// <summary>Registers the power bar UI element class with the UI system using a unique type identifier and associated creation callback.
    /// <code>Offset: 0x004DB190
    /// void __cdecl gmPowerbarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DB190)();

    /// <summary>Updates the visual representation of the power bar when a set-level notice is received.
    /// <code>Offset: 0x004DB1B0
    /// void __thiscall gmPowerbarUI::RecvNotice_SetPowerbarLevel(gmPowerbarUI*,PowerBarMode,float)</code>
    /// </summary>
    /// <param name="i_pbm">The power bar mode to target.</param>
    /// <param name="i_fLevel">The new level value for the power bar.</param>
    public void RecvNotice_SetPowerbarLevel(ACBindings.Internal.PowerBarMode i_pbm, float i_fLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, ACBindings.Internal.PowerBarMode, float, void>)0x004DB1B0)(ref this, i_pbm, i_fLevel);

    /// <summary>Handles the completion of a power‑bar action by resetting UI state for the specified mode, clearing registration and zeroing an attribute on a relevant child element.
    /// <code>Offset: 0x004DB1E0
    /// void __thiscall gmPowerbarUI::RecvNotice_FinishPowerbar(gmPowerbarUI*,PowerBarMode)</code>
    /// </summary>
    /// <param name="i_pbm">The power bar mode that has finished.</param>
    public void RecvNotice_FinishPowerbar(ACBindings.Internal.PowerBarMode i_pbm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, ACBindings.Internal.PowerBarMode, void>)0x004DB1E0)(ref this, i_pbm);

    /// <summary>Updates the power bar UI to reflect runtime DDD status, setting the label text and progress ratio when started, or unregistering callbacks upon completion.
    /// <code>Offset: 0x004DB220
    /// void __thiscall gmPowerbarUI::RecvNotice_RuntimeDDDStatus(gmPowerbarUI*,bool,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="bStart">Indicates whether to begin (true) or end (false) the DDD notice handling.</param>
    /// <param name="current">Current value of the DDD counter displayed in the UI.</param>
    /// <param name="total">Total required value for full DDD mode; if zero, a placeholder is shown instead of a numeric total.</param>
    public void RecvNotice_RuntimeDDDStatus(byte bStart, uint current, uint total) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, byte, uint, uint, void>)0x004DB220)(ref this, bStart, current, total);

    /// <summary>Configures the power‑bar user interface for the specified PowerBarMode, updating visual states, triggering animations and resetting internal attributes accordingly.
    /// <code>Offset: 0x004DB390
    /// void __thiscall gmPowerbarUI::RecvNotice_BeginPowerbar(gmPowerbarUI*,PowerBarMode)</code>
    /// </summary>
    /// <param name="pbm">The mode determining which power‑bar behavior to activate.</param>
    public void RecvNotice_BeginPowerbar(ACBindings.Internal.PowerBarMode pbm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPowerbarUI, ACBindings.Internal.PowerBarMode, void>)0x004DB390)(ref this, pbm);
}

