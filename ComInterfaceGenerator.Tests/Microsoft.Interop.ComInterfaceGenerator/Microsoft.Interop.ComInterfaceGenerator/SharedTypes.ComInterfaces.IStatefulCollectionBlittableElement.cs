﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 124, 183, 82, 10, 139, 224, 116, 66, 161, 244, 26, 43, 242, 192, 126, 96 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement.Method(global::SharedTypes.ComInterfaces.StatefulCollection<int> p, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement));
        byte* __p_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __p_native__marshaller = new();
        int __p_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __p_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __p_native__marshaller.FromManaged(p);
            __p_native__marshaller.GetManagedValuesSource().CopyTo(__p_native__marshaller.GetUnmanagedValuesDestination());
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __p_native = __p_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, int, int> )__vtable_native[3])(__this, __p_native, size);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __p_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement.MethodIn(in global::SharedTypes.ComInterfaces.StatefulCollection<int> pIn, in int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement));
        byte* __pIn_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pIn_native__marshaller = new();
        int __pIn_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pIn_native__marshaller.FromManaged(pIn);
            __pIn_native__marshaller.GetManagedValuesSource().CopyTo(__pIn_native__marshaller.GetUnmanagedValuesDestination());
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __pIn_native = __pIn_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int*, int> )__vtable_native[4])(__this, &__pIn_native, __size_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __pIn_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement.MethodRef(ref global::SharedTypes.ComInterfaces.StatefulCollection<int> pRef, int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement));
        byte* __pRef_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pRef_native__marshaller = new();
        int __pRef_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        try
        {
            // Marshal - Convert managed data to native data.
            __pRef_native__marshaller.FromManaged(pRef);
            __pRef_native__marshaller.GetManagedValuesSource().CopyTo(__pRef_native__marshaller.GetUnmanagedValuesDestination());
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __pRef_native = __pRef_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int, int> )__vtable_native[5])(__this, &__pRef_native, size);
            }

            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __pRef_native__marshaller.FromUnmanaged(__pRef_native);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __pRef_native__numElements = size;
            __pRef_native__marshaller.GetUnmanagedValuesSource(__pRef_native__numElements).CopyTo(__pRef_native__marshaller.GetManagedValuesDestination(__pRef_native__numElements));
            pRef = __pRef_native__marshaller.ToManaged();
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __pRef_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement.MethodOut(out global::SharedTypes.ComInterfaces.StatefulCollection<int> pOut, out int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out pOut);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out size);
        byte* __pOut_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pOut_native__marshaller = new();
        int __pOut_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (int* __size_native = &size)
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int*, int> )__vtable_native[6])(__this, &__pOut_native, __size_native);
            }

            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __pOut_native__marshaller.FromUnmanaged(__pOut_native);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __pOut_native__numElements = size;
            __pOut_native__marshaller.GetUnmanagedValuesSource(__pOut_native__numElements).CopyTo(__pOut_native__marshaller.GetManagedValuesDestination(__pOut_native__numElements));
            pOut = __pOut_native__marshaller.ToManaged();
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __pOut_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    global::SharedTypes.ComInterfaces.StatefulCollection<int> global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement.Return(int size)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement));
        global::SharedTypes.ComInterfaces.StatefulCollection<int> __retVal = default;
        byte* __retVal_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __retVal_native__marshaller = new();
        int __retVal_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __retVal_native__numElements);
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, int, byte**, int> )__vtable_native[7])(__this, size, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __retVal_native__marshaller.FromUnmanaged(__retVal_native);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal_native__numElements = size;
            __retVal_native__marshaller.GetUnmanagedValuesSource(__retVal_native__numElements).CopyTo(__retVal_native__marshaller.GetManagedValuesDestination(__retVal_native__numElements));
            __retVal = __retVal_native__marshaller.ToManaged();
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __retVal_native__marshaller.Free();
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Method(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte* __p_native, int size)
    {
        global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement @this = default;
        global::SharedTypes.ComInterfaces.StatefulCollection<int> p = default;
        int __retVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __p_native__marshaller = new();
        int __p_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __p_native__numElements);
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __p_native__marshaller.FromUnmanaged(__p_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __p_native__numElements = size;
            __p_native__marshaller.GetUnmanagedValuesSource(__p_native__numElements).CopyTo(__p_native__marshaller.GetManagedValuesDestination(__p_native__numElements));
            p = __p_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement>(__this_native);
            @this.Method(p, size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __p_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodIn(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __pIn_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement @this = default;
        ref byte* __pIn_native = ref *__pIn_native__param;
        global::SharedTypes.ComInterfaces.StatefulCollection<int> pIn = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pIn_native__marshaller = new();
        int __pIn_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pIn_native__numElements);
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __pIn_native__marshaller.FromUnmanaged(__pIn_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            size = __size_native;
            __pIn_native__numElements = size;
            __pIn_native__marshaller.GetUnmanagedValuesSource(__pIn_native__numElements).CopyTo(__pIn_native__marshaller.GetManagedValuesDestination(__pIn_native__numElements));
            pIn = __pIn_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement>(__this_native);
            @this.MethodIn(in pIn, in size);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __pIn_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodRef(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __pRef_native__param, int size)
    {
        global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement @this = default;
        ref byte* __pRef_native = ref *__pRef_native__param;
        global::SharedTypes.ComInterfaces.StatefulCollection<int> pRef = default;
        int __retVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pRef_native__marshaller = new();
        bool __pRef_native__ownOriginal = false;
        byte* __pRef_native__original = __pRef_native;
        int __pRef_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pRef_native__numElements);
        try
        {
            // UnmarshalCapture - Capture the native data into marshaller instances in case conversion to managed data throws an exception.
            __pRef_native__marshaller.FromUnmanaged(__pRef_native);
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            __pRef_native__numElements = size;
            __pRef_native__marshaller.GetUnmanagedValuesSource(__pRef_native__numElements).CopyTo(__pRef_native__marshaller.GetManagedValuesDestination(__pRef_native__numElements));
            pRef = __pRef_native__marshaller.ToManaged();
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement>(__this_native);
            @this.MethodRef(ref pRef, size);
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __pRef_native = __pRef_native__marshaller.ToUnmanaged();
            // Marshal - Convert managed data to native data.
            __pRef_native__marshaller.FromManaged(pRef);
            __pRef_native__ownOriginal = true;
            __pRef_native__marshaller.GetManagedValuesSource().CopyTo(__pRef_native__marshaller.GetUnmanagedValuesDestination());
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            if (__pRef_native__ownOriginal)
            {
            }

            __pRef_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MethodOut(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __pOut_native__param, int* __size_native__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement @this = default;
        ref byte* __pOut_native = ref *__pOut_native__param;
        global::SharedTypes.ComInterfaces.StatefulCollection<int> pOut = default;
        ref int __size_native = ref *__size_native__param;
        int size = default;
        int __retVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __pOut_native__marshaller = new();
        int __pOut_native__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __pOut_native__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement>(__this_native);
            @this.MethodOut(out pOut, out size);
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __pOut_native = __pOut_native__marshaller.ToUnmanaged();
            // Marshal - Convert managed data to native data.
            __size_native = size;
            __pOut_native__marshaller.FromManaged(pOut);
            __pOut_native__marshaller.GetManagedValuesSource().CopyTo(__pOut_native__marshaller.GetUnmanagedValuesDestination());
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __pOut_native__marshaller.Free();
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Return(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, int size, byte** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement @this = default;
        ref byte* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        global::SharedTypes.ComInterfaces.StatefulCollection<int> __invokeRetVal = default;
        int __retVal = default;
        // Setup - Perform required setup.
        scoped global::SharedTypes.ComInterfaces.StatefulCollectionMarshaller<int, int>.Default __invokeRetValUnmanaged__marshaller = new();
        int __invokeRetValUnmanaged__numElements;
        System.Runtime.CompilerServices.Unsafe.SkipInit(out __invokeRetValUnmanaged__numElements);
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement>(__this_native);
            __invokeRetVal = @this.Return(size);
            // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
            __invokeRetValUnmanaged = __invokeRetValUnmanaged__marshaller.ToUnmanaged();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged__marshaller.FromManaged(__invokeRetVal);
            __invokeRetValUnmanaged__marshaller.GetManagedValuesSource().CopyTo(__invokeRetValUnmanaged__marshaller.GetUnmanagedValuesDestination());
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __invokeRetValUnmanaged__marshaller.Free();
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStatefulCollectionBlittableElement), sizeof(void*) * 8);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte*, int, int> )&ABI_Method;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int*, int> )&ABI_MethodIn;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int, int> )&ABI_MethodRef;
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int*, int> )&ABI_MethodOut;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, int, byte**, int> )&ABI_Return;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    partial interface IStatefulCollectionBlittableElement
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    partial interface IStatefulCollectionBlittableElement
    {
    }
}