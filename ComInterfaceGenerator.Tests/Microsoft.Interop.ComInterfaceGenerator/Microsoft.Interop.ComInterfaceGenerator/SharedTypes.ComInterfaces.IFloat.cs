﻿// <auto-generated />
#pragma warning disable CS0612, CS0618
file unsafe class InterfaceInformation : global::System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static global::System.Guid Iid { get; } = new(new global::System.ReadOnlySpan<byte>(new byte[] { 169, 168, 164, 159, 143, 45, 168, 72, 182, 251, 180, 75, 95, 27, 159, 182 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[global::System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IFloat
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    float global::SharedTypes.ComInterfaces.IFloat.Get()
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IFloat));
        float __retVal;
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, float*, int> )__vtable_native[3])(__this, &__retVal);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
        return __retVal;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IFloat.Set(float value)
    {
        var(__this, __vtable_native) = ((global::System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IFloat));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged[MemberFunction]<void*, float, int> )__vtable_native[4])(__this, value);
        }

        // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
        global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        global::System.GC.KeepAlive(this);
    }
}

file unsafe partial interface InterfaceImplementation
{
    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Get(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, float* __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IFloat @this = default;
        ref float __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        float __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IFloat>(__this_native);
            __invokeRetVal = @this.Get();
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = __invokeRetVal;
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }

    [global::System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute(CallConvs = new[] { typeof(global::System.Runtime.CompilerServices.CallConvMemberFunction) })]
    internal static int ABI_Set(global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, float value)
    {
        global::SharedTypes.ComInterfaces.IFloat @this = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            @this = global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IFloat>(__this_native);
            @this.Set(value);
            // NotifyForSuccessfulInvoke - Keep alive any managed objects that need to stay alive across the call.
            __retVal = 0; // S_OK
        }
        catch (global::System.Exception __exception)
        {
            __retVal = global::System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)global::System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IFloat), sizeof(void*) * 5);
        {
            nint v0, v1, v2;
            global::System.Runtime.InteropServices.ComWrappers.GetIUnknownImpl(out v0, out v1, out v2);
            vtable[0] = (void*)v0;
            vtable[1] = (void*)v1;
            vtable[2] = (void*)v2;
        }

        {
            vtable[3] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, float*, int> )&ABI_Get;
            vtable[4] = (void*)(delegate* unmanaged[MemberFunction]<global::System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, float, int> )&ABI_Set;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [global::System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IFloat
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IFloat
    {
    }
}