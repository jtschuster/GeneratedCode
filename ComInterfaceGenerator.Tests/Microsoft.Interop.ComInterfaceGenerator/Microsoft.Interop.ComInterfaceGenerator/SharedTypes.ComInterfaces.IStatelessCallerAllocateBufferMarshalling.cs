﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 93, 250, 50, 71, 5, 193, 35, 74, 135, 167, 88, 220, 237, 212, 169, 179 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.Method(global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            System.Span<byte> __param_native__buffer = stackalloc byte[global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.BufferSize];
            __param_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(param, __param_native__buffer);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint, int, int> )__vtable_native[3])(__this, __param_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.MethodIn(in global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            System.Span<byte> __param_native__buffer = stackalloc byte[global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.BufferSize];
            __param_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(param, __param_native__buffer);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[4])(__this, &__param_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.MethodOut(out global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out param);
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[5])(__this, &__param_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            param = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__param_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.MethodRef(ref global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[6])(__this, &__param_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            param = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__param_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.Return()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType __retVal = default;
        nint __retVal_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[7])(__this, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling.ReturnPreserveSig()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling));
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType __retVal = default;
        nint __retVal_native = default;
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, nint> )__vtable_native[8])(__this);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint __param_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            param = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__param_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            @this.Method(param, size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            param = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__param_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            @this.MethodIn(in param, size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            @this.MethodOut(out param, size);
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(param);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        bool __param_native__ownOriginal = false;
        nint __param_native__original = __param_native;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            param = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToManaged(__param_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            @this.MethodRef(ref param, size);
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(param);
            __param_native__ownOriginal = true;
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            if (__param_native__ownOriginal)
            {
                global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.Free(__param_native__original);
            }
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        ref nint __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            __invokeRetVal = @this.Return();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static nint ABI_ReturnPreserveSig(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferType __retVal = default;
        nint __retVal_native = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling>(__this_native);
            __retVal = @this.ReturnPreserveSig();
            // Marshal - Convert managed data to native data.
            __retVal_native = global::SharedTypes.ComInterfaces.StatelessCallerAllocatedBufferTypeMarshaller.ConvertToUnmanaged(__retVal);
        }
        catch (System.Exception __exception)
        {
            __retVal_native = System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<nint>.ConvertToUnmanaged(__exception);
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatelessCallerAllocateBufferMarshalling), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint, int, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodOut;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodRef;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStatelessCallerAllocateBufferMarshalling
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStatelessCallerAllocateBufferMarshalling
    {
    }
}