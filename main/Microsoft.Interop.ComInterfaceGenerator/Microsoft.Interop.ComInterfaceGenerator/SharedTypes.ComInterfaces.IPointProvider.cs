﻿file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 20, 25, 70, 228, 2, 66, 159, 71, 132, 39, 98, 14, 145, 95, 132, 185 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IPointProvider
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::System.Drawing.Point global::SharedTypes.ComInterfaces.IPointProvider.GetPoint()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IPointProvider));
        global::System.Drawing.Point __retVal;
        {
            __retVal = ((delegate* unmanaged[MemberFunction]<void*, global::System.Drawing.Point> )__vtable_native[3])(__this);
        }

        System.GC.KeepAlive(this);
        return __retVal;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IPointProvider.SetPoint(global::System.Drawing.Point point)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IPointProvider));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::System.Drawing.Point, int> )__vtable_native[4])(__this, point);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static global::System.Drawing.Point ABI_GetPoint(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IPointProvider @this = default;
        global::System.Drawing.Point __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IPointProvider>(__this_native);
            __retVal = @this.GetPoint();
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<global::System.Drawing.Point>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SetPoint(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::System.Drawing.Point point)
    {
        global::SharedTypes.ComInterfaces.IPointProvider @this = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IPointProvider>(__this_native);
            @this.SetPoint(point);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IPointProvider), sizeof(void*) * 5);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::System.Drawing.Point> )&ABI_GetPoint;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::System.Drawing.Point, int> )&ABI_SetPoint;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IPointProvider
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IPointProvider
    {
    }
}