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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    int global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.GetData()
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        int __retVal;
                        {
                            __retVal = ((delegate* unmanaged<void*, int> )__vtable_native[0])(__this);
                        }

                        System.GC.KeepAlive(this);
                        return __retVal;
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
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.SetData(int x)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        {
                            ((delegate* unmanaged<void*, int, void> )__vtable_native[1])(__this, x);
                        }

                        System.GC.KeepAlive(this);
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
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.ExchangeData(ref int x)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        // Pin - Pin data in preparation for calling the P/Invoke.
                        fixed (int* __x_native = &x)
                        {
                            ((delegate* unmanaged<void*, int*, void> )__vtable_native[2])(__this, __x_native);
                        }

                        System.GC.KeepAlive(this);
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
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.SumAndSetData(int[] values, int numValues, out int oldValue)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                        // Pin - Pin data in preparation for calling the P/Invoke.
                        fixed (int* __oldValue_native = &oldValue)
                        fixed (void* __values_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(values))
                        {
                            ((delegate* unmanaged<void*, int*, int, int*, void> )__vtable_native[3])(__this, (int*)__values_native, numValues, __oldValue_native);
                        }

                        System.GC.KeepAlive(this);
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
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.SumAndSetData(ref int[] values, int numValues, out int oldValue)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                        int* __values_native = default;
                        // Setup - Perform required setup.
                        int __values_native__numElements;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out __values_native__numElements);
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __values_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(values, out __values_native__numElements);
                            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(values).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__values_native, __values_native__numElements));
                            // Pin - Pin data in preparation for calling the P/Invoke.
                            fixed (int* __oldValue_native = &oldValue)
                            {
                                ((delegate* unmanaged<void*, int**, int, int*, void> )__vtable_native[4])(__this, &__values_native, numValues, __oldValue_native);
                            }

                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            __values_native__numElements = numValues;
                            values = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__values_native, __values_native__numElements);
                            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__values_native, __values_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(values));
                        }
                        finally
                        {
                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            __values_native__numElements = numValues;
                            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__values_native);
                        }
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
        internal unsafe partial class ImplicitThis
        {
            internal unsafe partial interface INativeObject
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject.MultiplyWithData(int[] values, int numValues)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.INativeObject));
                        // Pin - Pin data in preparation for calling the P/Invoke.
                        fixed (void* __values_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(values))
                        {
                            ((delegate* unmanaged<void*, int*, int, void> )__vtable_native[5])(__this, (int*)__values_native, numValues);
                        }

                        System.GC.KeepAlive(this);
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
        internal unsafe partial class NoImplicitThis
        {
            internal unsafe partial interface IStaticMethodTable
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    int global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.IStaticMethodTable.Add(int x, int y)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.IStaticMethodTable));
                        int __retVal;
                        {
                            __retVal = ((delegate* unmanaged<int, int, int> )__vtable_native[0])(x, y);
                        }

                        System.GC.KeepAlive(this);
                        return __retVal;
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
        internal unsafe partial class NoImplicitThis
        {
            internal unsafe partial interface IStaticMethodTable
            {
                internal unsafe partial interface Native
                {
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    int global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.IStaticMethodTable.Multiply(int x, int y)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.IStaticMethodTable));
                        int __retVal;
                        {
                            __retVal = ((delegate* unmanaged<int, int, int> )__vtable_native[1])(x, y);
                        }

                        System.GC.KeepAlive(this);
                        return __retVal;
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    global::SharedTypes.IntWrapper global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.GetData()
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        bool __invokeSucceeded = default;
                        global::SharedTypes.IntWrapper __retVal = default;
                        int __retVal_native = default;
                        try
                        {
                            {
                                __retVal_native = ((delegate* unmanaged<void*, int> )__vtable_native[0])(__this);
                            }

                            __invokeSucceeded = true;
                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            __retVal = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__retVal_native);
                        }
                        finally
                        {
                            if (__invokeSucceeded)
                            {
                                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                                global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__retVal_native);
                            }
                        }

                        return __retVal;
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.SetData(global::SharedTypes.IntWrapper x)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        int __x_native = default;
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __x_native = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToUnmanaged(x);
                            {
                                ((delegate* unmanaged<void*, int, void> )__vtable_native[1])(__this, __x_native);
                            }

                            System.GC.KeepAlive(this);
                        }
                        finally
                        {
                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__x_native);
                        }
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.ExchangeData(ref global::SharedTypes.IntWrapper data)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        int __data_native = default;
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __data_native = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToUnmanaged(data);
                            {
                                ((delegate* unmanaged<void*, int*, void> )__vtable_native[2])(__this, &__data_native);
                            }

                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            data = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__data_native);
                        }
                        finally
                        {
                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__data_native);
                        }
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.SumAndSetData(global::SharedTypes.IntWrapper[] values, int numValues, out global::SharedTypes.IntWrapper oldValue)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        bool __invokeSucceeded = default;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                        int* __values_native = default;
                        int __oldValue_native = default;
                        // Setup - Perform required setup.
                        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.ManagedToUnmanagedIn __values_native__marshaller = new();
                        int __values_native__numElements;
                        int __values_native__lastIndexMarshalled = 0;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out __values_native__numElements);
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __values_native__marshaller.FromManaged(values, stackalloc int[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.ManagedToUnmanagedIn.BufferSize]);
                            {
                                System.ReadOnlySpan<global::SharedTypes.IntWrapper> __values_native__managedSpan = __values_native__marshaller.GetManagedValuesSource();
                                System.Span<int> __values_native__nativeSpan = __values_native__marshaller.GetUnmanagedValuesDestination();
                                for (int __i0 = 0; __i0 < __values_native__managedSpan.Length; ++__i0, ++__values_native__lastIndexMarshalled)
                                {
                                    __values_native__nativeSpan[__i0] = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToUnmanaged(__values_native__managedSpan[__i0]);
                                }
                            }

                            // Pin - Pin data in preparation for calling the P/Invoke.
                            fixed (void* __values_native__unused = __values_native__marshaller)
                            {
                                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                                __values_native = __values_native__marshaller.ToUnmanaged();
                                ((delegate* unmanaged<void*, int*, int, int*, void> )__vtable_native[3])(__this, __values_native, numValues, &__oldValue_native);
                            }

                            __invokeSucceeded = true;
                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            oldValue = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__oldValue_native);
                        }
                        finally
                        {
                            if (__invokeSucceeded)
                            {
                                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                                global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__oldValue_native);
                                _ = __values_native__lastIndexMarshalled;
                            }

                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            {
                                System.ReadOnlySpan<int> __values_native__nativeSpan = __values_native__marshaller.GetUnmanagedValuesDestination();
                                for (int __i0 = 0; __i0 < __values_native__lastIndexMarshalled; ++__i0)
                                {
                                    global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__values_native__nativeSpan[__i0]);
                                }
                            }

                            __values_native__marshaller.Free();
                        }
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.SumAndSetData(ref global::SharedTypes.IntWrapper[] values, int numValues, out global::SharedTypes.IntWrapper oldValue)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        bool __invokeSucceeded = default;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                        int* __values_native = default;
                        int __oldValue_native = default;
                        // Setup - Perform required setup.
                        int __values_native__numElements;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out __values_native__numElements);
                        int __values_native__lastIndexMarshalled = 0;
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __values_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.AllocateContainerForUnmanagedElements(values, out __values_native__numElements);
                            {
                                System.ReadOnlySpan<global::SharedTypes.IntWrapper> __values_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.GetManagedValuesSource(values);
                                System.Span<int> __values_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.GetUnmanagedValuesDestination(__values_native, __values_native__numElements);
                                for (int __i0 = 0; __i0 < __values_native__managedSpan.Length; ++__i0, ++__values_native__lastIndexMarshalled)
                                {
                                    __values_native__nativeSpan[__i0] = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToUnmanaged(__values_native__managedSpan[__i0]);
                                }
                            }

                            {
                                ((delegate* unmanaged<void*, int**, int, int*, void> )__vtable_native[4])(__this, &__values_native, numValues, &__oldValue_native);
                            }

                            __invokeSucceeded = true;
                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            oldValue = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__oldValue_native);
                            __values_native__numElements = numValues;
                            values = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.AllocateContainerForManagedElements(__values_native, __values_native__numElements);
                            {
                                System.ReadOnlySpan<int> __values_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.GetUnmanagedValuesSource(__values_native, __values_native__numElements);
                                System.Span<global::SharedTypes.IntWrapper> __values_native__managedSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.GetManagedValuesDestination(values);
                                for (int __i0 = 0; __i0 < __values_native__numElements; ++__i0)
                                {
                                    __values_native__managedSpan[__i0] = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__values_native__nativeSpan[__i0]);
                                }
                            }
                        }
                        finally
                        {
                            if (__invokeSucceeded)
                            {
                                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                                global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__oldValue_native);
                            }

                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            {
                                System.ReadOnlySpan<int> __values_native__nativeSpan = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.GetUnmanagedValuesSource(__values_native, __values_native__numElements);
                                for (int __i0 = 0; __i0 < __values_native__lastIndexMarshalled; ++__i0)
                                {
                                    global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__values_native__nativeSpan[__i0]);
                                }
                            }

                            __values_native__numElements = numValues;
                            global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.Free(__values_native);
                        }
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
                    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.ComInterfaceGenerator", "42.42.42.42")]
                    [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                    void global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject.MultiplyWithData(global::SharedTypes.IntWrapper[] values123, int numValues)
                    {
                        var(__this, __vtable_native) = ((System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider)this).GetVirtualMethodTableInfoForKey(typeof(global::ComInterfaceGenerator.Tests.NativeExportsNE.UnmanagedToManagedCustomMarshalling.INativeObject));
                        bool __invokeSucceeded = default;
                        int* __values123_native = default;
                        // Setup - Perform required setup.
                        scoped global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.ManagedToUnmanagedIn __values123_native__marshaller = new();
                        int __values123_native__numElements;
                        int __values123_native__lastIndexMarshalled = 0;
                        System.Runtime.CompilerServices.Unsafe.SkipInit(out __values123_native__numElements);
                        try
                        {
                            // Marshal - Convert managed data to native data.
                            __values123_native__marshaller.FromManaged(values123, stackalloc int[global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<global::SharedTypes.IntWrapper, int>.ManagedToUnmanagedIn.BufferSize]);
                            {
                                System.ReadOnlySpan<global::SharedTypes.IntWrapper> __values123_native__managedSpan = __values123_native__marshaller.GetManagedValuesSource();
                                System.Span<int> __values123_native__nativeSpan = __values123_native__marshaller.GetUnmanagedValuesDestination();
                                for (int __i0 = 0; __i0 < __values123_native__managedSpan.Length; ++__i0, ++__values123_native__lastIndexMarshalled)
                                {
                                    __values123_native__nativeSpan[__i0] = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToUnmanaged(__values123_native__managedSpan[__i0]);
                                }
                            }

                            // Pin - Pin data in preparation for calling the P/Invoke.
                            fixed (void* __values123_native__unused = __values123_native__marshaller)
                            {
                                // PinnedMarshal - Convert managed data to native data that requires the managed data to be pinned.
                                __values123_native = __values123_native__marshaller.ToUnmanaged();
                                ((delegate* unmanaged<void*, int*, int, void> )__vtable_native[5])(__this, __values123_native, numValues);
                            }

                            __invokeSucceeded = true;
                            System.GC.KeepAlive(this);
                            // Unmarshal - Convert native data to managed data.
                            {
                                __values123_native__numElements = __values123_native__marshaller.GetManagedValuesSource().Length;
                                System.Span<global::SharedTypes.IntWrapper> __values123_native__managedSpan = System.Runtime.InteropServices.MemoryMarshal.CreateSpan(ref System.Runtime.CompilerServices.Unsafe.AsRef(in __values123_native__marshaller.GetManagedValuesSource().GetPinnableReference()), __values123_native__numElements);
                                System.Span<int> __values123_native__nativeSpan = __values123_native__marshaller.GetUnmanagedValuesDestination();
                                for (int __i0 = 0; __i0 < __values123_native__numElements; ++__i0)
                                {
                                    __values123_native__managedSpan[__i0] = global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.ConvertToManaged(__values123_native__nativeSpan[__i0]);
                                }
                            }
                        }
                        finally
                        {
                            if (__invokeSucceeded)
                            {
                                // CleanupCalleeAllocated - Perform cleanup of callee allocated resources.
                                _ = __values123_native__lastIndexMarshalled;
                            }

                            // CleanupCallerAllocated - Perform cleanup of caller allocated resources.
                            {
                                System.ReadOnlySpan<int> __values123_native__nativeSpan = __values123_native__marshaller.GetUnmanagedValuesDestination();
                                for (int __i0 = 0; __i0 < __values123_native__lastIndexMarshalled; ++__i0)
                                {
                                    global::ComInterfaceGenerator.Tests.UnmanagedToManagedCustomMarshallingTests.IntWrapperMarshallerToIntWithFreeCounts.Free(__values123_native__nativeSpan[__i0]);
                                }
                            }

                            __values123_native__marshaller.Free();
                        }
                    }
                }
            }
        }
    }
}
