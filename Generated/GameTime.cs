namespace ACBindings.Internal;

public unsafe struct GameTime : System.IDisposable
{
    // Statics
    public static double* global_next_event = (double*)0x008EE9C0;
    public static ACBindings.Internal.GameTime* current_game_time = (ACBindings.Internal.GameTime*)0x008EE9C8;

    // Members
    public double zero_time_of_year;
    public int zero_year;
    public float day_length;
    public int days_per_year;
    public ACBindings.Internal.AC1Legacy.SmartArray___TimeOfDay_ptr times_of_day;
    public ACBindings.Internal.AC1Legacy.SmartArray___WeekDay_ptr days_of_the_week;
    public ACBindings.Internal.AC1Legacy.SmartArray___Season_ptr seasons;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte year_spec;
    public double year_length;
    public float present_time_of_day;
    public double time_of_day_begin;
    public double time_of_next_event;
    public float present_time_in_day_unit;
    public int current_year;
    public int current_day;
    public int current_season;
    public int current_week_day;
    public int current_time_of_day;
    public double clock_offset;
    public double time_zero_start_delta;

    // Generated Constructor
    public GameTime() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A7510
    /// void __thiscall GameTime::CalcDayBegin(GameTime*,long double)</code>
    /// </summary>
    public void CalcDayBegin(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, double, void>)0x005A7510)(ref this, time);

    /// <summary>
    /// <code>Offset: 0x005A75B0
    /// void __thiscall GameTime::CalcTimeOfDay(GameTime*,long double)</code>
    /// </summary>
    public void CalcTimeOfDay(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, double, void>)0x005A75B0)(ref this, time);

    /// <summary>
    /// <code>Offset: 0x005A7640
    /// void __thiscall GameTime::GetDateTimeString(GameTime*,char*,char*,const int,const int,const int,const int,const int)</code>
    /// </summary>
    public void GetDateTimeString(sbyte* date_string, sbyte* time_string, int year, int season, int weekday, int day, int time_of_day) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, sbyte*, sbyte*, int, int, int, int, int, void>)0x005A7640)(ref this, date_string, time_string, year, season, weekday, day, time_of_day);

    /// <summary>
    /// <code>Offset: 0x005A7770
    /// void __thiscall GameTime::GameTime(GameTime*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7770)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7800
    /// void __thiscall GameTime::UseTime(GameTime*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7800)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A78B0
    /// void __thiscall GameTime::GetDateTimeString(GameTime*,char*,char*)</code>
    /// </summary>
    public void GetDateTimeString(sbyte* date_string, sbyte* time_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, sbyte*, sbyte*, void>)0x005A78B0)(ref this, date_string, time_string);

    /// <summary>
    /// <code>Offset: 0x005A78E0
    /// void __thiscall GameTime::Destroy(GameTime*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A78E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7A60
    /// unsigned int __thiscall GameTime::pack_size(GameTime*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, uint>)0x005A7A60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7BD0
    /// unsigned int __thiscall GameTime::Pack(GameTime*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void**, uint*, uint>)0x005A7BD0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A7F80
    /// void __thiscall GameTime::~GameTime(GameTime*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7FD0
    /// int __thiscall GameTime::UnPack(GameTime*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void**, uint*, int>)0x005A7FD0)(ref this, addr, size);
}

