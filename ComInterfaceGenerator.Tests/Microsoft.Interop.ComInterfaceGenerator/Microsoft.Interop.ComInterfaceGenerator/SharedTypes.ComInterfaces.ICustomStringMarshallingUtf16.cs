﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 62, 95, 29, 225, 87, 221, 166, 65, 165, 158, 125, 17, 5, 81, 167, 96 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16.GetString()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16));
        string __retVal = default;
        ushort* __retVal_native = default;
        int __invokeRetVal = default;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort**, int> )__vtable_native[3])(__this, &__retVal_native);
            }

            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
            System.GC.KeepAlive(this);
            // Unmarshal - Convert native data to managed data.
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
    void global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16.SetString(string value)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __value_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(value))
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, ushort*, int> )__vtable_native[4])(__this, (ushort*)__value_native);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        System.GC.KeepAlive(this);
    }
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_GetString(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16 @this = default;
        ref ushort* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        string __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16>(__this_native);
            __invokeRetVal = @this.GetString();
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
    internal static int ABI_SetString(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort* __value_native)
    {
        global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16 @this = default;
        string value = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            value = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__value_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16>(__this_native);
            @this.SetString(value);
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
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.ICustomStringMarshallingUtf16), sizeof(void*) * 5);
        {
            nint v0, v1, v2;
            System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort**, int> )&ABI_GetString;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort*, int> )&ABI_SetString;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface ICustomStringMarshallingUtf16
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface ICustomStringMarshallingUtf16
    {
    }
}