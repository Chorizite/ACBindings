namespace ACBindings;

// IInputActionCallback
public unsafe struct IInputActionCallback : System.IDisposable
{
    // Child Types
    // IInputActionCallback_vtbl
    public unsafe struct IInputActionCallback_vtbl
    {
        // Members
        public System.IntPtr IInputActionCallback_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall IInputActionCallback::~IInputActionCallback(IInputActionCallback*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IInputActionCallback, void>)0x00411470)(ref this);
    // ObjectDrawStatus __thiscall IInputActionCallback::OnLoseFocus(RenderDevice*,CGfxObj*,const Position*,bool)
    public ACBindings.ObjectDrawStatus OnLoseFocus(ACBindings.CGfxObj* mesh, ACBindings.Position* mesh_pos, byte building_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IInputActionCallback, ACBindings.CGfxObj*, ACBindings.Position*, byte, ACBindings.ObjectDrawStatus>)0x006B4CF0)(ref this, mesh, mesh_pos, building_flag);
}

