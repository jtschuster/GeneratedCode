﻿// <auto-generated />
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 169, 168, 164, 159, 143, 61, 168, 72, 182, 251, 180, 91, 95, 27, 159, 182 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int[][] global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails.Get(out int[] widths, out int length)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out widths);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out length);
        int* __widths_native = default;
        int[][] __retVal = default;
        System.IntPtr* __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        ;
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        ;
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __length_native = &length)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int*, System.IntPtr**, int> )__vtable_native[3])(__this, &__widths_native, __length_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __widths_native__numElements = length;
            widths = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__widths_native, __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__widths_native, __widths_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(widths));
            __retVal_native__numElements = length;
            __retVal = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            {
                System.ReadOnlySpan<System.IntPtr> __retVal_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements);
                System.Span<int[]> __retVal_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesDestination(__retVal);
                for (int __i0 = 0; __i0 < __retVal_native__numElements; ++__i0)
                {
                    int __retVal_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__nativeSpan____i0__numElements);
                    ;
                    __retVal_native__nativeSpan____i0__numElements = widths[__i0];
                    __retVal_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForManagedElements((nint*)__retVal_native__nativeSpan[__i0], __retVal_native__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<nint> __retVal_native__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesSource((nint*)__retVal_native__nativeSpan[__i0], __retVal_native__nativeSpan____i0__numElements);
                        System.Span<int> __retVal_native__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesDestination(__retVal_native__managedSpan[__i0]);
                        for (int __i1 = 0; __i1 < __retVal_native__nativeSpan____i0__numElements; ++__i1)
                        {
                            __retVal_native__nativeSpan____i0__managedSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToManaged(__retVal_native__nativeSpan____i0__nativeSpan[__i1]);
                        }
                    }
                }
            }
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __widths_native__numElements = length;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__widths_native);
            __retVal_native__numElements = length;
            {
                System.ReadOnlySpan<System.IntPtr> __retVal_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__retVal_native, __retVal_native__numElements);
                for (int __i0 = 0; __i0 < __retVal_native__nativeSpan.Length; ++__i0)
                {
                    int __retVal_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__nativeSpan____i0__numElements);
                    ;
                    __retVal_native__nativeSpan____i0__numElements = widths[__i0];
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.Free((nint*)__retVal_native__nativeSpan[__i0]);
                }
            }

            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails.Get2(out int[][] array, out int[] widths)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out array);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out widths);
        System.IntPtr* __array_native = default;
        int* __widths_native = default;
        int __retVal = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        ;
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        ;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, System.IntPtr**, int**, int*, int> )__vtable_native[4])(__this, &__array_native, &__widths_native, &__retVal);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __widths_native__numElements = __retVal;
            widths = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__widths_native, __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__widths_native, __widths_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(widths));
            __array_native__numElements = __retVal;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            {
                System.ReadOnlySpan<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesSource(__array_native, __array_native__numElements);
                System.Span<int[]> __array_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesDestination(array);
                for (int __i0 = 0; __i0 < __array_native__numElements; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    __array_native__nativeSpan____i0__numElements = widths[__i0];
                    __array_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForManagedElements((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<nint> __array_native__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesSource((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                        System.Span<int> __array_native__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesDestination(__array_native__managedSpan[__i0]);
                        for (int __i1 = 0; __i1 < __array_native__nativeSpan____i0__numElements; ++__i1)
                        {
                            __array_native__nativeSpan____i0__managedSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToManaged(__array_native__nativeSpan____i0__nativeSpan[__i1]);
                        }
                    }
                }
            }
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __widths_native__numElements = __retVal;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__widths_native);
            __array_native__numElements = __retVal;
            {
                System.ReadOnlySpan<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements);
                for (int __i0 = 0; __i0 < __array_native__nativeSpan.Length; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    __array_native__nativeSpan____i0__numElements = widths[__i0];
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.Free((nint*)__array_native__nativeSpan[__i0]);
                }
            }

            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.Free(__array_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails.Set(int[][] array, int[] widths, int length)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails));
        System.IntPtr* __array_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.ManagedToUnmanagedIn __array_native__marshaller = new();
        int __array_native__numElements;
        int __array_native__lastIndexMarshalled = 0;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __array_native__marshaller.FromManaged(array, stackalloc System.IntPtr[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.ManagedToUnmanagedIn.BufferSize]);
            {
                System.ReadOnlySpan<int[]> __array_native__managedSpan = __array_native__marshaller.GetManagedValuesSource();
                System.Span<System.IntPtr> __array_native__nativeSpan = __array_native__marshaller.GetUnmanagedValuesDestination();
                for (int __i0 = 0; __i0 < __array_native__managedSpan.Length; ++__i0, ++__array_native__lastIndexMarshalled)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    __array_native__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForUnmanagedElements(__array_native__managedSpan[__i0], out __array_native__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<int> __array_native__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesSource(__array_native__managedSpan[__i0]);
                        System.Span<nint> __array_native__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesDestination((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                        for (int __i1 = 0; __i1 < __array_native__nativeSpan____i0__managedSpan.Length; ++__i1)
                        {
                            __array_native__nativeSpan____i0__nativeSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToUnmanaged(__array_native__nativeSpan____i0__managedSpan[__i1]);
                        }
                    }
                }
            }

            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __widths_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(widths))
            fixed (void* __array_native__unused = __array_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __array_native = __array_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, System.IntPtr*, int*, int, int> )__vtable_native[5])(__this, __array_native, (int*)__widths_native, length);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            {
                System.ReadOnlySpan<System.IntPtr> __array_native__nativeSpan = __array_native__marshaller.GetUnmanagedValuesDestination();
                for (int __i0 = 0; __i0 < __array_native__lastIndexMarshalled; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    ;
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.Free((nint*)__array_native__nativeSpan[__i0]);
                }
            }

            __array_native__marshaller.Free();
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __widths_native__param, int* __length_native__param, System.IntPtr** __invokeRetValUnmanaged__param)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails @this = default;
        ref int* __widths_native = ref *__widths_native__param;
        int[] widths = default;
        ref int __length_native = ref *__length_native__param;
        int length = default;
        ref System.IntPtr* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int[][] __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        ;
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        ;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails>(__this_native);
            __invokeRetVal = @this.Get(out widths, out length);
            // Marshal - Convert managed data to native data.
            __length_native = length;
            __widths_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(widths, out __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(widths).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__widths_native, __widths_native__numElements));
            __invokeRetValUnmanaged = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            {
                System.ReadOnlySpan<int[]> __invokeRetValUnmanaged__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesSource(__invokeRetVal);
                System.Span<System.IntPtr> __invokeRetValUnmanaged__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__invokeRetValUnmanaged, __invokeRetValUnmanaged__numElements);
                for (int __i0 = 0; __i0 < __invokeRetValUnmanaged__managedSpan.Length; ++__i0)
                {
                    int __invokeRetValUnmanaged__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                    ;
                    __invokeRetValUnmanaged__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForUnmanagedElements(__invokeRetValUnmanaged__managedSpan[__i0], out __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<int> __invokeRetValUnmanaged__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesSource(__invokeRetValUnmanaged__managedSpan[__i0]);
                        System.Span<nint> __invokeRetValUnmanaged__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesDestination((nint*)__invokeRetValUnmanaged__nativeSpan[__i0], __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                        for (int __i1 = 0; __i1 < __invokeRetValUnmanaged__nativeSpan____i0__managedSpan.Length; ++__i1)
                        {
                            __invokeRetValUnmanaged__nativeSpan____i0__nativeSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToUnmanaged(__invokeRetValUnmanaged__nativeSpan____i0__managedSpan[__i1]);
                        }
                    }
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
    internal static int ABI_Get2(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, System.IntPtr** __array_native__param, int** __widths_native__param, int* __invokeRetValUnmanaged__param)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails @this = default;
        ref System.IntPtr* __array_native = ref *__array_native__param;
        int[][] array = default;
        ref int* __widths_native = ref *__widths_native__param;
        int[] widths = default;
        ref int __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        ;
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        ;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails>(__this_native);
            __invokeRetVal = @this.Get2(out array, out widths);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = __invokeRetVal;
            __widths_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(widths, out __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(widths).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__widths_native, __widths_native__numElements));
            __array_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            {
                System.ReadOnlySpan<int[]> __array_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesSource(array);
                System.Span<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements);
                for (int __i0 = 0; __i0 < __array_native__managedSpan.Length; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    __array_native__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForUnmanagedElements(__array_native__managedSpan[__i0], out __array_native__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<int> __array_native__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesSource(__array_native__managedSpan[__i0]);
                        System.Span<nint> __array_native__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesDestination((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                        for (int __i1 = 0; __i1 < __array_native__nativeSpan____i0__managedSpan.Length; ++__i1)
                        {
                            __array_native__nativeSpan____i0__nativeSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToUnmanaged(__array_native__nativeSpan____i0__managedSpan[__i1]);
                        }
                    }
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
    internal static int ABI_Set(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, System.IntPtr* __array_native, int* __widths_native, int length)
    {
        global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails @this = default;
        int[][] array = default;
        int[] widths = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        ;
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        ;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __widths_native__numElements = length;
            widths = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__widths_native, __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__widths_native, __widths_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(widths));
            __array_native__numElements = length;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            {
                System.ReadOnlySpan<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesSource(__array_native, __array_native__numElements);
                System.Span<int[]> __array_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesDestination(array);
                for (int __i0 = 0; __i0 < __array_native__numElements; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    __array_native__nativeSpan____i0__numElements = widths[__i0];
                    __array_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.AllocateContainerForManagedElements((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                    {
                        System.ReadOnlySpan<nint> __array_native__nativeSpan____i0__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetUnmanagedValuesSource((nint*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                        System.Span<int> __array_native__nativeSpan____i0__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, nint>.GetManagedValuesDestination(__array_native__managedSpan[__i0]);
                        for (int __i1 = 0; __i1 < __array_native__nativeSpan____i0__numElements; ++__i1)
                        {
                            __array_native__nativeSpan____i0__managedSpan[__i1] = global::ComInterfaceGenerator.Tests.ComInterfaces.ThrowOn4thElementMarshalled.ConvertToManaged(__array_native__nativeSpan____i0__nativeSpan[__i1]);
                        }
                    }
                }
            }

            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails>(__this_native);
            @this.Set(array, widths, length);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::ComInterfaceGenerator.Tests.ComInterfaces.IJaggedIntArrayMarshallingFails), sizeof(void*) * 6);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int*, System.IntPtr**, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, System.IntPtr**, int**, int*, int> )&ABI_Get2;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, System.IntPtr*, int*, int, int> )&ABI_Set;
        }

        return vtable;
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
        internal partial interface IJaggedIntArrayMarshallingFails
        {
        }
    }
}

namespace ComInterfaceGenerator.Tests
{
    public static unsafe partial class ComInterfaces
    {
        internal partial interface IJaggedIntArrayMarshallingFails
        {
        }
    }
}