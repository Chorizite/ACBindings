namespace ACBindings.Internal;


/// <summary>Tracks the in‑game calendar, mapping elapsed time onto years, seasons, days and times of day while supporting daylight cycle transitions and global event scheduling.</summary>
public unsafe struct GameTime : System.IDisposable
{
    // Statics
    public static double* global_next_event = (double*)0x008EE9C0;
    public static ACBindings.Internal.GameTime** current_game_time = (ACBindings.Internal.GameTime**)0x008EE9C8;

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

    /// <summary>Computes the current year, day number, season index, and beginning‑of‑day timestamp for a given game time.
    /// <code>Offset: 0x005A7510
    /// void __thiscall GameTime::CalcDayBegin(GameTime*,long double)</code>
    /// </summary>
    /// <param name="time">Elapsed game time in long double units relative to the calendar’s zero point.</param>
    public void CalcDayBegin(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, double, void>)0x005A7510)(ref this, time);

    /// <summary>Determines the current time‑of‑day phase and schedules the next event based on a given absolute time, updating internal state such as current_time_of_day, present_time_in_day_unit, and time_of_next_event.
    /// <code>Offset: 0x005A75B0
    /// void __thiscall GameTime::CalcTimeOfDay(GameTime*,long double)</code>
    /// </summary>
    /// <param name="time">The absolute time value (in seconds or equivalent) at which to evaluate the time of day.</param>
    public void CalcTimeOfDay(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, double, void>)0x005A75B0)(ref this, time);

    /// <summary>Formats a human‑readable date string and a time‑of‑day string from supplied game‑time indices and writes them into the provided buffers. If the resulting strings would exceed the buffer capacity, each output is replaced with a single space character.
    /// <code>Offset: 0x005A7640
    /// void __thiscall GameTime::GetDateTimeString(GameTime*,char*,char*,const int,const int,const int,const int,const int)</code>
    /// </summary>
    /// <param name="date_string">Output buffer that receives the formatted date string.</param>
    /// <param name="time_string">Output buffer that receives the formatted time‑of‑day string.</param>
    /// <param name="year">Game year index to include in the date string.</param>
    /// <param name="season">Index of the current season, used for the season name and day calculation.</param>
    /// <param name="weekday">Unused; present for interface compatibility.</param>
    /// <param name="day">Day number within the current season, combined with the season’s start to produce the day of season number.</param>
    /// <param name="time_of_day">Index into the times_of_day array used to retrieve the time‑of‑day name.</param>
    public void GetDateTimeString(sbyte* date_string, sbyte* time_string, int year, int season, int weekday, int day, int time_of_day) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, sbyte*, sbyte*, int, int, int, int, int, void>)0x005A7640)(ref this, date_string, time_string, year, season, weekday, day, time_of_day);

    /// <summary>Initializes a new GameTime instance by resetting all internal counters, clearing collections, and assigning the default shared null string buffer for year_spec.
    /// <code>Offset: 0x005A7770
    /// void __thiscall GameTime::GameTime(GameTime*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7770)(ref this);

    /// <summary>Updates the GameTime instance’s internal clock by computing present time‑of‑day, handling day transitions, and scheduling the next global event based on current system time and configured offsets.
    /// <code>Offset: 0x005A7800
    /// void __thiscall GameTime::UseTime(GameTime*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7800)(ref this);

    /// <summary>Formats the current game date and time into separate string buffers.
    /// <code>Offset: 0x005A78B0
    /// void __thiscall GameTime::GetDateTimeString(GameTime*,char*,char*)</code>
    /// </summary>
    /// <param name="date_string">Buffer to receive the formatted date representation, incorporating year, season, weekday, and day.</param>
    /// <param name="time_string">Buffer to receive the formatted time-of-day representation based on the game's internal clock.</param>
    public void GetDateTimeString(sbyte* date_string, sbyte* time_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, sbyte*, sbyte*, void>)0x005A78B0)(ref this, date_string, time_string);

    /// <summary>Destroys a GameTime instance by releasing all allocated resources and resetting internal state.
    /// <code>Offset: 0x005A78E0
    /// void __thiscall GameTime::Destroy(GameTime*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A78E0)(ref this);

    /// <summary>Computes the total number of bytes required to serialize a GameTime instance, including its variable‑length string fields and the contents of its times_of_day, days_of_the_week, and seasons arrays.
    /// <code>Offset: 0x005A7A60
    /// unsigned int __thiscall GameTime::pack_size(GameTime*)</code>
    /// </summary>
    /// <returns>The size in bytes needed for packing this GameTime object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, uint>)0x005A7A60)(ref this);

    /// <summary>Packs the GameTime state into a contiguous byte buffer for serialization.
    /// <code>Offset: 0x005A7BD0
    /// unsigned int __thiscall GameTime::Pack(GameTime*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that receives the address of the next free position in the output buffer; updated as data is written.</param>
    /// <param name="size">Pointer to an unsigned integer containing the number of bytes available in the buffer before packing; updated with the remaining space after packing completes.</param>
    /// <returns>Remaining byte count in the buffer after serialization, or 0 if no space left.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void**, uint*, uint>)0x005A7BD0)(ref this, addr, size);

    /// <summary>Cleans up dynamic resources associated with a GameTime instance, releasing season, weekday, and time-of-day arrays and managing the lifetime of the reference‑counted year specification string.
    /// <code>Offset: 0x005A7F80
    /// void __thiscall GameTime::~GameTime(GameTime*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void>)0x005A7F80)(ref this);

    /// <summary>Deserializes a GameTime object from the provided binary buffer, reading primitive fields, strings, and arrays of TimeOfDay, WeekDay, and Season instances while advancing the address pointer and reducing the remaining byte count.
    /// <code>Offset: 0x005A7FD0
    /// int __thiscall GameTime::UnPack(GameTime*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; updated as data is consumed.</param>
    /// <param name="size">Pointer to the number of bytes remaining in the buffer; decremented by the amount read during unpacking.</param>
    /// <returns>Zero on successful deserialization; non‑zero if an error occurs or the buffer contains unexpected data.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameTime, void**, uint*, int>)0x005A7FD0)(ref this, addr, size);
}

