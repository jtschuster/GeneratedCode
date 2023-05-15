file unsafe class InterfaceInformation : System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
{
    public static System.Guid Iid { get; } = new(new System.ReadOnlySpan<byte>(new byte[] { 80, 159, 209, 149, 216, 242, 97, 78, 136, 75, 10, 145, 98, 234, 70, 70 }));

    private static void** _vtable;
    public static void** ManagedVirtualMethodTable => _vtable != null ? _vtable : (_vtable = InterfaceImplementation.CreateManagedVirtualFunctionTable());
}

[System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute]
file unsafe partial interface InterfaceImplementation : global::SharedTypes.ComInterfaces.Empty
{
}

file unsafe partial interface InterfaceImplementation
{
}

file unsafe partial interface InterfaceImplementation
{
    internal static void** CreateManagedVirtualFunctionTable()
    {
        return null;
    }
}

namespace SharedTypes.ComInterfaces
{
    [System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<InterfaceInformation, InterfaceImplementation>]
    internal partial interface Empty
    {
    }
}

namespace SharedTypes.ComInterfaces
{
    internal partial interface Empty
    {
    }
}