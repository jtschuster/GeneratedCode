﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 169, 168, 164, 159, 143, 61, 168, 72, 182, 251, 180, 91, 95, 27, 159, 182 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IJaggedIntArray
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int[][] global::SharedTypes.ComInterfaces.IJaggedIntArray.Get(out int[] widths, out int length)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IJaggedIntArray));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out widths);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out length);
        int* __widths_native;
        int[][] __retVal;
        System.IntPtr* __retVal_native;
        int __invokeRetVal;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
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
                __retVal_native__nativeSpan____i0__numElements = widths[__i0];
                __retVal_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements((int*)__retVal_native__nativeSpan[__i0], __retVal_native__nativeSpan____i0__numElements);
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource((int*)__retVal_native__nativeSpan[__i0], __retVal_native__nativeSpan____i0__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(__retVal_native__managedSpan[__i0]));
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::SharedTypes.ComInterfaces.IJaggedIntArray.Get2(out int[][] array, out int[] widths)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IJaggedIntArray));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out array);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out widths);
        System.IntPtr* __array_native;
        int* __widths_native;
        int __retVal;
        int __invokeRetVal;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
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
                __array_native__nativeSpan____i0__numElements = widths[__i0];
                __array_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(__array_native__managedSpan[__i0]));
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IJaggedIntArray.Set(int[][] array, int[] widths, int length)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IJaggedIntArray));
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
                    __array_native__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(__array_native__managedSpan[__i0], out __array_native__nativeSpan____i0__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(__array_native__managedSpan[__i0]).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements));
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
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free((int*)__array_native__nativeSpan[__i0]);
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
        global::SharedTypes.ComInterfaces.IJaggedIntArray @this = default;
        int* __widths_native__out = default;
        int[] widths = default;
        int __length_native__out = default;
        int length = default;
        System.IntPtr* __invokeRetValUnmanaged__out = default;
        int[][] __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IJaggedIntArray>(__this_native);
            __invokeRetVal = @this.Get(out widths, out length);
            // Marshal - Convert managed data to native data.
            __length_native__out = length;
            __widths_native__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(widths, out __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(widths).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__widths_native__out, __widths_native__numElements));
            __invokeRetValUnmanaged__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            {
                System.ReadOnlySpan<int[]> __invokeRetValUnmanaged__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesSource(__invokeRetVal);
                System.Span<System.IntPtr> __invokeRetValUnmanaged__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__invokeRetValUnmanaged__out, __invokeRetValUnmanaged__numElements);
                __invokeRetValUnmanaged__nativeSpan.Clear();
                for (int __i0 = 0; __i0 < __invokeRetValUnmanaged__managedSpan.Length; ++__i0)
                {
                    int __invokeRetValUnmanaged__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                    __invokeRetValUnmanaged__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(__invokeRetValUnmanaged__managedSpan[__i0], out __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(__invokeRetValUnmanaged__managedSpan[__i0]).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination((int*)__invokeRetValUnmanaged__nativeSpan[__i0], __invokeRetValUnmanaged__nativeSpan____i0__numElements));
                }
            }
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // CleanupFailure - Perform required cleanup.
            ;
            {
                System.ReadOnlySpan<System.IntPtr> __invokeRetValUnmanaged__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesSource(__invokeRetValUnmanaged__out, __invokeRetValUnmanaged__numElements);
                for (int __i0 = 0; __i0 < __invokeRetValUnmanaged__nativeSpan.Length; ++__i0)
                {
                    int __invokeRetValUnmanaged__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__nativeSpan____i0__numElements);
                    ;
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free((int*)__invokeRetValUnmanaged__nativeSpan[__i0]);
                }
            };
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__length_native__param = __length_native__out;
        *__widths_native__param = __widths_native__out;
        *__invokeRetValUnmanaged__param = __invokeRetValUnmanaged__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get2(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, System.IntPtr** __array_native__param, int** __widths_native__param, int* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IJaggedIntArray @this = default;
        System.IntPtr* __array_native__out = default;
        int[][] array = default;
        int* __widths_native__out = default;
        int[] widths = default;
        int __invokeRetValUnmanaged__out = default;
        int __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IJaggedIntArray>(__this_native);
            __invokeRetVal = @this.Get2(out array, out widths);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged__out = __invokeRetVal;
            __widths_native__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(widths, out __widths_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(widths).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__widths_native__out, __widths_native__numElements));
            __array_native__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            {
                System.ReadOnlySpan<int[]> __array_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetManagedValuesSource(array);
                System.Span<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesDestination(__array_native__out, __array_native__numElements);
                __array_native__nativeSpan.Clear();
                for (int __i0 = 0; __i0 < __array_native__managedSpan.Length; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    __array_native__nativeSpan[__i0] = (System.IntPtr)global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(__array_native__managedSpan[__i0], out __array_native__nativeSpan____i0__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(__array_native__managedSpan[__i0]).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements));
                }
            }
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // CleanupFailure - Perform required cleanup.
            ;
            {
                System.ReadOnlySpan<System.IntPtr> __array_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int[], System.IntPtr>.GetUnmanagedValuesSource(__array_native__out, __array_native__numElements);
                for (int __i0 = 0; __i0 < __array_native__nativeSpan.Length; ++__i0)
                {
                    int __array_native__nativeSpan____i0__numElements;
                    System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__nativeSpan____i0__numElements);
                    ;
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free((int*)__array_native__nativeSpan[__i0]);
                }
            };
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__invokeRetValUnmanaged__param = __invokeRetValUnmanaged__out;
        *__widths_native__param = __widths_native__out;
        *__array_native__param = __array_native__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Set(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, System.IntPtr* __array_native, int* __widths_native, int length)
    {
        global::SharedTypes.ComInterfaces.IJaggedIntArray @this = default;
        int[][] array = default;
        int[] widths = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __widths_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __widths_native__numElements);
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
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
                    __array_native__nativeSpan____i0__numElements = widths[__i0];
                    __array_native__managedSpan[__i0] = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource((int*)__array_native__nativeSpan[__i0], __array_native__nativeSpan____i0__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(__array_native__managedSpan[__i0]));
                }
            }

            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IJaggedIntArray>(__this_native);
            @this.Set(array, widths, length);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IJaggedIntArray), sizeof(void*) * 6);
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

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IJaggedIntArray
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IJaggedIntArray
    {
    }
}