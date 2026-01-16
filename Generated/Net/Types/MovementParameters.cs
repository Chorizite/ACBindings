namespace ACBindings.Internal;


/// <summary>Specifies movement behavior settings for an entity, including distance thresholds, desired heading, speed control, failure conditions, walking/running transition points, context identifiers, key bindings, and action timestamps.</summary>
public unsafe struct MovementParameters
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MovementParameters_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void> MovementParameters_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementParameters*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes a MovementParameters instance with default values for distance limits, speed, heading, and control flags.
    /// <code>Offset: 0x00524F80
    /// void __thiscall MovementParameters::MovementParameters(MovementParameters*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void>)0x00524F80)(ref this);

    /// <summary>Calculates movement directives by comparing the current distance against configured thresholds, setting a command code and a retreat flag accordingly.
    /// <code>Offset: 0x0052B5B0
    /// void __thiscall MovementParameters::towards_and_away(MovementParameters*,float,float,unsigned int*,int*)</code>
    /// </summary>
    /// <param name="curr_distance">Current measured distance to the target object.</param>
    /// <param name="curr_heading">Heading angle toward the target; currently unused in this logic.</param>
    /// <param name="command">Pointer where the function writes a movement command identifier.</param>
    /// <param name="moving_away">Pointer that receives 1 if the entity should retreat, or 0 otherwise.</param>
    public void towards_and_away(float curr_distance, float curr_heading, uint* command, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, float, float, uint*, int*, void>)0x0052B5B0)(ref this, curr_distance, curr_heading, command, moving_away);

    /// <summary>Determines the movement command for an entity by comparing its current distance and heading to target thresholds stored in the parameters. Based on internal flags, it sets a command code, indicates whether the entity should move away, and specifies a hold key such as run or none.
    /// <code>Offset: 0x0052B610
    /// void __thiscall MovementParameters::get_command(MovementParameters*,float,float,unsigned int*,HoldKey*,int*)</code>
    /// </summary>
    /// <param name="curr_distance">Current distance from the entity to the target object.</param>
    /// <param name="curr_heading">Current heading angle of the entity relative to the target.</param>
    /// <param name="command">Output pointer receiving the movement command identifier.</param>
    /// <param name="key">Output pointer receiving the hold key state (e.g., run or none).</param>
    /// <param name="moving_away">Output pointer indicating whether the entity should move away from the target (1) or not (0).</param>
    public void get_command(float curr_distance, float curr_heading, uint* command, ACBindings.Internal.HoldKey* key, int* moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, float, float, uint*, ACBindings.Internal.HoldKey*, int*, void>)0x0052B610)(ref this, curr_distance, curr_heading, command, key, moving_away);

    /// <summary>Determines the desired movement heading based on a command identifier and whether the entity is moving away.
    /// <code>Offset: 0x0052B6E0
    /// float __thiscall MovementParameters::get_desired_heading(MovementParameters*,unsigned int,int)</code>
    /// </summary>
    /// <param name="command">Identifier that specifies the type of movement command; specific values trigger forward or backward behavior.</param>
    /// <param name="moving_away">True if the movement should be in the opposite direction to the default for the command, otherwise false.</param>
    /// <returns>The desired heading angle in degrees (0 or 180).</returns>
    public float get_desired_heading(uint command, int moving_away) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, uint, int, float>)0x0052B6E0)(ref this, command, moving_away);

    /// <summary>Packs movement parameters into the supplied buffer, advancing the buffer pointer for each written field.
    /// <code>Offset: 0x0052B730
    /// unsigned int __thiscall MovementParameters::Pack(MovementParameters*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory location where packed data will be written; updated to point after the last byte written.</param>
    /// <param name="size">Available space in bytes at the address pointed to by addr; packing occurs only if size is large enough to hold all fields.</param>
    /// <returns>The total number of bytes reserved for the packed parameters, which is 40.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void**, uint, uint>)0x0052B730)(ref this, addr, size);

    /// <summary>Deserializes a MovementParameters object from a byte stream, advancing the input pointer.
    /// <code>Offset: 0x0052B7D0
    /// int __thiscall MovementParameters::UnPack(MovementParameters*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated after each field is read.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 0x28 for successful deserialization.</param>
    /// <returns>Non‑zero if unpacking succeeded, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, void**, uint, int>)0x0052B7D0)(ref this, addr, size);

    /// <summary>Unpacks movement parameters from a network buffer into this MovementParameters instance based on the specified MovementTypes::Type. The function reads a fixed number of bytes depending on the type, updates relevant fields, and advances the address pointer. Returns 1 on success or 0 if the type is unsupported or insufficient data remains.
    /// <code>Offset: 0x0052B860
    /// int __thiscall MovementParameters::UnPackNet(MovementParameters*,MovementTypes::Type,void**,unsigned int)</code>
    /// </summary>
    /// <param name="type">Movement type determining how many parameters are unpacked.</param>
    /// <param name="addr">Pointer to buffer containing packed movement data; advanced as data is read.</param>
    /// <param name="size">Remaining size of the buffer in bytes; must be sufficient for the expected number of parameters.</param>
    /// <returns>1 if parameters were successfully unpacked; 0 otherwise.</returns>
    public int UnPackNet(ACBindings.Internal.MovementTypes.Type type, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementParameters, ACBindings.Internal.MovementTypes.Type, void**, uint, int>)0x0052B860)(ref this, type, addr, size);
}

