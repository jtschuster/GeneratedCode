﻿// <auto-generated />
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 214, 62, 157, 90, 23, 204, 185, 79, 143, 130, 0, 112, 72, 155, 114, 19 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::ComInterfaceGenerator.Tests.ComInterfaces.IBool
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    bool global::ComInterfaceGenerator.Tests.ComInterfaces.IBool.Get()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IBool));
        bool __retVal;
        sbyte __retVal_native;
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, sbyte*, int> )__vtable_native[3])(__this, &__retVal_native);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        __retVal = __retVal_native != 0;
        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::ComInterfaceGenerator.Tests.ComInterfaces.IBool.Set(bool value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IBool));
        sbyte __value_native;
        int __invokeRetVal;
        // Marshal - Convert managed data to native data.
        __value_native = (sbyte)(value ? 1 : 0);
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, sbyte, int> )__vtable_native[4])(__this, __value_native);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, sbyte* __invokeRetValUnmanaged__param)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.IBool @this = default;
        ref sbyte __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        bool __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.IBool>(__this_native);
            __invokeRetVal = @this.Get();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = (sbyte)(__invokeRetVal ? 1 : 0);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Set(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, sbyte __value_native)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.IBool @this = default;
        bool value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = __value_native != 0;
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.IBool>(__this_native);
            @this.Set(value);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IBool), sizeof(void*) * 5);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, sbyte*, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, sbyte, int> )&ABI_Set;
        }

        return vtable;
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
        internal partial interface IBool
        {
        }
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        internal partial interface IBool
        {
        }
    }
}