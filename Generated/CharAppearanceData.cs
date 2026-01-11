namespace ACBindings.Internal;

public unsafe struct CharAppearanceData
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID base_palette;
    public ACBindings.Internal.IDClass____tagDataID head_object;
    public ACBindings.Internal.IDClass____tagDataID eyes_texture;
    public ACBindings.Internal.IDClass____tagDataID nose_texture;
    public ACBindings.Internal.IDClass____tagDataID mouth_texture;
    public ACBindings.Internal.IDClass____tagDataID default_eyes_texture;
    public ACBindings.Internal.IDClass____tagDataID default_nose_texture;
    public ACBindings.Internal.IDClass____tagDataID default_mouth_texture;
    public ACBindings.Internal.IDClass____tagDataID hair_palette;
    public ACBindings.Internal.IDClass____tagDataID eyes_palette;
    public ACBindings.Internal.IDClass____tagDataID skin_palette;

    // Generated Constructor
    public CharAppearanceData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004DEDD0
    /// void __thiscall CharAppearanceData::CharAppearanceData(CharAppearanceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharAppearanceData, void>)0x004DEDD0)(ref this);
}

