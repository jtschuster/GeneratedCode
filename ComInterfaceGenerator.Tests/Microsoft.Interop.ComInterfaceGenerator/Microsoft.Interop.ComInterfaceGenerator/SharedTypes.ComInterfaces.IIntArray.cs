﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : global::System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static global::System.Guid Iid { get; } = new(new global::System.ReadOnlySpan<byte>(new byte[] { 169, 168, 164, 159, 143, 61, 168, 72, 182, 251, 180, 91, 95, 27, 159, 182 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[global::System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IIntArray
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int[] global::SharedTypes.ComInterfaces.IIntArray.GetReturn(out int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        bool __invokeSucceeded = default;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out size);
        int[] __retVal = default;
        int* __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int**, int> )__vtable_native[3])(__this, __size_native, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal_native__numElements = size;
            __retVal = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__retVal_native);
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::SharedTypes.ComInterfaces.IIntArray.GetOut(out int[] array)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        bool __invokeSucceeded = default;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out array);
        int* __array_native = default;
        int __retVal = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int*, int> )__vtable_native[4])(__this, &__array_native, &__retVal);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = __retVal;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.SetContents(int[] array, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __array_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(array))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int, int> )__vtable_native[5])(__this, (int*)__array_native, size);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.FillAscending(int[] array, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __array_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(array))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int, int> )__vtable_native[6])(__this, (int*)__array_native, size);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.Double(int[] array, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __array_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(array))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int*, int, int> )__vtable_native[7])(__this, (int*)__array_native, size);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.PassIn(in int[] array, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int* __array_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn __array_native__marshaller = new();
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
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
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int, int> )__vtable_native[8])(__this, &__array_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __array_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IIntArray.SwapArray(ref int[] array, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IIntArray));
        int* __array_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __array_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements));
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int**, int, int> )__vtable_native[9])(__this, &__array_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __array_native__numElements = size;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native);
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetReturn(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __size_native__param, int** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        ref int* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int[] __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __invokeRetValUnmanaged__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            __invokeRetVal = @this.GetReturn(out size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __size_native = size;
            __invokeRetValUnmanaged = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(__invokeRetVal).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__invokeRetValUnmanaged, __invokeRetValUnmanaged__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetOut(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        ref int* __array_native = ref *__array_native__param;
        int[] array = default;
        ref int __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        int __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            __invokeRetVal = @this.GetOut(out array);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = __invokeRetVal;
            __array_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_SetContents(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __array_native, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.SetContents(array, size);
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
    internal static int ABI_FillAscending(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __array_native, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array).Clear();
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.FillAscending(array, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array).CopyTo(global::System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements)), global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).Length));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Double(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int* __array_native, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.Double(array, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array).CopyTo(global::System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements)), global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).Length));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_PassIn(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        ref int* __array_native = ref *__array_native__param;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.PassIn(in array, size);
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
    internal static int ABI_SwapArray(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int** __array_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IIntArray @this = default;
        ref int* __array_native = ref *__array_native__param;
        int[] array = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __array_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __array_native__numElements);
        bool __array_native__ownOriginal = false;
        int* __array_native__original = __array_native;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __array_native__numElements = size;
            array = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__array_native, __array_native__numElements);
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__array_native, __array_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(array));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IIntArray>(__this_native);
            @this.SwapArray(ref array, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __array_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(array, out __array_native__numElements);
            __array_native__ownOriginal = true;
            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(array).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__array_native, __array_native__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            if (__array_native__ownOriginal)
            {
                __array_native__numElements = size;
                global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__array_native__original);
            }
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)global::System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IIntArray), sizeof(void*) * 10);
        {
            nint v0, v1, v2;
            global::System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int**, int> )&ABI_GetReturn;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int*, int> )&ABI_GetOut;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int, int> )&ABI_SetContents;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int, int> )&ABI_FillAscending;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int*, int, int> )&ABI_Double;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int, int> )&ABI_PassIn;
            vtable[9] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int**, int, int> )&ABI_SwapArray;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [global::System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
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