﻿file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 100, 179, 13, 127, 4, 60, 135, 68, 145, 147, 75, 176, 93, 199, 182, 84 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.IDerivedComInterface
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IDerivedComInterface.SetName(string name)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IDerivedComInterface));
        int __invokeRetVal;
        // Pin - Pin data in preparation for calling the P/Invoke.
        fixed (void* __name_native = &global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.GetPinnableReference(name))
        {
            __invokeRetVal = ((delegate* unmanaged<void*, ushort*, int> )__vtable_native[5])(__this, (ushort*)__name_native);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    string global::SharedTypes.ComInterfaces.IDerivedComInterface.GetName()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IDerivedComInterface));
        string __retVal;
        ushort* __retVal_native = default;
        int __invokeRetVal;
        try
        {
            {
                __invokeRetVal = ((delegate* unmanaged<void*, ushort**, int> )__vtable_native[6])(__this, &__retVal_native);
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    int global::SharedTypes.ComInterfaces.IDerivedComInterface.GetInt()
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IDerivedComInterface));
        int __retVal;
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged<void*, int*, int> )__vtable_native[3])(__this, &__retVal);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
        return __retVal;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    void global::SharedTypes.ComInterfaces.IDerivedComInterface.SetInt(int x)
    {
        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::SharedTypes.ComInterfaces.IDerivedComInterface));
        int __invokeRetVal;
        {
            __invokeRetVal = ((delegate* unmanaged<void*, int, int> )__vtable_native[4])(__this, x);
        }

        System.GC.KeepAlive(this);
        // Unmarshal - Convert native data to managed data.
        System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(__invokeRetVal);
    }

    int global::SharedTypes.ComInterfaces.IGetAndSetInt.GetInt() => throw new System.Diagnostics.UnreachableException();
    void global::SharedTypes.ComInterfaces.IGetAndSetInt.SetInt(int x) => throw new System.Diagnostics.UnreachableException();
}

file unsafe partial interface InterfaceImplementation
{
    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute]
    internal static int ABI_SetName(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort* __name_native)
    {
        global::SharedTypes.ComInterfaces.IDerivedComInterface @this = default;
        string name = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            name = global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToManaged(__name_native);
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IDerivedComInterface>(__this_native);
            @this.SetName(name);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__name_native);
        }

        return __retVal;
    }

    [System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute]
    internal static int ABI_GetName(System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch* __this_native, ushort** __invokeRetValUnmanaged__param)
    {
        global::SharedTypes.ComInterfaces.IDerivedComInterface @this = default;
        ref ushort* __invokeRetValUnmanaged = ref *__invokeRetValUnmanaged__param;
        string __invokeRetVal = default;
        int __retVal = default;
        try
        {
            // Unmarshal - Convert native data to managed data.
            __retVal = 0; // S_OK
            @this = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch.GetInstance<global::SharedTypes.ComInterfaces.IDerivedComInterface>(__this_native);
            __invokeRetVal = @this.GetName();
            // Marshal - Convert managed data to native data.
            __invokeRetValUnmanaged = (ushort*)global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.ConvertToUnmanaged(__invokeRetVal);
        }
        catch (System.Exception __exception)
        {
            __retVal = System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<int>.ConvertToUnmanaged(__exception);
        }
        finally
        {
            // Cleanup - Perform required cleanup.
            global::System.Runtime.InteropServices.Marshalling.Utf16StringMarshaller.Free(__invokeRetValUnmanaged);
        }

        return __retVal;
    }
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        void** vtable = (void**)System.Runtime.CompilerServices.RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::SharedTypes.ComInterfaces.IDerivedComInterface), sizeof(void*) * 7);
        {
            System.Runtime.InteropServices.NativeMemory.Copy(System.Runtime.InteropServices.Marshalling.StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetIUnknownDerivedDetails(typeof(global::SharedTypes.ComInterfaces.IGetAndSetInt).TypeHandle).ManagedVirtualMethodTable, vtable, (nuint)(sizeof(void*) * 5));
        }

        {
            vtable[5] = (void*)(delegate* unmanaged<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort*, int> )&ABI_SetName;
            vtable[6] = (void*)(delegate* unmanaged<System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch*, ushort**, int> )&ABI_GetName;
        }

        return vtable;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface IDerivedComInterface
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface IDerivedComInterface
    {
        new int GetInt() => ((global::SharedTypes.ComInterfaces.IGetAndSetInt)this).GetInt();
        new void SetInt(int x) => ((global::SharedTypes.ComInterfaces.IGetAndSetInt)this).SetInt(x);
    }
}