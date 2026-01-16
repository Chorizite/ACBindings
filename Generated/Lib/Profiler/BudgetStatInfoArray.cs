namespace ACBindings.Internal;


/// <summary>Manages a collection of BudgetStatInfo instances, ensuring proper lifecycle through reference counting and deallocation.</summary>
/// <remarks>Upon destruction, releases all stored objects, decrementing their references and freeing memory to maintain resource integrity.</remarks>
public unsafe struct BudgetStatInfoArray : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.BudgetStatInfo*** s_BudgetStatInfo = (ACBindings.Internal.BudgetStatInfo***)0x008F20B0;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a BudgetStatInfoArray instance by releasing all stored budget stat info objects, decrementing reference counts, and freeing allocated memory.
    /// <code>Offset: 0x005DA490
    /// void __thiscall BudgetStatInfoArray::~BudgetStatInfoArray(BudgetStatInfoArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BudgetStatInfoArray, void>)0x005DA490)(ref this);
}

