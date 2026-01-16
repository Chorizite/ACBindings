namespace ACBindings.Internal;


/// <summary>Represents waveform parameters used to generate audio or visual signals, including base value, amplitude, phase, frequency and roughness, each optionally varying over time.</summary>
public unsafe struct Waveform
{
    // Members
    public ACBindings.Internal.WaveformType type;
    public float base_;
    public float base_vel;
    public float amplitude;
    public float amplitude_vel;
    public float phase;
    public float phase_vel;
    public float frequency;
    public float frequency_vel;
    public float roughness;
    public float roughness_vel;

    // Generated Constructor
    public Waveform() {
        _ConstructorInternal();
    }
    public Waveform(float base_) {
        _ConstructorInternal(base_);
    }

    // Methods

    /// <summary>Resets all waveform properties to their default values, including type, base, amplitude, phase, frequency, roughness, and their velocity components.
    /// <code>Offset: 0x005B1FE0
    /// void __thiscall Waveform::SetDefaults(Waveform*)</code>
    /// </summary>
    public void SetDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, void>)0x005B1FE0)(ref this);

    /// <summary>Computes the waveform’s value for a given phase offset at the specified elapsed time, incorporating amplitude, frequency, roughness, and velocity parameters based on the waveform type.
    /// <code>Offset: 0x005B2010
    /// float __thiscall Waveform::GetValueForPhase(Waveform*,const float,const long double)</code>
    /// </summary>
    /// <param name="p">Phase offset applied to the waveform’s internal phase before evaluation.</param>
    /// <param name="time">Elapsed time used to apply velocity-based changes and time‑dependent components.</param>
    /// <returns>The calculated float value of the waveform at that phase and time.</returns>
    public float GetValueForPhase(float p, double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, float, double, float>)0x005B2010)(ref this, p, time);

    /// <summary>Computes and returns the current value of this waveform at the specified time, using its internal parameters such as amplitude, frequency, phase offset, etc.
    /// <code>Offset: 0x005B2230
    /// float __thiscall Waveform::GetValue(Waveform*,const long double)</code>
    /// </summary>
    /// <param name="time">The point in time at which to evaluate the waveform.</param>
    /// <returns>The calculated waveform value as a float.</returns>
    public float GetValue(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, double, float>)0x005B2230)(ref this, time);

    /// <summary>Initializes waveform properties to default values, setting type to none and numeric fields to baseline constants.
    /// <code>Offset: 0x005B2250
    /// void __thiscall Waveform::Waveform(Waveform*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, void>)0x005B2250)(ref this);

    /// <summary>Initializes a new Waveform instance with default settings and assigns the supplied base value.
    /// <code>Offset: 0x005B2280
    /// void __thiscall Waveform::Waveform(Waveform*,const float)</code>
    /// </summary>
    /// <param name="base">The initial base level for the waveform.</param>
    public void _ConstructorInternal(float base_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, float, void>)0x005B2280)(ref this, base_);

    /// <summary>Serializes or deserializes the waveform parameters to or from an Archive according to the archive's flags.
    /// <code>Offset: 0x005B22C0
    /// void __thiscall Waveform::Serialize(Waveform*,Archive*)</code>
    /// </summary>
    /// <param name="ar">Archive used for the operation; when its m_flags bit 0 is set, writes the current Waveform data into the archive, otherwise reads data into the Waveform instance.</param>
    public void Serialize(ACBindings.Internal.Archive* ar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.Archive*, void>)0x005B22C0)(ref this, ar);

    /// <summary>Parses a waveform definition from the supplied file node, populating the Waveform structure with type and numeric parameters such as base, amplitude, phase, frequency, roughness, and their velocity components.
    /// <code>Offset: 0x005B2300
    /// bool __thiscall Waveform::Parse(Waveform*,const PFileNode*)</code>
    /// </summary>
    /// <param name="baseNode">Root file node containing waveform information; may represent either a simple value or a complex node with sub‑nodes specifying each parameter.</param>
    /// <returns>True if the waveform was parsed successfully; otherwise false after reporting an error to the node.</returns>
    public byte Parse(ACBindings.Internal.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.PFileNode*, byte>)0x005B2300)(ref this, baseNode);

    /// <summary>Obtains a human‑readable name for the waveform type stored in this Waveform instance, storing the result in *a2 and returning that pointer.
    /// <code>Offset: 0x005B27A0
    /// int* __thiscall Waveform::GetTypeString(int*,int*)</code>
    /// </summary>
    /// <param name="this">Reference to the Waveform object whose type is queried.</param>
    /// <param name="a2">Output parameter receiving the address of the string representation of the waveform type.</param>
    /// <returns>Pointer to the string describing the waveform type, or a reference‑counted string for the None type.</returns>
    public int* GetTypeString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, int*, int*>)0x005B27A0)(ref this, a2);

    /// <summary>Serializes a waveform into a hierarchical file structure represented by a PFileNode tree. When the waveform has no type (WAVEFORM_NONE), it stores only the base value; otherwise, it creates child nodes for each property—base, amplitude, phase, frequency, roughness and their velocities—and writes them as floating‑point values.
    /// <code>Offset: 0x005B28A0
    /// void __thiscall Waveform::Output(Waveform*,PFileNode*)</code>
    /// </summary>
    /// <param name="baseNode">The node under which the waveform data will be written. The method adds subnodes representing each waveform attribute.</param>
    public void Output(ACBindings.Internal.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.PFileNode*, void>)0x005B28A0)(ref this, baseNode);

    /// <summary>Converts the Waveform instance into a readable string representation and stores it in the supplied buffer.
    /// <code>Offset: 0x005B2C30
    /// int* __thiscall Waveform::ToString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer that will receive the address of the resulting string object.</param>
    /// <returns>The same pointer passed as a2, pointing to the formatted waveform description.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, int*, int*>)0x005B2C30)(ref this, a2);
}

