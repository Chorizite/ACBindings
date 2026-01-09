namespace ACBindings;

// StringInfoData
public unsafe struct StringInfoData
{
    // Child Types
    // StringInfoData_vtbl
    public unsafe struct StringInfoData_vtbl
    {
        // Members
        public System.IntPtr StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ushort m_eType;
    public uint m_eVarID;

    // Methods
    // StringInfoData* __cdecl StringInfoData::Create(unsigned __int16)
    public static ACBindings.StringInfoData* Create(ushort i_eType) => ((delegate* unmanaged[Cdecl]<ushort, ACBindings.StringInfoData*>)0x0042ED90)(i_eType);
    // bool __cdecl StringInfoData::Compare(const StringInfoData*,const StringInfoData*)
    public static byte Compare(ACBindings.StringInfoData* i_pcLhs, ACBindings.StringInfoData* i_pcRhs) => ((delegate* unmanaged[Cdecl]<ACBindings.StringInfoData*, ACBindings.StringInfoData*, byte>)0x0042F050)(i_pcLhs, i_pcRhs);
    // void __thiscall StringInfoData::Serialize(StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoData, ACBindings.Archive*, void>)0x0042F0E0)(ref this, rArchive);
    // StringInfoData* __cdecl StringInfoData::Copy(const StringInfoData*)
    public static ACBindings.StringInfoData* Copy(ACBindings.StringInfoData* i_pcRhs) => ((delegate* unmanaged[Cdecl]<ACBindings.StringInfoData*, ACBindings.StringInfoData*>)0x0042F3A0)(i_pcRhs);
}

