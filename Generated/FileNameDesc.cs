namespace ACBindings;

// FileNameDesc
public unsafe struct FileNameDesc : System.IDisposable
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte height_map;
    public ACBindings.AC1Legacy.PStringBase__sbyte terrain_map;
    public ACBindings.AC1Legacy.PStringBase__sbyte scene_map;
    public ACBindings.AC1Legacy.PStringBase__sbyte encounter_type_map;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall FileNameDesc::~FileNameDesc(FileNameDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNameDesc, void>)0x00501450)(ref this);
}

