namespace ACBindings.Internal;


/// <summary>Defines an interface for input action callbacks, exposing a virtual function table to handle user interactions in the application.</summary>
public unsafe struct IInputActionCallback : System.IDisposable
{
    // Child Types

    /// <summary>Virtual function table for input action callbacks, exposing destructor, action handler, and focus‑loss callback.</summary>
    public unsafe struct IInputActionCallback_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IInputActionCallback*, void> IInputActionCallback_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IInputActionCallback*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IInputActionCallback*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases resources for an input action callback, resetting its virtual table pointer and notifying the global ID manager when available.
    /// <code>Offset: 0x00411470
    /// void __thiscall IInputActionCallback::~IInputActionCallback(IInputActionCallback*)</code>
    /// </summary>
    /// <param name="this">The instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IInputActionCallback, void>)0x00411470)(ref this);

    /// <summary>Handles loss of focus for a graphical object, adjusting its rendering status accordingly.
    /// <code>Offset: 0x006B4CF0
    /// ObjectDrawStatus __thiscall IInputActionCallback::OnLoseFocus(RenderDevice*,CGfxObj*,const Position*,bool)</code>
    /// </summary>
    /// <param name="this">The render device handling the draw call.</param>
    /// <param name="mesh">The graphic mesh affected by the focus change.</param>
    /// <param name="mesh_pos">The world position of the mesh at the time of focus loss.</param>
    /// <param name="building_flag">Indicates whether the object is in building mode during the operation.</param>
    /// <returns>An ObjectDrawStatus value representing the outcome of the state update.</returns>
    public ACBindings.Internal.ObjectDrawStatus OnLoseFocus(ACBindings.Internal.CGfxObj* mesh, ACBindings.Internal.Position* mesh_pos, byte building_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IInputActionCallback, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus>)0x006B4CF0)(ref this, mesh, mesh_pos, building_flag);
}

