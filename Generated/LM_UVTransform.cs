namespace ACBindings;

// LM_UVTransform
public unsafe struct LM_UVTransform
{
    // Base Classes
    public ACBindings.LayerModifier BaseClass_LayerModifier; // ACBindings.LayerModifier

    // Child Types
    // LM_UVTransform_vtbl
    public unsafe struct LM_UVTransform_vtbl
    {
        // Members
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetTCIndex; // function pointer
        public System.IntPtr GetSize; // function pointer
        public System.IntPtr DoesModifyVertex; // function pointer
        public System.IntPtr Copy; // function pointer
        public System.IntPtr Apply; // function pointer
        public System.IntPtr ApplyTextureTransform; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr LoadFromFileNode; // function pointer
        public System.IntPtr SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint m_nStageIndex;
    public ACBindings.Matrix4 m_mTransform;

    // Methods
    // unsigned int __thiscall LM_UVTransform::GetSize(LM_UVTransform*)
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTransform, uint>)0x00450B10)(ref this);
    // void __thiscall LM_UVTransform::ApplyTextureTransform(LM_UVTransform*,Matrix4*)
    public void ApplyTextureTransform(ACBindings.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTransform, ACBindings.Matrix4*, void>)0x00450B20)(ref this, mTextureMatrix);
    // LayerModifier* __thiscall LM_UVTransform::Copy(LM_UVTransform*)
    public ACBindings.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTransform, ACBindings.LayerModifier*>)0x00450BE0)(ref this);
    // void __thiscall LM_UVTransform::Serialize(LM_UVTransform*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTransform, ACBindings.Archive*, void>)0x00451410)(ref this, io_archive);
}

