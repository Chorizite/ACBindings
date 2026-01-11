namespace ACBindings.Internal;

public unsafe struct DBLevelInfo : System.IDisposable
{
    // Members
    public fixed byte m_Resources_Raw[72];
    public ACBindings.Internal.DBLevelResource* m_Resources => (ACBindings.Internal.DBLevelResource*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Resources_Raw[0]);

    // Generated Constructor
    public DBLevelInfo() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0044C030
    /// void __thiscall DBLevelInfo::DBLevelInfo(DBLevelInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBLevelInfo, void>)0x0044C030)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C080
    /// void __thiscall DBLevelInfo::~DBLevelInfo(DBLevelInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBLevelInfo, void>)0x0044C080)(ref this);
}

