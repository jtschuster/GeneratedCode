﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 149, 115, 133, 164, 251, 6, 110, 74, 129, 219, 53, 70, 27, 233, 153, 197 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int[] global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails.Get()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails));
        int[] __retVal = default;
        nint* __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint**, int> )__vtable_native[3])(__this, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal_native__numElements = 10;
            __retVal = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            {
                System.ReadOnlySpan<nint> __retVal_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements);
                System.Span<int> __retVal_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesDestination(__retVal);
                for (int __i0 = 0; __i0 < __retVal_native__numElements; ++__i0)
                {
                    __retVal_native__managedSpan[__i0] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToManaged(__retVal_native__nativeSpan[__i0]);
                }
            }
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __retVal_native__numElements = 10;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails.Set(int[] value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails));
        nint* __value_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.ManagedToUnmanagedIn __value_native__marshaller = new();
        int __value_native__numElements;
        int __value_native__lastIndexMarshalled = 0;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __value_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native__marshaller.FromManaged(value, stackalloc nint[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.ManagedToUnmanagedIn.BufferSize]);
            {
                System.ReadOnlySpan<int> __value_native__managedSpan = __value_native__marshaller.GetManagedValuesSource();
                System.Span<nint> __value_native__nativeSpan = __value_native__marshaller.GetUnmanagedValuesDestination();
                for (int __i0 = 0; __i0 < __value_native__managedSpan.Length; ++__i0, ++__value_native__lastIndexMarshalled)
                {
                    __value_native__nativeSpan[__i0] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToUnmanaged(__value_native__managedSpan[__i0]);
                }
            }

            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __value_native__unused = __value_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __value_native = __value_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, nint*, int> )__vtable_native[4])(__this, __value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            _ = __value_native__lastIndexMarshalled;
            __value_native__marshaller.Free();
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint** __invokeRetValUnmanaged__param)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails @this = default;
        ref nint* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int[] __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails>(__this_native);
            __invokeRetVal = @this.Get();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            {
                System.ReadOnlySpan<int> __invokeRetValUnmanaged__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesSource(__invokeRetVal);
                System.Span<nint> __invokeRetValUnmanaged__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesDestination(__invokeRetValUnmanaged, __invokeRetValUnmanaged__numElements);
                __invokeRetValUnmanaged__nativeSpan.Clear();
                for (int __i0 = 0; __i0 < __invokeRetValUnmanaged__managedSpan.Length; ++__i0)
                {
                    __invokeRetValUnmanaged__nativeSpan[__i0] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToUnmanaged(__invokeRetValUnmanaged__managedSpan[__i0]);
                }
            }
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Set(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, nint* __value_native)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails @this = default;
        int[] value = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __value_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __value_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __value_native__numElements = 10;
            value = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForManagedElements(__value_native, __value_native__numElements);
            {
                System.ReadOnlySpan<nint> __value_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesSource(__value_native, __value_native__numElements);
                System.Span<int> __value_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesDestination(value);
                for (int __i0 = 0; __i0 < __value_native__numElements; ++__i0)
                {
                    __value_native__managedSpan[__i0] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToManaged(__value_native__nativeSpan[__i0]);
                }
            }

            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails>(__this_native);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.ICollectionMarshallingFails), sizeof(void*) * 5);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint**, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, nint*, int> )&ABI_Set;
        }

        return vtable;
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
        internal partial interface ICollectionMarshallingFails
        {
        }
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        internal partial interface ICollectionMarshallingFails
        {
        }
    }
}