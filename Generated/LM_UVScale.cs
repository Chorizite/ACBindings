namespace ACBindings;

// LM_UVScale
public unsafe struct LM_UVScale
{
    // Base Classes
    public ACBindings.LayerModifier BaseClass_LayerModifier; // ACBindings.LayerModifier

    // Child Types
    // LM_UVScale_vtbl
    public unsafe struct LM_UVScale_vtbl
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
    public ACBindings.Waveform uScale;
    public ACBindings.Waveform vScale;

    // Generated Constructor
    public LM_UVScale() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall LM_UVScale::LM_UVScale(LM_UVScale*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVScale, void>)0x00450950)(ref this);
    // void __thiscall LM_UVScale::ApplyTextureTransform(LM_UVScale*,Matrix4*)
    public void ApplyTextureTransform(ACBindings.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVScale, ACBindings.Matrix4*, void>)0x00450A40)(ref this, mTextureMatrix);
    // LayerModifier* __thiscall LM_UVScale::Copy(LM_UVScale*)
    public ACBindings.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVScale, ACBindings.LayerModifier*>)0x00450BA0)(ref this);
    // bool __thiscall LM_UVScale::SaveToFileNode(LM_UVScale*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)
    public byte SaveToFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVScale, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x004511C0)(ref this, baseNode, owner, layerIndex, modIndex);
    // bool __thiscall LM_UVScale::LoadFromFileNode(LM_UVScale*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)
    public byte LoadFromFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVScale, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x00451870)(ref this, baseNode, owner, layerIndex, modIndex);
}

