namespace ACBindings.Internal;

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
    public ACBindings.Internal.AC1Legacy.Vector3 m_fOrigin;

    // Generated Constructor
    public Frame() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the Frame object with an identity quaternion and a zero origin position, then caches its state.
    /// <code>Offset: 0x00424CE0
    /// void __thiscall Frame::Frame(Frame*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00424CE0)(ref this);

    /// <summary>Compares this frame with another, returning true when the origin vectors match within a small tolerance and the quaternion orientations are equal.
    /// <code>Offset: 0x00424E90
    /// int __thiscall Frame::is_equal(Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="rhs">The frame to compare against.</param>
    /// <returns>Non‑zero if both frames are equivalent; zero otherwise.</returns>
    public int is_equal(ACBindings.Internal.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, int>)0x00424E90)(ref this, rhs);

    /// <summary>Compares quaternion components of this frame with another, determining if they are effectively equal within a small tolerance.
    /// <code>Offset: 0x00424ED0
    /// int __thiscall Frame::is_quaternion_equal(Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="rhs">The frame whose quaternion to compare against.</param>
    /// <returns>Non-zero if all quaternion components differ by less than 0.0002; otherwise zero.</returns>
    public int is_quaternion_equal(ACBindings.Internal.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, int>)0x00424ED0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x00452530
    /// AC1Legacy::Vector3* __thiscall Frame::localtoglobalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452530)(ref this, result, in_);

    /// <summary>
    /// <code>Offset: 0x00452590
    /// AC1Legacy::Vector3* __thiscall Frame::globaltolocalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452590)(ref this, result, in_);

    /// <summary>
    /// <code>Offset: 0x004525F0
    /// void __thiscall Frame::rotate(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void rotate(ACBindings.Internal.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004525F0)(ref this, w);

    /// <summary>
    /// <code>Offset: 0x00452660
    /// AC1Legacy::Vector3* __thiscall Frame::localtoglobal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452660)(ref this, result, in_);

    /// <summary>
    /// <code>Offset: 0x004526C0
    /// AC1Legacy::Vector3* __thiscall Frame::globaltolocal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004526C0)(ref this, result, in_);

    /// <summary>
    /// <code>Offset: 0x00455E90
    /// int __cdecl Frame::close_rotation(const Frame*,const Frame*,const float)</code>
    /// </summary>
    public static int close_rotation(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2, float epsilon) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, int>)0x00455E90)(f1, f2, epsilon);

    /// <summary>
    /// <code>Offset: 0x00512DE0
    /// void __thiscall Frame::combine(Frame*,const Frame*,const Frame*)</code>
    /// </summary>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, void>)0x00512DE0)(ref this, f1, f2);

    /// <summary>
    /// <code>Offset: 0x00519B00
    /// void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2, ACBindings.Internal.AC1Legacy.Vector3* scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00519B00)(ref this, f1, f2, scale);

    /// <summary>
    /// <code>Offset: 0x00525D80
    /// void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*)</code>
    /// </summary>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, void>)0x00525D80)(ref this, f1, f2);

    /// <summary>
    /// <code>Offset: 0x00535B30
    /// void __thiscall Frame::cache(Frame*)</code>
    /// </summary>
    public void cache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00535B30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00535C10
    /// int __thiscall Frame::IsValid(Frame*)</code>
    /// </summary>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int>)0x00535C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00535D20
    /// int __thiscall Frame::IsValidExceptForHeading(Frame*)</code>
    /// </summary>
    public int IsValidExceptForHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int>)0x00535D20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00535DC0
    /// void __thiscall Frame::set_rotate(Frame*,float,float,float,float)</code>
    /// </summary>
    public void set_rotate(float new_qw, float new_qx, float new_qy, float new_qz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, float, float, float, void>)0x00535DC0)(ref this, new_qw, new_qx, new_qy, new_qz);

    /// <summary>
    /// <code>Offset: 0x00535E70
    /// unsigned int __thiscall Frame::Pack(Frame*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void**, uint, uint>)0x00535E70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00535EE0
    /// int __thiscall Frame::UnPack(Frame*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void**, uint, int>)0x00535EE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00535F70
    /// void __thiscall Frame::Serialize(Frame*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Archive*, void>)0x00535F70)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00536030
    /// void __thiscall Frame::interpolate_origin(Frame*,const Frame*,const Frame*,float)</code>
    /// </summary>
    public void interpolate_origin(ACBindings.Internal.Frame* from, ACBindings.Internal.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, void>)0x00536030)(ref this, from, to, t);

    /// <summary>
    /// <code>Offset: 0x005360D0
    /// void __thiscall Frame::interpolate_rotation(Frame*,const Frame*,const Frame*,float)</code>
    /// </summary>
    public void interpolate_rotation(ACBindings.Internal.Frame* from, ACBindings.Internal.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, void>)0x005360D0)(ref this, from, to, t);

    /// <summary>
    /// <code>Offset: 0x00536260
    /// void __thiscall Frame::subtract1(Frame*,const Frame*,const AFrame*)</code>
    /// </summary>
    public void subtract1(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, void>)0x00536260)(ref this, f1, f2);

    /// <summary>
    /// <code>Offset: 0x00536390
    /// void __thiscall Frame::subtract2(Frame*,const Frame*,const Frame*)</code>
    /// </summary>
    public void subtract2(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, void>)0x00536390)(ref this, f1, f2);

    /// <summary>
    /// <code>Offset: 0x00536460
    /// AC1Legacy::Vector3* __thiscall Frame::get_vector_heading(Frame*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_vector_heading(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00536460)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x005364A0
    /// float __thiscall Frame::get_heading(Frame*)</code>
    /// </summary>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float>)0x005364A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005364E0
    /// void __thiscall Frame::grotate(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void grotate(ACBindings.Internal.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005364E0)(ref this, w);

    /// <summary>
    /// <code>Offset: 0x00536610
    /// void __thiscall Frame::cache_quaternion(Frame*)</code>
    /// </summary>
    public void cache_quaternion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00536610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536780
    /// void __thiscall Frame::rotate_around_axis_to_vector(Frame*,int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void rotate_around_axis_to_vector(int axis_num, ACBindings.Internal.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00536780)(ref this, axis_num, dir);

    /// <summary>
    /// <code>Offset: 0x00536930
    /// void __thiscall Frame::euler_set_rotate(Frame*,float,float,float,int)</code>
    /// </summary>
    public void euler_set_rotate(float x, float y, float z, int order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, float, float, int, void>)0x00536930)(ref this, x, y, z, order);

    /// <summary>
    /// <code>Offset: 0x00536AF0
    /// void __thiscall Frame::set_vector_heading(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_vector_heading(ACBindings.Internal.AC1Legacy.Vector3* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00536AF0)(ref this, heading);

    /// <summary>
    /// <code>Offset: 0x00536B80
    /// void __thiscall Frame::set_heading(Frame*,float)</code>
    /// </summary>
    public void set_heading(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, void>)0x00536B80)(ref this, degrees);
}

