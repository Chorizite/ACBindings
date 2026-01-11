namespace ACBindings.Internal;

public unsafe struct FileNameDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte height_map;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte terrain_map;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte scene_map;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte encounter_type_map;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00501450
    /// void __thiscall FileNameDesc::~FileNameDesc(FileNameDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNameDesc, void>)0x00501450)(ref this);
}

