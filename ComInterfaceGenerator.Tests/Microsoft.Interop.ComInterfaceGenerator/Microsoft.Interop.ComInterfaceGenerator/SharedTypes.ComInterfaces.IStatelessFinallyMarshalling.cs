﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 93, 250, 50, 71, 5, 193, 38, 74, 135, 167, 88, 220, 237, 212, 169, 179 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.Method(global::SharedTypes.ComInterfaces.StatelessFinallyType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative, int> )__vtable_native[3])(__this, __param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.MethodIn(in global::SharedTypes.ComInterfaces.StatelessFinallyType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )__vtable_native[4])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.MethodOut(out global::SharedTypes.ComInterfaces.StatelessFinallyType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        bool __invokeSucceeded = default;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out param);
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )__vtable_native[5])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
                param = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__param_native);
            }

            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.MethodRef(ref global::SharedTypes.ComInterfaces.StatelessFinallyType param)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(param);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )__vtable_native[6])(__this, &__param_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
                param = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__param_native);
            }

            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__param_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessFinallyType global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.Return()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyType __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __retVal_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )__vtable_native[7])(__this, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
                __retVal = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__retVal_native);
            }

            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessFinallyType global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling.ReturnPreserveSig()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyType __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __retVal_native = default;
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessFinallyNative> )__vtable_native[8])(__this);
            }

            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
                __retVal = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__retVal_native);
            }

            // Cleanup - Perform required cleanup.
            global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyType param = default;
        int __retVal = default;
        try
        {
            // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
            param = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__param_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            @this.Method(param);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessFinallyNative* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessFinallyType param = default;
        int __retVal = default;
        try
        {
            // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
            param = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__param_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            @this.MethodIn(in param);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessFinallyNative* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessFinallyType param = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            @this.MethodOut(out param);
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(param);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessFinallyNative* __param_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native = ref *__param_native__param;
        global::SharedTypes.ComInterfaces.StatelessFinallyType param = default;
        int __retVal = default;
        // Setup - Perform required setup.
        bool __param_native__ownOriginal = false;
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __param_native__original = __param_native;
        try
        {
            // GuaranteedUnmarshal - Convert native data to managed data even in the case of an exception during the non-cleanup phases.
            param = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToManagedFinally(__param_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            @this.MethodRef(ref param);
            // Marshal - Convert managed data to native data.
            __param_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(param);
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
                global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.Free(__param_native__original);
            }
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessFinallyNative* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessFinallyNative __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatelessFinallyType __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            __invokeRetVal = @this.Return();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static global::SharedTypes.ComInterfaces.StatelessFinallyNative ABI_ReturnPreserveSig(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling @this = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyType __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessFinallyNative __retVal_native = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling>(__this_native);
            __retVal = @this.ReturnPreserveSig();
            // Marshal - Convert managed data to native data.
            __retVal_native = global::SharedTypes.ComInterfaces.StatelessFinallyTypeMarshaller.ConvertToUnmanaged(__retVal);
        }
        catch (System.Exception __exception)
        {
            __retVal_native = System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<global::SharedTypes.ComInterfaces.StatelessFinallyNative>.ConvertToUnmanaged(__exception);
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatelessFinallyMarshalling), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )&ABI_MethodOut;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )&ABI_MethodRef;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessFinallyNative> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStatelessFinallyMarshalling
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStatelessFinallyMarshalling
    {
    }
}