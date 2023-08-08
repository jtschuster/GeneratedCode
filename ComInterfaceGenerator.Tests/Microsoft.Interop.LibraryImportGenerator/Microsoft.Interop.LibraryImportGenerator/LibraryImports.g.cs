﻿// <auto-generated/>
namespace ComInterfaceGenerator.Tests
{
    unsafe partial class NativeExportsNE
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "set_com_object_data", ExactSpelling = true)]
        public static extern partial void SetComObjectData(void* obj, int data);
    }
}
namespace ComInterfaceGenerator.Tests
{
    unsafe partial class NativeExportsNE
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_com_object_data", ExactSpelling = true)]
        public static extern partial int GetComObjectData(void* obj);
    }
}
namespace ComInterfaceGenerator.Tests
{
    unsafe partial class NativeExportsNE
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void SetComObjectData(global::SharedTypes.ComInterfaces.IGetAndSetInt obj, int data)
        {
            void* __obj_native = default;
            try
            {
                // Marshal - Convert managed data to native data.
                __obj_native = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.ConvertToUnmanaged(obj);
                {
                    __PInvoke(__obj_native, data);
                }
            }
            finally
            {
                // Cleanup - Perform required cleanup.
                global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.Free(__obj_native);
            }

            // Local P/Invoke
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "set_com_object_data", ExactSpelling = true)]
            static extern unsafe void __PInvoke(void* __obj_native, int __data_native);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    unsafe partial class NativeExportsNE
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial int GetComObjectData(global::SharedTypes.ComInterfaces.IGetAndSetInt obj)
        {
            void* __obj_native = default;
            int __retVal = default;
            try
            {
                // Marshal - Convert managed data to native data.
                __obj_native = (void*)global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.ConvertToUnmanaged(obj);
                {
                    __retVal = __PInvoke(__obj_native);
                }
            }
            finally
            {
                // Cleanup - Perform required cleanup.
                global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.Free(__obj_native);
            }

            return __retVal;
            // Local P/Invoke
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_com_object_data", ExactSpelling = true)]
            static extern unsafe int __PInvoke(void* __obj_native);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class GeneratedComInterfaceComImportInteropTests
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        private static partial global::SharedTypes.ComInterfaces.IGetAndSetInt NewNativeObject()
        {
            global::SharedTypes.ComInterfaces.IGetAndSetInt __retVal = default;
            void* __retVal_native = default;
            try
            {
                {
                    __retVal_native = __PInvoke();
                }

                // Unmarshal - Convert native data to managed data.
                __retVal = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.ConvertToManaged(__retVal_native);
            }
            finally
            {
                // Cleanup - Perform required cleanup.
                global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.Free(__retVal_native);
            }

            return __retVal;
            // Local P/Invoke
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_get_and_set_int", ExactSpelling = true)]
            static extern unsafe void* __PInvoke();
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_com_object", ExactSpelling = true)]
        public static extern partial void* NewNativeObject();
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class IGetAndSetIntTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_get_and_set_int", ExactSpelling = true)]
        public static extern partial void* NewNativeObject();
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class IGetAndSetIntTests
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        internal static partial global::SharedTypes.ComInterfaces.IGetAndSetInt NewNativeObjectWithMarshaller()
        {
            global::SharedTypes.ComInterfaces.IGetAndSetInt __retVal = default;
            void* __retVal_native = default;
            try
            {
                {
                    __retVal_native = __PInvoke();
                }

                // Unmarshal - Convert native data to managed data.
                __retVal = global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.ConvertToManaged(__retVal_native);
            }
            finally
            {
                // Cleanup - Perform required cleanup.
                global::System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.Free(__retVal_native);
            }

            return __retVal;
            // Local P/Invoke
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_get_and_set_int", ExactSpelling = true)]
            static extern unsafe void* __PInvoke();
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class IGetAndSetIntTests
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
        [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        internal static partial global::SharedTypes.ComInterfaces.IGetAndSetInt NewNativeObjectWithUniqueMarshaller()
        {
            global::SharedTypes.ComInterfaces.IGetAndSetInt __retVal = default;
            void* __retVal_native = default;
            try
            {
                {
                    __retVal_native = __PInvoke();
                }

                // Unmarshal - Convert native data to managed data.
                __retVal = global::System.Runtime.InteropServices.Marshalling.UniqueComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.ConvertToManaged(__retVal_native);
            }
            finally
            {
                // Cleanup - Perform required cleanup.
                global::System.Runtime.InteropServices.Marshalling.UniqueComInterfaceMarshaller<global::SharedTypes.ComInterfaces.IGetAndSetInt>.Free(__retVal_native);
            }

            return __retVal;
            // Local P/Invoke
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_get_and_set_int", ExactSpelling = true)]
            static extern unsafe void* __PInvoke();
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class IGetIntArrayTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_get_and_set_int_array", ExactSpelling = true)]
        public static extern partial void* NewNativeObject();
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class ImplicitThis
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.NativeObject NewNativeObject()
            {
                global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.NativeObject __retVal;
                void* __retVal_native;
                {
                    __retVal_native = __PInvoke();
                }

                // Unmarshal - Convert native data to managed data.
                __retVal = global::ComInterfaceGenerator.Tests.NativeExportsNE.ImplicitThis.NativeObjectMarshaller.ConvertToManaged(__retVal_native);
                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_native_object", ExactSpelling = true)]
                static extern unsafe void* __PInvoke();
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
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "delete_native_object", ExactSpelling = true)]
            public static extern partial void DeleteNativeObject(void* obj);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class ImplicitThis
        {
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "set_native_object_data", ExactSpelling = true)]
            public static extern partial void SetNativeObjectData(void* obj, int data);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class ImplicitThis
        {
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_native_object_data", ExactSpelling = true)]
            public static extern partial int GetNativeObjectData(void* obj);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class NoImplicitThis
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.StaticMethodTable GetStaticFunctionTable()
            {
                global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.StaticMethodTable __retVal;
                void* __retVal_native;
                {
                    __retVal_native = __PInvoke();
                }

                // Unmarshal - Convert native data to managed data.
                __retVal = global::ComInterfaceGenerator.Tests.NativeExportsNE.NoImplicitThis.StaticMethodTableMarshaller.ConvertToManaged(__retVal_native);
                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_static_function_table", ExactSpelling = true)]
                static extern unsafe void* __PInvoke();
            }
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class PreserveSigTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "create_point_provider", ExactSpelling = true)]
        public static extern partial void* NewNativeObject();
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class StringMarshallingTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_utf8_marshalling", ExactSpelling = true)]
        public static extern partial void* NewIUtf8Marshalling();
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class StringMarshallingTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_utf16_marshalling", ExactSpelling = true)]
        public static extern partial void* NewIUtf16Marshalling();
    }
}
namespace ComInterfaceGenerator.Tests
{
    public unsafe partial class StringMarshallingTests
    {
        [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "new_string_marshalling_override", ExactSpelling = true)]
        public static extern partial void* NewStringMarshallingOverride();
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class UnmanagedToManagedCustomMarshalling
        {
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "set_native_object_data", ExactSpelling = true)]
            public static extern partial void SetNativeObjectData(void* obj, int data);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class UnmanagedToManagedCustomMarshalling
        {
            [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "get_native_object_data", ExactSpelling = true)]
            public static extern partial int GetNativeObjectData(void* obj);
        }
    }
}
namespace ComInterfaceGenerator.Tests
{
    internal unsafe partial class NativeExportsNE
    {
        internal unsafe partial class UnmanagedToManagedCustomMarshalling
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial int ExchangeNativeObjectData(void* obj, ref int x)
            {
                int __retVal;
                // Pin - Pin data in preparation for calling the P/Invoke.
                fixed (int* __x_native = &x)
                {
                    __retVal = __PInvoke(obj, __x_native);
                }

                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "exchange_native_object_data", ExactSpelling = true)]
                static extern unsafe int __PInvoke(void* __obj_native, int* __x_native);
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
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial int SumAndSetNativeObjectData(void* obj, int[] arr, int numValues, out int oldValue)
            {
                System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                int __retVal;
                // Pin - Pin data in preparation for calling the P/Invoke.
                fixed (int* __oldValue_native = &oldValue)
                fixed (void* __arr_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(arr))
                {
                    __retVal = __PInvoke(obj, (int*)__arr_native, numValues, __oldValue_native);
                }

                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "sum_and_set_native_object_data", ExactSpelling = true)]
                static extern unsafe int __PInvoke(void* __obj_native, int* __arr_native, int __numValues_native, int* __oldValue_native);
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
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial int SumAndSetNativeObjectData(void* obj, ref int[] arr, int numValues, out int oldValue)
            {
                System.Runtime.CompilerServices.Unsafe.SkipInit(out oldValue);
                int* __arr_native = default;
                int __retVal = default;
                // Setup - Perform required setup.
                int __arr_native__numElements;
                System.Runtime.CompilerServices.Unsafe.SkipInit(out __arr_native__numElements);
                try
                {
                    // Marshal - Convert managed data to native data.
                    __arr_native = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForUnmanagedElements(arr, out __arr_native__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesSource(arr).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesDestination(__arr_native, __arr_native__numElements));
                    // Pin - Pin data in preparation for calling the P/Invoke.
                    fixed (int* __oldValue_native = &oldValue)
                    {
                        __retVal = __PInvoke(obj, &__arr_native, numValues, __oldValue_native);
                    }

                    // Unmarshal - Convert native data to managed data.
                    __arr_native__numElements = numValues;
                    arr = global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.AllocateContainerForManagedElements(__arr_native, __arr_native__numElements);
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetUnmanagedValuesSource(__arr_native, __arr_native__numElements).CopyTo(global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.GetManagedValuesDestination(arr));
                }
                finally
                {
                    // Cleanup - Perform required cleanup.
                    __arr_native__numElements = numValues;
                    global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.Free(__arr_native);
                }

                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "sum_and_set_native_object_data_with_ref", ExactSpelling = true)]
                static extern unsafe int __PInvoke(void* __obj_native, int** __arr_native, int __numValues_native, int* __oldValue_native);
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
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
            [global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
            public static partial int MultiplyWithNativeObjectData(void* obj, int[] arr, int numValues)
            {
                int __retVal;
                // Pin - Pin data in preparation for calling the P/Invoke.
                fixed (void* __arr_native = &global::System.Runtime.InteropServices.Marshalling.ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(arr))
                {
                    __retVal = __PInvoke(obj, (int*)__arr_native, numValues);
                }

                return __retVal;
                // Local P/Invoke
                [System.Runtime.InteropServices.DllImportAttribute("Microsoft.Interop.Tests.NativeExportsNE", EntryPoint = "multiply_with_native_object_data", ExactSpelling = true)]
                static extern unsafe int __PInvoke(void* __obj_native, int* __arr_native, int __numValues_native);
            }
        }
    }
}
