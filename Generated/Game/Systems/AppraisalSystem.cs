namespace ACBindings.Internal;

public unsafe struct AppraisalSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005B52B0
    /// unsigned int __cdecl AppraisalSystem::DamageTypeToString(const DAMAGE_TYPE,char*,const unsigned int)</code>
    /// </summary>
    public static uint DamageTypeToString(ACBindings.Internal.DAMAGE_TYPE dtype, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DAMAGE_TYPE, sbyte*, uint, uint>)0x005B52B0)(dtype, buf, size);

    /// <summary>
    /// <code>Offset: 0x005B5690
    /// int __cdecl AppraisalSystem::InqMaterialName(int,int*)</code>
    /// </summary>
    public static int InqMaterialName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5690)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B56B0
    /// int __cdecl AppraisalSystem::LockpickSuccessPercentToString(int,int*)</code>
    /// </summary>
    public static int LockpickSuccessPercentToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B56B0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B57C0
    /// int __cdecl AppraisalSystem::InqHeritageGroupDisplayName(const char*,int*)</code>
    /// </summary>
    public static int InqHeritageGroupDisplayName(sbyte* m_charbuffer, int* a2) => ((delegate* unmanaged[Cdecl]<sbyte*, int*, int>)0x005B57C0)(m_charbuffer, a2);

    /// <summary>
    /// <code>Offset: 0x005B5870
    /// int __cdecl AppraisalSystem::InqGenderDisplayName(int,int*)</code>
    /// </summary>
    public static int InqGenderDisplayName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5870)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B5900
    /// int __cdecl AppraisalSystem::AttunedStatusToString(int,int*)</code>
    /// </summary>
    public static int AttunedStatusToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5900)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B5930
    /// int __cdecl AppraisalSystem::BondedStatusToString(int,int*)</code>
    /// </summary>
    public static int BondedStatusToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5930)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B5990
    /// int __cdecl AppraisalSystem::InqWorkmanshipAdjective(unsigned int,int*,int)</code>
    /// </summary>
    public static int InqWorkmanshipAdjective(uint a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<uint, int*, int, int>)0x005B5990)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B5A20
    /// void __cdecl AppraisalSystem::WeaponTimeToString(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    public static void WeaponTimeToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, void>)0x005B5A20)(a1);

    /// <summary>
    /// <code>Offset: 0x005B5AE0
    /// int __cdecl AppraisalSystem::SkillToString(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    public static int SkillToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005B5AE0)(a1);

    /// <summary>
    /// <code>Offset: 0x005B5FE0
    /// int __cdecl AppraisalSystem::ClothingPriorityToString(int,int*)</code>
    /// </summary>
    public static int ClothingPriorityToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5FE0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B6540
    /// int __cdecl AppraisalSystem::DamageResistanceToString(CLogonHeader::HandshakeWireData,float,int*)</code>
    /// </summary>
    public static int DamageResistanceToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1, float a2, int* a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, float, int*, int>)0x005B6540)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B68B0
    /// int __cdecl AppraisalSystem::InqPluralizedGemName(volatile LONG*,void**)</code>
    /// </summary>
    public static int InqPluralizedGemName(int* m_charbuffer, void** a2) => ((delegate* unmanaged[Cdecl]<int*, void**, int>)0x005B68B0)(m_charbuffer, a2);

    /// <summary>
    /// <code>Offset: 0x005B6A90
    /// int __cdecl AppraisalSystem::InqCreatureDisplayName(int,int*)</code>
    /// </summary>
    public static int InqCreatureDisplayName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B6A90)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005B6B90
    /// int __cdecl AppraisalSystem::InqGenderHeritageDisplay(int,const char*,int,CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    public static int InqGenderHeritageDisplay(int a1, sbyte* a2, int a3, ACBindings.Internal.CLogonHeader.HandshakeWireData a4) => ((delegate* unmanaged[Cdecl]<int, sbyte*, int, ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005B6B90)(a1, a2, a3, a4);
}

