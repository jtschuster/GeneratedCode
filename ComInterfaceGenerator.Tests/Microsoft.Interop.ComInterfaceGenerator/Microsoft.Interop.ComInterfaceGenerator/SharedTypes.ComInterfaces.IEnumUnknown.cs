﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 0, 1, 0, 0, 0, 0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IEnumUnknown
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IEnumUnknown.Next(uint celt, object[] rgelt, out uint pceltFetched)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IEnumUnknown));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out pceltFetched);
        System.IntPtr* __rgelt_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.ManagedToUnmanagedIn __rgelt_native__marshaller = new();
        int __rgelt_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __rgelt_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __rgelt_native__marshaller.FromManaged(rgelt, stackalloc System.IntPtr[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.ManagedToUnmanagedIn.BufferSize]);
            __rgelt_native__marshaller.GetUnmanagedValuesDestination().Clear();
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (uint* __pceltFetched_native = &pceltFetched)
            fixed (void* __rgelt_native__unused = __rgelt_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __rgelt_native = __rgelt_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint, System.IntPtr*, uint*, int> )__vtable_native[3])(__this, celt, __rgelt_native, __pceltFetched_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            {
                __rgelt_native__numElements = __rgelt_native__marshaller.GetManagedValuesSource().Length;
                System.Span<object> __rgelt_native__managedSpan = System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref System.Runtime.CompilerServices.Unsafe.AsRef(in __rgelt_native__marshaller.GetManagedValuesSource().GetPinnableReference()), __rgelt_native__numElements);
                System.Span<System.IntPtr> __rgelt_native__nativeSpan = __rgelt_native__marshaller.GetUnmanagedValuesDestination();
                for (int __i0 = 0; __i0 < __rgelt_native__numElements; ++__i0)
                {
                    __rgelt_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<object>.ConvertToManaged((void*)__rgelt_native__nativeSpan[__i0]);
                }
            }
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            {
                System.ReadOnlySpan<System.IntPtr> __rgelt_native__nativeSpan = __rgelt_native__marshaller.GetUnmanagedValuesDestination();
                for (int __i0 = 0; __i0 < __rgelt_native__nativeSpan.Length; ++__i0)
                {
                    global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<object>.Free((void*)__rgelt_native__nativeSpan[__i0]);
                }
            }

            __rgelt_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IEnumUnknown.Skip(uint celt)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IEnumUnknown));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, uint, int> )__vtable_native[4])(__this, celt);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IEnumUnknown.Reset()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IEnumUnknown));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int> )__vtable_native[5])(__this);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IEnumUnknown.Clone(out global::SharedTypes.ComInterfaces.IEnumUnknown ppenum)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IEnumUnknown));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ppenum);
        void* __ppenum_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, void**, int> )__vtable_native[6])(__this, &__ppenum_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            ppenum = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IEnumUnknown>.ConvertToManaged(__ppenum_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IEnumUnknown>.Free(__ppenum_native);
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Next(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, uint celt, System.IntPtr* __rgelt_native, uint* __pceltFetched_native__param)
    {
        global::SharedTypes.ComInterfaces.IEnumUnknown @this = default;
        object[] rgelt = default;
        uint __pceltFetched_native__out = default;
        uint pceltFetched = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __rgelt_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __rgelt_native__numElements);
        scoped System.Span<System.IntPtr> __rgelt_native__out = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.GetManagedValuesDestination(rgelt).Clear();
            __rgelt_native__numElements = -1;
            rgelt = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.AllocateContainerForManagedElements(__rgelt_native, __rgelt_native__numElements);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IEnumUnknown>(__this_native);
            @this.Next(celt, rgelt, out pceltFetched);
            // Marshal - Convert managed data to native data.
            __pceltFetched_native__out = pceltFetched;
            {
                __rgelt_native__numElements = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.GetManagedValuesDestination(rgelt).Length;
                __rgelt_native__out = stackalloc System.IntPtr[__rgelt_native__numElements];
                System.Span<System.IntPtr> __rgelt_native__nativeSpan = __rgelt_native__out;
                System.Span<object> __rgelt_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.GetManagedValuesDestination(rgelt);
                for (int __i0 = 0; __i0 < __rgelt_native__numElements; ++__i0)
                {
                    void* __rgelt_native__nativeSpan____i0__original = (void*)__rgelt_native__nativeSpan[__i0];
                    __rgelt_native__nativeSpan[__i0] = (System.IntPtr)(void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<object>.ConvertToUnmanaged(__rgelt_native__managedSpan[__i0]);
                }
            }

            // AssignOut - Assign to parameters
            *__pceltFetched_native__param = __pceltFetched_native__out;
            __rgelt_native__out.CopyTo(System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref System.Runtime.CompilerServices.Unsafe.AsRef(in global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<object, System.IntPtr>.GetUnmanagedValuesSource(__rgelt_native, __rgelt_native__numElements).GetPinnableReference()), __rgelt_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // CleanupFailure - Perform required cleanup.
            {
                System.ReadOnlySpan<System.IntPtr> __rgelt_native__nativeSpan = __rgelt_native__out;
                for (int __i0 = 0; __i0 < __rgelt_native__nativeSpan.Length; ++__i0)
                {
                    global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<object>.Free((void*)__rgelt_native__nativeSpan[__i0]);
                }
            }

            __rgelt_native__numElements = -1;
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Skip(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, uint celt)
    {
        global::SharedTypes.ComInterfaces.IEnumUnknown @this = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IEnumUnknown>(__this_native);
            @this.Skip(celt);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Reset(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native)
    {
        global::SharedTypes.ComInterfaces.IEnumUnknown @this = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IEnumUnknown>(__this_native);
            @this.Reset();
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Clone(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, void** __ppenum_native__param)
    {
        global::SharedTypes.ComInterfaces.IEnumUnknown @this = default;
        void* __ppenum_native__out = default;
        global::SharedTypes.ComInterfaces.IEnumUnknown ppenum = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IEnumUnknown>(__this_native);
            @this.Clone(out ppenum);
            // Marshal - Convert managed data to native data.
            __ppenum_native__out = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IEnumUnknown>.ConvertToUnmanaged(ppenum);
            // AssignOut - Assign to parameters
            *__ppenum_native__param = __ppenum_native__out;
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // CleanupFailure - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IEnumUnknown>.Free(__ppenum_native__out);
            return __retVal;
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IEnumUnknown), sizeof(void*) * 7);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, uint, System.IntPtr*, uint*, int> )&ABI_Next;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, uint, int> )&ABI_Skip;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int> )&ABI_Reset;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, void**, int> )&ABI_Clone;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IEnumUnknown
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IEnumUnknown
    {
    }
}