﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 93, 250, 49, 71, 3, 193, 34, 74, 135, 161, 88, 220, 237, 212, 169, 179 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.Method(global::SharedTypes.ComInterfaces.StatefulPinnedType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native__marshaller.FromManaged(param, stackalloc byte[global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller.BufferSize]);
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __param_native__unused = __param_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __param_native = __param_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint, int> )__vtable_native[3])(__this, __param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __param_native__marshaller.OnInvoked();
            System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.MethodIn(in global::SharedTypes.ComInterfaces.StatefulPinnedType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native__marshaller.FromManaged(param, stackalloc byte[global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller.BufferSize]);
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __param_native__unused = __param_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __param_native = __param_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[4])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __param_native__marshaller.OnInvoked();
            System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.MethodOut(out global::SharedTypes.ComInterfaces.StatefulPinnedType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        bool __invokeSucceeded = default;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out param);
        nint __param_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[5])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __param_native__marshaller.FromUnmanaged(__param_native);
            // Unmarshal - Convert native data to managed data.
            param = __param_native__marshaller.ToManaged();
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                __param_native__marshaller.Free();
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.MethodRef(ref global::SharedTypes.ComInterfaces.StatefulPinnedType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __param_native = __param_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[6])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __param_native__marshaller.OnInvoked();
            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __param_native__marshaller.FromUnmanaged(__param_native);
            // Unmarshal - Convert native data to managed data.
            param = __param_native__marshaller.ToManaged();
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatefulPinnedType global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.Return()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatefulPinnedType __retVal = default;
        nint __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __retVal_native__marshaller = new();
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[7])(__this, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __retVal_native__marshaller.FromUnmanaged(__retVal_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = __retVal_native__marshaller.ToManaged();
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                __retVal_native__marshaller.Free();
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatefulPinnedType global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling.ReturnPreserveSig()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatefulPinnedType __retVal = default;
        nint __retVal_native = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __retVal_native__marshaller = new();
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, nint> )__vtable_native[8])(__this);
            }

            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __retVal_native__marshaller.FromUnmanaged(__retVal_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = __retVal_native__marshaller.ToManaged();
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                __retVal_native__marshaller.Free();
            }
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint __param_native)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatefulPinnedType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __param_native__marshaller.FromUnmanaged(__param_native);
            // Unmarshal - Convert native data to managed data.
            param = __param_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            @this.Method(param);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatefulPinnedType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __param_native__marshaller.FromUnmanaged(__param_native);
            // Unmarshal - Convert native data to managed data.
            param = __param_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            @this.MethodIn(in param);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatefulPinnedType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            @this.MethodOut(out param);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            __param_native__marshaller.OnInvoked();
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __param_native = __param_native__marshaller.ToUnmanaged();
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatefulPinnedType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __param_native__marshaller = new();
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __param_native__marshaller.FromUnmanaged(__param_native);
            // Unmarshal - Convert native data to managed data.
            param = __param_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            @this.MethodRef(ref param);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            __param_native__marshaller.OnInvoked();
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __param_native = __param_native__marshaller.ToUnmanaged();
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __param_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        ref nint __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatefulPinnedType __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __invokeRetValUnmanaged__marshaller = new();
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            __invokeRetVal = @this.Return();
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            __invokeRetValUnmanaged__marshaller.OnInvoked();
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __invokeRetValUnmanaged = __invokeRetValUnmanaged__marshaller.ToUnmanaged();
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __invokeRetValUnmanaged__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static nint ABI_ReturnPreserveSig(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatefulPinnedType __retVal = default;
        nint __retVal_native = default;
        // Setup - Perform required setup.
        global::SharedTypes.ComInterfaces.StatefulPinnedTypeMarshaller __retVal_native__marshaller = new();
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling>(__this_native);
            __retVal = @this.ReturnPreserveSig();
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal_native__marshaller.OnInvoked();
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __retVal_native = __retVal_native__marshaller.ToUnmanaged();
        }
        catch (System.Exception __exception)
        {
            __retVal_native = System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<nint>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __retVal_native__marshaller.Free();
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatefulPinnedMarshalling), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_MethodOut;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_MethodRef;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStatefulPinnedMarshalling
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStatefulPinnedMarshalling
    {
    }
}