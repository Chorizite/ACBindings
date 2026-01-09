namespace ACBindings;

// Frame
public unsafe struct Frame
{
    // Child Types
    // Frame::FrameInitializationEnum
    public enum FrameInitializationEnum : uint
    {
    }

    // Members
    public float qw;
    public float qx;
    public float qy;
    public float qz;
    public fixed float m_fl2gv[9];
    public ACBindings.AC1Legacy.Vector3 m_fOrigin;

    // Generated Constructor
    public Frame() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall Frame::Frame(Frame*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, void>)0x00424CE0)(ref this);
    // int __thiscall Frame::is_equal(Frame*,const Frame*)
    public int is_equal(ACBindings.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, int>)0x00424E90)(ref this, rhs);
    // int __thiscall Frame::is_quaternion_equal(Frame*,const Frame*)
    public int is_quaternion_equal(ACBindings.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, int>)0x00424ED0)(ref this, rhs);
    // AC1Legacy::Vector3* __thiscall Frame::localtoglobalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* localtoglobalvec(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00452530)(ref this, result, in_);
    // AC1Legacy::Vector3* __thiscall Frame::globaltolocalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* globaltolocalvec(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00452590)(ref this, result, in_);
    // void __thiscall Frame::rotate(Frame*,const AC1Legacy::Vector3*)
    public void rotate(ACBindings.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, void>)0x004525F0)(ref this, w);
    // AC1Legacy::Vector3* __thiscall Frame::localtoglobal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* localtoglobal(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00452660)(ref this, result, in_);
    // AC1Legacy::Vector3* __thiscall Frame::globaltolocal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* globaltolocal(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x004526C0)(ref this, result, in_);
    // int __cdecl Frame::close_rotation(const Frame*,const Frame*,const float)
    public static int close_rotation(ACBindings.Frame* f1, ACBindings.Frame* f2, float epsilon) => ((delegate* unmanaged[Cdecl]<ACBindings.Frame*, ACBindings.Frame*, float, int>)0x00455E90)(f1, f2, epsilon);
    // void __thiscall Frame::combine(Frame*,const Frame*,const Frame*)
    public void combine(ACBindings.Frame* f1, ACBindings.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.Frame*, void>)0x00512DE0)(ref this, f1, f2);
    // void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*,const AC1Legacy::Vector3*)
    public void combine(ACBindings.Frame* f1, ACBindings.AFrame* f2, ACBindings.AC1Legacy.Vector3* scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.AFrame*, ACBindings.AC1Legacy.Vector3*, void>)0x00519B00)(ref this, f1, f2, scale);
    // void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*)
    public void combine(ACBindings.Frame* f1, ACBindings.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.AFrame*, void>)0x00525D80)(ref this, f1, f2);
    // void __thiscall Frame::cache(Frame*)
    public void cache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, void>)0x00535B30)(ref this);
    // int __thiscall Frame::IsValid(Frame*)
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, int>)0x00535C10)(ref this);
    // int __thiscall Frame::IsValidExceptForHeading(Frame*)
    public int IsValidExceptForHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, int>)0x00535D20)(ref this);
    // void __thiscall Frame::set_rotate(Frame*,float,float,float,float)
    public void set_rotate(float new_qw, float new_qx, float new_qy, float new_qz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, float, float, float, float, void>)0x00535DC0)(ref this, new_qw, new_qx, new_qy, new_qz);
    // unsigned int __thiscall Frame::Pack(Frame*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, void**, uint, uint>)0x00535E70)(ref this, addr, size);
    // int __thiscall Frame::UnPack(Frame*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, void**, uint, int>)0x00535EE0)(ref this, addr, size);
    // void __thiscall Frame::Serialize(Frame*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Archive*, void>)0x00535F70)(ref this, io_archive);
    // void __thiscall Frame::interpolate_origin(Frame*,const Frame*,const Frame*,float)
    public void interpolate_origin(ACBindings.Frame* from, ACBindings.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.Frame*, float, void>)0x00536030)(ref this, from, to, t);
    // void __thiscall Frame::interpolate_rotation(Frame*,const Frame*,const Frame*,float)
    public void interpolate_rotation(ACBindings.Frame* from, ACBindings.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.Frame*, float, void>)0x005360D0)(ref this, from, to, t);
    // void __thiscall Frame::subtract1(Frame*,const Frame*,const AFrame*)
    public void subtract1(ACBindings.Frame* f1, ACBindings.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.AFrame*, void>)0x00536260)(ref this, f1, f2);
    // void __thiscall Frame::subtract2(Frame*,const Frame*,const Frame*)
    public void subtract2(ACBindings.Frame* f1, ACBindings.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.Frame*, ACBindings.Frame*, void>)0x00536390)(ref this, f1, f2);
    // AC1Legacy::Vector3* __thiscall Frame::get_vector_heading(Frame*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* get_vector_heading(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00536460)(ref this, result);
    // float __thiscall Frame::get_heading(Frame*)
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, float>)0x005364A0)(ref this);
    // void __thiscall Frame::grotate(Frame*,const AC1Legacy::Vector3*)
    public void grotate(ACBindings.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, void>)0x005364E0)(ref this, w);
    // void __thiscall Frame::cache_quaternion(Frame*)
    public void cache_quaternion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, void>)0x00536610)(ref this);
    // void __thiscall Frame::rotate_around_axis_to_vector(Frame*,int,const AC1Legacy::Vector3*)
    public void rotate_around_axis_to_vector(int axis_num, ACBindings.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, int, ACBindings.AC1Legacy.Vector3*, void>)0x00536780)(ref this, axis_num, dir);
    // void __thiscall Frame::euler_set_rotate(Frame*,float,float,float,int)
    public void euler_set_rotate(float x, float y, float z, int order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, float, float, float, int, void>)0x00536930)(ref this, x, y, z, order);
    // void __thiscall Frame::set_vector_heading(Frame*,const AC1Legacy::Vector3*)
    public void set_vector_heading(ACBindings.AC1Legacy.Vector3* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, ACBindings.AC1Legacy.Vector3*, void>)0x00536AF0)(ref this, heading);
    // void __thiscall Frame::set_heading(Frame*,float)
    public void set_heading(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Frame, float, void>)0x00536B80)(ref this, degrees);
}

