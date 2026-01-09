namespace ACBindings;

// MovementParameters
public unsafe struct MovementParameters
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // MovementParameters_vtbl
    public unsafe struct MovementParameters_vtbl
    {
        // Members
        public System.IntPtr MovementParameters_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings._7CC14DB3FCEC905CF11411CCBEFB9964 ___u1;
    public float distance_to_object;
    public float min_distance;
    public float desired_heading;
    public float speed;
    public float fail_distance;
    public float walk_run_threshhold;
    public uint context_id;
    public ACBindings.HoldKey hold_key_to_apply;
    public uint action_stamp;

    // Generated Constructor
    public MovementParameters() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall MovementParameters::MovementParameters(MovementParameters*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, void>)0x00524F80)(ref this);
    // void __thiscall MovementParameters::towards_and_away(MovementParameters*,float,float,unsigned int*,int*)
    public void towards_and_away(float curr_distance, float curr_heading, uint* command, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, float, float, uint*, int*, void>)0x0052B5B0)(ref this, curr_distance, curr_heading, command, moving_away);
    // void __thiscall MovementParameters::get_command(MovementParameters*,float,float,unsigned int*,HoldKey*,int*)
    public void get_command(float curr_distance, float curr_heading, uint* command, ACBindings.HoldKey* key, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, float, float, uint*, ACBindings.HoldKey*, int*, void>)0x0052B610)(ref this, curr_distance, curr_heading, command, key, moving_away);
    // float __thiscall MovementParameters::get_desired_heading(MovementParameters*,unsigned int,int)
    public float get_desired_heading(uint command, int moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, uint, int, float>)0x0052B6E0)(ref this, command, moving_away);
    // unsigned int __thiscall MovementParameters::Pack(MovementParameters*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, void**, uint, uint>)0x0052B730)(ref this, addr, size);
    // int __thiscall MovementParameters::UnPack(MovementParameters*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, void**, uint, int>)0x0052B7D0)(ref this, addr, size);
    // int __thiscall MovementParameters::UnPackNet(MovementParameters*,MovementTypes::Type,void**,unsigned int)
    public int UnPackNet(ACBindings.MovementTypes.Type type, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementParameters, ACBindings.MovementTypes.Type, void**, uint, int>)0x0052B860)(ref this, type, addr, size);
}

