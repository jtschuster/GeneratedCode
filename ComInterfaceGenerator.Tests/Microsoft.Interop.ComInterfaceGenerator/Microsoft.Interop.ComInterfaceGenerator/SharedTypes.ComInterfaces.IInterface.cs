﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 152, 115, 133, 164, 251, 6, 110, 74, 129, 219, 53, 70, 27, 233, 153, 197 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IInterface
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.IInt global::SharedTypes.ComInterfaces.IInterface.Get()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInterface));
        global::SharedTypes.ComInterfaces.IInt __retVal = default;
        void* __retVal_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int> )__vtable_native[3])(__this, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInterface.SetInt(global::SharedTypes.ComInterfaces.IInt value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInterface));
        void* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(value);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void*, int> )__vtable_native[4])(__this, __value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInterface.SwapRef(ref global::SharedTypes.ComInterfaces.IInt value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInterface));
        void* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(value);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int> )__vtable_native[5])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            value = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__value_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInterface.GetOut(out global::SharedTypes.ComInterfaces.IInt value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInterface));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out value);
        void* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int> )__vtable_native[6])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            value = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__value_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IInterface.InInt(in global::SharedTypes.ComInterfaces.IInt value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IInterface));
        void* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(value);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int> )__vtable_native[7])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native);
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IInterface @this = default;
        void* __invokeRetValUnmanaged__out = default;
        global::SharedTypes.ComInterfaces.IInt __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInterface>(__this_native);
            __invokeRetVal = @this.Get();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged__out = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__invokeRetValUnmanaged__param = __invokeRetValUnmanaged__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SetInt(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void* __value_native)
    {
        global::SharedTypes.ComInterfaces.IInterface @this = default;
        global::SharedTypes.ComInterfaces.IInt value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInterface>(__this_native);
            @this.SetInt(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SwapRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInterface @this = default;
        void* __value_native__out = default;
        void* __value_native = *__value_native__param;
        global::SharedTypes.ComInterfaces.IInt value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInterface>(__this_native);
            @this.SwapRef(ref value);
            // Marshal - Convert managed data to native data.
            __value_native__out = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // CleanupFailure - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native__out);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__value_native__param = __value_native__out;
        // Cleanup - Perform required cleanup.
        global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.Free(__value_native);
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInterface @this = default;
        void* __value_native__out = default;
        global::SharedTypes.ComInterfaces.IInt value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInterface>(__this_native);
            @this.GetOut(out value);
            // Marshal - Convert managed data to native data.
            __value_native__out = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToUnmanaged(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__value_native__param = __value_native__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_InInt(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IInterface @this = default;
        void* __value_native = *__value_native__param;
        global::SharedTypes.ComInterfaces.IInt value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IInt>.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IInterface>(__this_native);
            @this.InInt(in value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IInterface), sizeof(void*) * 8);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void**, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void*, int> )&ABI_SetInt;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void**, int> )&ABI_SwapRef;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void**, int> )&ABI_GetOut;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void**, int> )&ABI_InInt;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IInterface
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IInterface
    {
    }
}