namespace ACBindings;

// LM_UVTranslate
public unsafe struct LM_UVTranslate
{
    // Base Classes
    public ACBindings.LayerModifier BaseClass_LayerModifier; // ACBindings.LayerModifier

    // Child Types
    // LM_UVTranslate_vtbl
    public unsafe struct LM_UVTranslate_vtbl
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
    public ACBindings.Waveform uTranslate;
    public ACBindings.Waveform vTranslate;

    // Generated Constructor
    public LM_UVTranslate() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall LM_UVTranslate::SetUTranslate(LM_UVScale*,const Waveform*)
    public void SetUTranslate(ACBindings.Waveform* uScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.Waveform*, void>)0x0044F8D0)(ref this, uScale);
    // void __thiscall LM_UVTranslate::SetVTranslate(LM_UVScale*,const Waveform*)
    public void SetVTranslate(ACBindings.Waveform* vScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.Waveform*, void>)0x0044F920)(ref this, vScale);
    // void __thiscall LM_UVTranslate::LM_UVTranslate(LM_UVTranslate*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, void>)0x004507E0)(ref this);
    // unsigned int __thiscall LM_UVTranslate::GetSize(LM_UVScale*)
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, uint>)0x00450820)(ref this);
    // void __thiscall LM_UVTranslate::ApplyTextureTransform(LM_UVTranslate*,Matrix4*)
    public void ApplyTextureTransform(ACBindings.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.Matrix4*, void>)0x00450830)(ref this, mTextureMatrix);
    // LayerModifier* __thiscall LM_UVTranslate::Copy(LM_UVTranslate*)
    public ACBindings.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.LayerModifier*>)0x00450C50)(ref this);
    // void __thiscall LM_UVTranslate::Serialize(LM_UVScale*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.Archive*, void>)0x00450CB0)(ref this, io_archive);
    // bool __thiscall LM_UVTranslate::SaveToFileNode(LM_UVTranslate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)
    public byte SaveToFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x00450D20)(ref this, baseNode, owner, layerIndex, modIndex);
    // bool __thiscall LM_UVTranslate::LoadFromFileNode(LM_UVTranslate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)
    public byte LoadFromFileNode(ACBindings.PFileNode* baseNode, ACBindings.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LM_UVTranslate, ACBindings.PFileNode*, ACBindings.RenderMaterial*, uint, uint, byte>)0x004514A0)(ref this, baseNode, owner, layerIndex, modIndex);
}

