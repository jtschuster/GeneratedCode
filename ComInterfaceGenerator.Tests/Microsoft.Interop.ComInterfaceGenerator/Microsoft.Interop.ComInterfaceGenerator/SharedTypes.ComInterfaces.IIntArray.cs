﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 169, 168, 164, 159, 143, 61, 168, 72, 182, 251, 180, 91, 95, 27, 159, 182 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IIntArray
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int[] global::SharedTypes.ComInterfaces.IIntArray.GetReturn(out int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out size);
        int[] __retVal = default;
        int* __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int**, int> )__vtable_native[3])(__this, __size_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal_native__numElements = size;
            __retVal = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __retVal_native__numElements = size;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::SharedTypes.ComInterfaces.IIntArray.GetOut(out int[] array)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out array);
        int* __array_native = default;
        int __retVal = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int*, int> )__vtable_native[4])(__this, &__array_native, &__retVal);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __array_native__numElements = __retVal;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __array_native__numElements = __retVal;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.SetContents(int[] array, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __array_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(array))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int, int> )__vtable_native[5])(__this, (int*)__array_native, size);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.FillAscending(int[] array, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __array_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(array))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int, int> )__vtable_native[6])(__this, (int*)__array_native, size);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.PassIn(in int[] array, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int* __array_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn __array_native__marshaller = new();
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __array_native__marshaller.FromManaged(array, stackalloc int[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.BufferSize]);
            __array_native__marshaller.GetManagedValuesSource().CopyTo(__array_native__marshaller.GetUnmanagedValuesDestination());
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __array_native__unused = __array_native__marshaller)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __array_native = __array_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int, int> )__vtable_native[7])(__this, &__array_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __array_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.SwapArray(ref int[] array, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int* __array_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __array_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements));
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int, int> )__vtable_native[8])(__this, &__array_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __array_native__numElements = size;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetReturn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __size_native__param, int** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int __size_native__out = default;
        int size = default;
        int* __invokeRetValUnmanaged__out = default;
        int[] __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            __invokeRetVal = @this.GetReturn(out size);
            // Marshal - Convert managed data to native data.
            __size_native__out = size;
            __invokeRetValUnmanaged__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(__invokeRetVal).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__invokeRetValUnmanaged__out, __invokeRetValUnmanaged__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__size_native__param = __size_native__out;
        *__invokeRetValUnmanaged__param = __invokeRetValUnmanaged__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int* __array_native__out = default;
        int[] array = default;
        int __invokeRetValUnmanaged__out = default;
        int __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            __invokeRetVal = @this.GetOut(out array);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged__out = __invokeRetVal;
            __array_native__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native__out, __array_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__invokeRetValUnmanaged__param = __invokeRetValUnmanaged__out;
        *__array_native__param = __array_native__out;
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SetContents(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __array_native, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.SetContents(array, size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_FillAscending(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __array_native, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        System.Span<int> __array_native__out;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array).Clear();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.FillAscending(array, size);
            // Marshal - Convert managed data to native data.
            {
                __array_native__numElements = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).Length;
#pragma warning disable CS9081
                __array_native__out = stackalloc int[__array_native__numElements];
#pragma warning restore CS9081
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array).CopyTo(__array_native__out);
            }
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        __array_native__out.CopyTo(System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref System.Runtime.CompilerServices.Unsafe.AsRef(in global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).GetPinnableReference()), __array_native__numElements));
        // Cleanup - Perform required cleanup.
        global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_PassIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int* __array_native = *__array_native__param;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.PassIn(in array, size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SwapArray(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int* __array_native__out = default;
        int* __array_native = *__array_native__param;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.SwapArray(ref array, size);
            // Marshal - Convert managed data to native data.
            __array_native__out = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native__out, __array_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // Cleanup - Perform required cleanup.
            __array_native__numElements = size;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native__out);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__array_native__param = __array_native__out;
        // Cleanup - Perform required cleanup.
        __array_native__numElements = size;
        global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IIntArray), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int**, int> )&ABI_GetReturn;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int*, int> )&ABI_GetOut;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int, int> )&ABI_SetContents;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int, int> )&ABI_FillAscending;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int, int> )&ABI_PassIn;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int, int> )&ABI_SwapArray;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IIntArray
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IIntArray
    {
    }
}