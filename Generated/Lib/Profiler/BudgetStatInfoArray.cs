namespace ACBindings;

// BudgetStatInfoArray
public unsafe struct BudgetStatInfoArray : System.IDisposable
{
    // Statics
    public static ACBindings.BudgetStatInfo* s_BudgetStatInfo = (ACBindings.BudgetStatInfo*)0x008F20B0;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BudgetStatInfoArray::~BudgetStatInfoArray(BudgetStatInfoArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BudgetStatInfoArray, void>)0x005DA490)(ref this);
}

