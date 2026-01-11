namespace ACBindings.Internal;

public unsafe struct Position
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Position_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void> Position_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint objcell_id;
    public ACBindings.Internal.Frame frame;

    // Generated Constructor
    public Position() {
        _ConstructorInternal();
    }
    public Position(uint cellID, ACBindings.Internal.Frame* newFrame) {
        _ConstructorInternal(cellID, newFrame);
    }
    public Position(ACBindings.Internal.Position* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Initializes a Position instance with default state: sets object cell ID to zero, establishes an identity orientation quaternion, positions the origin at (0, 0, 0), and caches the frame for later use.
    /// <code>Offset: 0x00424D10
    /// void __thiscall Position::Position(Position*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void>)0x00424D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004527C0
    /// void __thiscall Position::Position(Position*,unsigned int,const Frame*)</code>
    /// </summary>
    public void _ConstructorInternal(uint cellID, ACBindings.Internal.Frame* newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint, ACBindings.Internal.Frame*, void>)0x004527C0)(ref this, cellID, newFrame);

    /// <summary>
    /// <code>Offset: 0x004527F0
    /// unsigned int __thiscall Position::get_outside_cell_id(Position*)</code>
    /// </summary>
    public uint get_outside_cell_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint>)0x004527F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00452830
    /// AC1Legacy::Vector3* __thiscall Position::localtolocal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtolocal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452830)(ref this, result, p, v);

    /// <summary>
    /// <code>Offset: 0x00452900
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452900)(ref this, result, p);

    /// <summary>
    /// <code>Offset: 0x004529E0
    /// void __thiscall Position::Position(Position*,const Position*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Position* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, void>)0x004529E0)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x004562A0
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004562A0)(ref this, result, p, v);

    /// <summary>
    /// <code>Offset: 0x00456340
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00456340)(ref this, result, v);

    /// <summary>
    /// <code>Offset: 0x005054A0
    /// void __thiscall Position::adjust_to_outside(Position*)</code>
    /// </summary>
    public void adjust_to_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void>)0x005054A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050AA30
    /// AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AA30)(ref this, result, p);

    /// <summary>
    /// <code>Offset: 0x0050CEF0
    /// AC1Legacy::Vector3* __thiscall Position::globaltolocalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050CEF0)(ref this, result, v);

    /// <summary>
    /// <code>Offset: 0x0050E3F0
    /// AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050E3F0)(ref this, result, p, v);

    /// <summary>
    /// <code>Offset: 0x005566B0
    /// Frame* __thiscall Position::subtract2(Position*,Frame*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.Frame* subtract2(ACBindings.Internal.Frame* result, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Frame*, ACBindings.Internal.Position*, ACBindings.Internal.Frame*>)0x005566B0)(ref this, result, p2);

    /// <summary>
    /// <code>Offset: 0x005AA3E0
    /// unsigned int __thiscall Position::ToString(Position*,char*,const unsigned int)</code>
    /// </summary>
    public uint ToString(sbyte* buf, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, sbyte*, uint, uint>)0x005AA3E0)(ref this, buf, size);

    /// <summary>
    /// <code>Offset: 0x005AA460
    /// int __thiscall Position::FromString(Position*,const char*)</code>
    /// </summary>
    public int FromString(sbyte* buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, sbyte*, int>)0x005AA460)(ref this, buf);

    /// <summary>
    /// <code>Offset: 0x005AA510
    /// unsigned int __thiscall Position::pack_size(Position*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint>)0x005AA510)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AA530
    /// int __thiscall Position::IsValid(Position*)</code>
    /// </summary>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, int>)0x005AA530)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AA560
    /// float __thiscall Position::distance(Position*,const Position*)</code>
    /// </summary>
    public float distance(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA560)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x005AA5A0
    /// float __thiscall Position::xy_distance(Position*,const Position*)</code>
    /// </summary>
    public float xy_distance(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA5A0)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x005AA5D0
    /// float __thiscall Position::heading(Position*,const Position*)</code>
    /// </summary>
    public float heading(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA5D0)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x005AA630
    /// unsigned int __thiscall Position::determine_quadrant(Position*,float,const Position*)</code>
    /// </summary>
    public uint determine_quadrant(float height, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, float, ACBindings.Internal.Position*, uint>)0x005AA630)(ref this, height, p);

    /// <summary>
    /// <code>Offset: 0x005AA6F0
    /// unsigned int __thiscall Position::Pack(Position*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, uint>)0x005AA6F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA740
    /// int __thiscall Position::UnPack(Position*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, int>)0x005AA740)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA7A0
    /// void __thiscall Position::Serialize(Position*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Archive*, void>)0x005AA7A0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x005AA7F0
    /// unsigned int __thiscall Position::PackOrigin(Position*,void**,unsigned int)</code>
    /// </summary>
    public uint PackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, uint>)0x005AA7F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA840
    /// int __thiscall Position::UnPackOrigin(Position*,void**,unsigned int)</code>
    /// </summary>
    public int UnPackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, int>)0x005AA840)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA8A0
    /// float __cdecl Position::cylinder_distance(float,float,const Position*,float,float,const Position*)</code>
    /// </summary>
    public static float cylinder_distance(float r1, float h1, ACBindings.Internal.Position* p1, float r2, float h2, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.Position*, float, float, ACBindings.Internal.Position*, float>)0x005AA8A0)(r1, h1, p1, r2, h2, p2);

    /// <summary>
    /// <code>Offset: 0x005AA960
    /// float __cdecl Position::cylinder_distance_no_z(float,const Position*,float,const Position*)</code>
    /// </summary>
    public static float cylinder_distance_no_z(float r1, ACBindings.Internal.Position* p1, float r2, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Cdecl]<float, ACBindings.Internal.Position*, float, ACBindings.Internal.Position*, float>)0x005AA960)(r1, p1, r2, p2);

    /// <summary>
    /// <code>Offset: 0x005AA9B0
    /// int* __thiscall Position::ToDisplayString(int,int*)</code>
    /// </summary>
    public int* ToDisplayString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, int*, int*>)0x005AA9B0)(ref this, a2);
}

