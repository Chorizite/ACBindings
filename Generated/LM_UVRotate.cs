namespace ACBindings;

// LM_UVRotate
public unsafe struct LM_UVRotate
{
    // Base Classes
    public ACBindings.LayerModifier BaseClass_LayerModifier; // ACBindings.LayerModifier

    // Child Types
    // LM_UVRotate_vtbl
    public unsafe struct LM_UVRotate_vtbl
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
    public uint texCoordIndex;
    public ACBindings.Waveform rotate;

    // Generated Constructor
    public LM_UVRotate() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall LM_UVRotate::LM_UVRotate(LM_UVRotate*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, void>)0x004508B0)(ref this);
    // unsigned int __thiscall LM_UVRotate::GetSize(LM_UVRotate*)
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, uint>)0x004508E0)(ref this);
    // void __thiscall LM_UVRotate::ApplyTextureTransform(LM_UVRotate*,Matrix4*)
    public void ApplyTextureTransform(ACBindings.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, ACBindings.Matrix4*, void>)0x004508F0)(ref this, mTextureMatrix);
    // LayerModifier* __thiscall LM_UVRotate::Copy(LM_UVRotate*)
    public ACBindings.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, ACBindings.LayerModifier*>)0x00450B50)(ref this);
    // void __thiscall LM_UVRotate::Serialize(LM_UVRotate*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, ACBindings.Archive*, void>)0x00450F70)(ref this, io_archive);
    // bool __thiscall LM_UVRotate::SaveToFileNode(LM_UVRotate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)
    public byte SaveToFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x00450FF0)(ref this, baseNode, owner, layerIndex, modIndex);
    // bool __thiscall LM_UVRotate::LoadFromFileNode(LM_UVRotate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)
    public byte LoadFromFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVRotate, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x004516D0)(ref this, baseNode, owner, layerIndex, modIndex);
}

