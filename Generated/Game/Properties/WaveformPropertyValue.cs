namespace ACBindings;

// WaveformPropertyValue
public unsafe struct WaveformPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.Waveform m_value;

    // Methods
    // bool __thiscall WaveformPropertyValue::FromFileNode(WaveformPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425710)(ref this, desc, node);
    // bool __thiscall WaveformPropertyValue::ToFileNode(WaveformPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425740)(ref this, desc, node);
    // bool __thiscall WaveformPropertyValue::InqWaveform(WaveformPropertyValue*,Waveform*)
    public byte InqWaveform(ACBindings.Waveform* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.Waveform*, byte>)0x00425760)(ref this, value);
    // bool __thiscall WaveformPropertyValue::SetWaveform(WaveformPropertyValue*,const Waveform*)
    public byte SetWaveform(ACBindings.Waveform* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.Waveform*, byte>)0x004257D0)(ref this, value);
    // bool __thiscall WaveformPropertyValue::SetValue(WaveformPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00425820)(ref this, value);
    // bool __thiscall WaveformPropertyValue::Compare(WaveformPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00425840)(ref this, p);
    // bool __thiscall WaveformPropertyValue::InqLessThan(WaveformPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00425990)(ref this, i_pcRHS, o_rbLessThan);
    // BasePropertyValue* __thiscall WaveformPropertyValue::Copy(WaveformPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.BasePropertyValue*>)0x004259F0)(ref this);
    // void __thiscall WaveformPropertyValue::Serialize(WaveformPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, ACBindings.Archive*, uint, void>)0x00425A30)(ref this, io_archive, i_eName);
    // char __thiscall WaveformPropertyValue::GetValueAsString(void*,int,LONG*,int)
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveformPropertyValue, int, int*, int, sbyte>)0x00426880)(ref this, a2, a3, a4);
}

