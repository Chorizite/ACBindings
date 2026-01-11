namespace ACBindings.Internal;

public unsafe struct MovementParameters
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MovementParameters_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void> MovementParameters_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal._7CC14DB3FCEC905CF11411CCBEFB9964 ___u1;
    public float distance_to_object;
    public float min_distance;
    public float desired_heading;
    public float speed;
    public float fail_distance;
    public float walk_run_threshhold;
    public uint context_id;
    public ACBindings.Internal.HoldKey hold_key_to_apply;
    public uint action_stamp;

    // Generated Constructor
    public MovementParameters() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00524F80
    /// void __thiscall MovementParameters::MovementParameters(MovementParameters*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void>)0x00524F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052B5B0
    /// void __thiscall MovementParameters::towards_and_away(MovementParameters*,float,float,unsigned int*,int*)</code>
    /// </summary>
    public void towards_and_away(float curr_distance, float curr_heading, uint* command, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, float, float, uint*, int*, void>)0x0052B5B0)(ref this, curr_distance, curr_heading, command, moving_away);

    /// <summary>
    /// <code>Offset: 0x0052B610
    /// void __thiscall MovementParameters::get_command(MovementParameters*,float,float,unsigned int*,HoldKey*,int*)</code>
    /// </summary>
    public void get_command(float curr_distance, float curr_heading, uint* command, ACBindings.Internal.HoldKey* key, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, float, float, uint*, ACBindings.Internal.HoldKey*, int*, void>)0x0052B610)(ref this, curr_distance, curr_heading, command, key, moving_away);

    /// <summary>
    /// <code>Offset: 0x0052B6E0
    /// float __thiscall MovementParameters::get_desired_heading(MovementParameters*,unsigned int,int)</code>
    /// </summary>
    public float get_desired_heading(uint command, int moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, uint, int, float>)0x0052B6E0)(ref this, command, moving_away);

    /// <summary>
    /// <code>Offset: 0x0052B730
    /// unsigned int __thiscall MovementParameters::Pack(MovementParameters*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void**, uint, uint>)0x0052B730)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052B7D0
    /// int __thiscall MovementParameters::UnPack(MovementParameters*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void**, uint, int>)0x0052B7D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052B860
    /// int __thiscall MovementParameters::UnPackNet(MovementParameters*,MovementTypes::Type,void**,unsigned int)</code>
    /// </summary>
    public int UnPackNet(ACBindings.Internal.MovementTypes.Type type, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, ACBindings.Internal.MovementTypes.Type, void**, uint, int>)0x0052B860)(ref this, type, addr, size);
}

