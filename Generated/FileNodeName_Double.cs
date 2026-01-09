namespace ACBindings;

// FileNodeName_Double
public unsafe struct FileNodeName_Double
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public double m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Double::Clone(FileNodeName_Double*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Double, ACBindings.IFileNodeName*>)0x00425460)(ref this);
    // void __thiscall FileNodeName_Double::Serialize(FileNodeName_Double*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Double, ACBindings.Archive*, void>)0x00425490)(ref this, io_archive);
    // unsigned int __stdcall FileNodeName_Double::GetType()
    public static uint GetType() => ((delegate* unmanaged[Stdcall]<uint>)0x00527400)();
    // char __thiscall FileNodeName_Double::FromPString(double*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Double, sbyte**, sbyte>)0x0065BAF0)(ref this, a2);
    // int* __thiscall FileNodeName_Double::ToPString(double*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Double, int*, int*>)0x0065C0C0)(ref this, a2);
}

