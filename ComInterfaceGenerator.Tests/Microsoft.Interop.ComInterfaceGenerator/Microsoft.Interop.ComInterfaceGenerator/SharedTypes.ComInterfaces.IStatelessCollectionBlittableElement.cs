﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 124, 183, 82, 10, 139, 224, 116, 66, 161, 244, 26, 43, 242, 192, 126, 96 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.Method(global::SharedTypes.ComInterfaces.StatelessCollection<int> p, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        global::SharedTypes.ComInterfaces.NativeCollection<int> __p_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __p_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __p_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __p_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(p, out __p_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(p).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__p_native, __p_native__numElements));
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.NativeCollection<int>, int, int> )__vtable_native[3])(__this, __p_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __p_native__numElements = 0;
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.Free(__p_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.MethodIn(in global::SharedTypes.ComInterfaces.StatelessCollection<int> pIn, in int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        global::SharedTypes.ComInterfaces.NativeCollection<int> __pIn_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pIn_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pIn_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(pIn, out __pIn_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(pIn).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__pIn_native, __pIn_native__numElements));
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int*, int> )__vtable_native[4])(__this, &__pIn_native, __size_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __pIn_native__numElements = 0;
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.Free(__pIn_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.MethodRef(ref global::SharedTypes.ComInterfaces.StatelessCollection<int> pRef, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        global::SharedTypes.ComInterfaces.NativeCollection<int> __pRef_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pRef_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pRef_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForUnmanagedElements(pRef, out __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesSource(pRef).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesDestination(__pRef_native, __pRef_native__numElements));
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int, int> )__vtable_native[5])(__this, &__pRef_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __pRef_native__numElements = size;
            pRef = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForManagedElements(__pRef_native, __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesSource(__pRef_native, __pRef_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesDestination(pRef));
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __pRef_native__numElements = size;
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.Free(__pRef_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.MethodOut(out global::SharedTypes.ComInterfaces.StatelessCollection<int> pOut, out int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        bool __invokeSucceeded = default;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out pOut);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out size);
        global::SharedTypes.ComInterfaces.NativeCollection<int> __pOut_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pOut_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int*, int> )__vtable_native[6])(__this, &__pOut_native, __size_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __pOut_native__numElements = size;
            pOut = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__pOut_native, __pOut_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__pOut_native, __pOut_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(pOut));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__pOut_native);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessCollection<int> global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.Return(int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.NativeCollection<int> __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int> )__vtable_native[7])(__this, size, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal_native__numElements = size;
            __retVal = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessCollection<int> global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement.ReturnPreserveSig(int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.NativeCollection<int> __retVal_native = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, int, global::SharedTypes.ComInterfaces.NativeCollection<int>> )__vtable_native[8])(__this, size);
            }

            __invokeSucceeded = true;
            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal_native__numElements = size;
            __retVal = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.NativeCollection<int> __p_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> p = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __p_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __p_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __p_native__numElements = size;
            p = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__p_native, __p_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__p_native, __p_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(p));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            @this.Method(p, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.NativeCollection<int>* __pIn_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        ref global::SharedTypes.ComInterfaces.NativeCollection<int> __pIn_native = ref *__pIn_native__param;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> pIn = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pIn_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            size = __size_native;
            __pIn_native__numElements = size;
            pIn = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__pIn_native, __pIn_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__pIn_native, __pIn_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(pIn));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            @this.MethodIn(in pIn, in size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.NativeCollection<int>* __pRef_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        ref global::SharedTypes.ComInterfaces.NativeCollection<int> __pRef_native = ref *__pRef_native__param;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> pRef = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pRef_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        bool __pRef_native__ownOriginal = false;
        global::SharedTypes.ComInterfaces.NativeCollection<int> __pRef_native__original = __pRef_native;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __pRef_native__numElements = size;
            pRef = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForManagedElements(__pRef_native, __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesSource(__pRef_native, __pRef_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesDestination(pRef));
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            @this.MethodRef(ref pRef, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __pRef_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForUnmanagedElements(pRef, out __pRef_native__numElements);
            __pRef_native__ownOriginal = true;
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesSource(pRef).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesDestination(__pRef_native, __pRef_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            if (__pRef_native__ownOriginal)
            {
                __pRef_native__numElements = size;
                global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.Bidirectional.Free(__pRef_native__original);
            }
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.NativeCollection<int>* __pOut_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        ref global::SharedTypes.ComInterfaces.NativeCollection<int> __pOut_native = ref *__pOut_native__param;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> pOut = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pOut_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            @this.MethodOut(out pOut, out size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __size_native = size;
            __pOut_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(pOut, out __pOut_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(pOut).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__pOut_native, __pOut_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int size, global::SharedTypes.ComInterfaces.NativeCollection<int>* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        ref global::SharedTypes.ComInterfaces.NativeCollection<int> __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            __invokeRetVal = @this.Return(size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(__invokeRetVal).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__invokeRetValUnmanaged, __invokeRetValUnmanaged__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static global::SharedTypes.ComInterfaces.NativeCollection<int> ABI_ReturnPreserveSig(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement @this = default;
        global::SharedTypes.ComInterfaces.StatelessCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.NativeCollection<int> __retVal_native = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement>(__this_native);
            __retVal = @this.ReturnPreserveSig(size);
            // Marshal - Convert managed data to native data.
            __retVal_native = global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(__retVal, out __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(__retVal).CopyTo(global::SharedTypes.ComInterfaces.StatelessCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__retVal_native, __retVal_native__numElements));
        }
        catch (System.Exception __exception)
        {
            __retVal_native = System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<global::SharedTypes.ComInterfaces.NativeCollection<int>>.ConvertToUnmanaged(__exception);
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatelessCollectionBlittableElement), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.NativeCollection<int>, int, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int*, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int, int> )&ABI_MethodRef;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int*, int> )&ABI_MethodOut;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, global::SharedTypes.ComInterfaces.NativeCollection<int>*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, global::SharedTypes.ComInterfaces.NativeCollection<int>> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    partial interface IStatelessCollectionBlittableElement
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    partial interface IStatelessCollectionBlittableElement
    {
    }
}