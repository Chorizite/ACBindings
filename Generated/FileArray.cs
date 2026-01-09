namespace ACBindings;

// FileArray
public unsafe struct FileArray
{
    // Methods
    // IDClass<_tagDataID,32,0>* __cdecl FileArray::GetDID(IDClass<_tagDataID,32,0>*,_DWORD*,int)
    public static ACBindings.IDClass___tagDataID* GetDID(ACBindings.IDClass___tagDataID* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.IDClass___tagDataID*, int*, int, ACBindings.IDClass___tagDataID*>)0x006791F0)(a1, a2, a3);
    // PStringBase<char>* __cdecl FileArray::GetRelativeFilePath(PStringBase<char>*)
    public static ACBindings.PStringBase__sbyte* GetRelativeFilePath(ACBindings.PStringBase__sbyte* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.PStringBase__sbyte*, ACBindings.PStringBase__sbyte*>)0x00679220)(a1);
    // PStringBase<char>* __cdecl FileArray::GetFileNameForDummies(PStringBase<char>*,int)
    public static ACBindings.PStringBase__sbyte* GetFileNameForDummies(ACBindings.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.PStringBase__sbyte*, int, ACBindings.PStringBase__sbyte*>)0x00679240)(a1, a2);
    // PStringBase<char>* __cdecl FileArray::GetAbsoluteFilePathForDummies(PStringBase<char>*,int)
    public static ACBindings.PStringBase__sbyte* GetAbsoluteFilePathForDummies(ACBindings.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.PStringBase__sbyte*, int, ACBindings.PStringBase__sbyte*>)0x00679290)(a1, a2);
}

