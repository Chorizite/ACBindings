namespace ACBindings.Internal;

public unsafe struct LayerModifier
{
    // Child Types
    public unsafe struct LayerModifier_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, uint> GetTCIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, uint> GetSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, byte> DoesModifyVertex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LayerModifier*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

