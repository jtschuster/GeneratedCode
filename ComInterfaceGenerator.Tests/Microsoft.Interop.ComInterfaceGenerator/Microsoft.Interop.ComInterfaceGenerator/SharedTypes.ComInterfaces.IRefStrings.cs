﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 219, 183, 70, 81, 136, 5, 155, 70, 184, 229, 179, 128, 144, 162, 252, 21 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IRefStrings
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IRefStrings.RefString(ref string value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IRefStrings));
        byte* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native = (byte*)global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToUnmanaged(value);
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int> )__vtable_native[3])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            value = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__value_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__value_native);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IRefStrings.InString(in string value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IRefStrings));
        byte* __value_native = default;
        int __invokeRetVal = default;
        // Setup - Perform required setup.
        scoped global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn __value_native__marshaller = new();
        try
        {
            // Marshal - Convert managed data to native data.
            __value_native__marshaller.FromManaged(value, stackalloc byte[global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            {
                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                __value_native = __value_native__marshaller.ToUnmanaged();
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int> )__vtable_native[4])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            __value_native__marshaller.Free();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IRefStrings.OutString(out string value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IRefStrings));
        System.Runtime.CompilerServices.Unsafe.SkipInit(out value);
        byte* __value_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, byte**, int> )__vtable_native[5])(__this, &__value_native);
            }

            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            value = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__value_native);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__value_native);
        }
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_RefString(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IRefStrings @this = default;
        byte* __value_native__out = default;
        byte* __value_native = *__value_native__param;
        string value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IRefStrings>(__this_native);
            @this.RefString(ref value);
            // Marshal - Convert managed data to native data.
            __value_native__out = (byte*)global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToUnmanaged(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__value_native__out);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__value_native__param = __value_native__out;
        // Cleanup - Perform required cleanup.
        global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.Free(__value_native);
        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_InString(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IRefStrings @this = default;
        byte* __value_native = *__value_native__param;
        string value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IRefStrings>(__this_native);
            @this.InString(in value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_OutString(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, byte** __value_native__param)
    {
        global::SharedTypes.ComInterfaces.IRefStrings @this = default;
        byte* __value_native__out = default;
        byte* __value_native = *__value_native__param;
        string value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IRefStrings>(__this_native);
            @this.OutString(out value);
            // Marshal - Convert managed data to native data.
            __value_native__out = (byte*)global::System.Runtime.InteropServices.Marshalling.Utf8StringMarshaller.ConvertToUnmanaged(value);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
            return __retVal;
        }

        // AssignOut - Assign to parameters
        *__value_native__param = __value_native__out;
        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IRefStrings), sizeof(void*) * 6);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int> )&ABI_RefString;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int> )&ABI_InString;
            vtable[5] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, byte**, int> )&ABI_OutString;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IRefStrings
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IRefStrings
    {
    }
}