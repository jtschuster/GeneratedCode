﻿// <auto-generated />
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 253, 227, 255, 58, 30, 209, 149, 65, 130, 80, 12, 115, 50, 25, 119, 160 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.StringMarshallingUtf8_2(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        byte* __input_native = default;
        string __retVal;
        byte* __retVal_native = default;
        int __invokeRetVal;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn __input_native__marshaller = new();
        try
        {
            // Marshal - Convert managed data to native data.
            __input_native__marshaller.FromManaged(input, stackalloc byte[global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __input_native = __input_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, byte**, int> )__vtable_native[6])(__this, __input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__retVal_native);
            __input_native__marshaller.Free();
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.MarshalAsLPWString_2(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        string __retVal;
        ushort* __retVal_native = default;
        int __invokeRetVal;
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __input_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(input))
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort**, int> )__vtable_native[7])(__this, (ushort*)__input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.MarshalUsingUtf16_2(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        string __retVal;
        ushort* __retVal_native = default;
        int __invokeRetVal;
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __input_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(input))
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort**, int> )__vtable_native[8])(__this, (ushort*)__input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.StringMarshallingUtf8(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        byte* __input_native = default;
        string __retVal;
        byte* __retVal_native = default;
        int __invokeRetVal;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn __input_native__marshaller = new();
        try
        {
            // Marshal - Convert managed data to native data.
            __input_native__marshaller.FromManaged(input, stackalloc byte[global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __input_native = __input_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte*, byte**, int> )__vtable_native[3])(__this, __input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__retVal_native);
            __input_native__marshaller.Free();
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.MarshalAsLPWString(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        string __retVal;
        ushort* __retVal_native = default;
        int __invokeRetVal;
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __input_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(input))
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort**, int> )__vtable_native[4])(__this, (ushort*)__input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived.MarshalUsingUtf16(string input)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived));
        string __retVal;
        ushort* __retVal_native = default;
        int __invokeRetVal;
        try
        {
            // Pin - Pin data in preparation for calling the P/Invoke.
            fixed (void* __input_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(input))
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, ushort**, int> )__vtable_native[5])(__this, (ushort*)__input_native, &__retVal_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            __retVal = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__retVal_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__retVal_native);
        }

        return __retVal;
    }

    string global::SharedTypes.ComInterfaces.IStringMarshallingOverride.StringMarshallingUtf8(string input) => throw new System.Diagnostics.UnreachableException();
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverride.MarshalAsLPWString(string input) => throw new System.Diagnostics.UnreachableException();
    string global::SharedTypes.ComInterfaces.IStringMarshallingOverride.MarshalUsingUtf16(string input) => throw new System.Diagnostics.UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_StringMarshallingUtf8_2(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte* __input_native, byte** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived @this = default;
        string input = default;
        ref byte* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        string __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            input = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__input_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived>(__this_native);
            __invokeRetVal = @this.StringMarshallingUtf8_2(input);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = (byte*)global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MarshalAsLPWString_2(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort* __input_native, ushort** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived @this = default;
        string input = default;
        ref ushort* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        string __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            input = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__input_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived>(__this_native);
            __invokeRetVal = @this.MarshalAsLPWString_2(input);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = (ushort*)global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_MarshalUsingUtf16_2(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort* __input_native, ushort** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived @this = default;
        string input = default;
        ref ushort* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        string __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            input = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__input_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived>(__this_native);
            __invokeRetVal = @this.MarshalUsingUtf16_2(input);
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = (ushort*)global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToUnmanaged(__invokeRetVal);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverrideDerived), sizeof(void*) * 9);
        {
            System.Runtime.InteropServices.NativeMemory.Copy(System.Runtime.InteropServices.Marshalling.StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(global::SharedTypes.ComInterfaces.IStringMarshallingOverride).TypeHandle).ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 6));
        }

        {
            vtable[6] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte*, byte**, int> )&ABI_StringMarshallingUtf8_2;
            vtable[7] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort*, ushort**, int> )&ABI_MarshalAsLPWString_2;
            vtable[8] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort*, ushort**, int> )&ABI_MarshalUsingUtf16_2;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IStringMarshallingOverrideDerived
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IStringMarshallingOverrideDerived
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        new string StringMarshallingUtf8(string input) => ((global::SharedTypes.ComInterfaces.IStringMarshallingOverride)this).StringMarshallingUtf8(input);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        new string MarshalAsLPWString(string input) => ((global::SharedTypes.ComInterfaces.IStringMarshallingOverride)this).MarshalAsLPWString(input);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        new string MarshalUsingUtf16(string input) => ((global::SharedTypes.ComInterfaces.IStringMarshallingOverride)this).MarshalUsingUtf16(input);
    }
}