namespace ACBindings;

// DBLevelInfo
public unsafe struct DBLevelInfo : System.IDisposable
{
    // Members
    public fixed byte m_Resources_Raw[72];
    public ACBindings.DBLevelResource* m_Resources => (ACBindings.DBLevelResource*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Resources_Raw[0]);

    // Generated Constructor
    public DBLevelInfo() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall DBLevelInfo::DBLevelInfo(DBLevelInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBLevelInfo, void>)0x0044C030)(ref this);
    // void __thiscall DBLevelInfo::~DBLevelInfo(DBLevelInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBLevelInfo, void>)0x0044C080)(ref this);
}

