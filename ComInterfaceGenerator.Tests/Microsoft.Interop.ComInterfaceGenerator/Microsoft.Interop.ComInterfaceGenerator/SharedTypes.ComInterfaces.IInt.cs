﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 42, 31, 109, 238, 24, 52, 23, 67, 168, 124, 53, 72, 143, 101, 70, 171 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IInt
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::SharedTypes.ComInterfaces.IInt.Get()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInt));
        int __retVal;
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int> )__vtable_native[3])(__this, &__retVal);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInt.Set(int value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInt));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int, int> )__vtable_native[4])(__this, value);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInt.SwapRef(ref int value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInt));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (int* __value_native = &value)
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int> )__vtable_native[5])(__this, __value_native);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInt.GetOut(out int value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInt));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out value);
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (int* __value_native = &value)
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int> )__vtable_native[6])(__this, __value_native);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInt.SetIn(in int value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInt));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (int* __value_native = &value)
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int> )__vtable_native[7])(__this, __value_native);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IInt @this = default;
        ref int __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInt>(__this_native);
            __invokeRetVal = @this.Get();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = __invokeRetVal;
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Set(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int value)
    {
        global::SharedTypes.ComInterfaces.IInt @this = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInt>(__this_native);
            @this.Set(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SwapRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInt @this = default;
        ref int __value_native = ref *__value_native__param;
        int value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = __value_native;
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInt>(__this_native);
            @this.SwapRef(ref value);
            // Marshal - Convert managed data to native data.
            __value_native = value;
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInt @this = default;
        ref int __value_native = ref *__value_native__param;
        int value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInt>(__this_native);
            @this.GetOut(out value);
            // Marshal - Convert managed data to native data.
            __value_native = value;
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SetIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInt @this = default;
        ref int __value_native = ref *__value_native__param;
        int value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = __value_native;
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInt>(__this_native);
            @this.SetIn(in value);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IInt), sizeof(void*) * 8);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, int> )&ABI_Set;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int> )&ABI_SwapRef;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int> )&ABI_GetOut;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int> )&ABI_SetIn;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IInt
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IInt
    {
    }
}