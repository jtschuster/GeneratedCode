﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : global::System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static global::System.Guid Iid { get; } = new(new global::System.ReadOnlySpan<byte>(new byte[] { 153, 12, 187, 59, 108, 125, 209, 74, 190, 76, 172, 180, 194, 18, 127, 2 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[global::System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.Method(global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> p, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __p_native = &global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetPinnableReference(p))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>, int, int> )__vtable_native[3])(__this, (global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>)__p_native, size);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.MethodIn(in global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pIn, in int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pIn_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pIn_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pIn_native = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(pIn, out __pIn_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(pIn).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__pIn_native, __pIn_native__numElements));
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int*, int> )__vtable_native[4])(__this, &__pIn_native, __size_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __pIn_native__numElements = 0;
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.Free(__pIn_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.MethodRef(ref global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pRef, int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pRef_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pRef_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pRef_native = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForUnmanagedElements(pRef, out __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesSource(pRef).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesDestination(__pRef_native, __pRef_native__numElements));
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int, int> )__vtable_native[5])(__this, &__pRef_native, size);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __pRef_native__numElements = size;
            pRef = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForManagedElements(__pRef_native, __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesSource(__pRef_native, __pRef_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesDestination(pRef));
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            __pRef_native__numElements = size;
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.Free(__pRef_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.MethodOut(out global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pOut, out int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        bool __invokeSucceeded = default;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out pOut);
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out size);
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pOut_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __pOut_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int*, int> )__vtable_native[6])(__this, &__pOut_native, __size_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __pOut_native__numElements = size;
            pOut = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__pOut_native, __pOut_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__pOut_native, __pOut_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(pOut));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__pOut_native);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.Return(int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int> )__vtable_native[7])(__this, size, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal_native__numElements = size;
            __retVal = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements.ReturnPreserveSig(int size)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements));
        bool __invokeSucceeded = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __retVal_native = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __retVal_native = ((delegate* unmanaged[MemberFunction]<void*, int, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>> )__vtable_native[8])(__this, size);
            }

            __invokeSucceeded = true;
            global::System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            __retVal_native__numElements = size;
            __retVal = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__retVal_native, __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__retVal_native, __retVal_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(__retVal));
        }
        finally
        {
            if (__invokeSucceeded)
            {
                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.Free(__retVal_native);
            }
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __p_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> p = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __p_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __p_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __p_native__numElements = size;
            p = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__p_native, __p_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__p_native, __p_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(p));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            @this.Method(p, size);
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
    internal static int ABI_MethodIn(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>* __pIn_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pIn_native = ref *__pIn_native__param;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pIn = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pIn_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            size = __size_native;
            __pIn_native__numElements = size;
            pIn = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.AllocateContainerForManagedElements(__pIn_native, __pIn_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetUnmanagedValuesSource(__pIn_native, __pIn_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.UnmanagedToManaged.GetManagedValuesDestination(pIn));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            @this.MethodIn(in pIn, in size);
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
    internal static int ABI_MethodRef(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>* __pRef_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pRef_native = ref *__pRef_native__param;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pRef = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pRef_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        bool __pRef_native__ownOriginal = false;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pRef_native__original = __pRef_native;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __pRef_native__numElements = size;
            pRef = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForManagedElements(__pRef_native, __pRef_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesSource(__pRef_native, __pRef_native__numElements).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesDestination(pRef));
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            @this.MethodRef(ref pRef, size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __pRef_native = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.AllocateContainerForUnmanagedElements(pRef, out __pRef_native__numElements);
            __pRef_native__ownOriginal = true;
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetManagedValuesSource(pRef).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.GetUnmanagedValuesDestination(__pRef_native, __pRef_native__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
            if (__pRef_native__ownOriginal)
            {
                __pRef_native__numElements = size;
                global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.Bidirectional.Free(__pRef_native__original);
            }
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>* __pOut_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __pOut_native = ref *__pOut_native__param;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> pOut = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __pOut_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            @this.MethodOut(out pOut, out size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __size_native = size;
            __pOut_native = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(pOut, out __pOut_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(pOut).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__pOut_native, __pOut_native__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int size, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        ref global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        int __invokeRetValUnmanaged__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            __invokeRetVal = @this.Return(size);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(__invokeRetVal, out __invokeRetValUnmanaged__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(__invokeRetVal).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__invokeRetValUnmanaged, __invokeRetValUnmanaged__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> ABI_ReturnPreserveSig(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements @this = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollection<int> __retVal = default;
        global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int> __retVal_native = default;
        // Setup - Perform required setup.
        int __retVal_native__numElements;
        global::System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements>(__this_native);
            __retVal = @this.ReturnPreserveSig(size);
            // Marshal - Convert managed data to native data.
            __retVal_native = global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.AllocateContainerForUnmanagedElements(__retVal, out __retVal_native__numElements);
            global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetManagedValuesSource(__retVal).CopyTo(global::SharedTypes.ComInterfaces.StatelessPinnableCollectionMarshaller<int, int>.ManagedToUnmanaged.GetUnmanagedValuesDestination(__retVal_native, __retVal_native__numElements));
        }
        catch (global::System.Exception __exception)
        {
            __retVal_native = global::System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>>.ConvertToUnmanaged(__exception);
        }

        return __retVal_native;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)global::System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatelessPinnableCollectionBlittableElements), sizeof(void*) * 9);
        {
            nint v0, v1, v2;
            global::System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>, int, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int*, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int, int> )&ABI_MethodRef;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int*, int> )&ABI_MethodOut;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>*, int> )&ABI_Return;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, global::SharedTypes.ComInterfaces.StatelessPinnableCollectionNative<int>> )&ABI_ReturnPreserveSig;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [global::System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStatelessPinnableCollectionBlittableElements
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStatelessPinnableCollectionBlittableElements
    {
    }
}