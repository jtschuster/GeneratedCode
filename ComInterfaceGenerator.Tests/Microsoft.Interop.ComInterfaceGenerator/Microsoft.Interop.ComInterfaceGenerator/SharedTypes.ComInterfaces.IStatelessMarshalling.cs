﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : global::System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static global::System.Guid Iid { get; } = new(new global::System.ReadOnlySpan<byte>(new byte[] { 93, 250, 50, 71, 5, 193, 35, 74, 135, 167, 88, 220, 237, 212, 169, 179 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[global::System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatelessMarshalling
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessMarshalling.Method(global::SharedTypes.ComInterfaces.StatelessType param, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint, int, int> )__vtable_native[3])(__this, __param_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessMarshalling.MethodIn(in global::SharedTypes.ComInterfaces.StatelessType param, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[4])(__this, &__param_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessMarshalling.MethodOut(out global::SharedTypes.ComInterfaces.StatelessType param, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        bool __invokeSucceeded = default;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out param);
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[5])(__this, &__param_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            param = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.ConvertToManaged(__param_native);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.Free(__param_native);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessMarshalling.MethodRef(ref global::SharedTypes.ComInterfaces.StatelessType param, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        nint __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int, int> )__vtable_native[6])(__this, &__param_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            param = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.ConvertToManaged(__param_native);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessType global::SharedTypes.ComInterfaces.IStatelessMarshalling.Return()
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessType __retVal = default;
        nint __retVal_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[7])(__this, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.ConvertToManaged(__retVal_native);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessType global::SharedTypes.ComInterfaces.IStatelessMarshalling.ReturnPreserveSig()
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessType __retVal = default;
        nint __retVal_native = default;
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, nint> )__vtable_native[8])(__this);
            }

            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.ConvertToManaged(__retVal_native);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint __param_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            param = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.ConvertToManaged(__param_native);
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            @this.Method(param, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            param = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.UnmanagedToManaged.ConvertToManaged(__param_native);
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            @this.MethodIn(in param, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            @this.MethodOut(out param, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.ConvertToUnmanaged(param);
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __param_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        ref nint __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        bool __param_native__ownOriginal = false;
        nint __param_native__original = __param_native;
        try
        {
            // Unmarshal - Convert native data to managed data.
            param = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.ConvertToManaged(__param_native);
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            @this.MethodRef(ref param, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.ConvertToUnmanaged(param);
            __param_native__ownOriginal = true;
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            if (__param_native__ownOriginal)
            {
                global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.Bidirectional.Free(__param_native__original);
            }
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        ref nint __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatelessType __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            __invokeRetVal = @this.Return();
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static nint ABI_ReturnPreserveSig(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IStatelessMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessType __retVal = default;
        nint __retVal_native = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessMarshalling>(__this_native);
            __retVal = @this.ReturnPreserveSig();
            // Marshal - Convert managed data to native data.
            __retVal_native = global::SharedTypes.ComInterfaces.StatelessTypeMarshaller.ManagedToUnmanaged.ConvertToUnmanaged(__retVal);
        }
        catch (global::System.Exception __exception)
        {
            __retVal_native = global::System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<nint>.ConvertToUnmanaged(__exception);
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)global::System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatelessMarshalling), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            global::System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint, int, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodOut;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int, int> )&ABI_MethodRef;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [global::System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStatelessMarshalling
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStatelessMarshalling
    {
    }
}