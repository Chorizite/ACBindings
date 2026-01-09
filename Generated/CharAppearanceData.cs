namespace ACBindings;

// CharAppearanceData
public unsafe struct CharAppearanceData
{
    // Members
    public ACBindings.IDClass___tagDataID base_palette;
    public ACBindings.IDClass___tagDataID head_object;
    public ACBindings.IDClass___tagDataID eyes_texture;
    public ACBindings.IDClass___tagDataID nose_texture;
    public ACBindings.IDClass___tagDataID mouth_texture;
    public ACBindings.IDClass___tagDataID default_eyes_texture;
    public ACBindings.IDClass___tagDataID default_nose_texture;
    public ACBindings.IDClass___tagDataID default_mouth_texture;
    public ACBindings.IDClass___tagDataID hair_palette;
    public ACBindings.IDClass___tagDataID eyes_palette;
    public ACBindings.IDClass___tagDataID skin_palette;

    // Generated Constructor
    public CharAppearanceData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CharAppearanceData::CharAppearanceData(CharAppearanceData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharAppearanceData, void>)0x004DEDD0)(ref this);
}

