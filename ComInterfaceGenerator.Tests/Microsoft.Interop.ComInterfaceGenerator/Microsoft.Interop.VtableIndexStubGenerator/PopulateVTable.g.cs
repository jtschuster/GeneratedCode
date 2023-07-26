﻿// <auto-generated/>
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    internal static unsafe void PopulateUnmanagedVirtualMethodTable(void** vtable)
                    {
                        vtable[0] = (void*)(delegate* unmanaged<void*, int> )&ABI_GetData;
                        vtable[1] = (void*)(delegate* unmanaged<void*, int, void> )&ABI_SetData;
                        vtable[2] = (void*)(delegate* unmanaged<void*, int*, void> )&ABI_ExchangeData;
                        vtable[3] = (void*)(delegate* unmanaged<void*, int*, int, int*, void> )&ABI_SumAndSetData;
                        vtable[4] = (void*)(delegate* unmanaged<void*, int**, int, int*, void> )&ABI_SumAndSetData;
                        vtable[5] = (void*)(delegate* unmanaged<void*, int*, int, void> )&ABI_MultiplyWithData;
                    }
                }
            }
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class UnmanagedToManagedCustomMarshalling
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    internal static unsafe void PopulateUnmanagedVirtualMethodTable(void** vtable)
                    {
                        vtable[0] = (void*)(delegate* unmanaged<void*, int> )&ABI_GetData;
                        vtable[1] = (void*)(delegate* unmanaged<void*, int, void> )&ABI_SetData;
                        vtable[2] = (void*)(delegate* unmanaged<void*, int*, void> )&ABI_ExchangeData;
                        vtable[3] = (void*)(delegate* unmanaged<void*, int*, int, int*, void> )&ABI_SumAndSetData;
                        vtable[4] = (void*)(delegate* unmanaged<void*, int**, int, int*, void> )&ABI_SumAndSetData;
                        vtable[5] = (void*)(delegate* unmanaged<void*, int*, int, void> )&ABI_MultiplyWithData;
                    }
                }
            }
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class UnmanagedToManagedCustomMarshalling
        {
            internal unsafe partial interface INativeObjectStateful
            {
                internal unsafe partial interface Native
                {
                    internal static unsafe void PopulateUnmanagedVirtualMethodTable(void** vtable)
                    {
                        vtable[3] = (void*)(delegate* unmanaged<void*, int*, int, int*, void> )&ABI_SumAndSetData;
                        vtable[4] = (void*)(delegate* unmanaged<void*, int**, int, int*, void> )&ABI_SumAndSetData;
                        vtable[5] = (void*)(delegate* unmanaged<void*, int*, int, void> )&ABI_MultiplyWithData;
                    }
                }
            }
        }
    }
}
