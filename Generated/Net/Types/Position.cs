namespace ACBindings;

// Position
public unsafe struct Position
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Position_vtbl
    public unsafe struct Position_vtbl
    {
        // Members
        public System.IntPtr Position_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint objcell_id;
    public ACBindings.Frame frame;

    // Generated Constructor
    public Position() {
        _ConstructorInternal();
    }
    public Position(uint cellID, ACBindings.Frame* newFrame) {
        _ConstructorInternal(cellID, newFrame);
    }
    public Position(ACBindings.Position* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall Position::Position(Position*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void>)0x00424D10)(ref this);
    // void __thiscall Position::Position(Position*,unsigned int,const Frame*)
    public void _ConstructorInternal(uint cellID, ACBindings.Frame* newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, uint, ACBindings.Frame*, void>)0x004527C0)(ref this, cellID, newFrame);
    // unsigned int __thiscall Position::get_outside_cell_id(Position*)
    public uint get_outside_cell_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, uint>)0x004527F0)(ref this);
    // AC1Legacy::Vector3* __thiscall Position::localtolocal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* localtolocal(ACBindings.AC1Legacy.Vector3* result, ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00452830)(ref this, result, p, v);
    // AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*)
    public ACBindings.AC1Legacy.Vector3* localtoglobal(ACBindings.AC1Legacy.Vector3* result, ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*>)0x00452900)(ref this, result, p);
    // void __thiscall Position::Position(Position*,const Position*)
    public void _ConstructorInternal(ACBindings.Position* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Position*, void>)0x004529E0)(ref this, that);
    // AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* localtoglobal(ACBindings.AC1Legacy.Vector3* result, ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x004562A0)(ref this, result, p, v);
    // AC1Legacy::Vector3* __thiscall Position::localtoglobalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* localtoglobalvec(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00456340)(ref this, result, v);
    // void __thiscall Position::adjust_to_outside(Position*)
    public void adjust_to_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void>)0x005054A0)(ref this);
    // AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*)
    public ACBindings.AC1Legacy.Vector3* get_offset(ACBindings.AC1Legacy.Vector3* result, ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*>)0x0050AA30)(ref this, result, p);
    // AC1Legacy::Vector3* __thiscall Position::globaltolocalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* globaltolocalvec(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x0050CEF0)(ref this, result, v);
    // AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* get_offset(ACBindings.AC1Legacy.Vector3* result, ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x0050E3F0)(ref this, result, p, v);
    // Frame* __thiscall Position::subtract2(Position*,Frame*,const Position*)
    public ACBindings.Frame* subtract2(ACBindings.Frame* result, ACBindings.Position* p2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Frame*, ACBindings.Position*, ACBindings.Frame*>)0x005566B0)(ref this, result, p2);
    // unsigned int __thiscall Position::ToString(Position*,char*,const unsigned int)
    public uint ToString(sbyte* buf, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, sbyte*, uint, uint>)0x005AA3E0)(ref this, buf, size);
    // int __thiscall Position::FromString(Position*,const char*)
    public int FromString(sbyte* buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, sbyte*, int>)0x005AA460)(ref this, buf);
    // unsigned int __thiscall Position::pack_size(Position*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, uint>)0x005AA510)(ref this);
    // int __thiscall Position::IsValid(Position*)
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, int>)0x005AA530)(ref this);
    // float __thiscall Position::distance(Position*,const Position*)
    public float distance(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Position*, float>)0x005AA560)(ref this, p);
    // float __thiscall Position::xy_distance(Position*,const Position*)
    public float xy_distance(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Position*, float>)0x005AA5A0)(ref this, p);
    // float __thiscall Position::heading(Position*,const Position*)
    public float heading(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Position*, float>)0x005AA5D0)(ref this, p);
    // unsigned int __thiscall Position::determine_quadrant(Position*,float,const Position*)
    public uint determine_quadrant(float height, ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, float, ACBindings.Position*, uint>)0x005AA630)(ref this, height, p);
    // unsigned int __thiscall Position::Pack(Position*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void**, uint, uint>)0x005AA6F0)(ref this, addr, size);
    // int __thiscall Position::UnPack(Position*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void**, uint, int>)0x005AA740)(ref this, addr, size);
    // void __thiscall Position::Serialize(Position*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, ACBindings.Archive*, void>)0x005AA7A0)(ref this, io_archive);
    // unsigned int __thiscall Position::PackOrigin(Position*,void**,unsigned int)
    public uint PackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void**, uint, uint>)0x005AA7F0)(ref this, addr, size);
    // int __thiscall Position::UnPackOrigin(Position*,void**,unsigned int)
    public int UnPackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, void**, uint, int>)0x005AA840)(ref this, addr, size);
    // float __cdecl Position::cylinder_distance(float,float,const Position*,float,float,const Position*)
    public static float cylinder_distance(float r1, float h1, ACBindings.Position* p1, float r2, float h2, ACBindings.Position* p2) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Position*, float, float, ACBindings.Position*, float>)0x005AA8A0)(r1, h1, p1, r2, h2, p2);
    // float __cdecl Position::cylinder_distance_no_z(float,const Position*,float,const Position*)
    public static float cylinder_distance_no_z(float r1, ACBindings.Position* p1, float r2, ACBindings.Position* p2) => ((delegate* unmanaged[Cdecl]<float, ACBindings.Position*, float, ACBindings.Position*, float>)0x005AA960)(r1, p1, r2, p2);
    // int* __thiscall Position::ToDisplayString(int,int*)
    public int* ToDisplayString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Position, int*, int*>)0x005AA9B0)(ref this, a2);
}

