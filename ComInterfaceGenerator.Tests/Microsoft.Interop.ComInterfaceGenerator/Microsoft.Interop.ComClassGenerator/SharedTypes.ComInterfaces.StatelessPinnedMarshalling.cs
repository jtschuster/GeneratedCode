﻿// <auto-generated />
file sealed unsafe class ComClassInformation : global::System.Runtime.InteropServices.Marshalling.IComExposedClass
{
    private static volatile global::System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* s_vtables;
    public static global::System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* GetComInterfaceEntries(out int count)
    {
        count = 1;
        if (s_vtables == null)
        {
            global::System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* vtables = (global::System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry*)global::System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(ComClassInformation), sizeof(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry) * 1);
            global::System.Runtime.InteropServices.Marshalling.IIUnknownDerivedDetails details;
            details = global::System.Runtime.InteropServices.Marshalling.StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(SharedTypes.ComInterfaces.IStatelessPinnedMarshalling).TypeHandle);
            vtables[0] = new()
            {
                IID = details.Iid,
                Vtable = (nint)details.ManagedVirtualMethodTable
            };
            s_vtables = vtables;
        }

        return s_vtables;
    }
}

namespace SharedTypes.ComInterfaces
{
    [global::System.Runtime.InteropServices.Marshalling.ComExposedClassAttribute<ComClassInformation>]
    internal partial class StatelessPinnedMarshalling
    {
    }
}
