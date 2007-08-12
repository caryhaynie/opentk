namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    public static partial class Wgl
    {
        static Wgl() { }

        public static 
        IntPtr CreateContext(IntPtr hDc)
        {
            return Delegates.glCreateContext((IntPtr)hDc);
        }
        
        public static 
        Boolean DeleteContext(IntPtr oldContext)
        {
            return Delegates.glDeleteContext((IntPtr)oldContext);
        }
        
        public static 
        IntPtr GetCurrentContext()
        {
            return Delegates.glGetCurrentContext();
        }
        
        public static 
        Boolean MakeCurrent(IntPtr hDc, IntPtr newContext)
        {
            return Delegates.glMakeCurrent((IntPtr)hDc, (IntPtr)newContext);
        }
        
        [System.CLSCompliant(false)]
        public static 
        Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask)
        {
            return Delegates.glCopyContext((IntPtr)hglrcSrc, (IntPtr)hglrcDst, (UInt32)mask);
        }
        
        public static 
        Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, Int32 mask)
        {
            return Delegates.glCopyContext((IntPtr)hglrcSrc, (IntPtr)hglrcDst, (UInt32)mask);
        }
        
        public static 
        int ChoosePixelFormat(IntPtr hDc, OpenTK.Platform.Windows.API.PixelFormatDescriptor pPfd)
        {
            return Delegates.glChoosePixelFormat((IntPtr)hDc, (OpenTK.Platform.Windows.API.PixelFormatDescriptor)pPfd);
        }
        
        [System.CLSCompliant(false)]
        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd)
        {
            return Delegates.glDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (OpenTK.Platform.Windows.API.PixelFormatDescriptor)ppfd);
        }
        
        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, Int32 cjpfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd)
        {
            return Delegates.glDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (OpenTK.Platform.Windows.API.PixelFormatDescriptor)ppfd);
        }
        
        public static 
        IntPtr GetCurrentDC()
        {
            return Delegates.glGetCurrentDC();
        }
        
        public static 
        IntPtr GetDefaultProcAddress(String lpszProc)
        {
            return Delegates.glGetDefaultProcAddress((String)lpszProc);
        }
        
        public static 
        IntPtr GetProcAddress(String lpszProc)
        {
            return Delegates.glGetProcAddress((String)lpszProc);
        }
        
        public static 
        int GetPixelFormat(IntPtr hdc)
        {
            return Delegates.glGetPixelFormat((IntPtr)hdc);
        }
        
        public static 
        Boolean SetPixelFormat(IntPtr hdc, int ipfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd)
        {
            return Delegates.glSetPixelFormat((IntPtr)hdc, (int)ipfd, (OpenTK.Platform.Windows.API.PixelFormatDescriptor)ppfd);
        }
        
        public static 
        Boolean SwapBuffers(IntPtr hdc)
        {
            return Delegates.glSwapBuffers((IntPtr)hdc);
        }
        
        public static 
        Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
        {
            return Delegates.glShareLists((IntPtr)hrcSrvShare, (IntPtr)hrcSrvSource);
        }
        
        public static 
        IntPtr CreateLayerContext(IntPtr hDc, int level)
        {
            return Delegates.glCreateLayerContext((IntPtr)hDc, (int)level);
        }
        
        [System.CLSCompliant(false)]
        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, OpenTK.Platform.Windows.API.LayerPlaneDescriptor plpd)
        {
            return Delegates.glDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (OpenTK.Platform.Windows.API.LayerPlaneDescriptor)plpd);
        }
        
        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, Int32 nBytes, OpenTK.Platform.Windows.API.LayerPlaneDescriptor plpd)
        {
            return Delegates.glDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (OpenTK.Platform.Windows.API.LayerPlaneDescriptor)plpd);
        }
        
        public static 
        int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr)
        {
            return Delegates.glSetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32)pcr);
        }
        
        public static 
        int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr)
        {
            return Delegates.glGetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32)pcr);
        }
        
        public static 
        Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize)
        {
             return Delegates.glRealizeLayerPalette((IntPtr)hdc, (int)iLayerPlane, (Boolean)bRealize); 
        }
        
        [System.CLSCompliant(false)]
        public static 
        Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags)
        {
            return Delegates.glSwapLayerBuffers((IntPtr)hdc, (UInt32)fuFlags);
        }
        
        public static 
        Boolean SwapLayerBuffers(IntPtr hdc, Int32 fuFlags)
        {
            return Delegates.glSwapLayerBuffers((IntPtr)hdc, (UInt32)fuFlags);
        }
        
        public static 
        Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
        {
            return Delegates.glUseFontBitmapsA((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase);
        }
        
        public static 
        Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
        {
            return Delegates.glUseFontBitmapsW((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase);
        }
        
        public static class ARB
        {
            [System.CLSCompliant(false)]
            public static 
            IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, UInt32 uType)
            {
                return Delegates.glCreateBufferRegionARB((IntPtr)hDC, (int)iLayerPlane, (UInt32)uType);
            }
            
            public static 
            IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, Int32 uType)
            {
                return Delegates.glCreateBufferRegionARB((IntPtr)hDC, (int)iLayerPlane, (UInt32)uType);
            }
            
            public static 
            void DeleteBufferRegion(IntPtr hRegion)
            {
                Delegates.glDeleteBufferRegionARB((IntPtr)hRegion);
            }
            
            public static 
            Boolean SaveBufferRegion(IntPtr hRegion, int x, int y, int width, int height)
            {
                return Delegates.glSaveBufferRegionARB((IntPtr)hRegion, (int)x, (int)y, (int)width, (int)height);
            }
            
            public static 
            Boolean RestoreBufferRegion(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
            {
                return Delegates.glRestoreBufferRegionARB((IntPtr)hRegion, (int)x, (int)y, (int)width, (int)height, (int)xSrc, (int)ySrc);
            }
            
            public static 
            System.String GetExtensionsString(IntPtr hdc)
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.glGetExtensionsStringARB((IntPtr)hdc));
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues)
            {
                unsafe { return Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [In, Out] int[] piValues)
            {
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [In, Out] int[] piValues)
            {
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues)
            {
                unsafe { return Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [In, Out] Single[] pfValues)
            {
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [In, Out] Single[] pfValues)
            {
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                unsafe { return Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                return Delegates.glMakeContextCurrentARB((IntPtr)hDrawDC, (IntPtr)hReadDC, (IntPtr)hglrc);
            }
            
            public static 
            IntPtr GetCurrentReadDC()
            {
                return Delegates.glGetCurrentReadDCARB();
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
            {
                unsafe { return Delegates.glCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList); }
            }
            
            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, [In, Out] int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        IntPtr retval = Delegates.glCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        IntPtr retval = Delegates.glCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                return Delegates.glGetPbufferDCARB((IntPtr)hPbuffer);
            }
            
            public static 
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                return Delegates.glReleasePbufferDCARB((IntPtr)hPbuffer, (IntPtr)hDC);
            }
            
            public static 
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                return Delegates.glDestroyPbufferARB((IntPtr)hPbuffer);
            }
            
            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int piValue)
            {
                return Delegates.glQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int)piValue);
            }
            
            public static 
            Boolean BindTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.glBindTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }
            
            public static 
            Boolean ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.glReleaseTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetPbufferAttrib(IntPtr hPbuffer, int* piAttribList)
            {
                unsafe { return Delegates.glSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList); }
            }
            
            public static 
            Boolean SetPbufferAttrib(IntPtr hPbuffer, [In, Out] int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        Boolean retval = Delegates.glSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetPbufferAttrib(IntPtr hPbuffer, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        Boolean retval = Delegates.glSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
        }

        public static class EXT
        {
            [System.CLSCompliant(false)]
            public static 
            Boolean CreateDisplayColorTable(UInt16 id)
            {
                return Delegates.glCreateDisplayColorTableEXT((UInt16)id);
            }
            
            public static 
            Boolean CreateDisplayColorTable(Int16 id)
            {
                return Delegates.glCreateDisplayColorTableEXT((UInt16)id);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean LoadDisplayColorTable(UInt16* table, UInt32 length)
            {
                unsafe { return Delegates.glLoadDisplayColorTableEXT((UInt16*)table, (UInt32)length); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean LoadDisplayColorTable(Int16* table, Int32 length)
            {
                    {
                        Boolean retval = Delegates.glLoadDisplayColorTableEXT((UInt16*)table, (UInt32)length);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean LoadDisplayColorTable([In, Out] UInt16[] table, UInt32 length)
            {
                unsafe
                {
                    fixed (UInt16* table_ptr = table)
                    {
                        Boolean retval = Delegates.glLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean LoadDisplayColorTable([In, Out] Int16[] table, Int32 length)
            {
                unsafe
                {
                    fixed (Int16* table_ptr = table)
                    {
                        Boolean retval = Delegates.glLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean LoadDisplayColorTable(ref UInt16 table, UInt32 length)
            {
                unsafe
                {
                    fixed (UInt16* table_ptr = &table)
                    {
                        Boolean retval = Delegates.glLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean LoadDisplayColorTable(ref Int16 table, Int32 length)
            {
                unsafe
                {
                    fixed (Int16* table_ptr = &table)
                    {
                        Boolean retval = Delegates.glLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean BindDisplayColorTable(UInt16 id)
            {
                return Delegates.glBindDisplayColorTableEXT((UInt16)id);
            }
            
            public static 
            Boolean BindDisplayColorTable(Int16 id)
            {
                return Delegates.glBindDisplayColorTableEXT((UInt16)id);
            }
            
            [System.CLSCompliant(false)]
            public static 
            void DestroyDisplayColorTable(UInt16 id)
            {
                Delegates.glDestroyDisplayColorTableEXT((UInt16)id);
            }
            
            public static 
            void DestroyDisplayColorTable(Int16 id)
            {
                Delegates.glDestroyDisplayColorTableEXT((UInt16)id);
            }
            
            public static 
            System.String GetExtensionsString()
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.glGetExtensionsStringEXT());
            }
            
            public static 
            Boolean MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                return Delegates.glMakeContextCurrentEXT((IntPtr)hDrawDC, (IntPtr)hReadDC, (IntPtr)hglrc);
            }
            
            public static 
            IntPtr GetCurrentReadDC()
            {
                return Delegates.glGetCurrentReadDCEXT();
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
            {
                unsafe { return Delegates.glCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList); }
            }
            
            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, [In, Out] int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        IntPtr retval = Delegates.glCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        IntPtr retval = Delegates.glCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                return Delegates.glGetPbufferDCEXT((IntPtr)hPbuffer);
            }
            
            public static 
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                return Delegates.glReleasePbufferDCEXT((IntPtr)hPbuffer, (IntPtr)hDC);
            }
            
            public static 
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                return Delegates.glDestroyPbufferEXT((IntPtr)hPbuffer);
            }
            
            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int piValue)
            {
                return Delegates.glQueryPbufferEXT((IntPtr)hPbuffer, (int)iAttribute, (int)piValue);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues)
            {
                unsafe { return Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] int* piValues)
            {
                piAttributes = default(int*);
                piValues = default(int*);
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [In, Out] int[] piValues)
            {
                piAttributes = default(int*);
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [In, Out] int[] piValues)
            {
                piAttributes = default(int*);
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] out int piValues)
            {
                piAttributes = default(int*);
                piValues = default(int);
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] out int piValues)
            {
                piAttributes = default(int*);
                piValues = default(int);
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] int* piValues)
            {
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [In, Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] out int piValues)
            {
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] int* piValues)
            {
                piAttributes = default(int);
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] int* piValues)
            {
                piAttributes = default(int);
                piValues = default(int*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [In, Out] int[] piValues)
            {
                piAttributes = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [In, Out] int[] piValues)
            {
                piAttributes = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] out int piValues)
            {
                piAttributes = default(int);
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] out int piValues)
            {
                piAttributes = default(int);
                piValues = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues)
            {
                unsafe { return Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues)
            {
                piAttributes = default(int*);
                pfValues = default(Single*);
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [In, Out] Single[] pfValues)
            {
                piAttributes = default(int*);
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [In, Out] Single[] pfValues)
            {
                piAttributes = default(int*);
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] out Single pfValues)
            {
                piAttributes = default(int*);
                pfValues = default(Single);
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] out Single pfValues)
            {
                piAttributes = default(int*);
                pfValues = default(Single);
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] Single* pfValues)
            {
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [In, Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [In, Out] int[] piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [In, Out] int[] piAttributes, [Out] out Single pfValues)
            {
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] Single* pfValues)
            {
                piAttributes = default(int);
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] Single* pfValues)
            {
                piAttributes = default(int);
                pfValues = default(Single*);
                    fixed (int* piAttributes_ptr = &piAttributes)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [In, Out] Single[] pfValues)
            {
                piAttributes = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [In, Out] Single[] pfValues)
            {
                piAttributes = default(int);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] out Single pfValues)
            {
                piAttributes = default(int);
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetPixelFormatAttribv(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] out Single pfValues)
            {
                piAttributes = default(int);
                pfValues = default(Single);
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.glGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                unsafe { return Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, [In, Out] int[] piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, [In, Out] Single[] pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(UInt32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int*);
                nNumFormats = default(Int32);
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats, (UInt32)nNumFormats);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [In, Out] int[] piFormats, [Out] UInt32 nNumFormats)
            {
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [In, Out] int[] piFormats, [Out] Int32 nNumFormats)
            {
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] UInt32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(UInt32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] Int32 nNumFormats)
            {
                piFormats = default(int);
                nNumFormats = default(Int32);
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    {
                        Boolean retval = Delegates.glChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32)nNumFormats);
                        piFormats = *piFormats_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SwapInterval(int interval)
            {
                return Delegates.glSwapIntervalEXT((int)interval);
            }
            
            public static 
            int GetSwapInterval()
            {
                return Delegates.glGetSwapIntervalEXT();
            }
            
        }

        public static class NV
        {
            public static 
            IntPtr AllocateMemory(Int32 size, Single readfreq, Single writefreq, Single priority)
            {
                 return Delegates.glAllocateMemoryNV((Int32)size, (Single)readfreq, (Single)writefreq, (Single)priority); 
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe void FreeMemory([Out] void* pointer)
            {
                unsafe { Delegates.glFreeMemoryNV((void*)pointer); }
            }
            
            public static 
            void FreeMemory([In, Out] object pointer)
            {
                System.Runtime.InteropServices.GCHandle pointer_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pointer, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    try
                    {
                        Delegates.glFreeMemoryNV((void*)pointer_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        pointer_ptr.Free();
                    }
                }
            }
            
        }

        public static class OML
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                unsafe { return Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc, (Int64*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator)
            {
                unsafe { return Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator, (Int32*)denominator); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [Out] Int32* numerator, [In, Out] Int32[] denominator)
            {
                numerator = default(Int32*);
                    fixed (Int32* denominator_ptr = denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator, (Int32*)denominator_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [Out] Int32* numerator, [Out] out Int32 denominator)
            {
                numerator = default(Int32*);
                denominator = default(Int32);
                    fixed (Int32* denominator_ptr = &denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator, (Int32*)denominator_ptr);
                        denominator = *denominator_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [In, Out] Int32[] numerator, [Out] Int32* denominator)
            {
                denominator = default(Int32*);
                    fixed (Int32* numerator_ptr = numerator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator);
                        return retval;
                    }
            }
            
            public static 
            Boolean GetMscRate(IntPtr hdc, [In, Out] Int32[] numerator, [In, Out] Int32[] denominator)
            {
                unsafe
                {
                    fixed (Int32* numerator_ptr = numerator)
                    fixed (Int32* denominator_ptr = denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetMscRate(IntPtr hdc, [In, Out] Int32[] numerator, [Out] out Int32 denominator)
            {
                denominator = default(Int32);
                unsafe
                {
                    fixed (Int32* numerator_ptr = numerator)
                    fixed (Int32* denominator_ptr = &denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                        denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [Out] out Int32 numerator, [Out] Int32* denominator)
            {
                numerator = default(Int32);
                denominator = default(Int32*);
                    fixed (Int32* numerator_ptr = &numerator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator);
                        numerator = *numerator_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean GetMscRate(IntPtr hdc, [Out] out Int32 numerator, [In, Out] Int32[] denominator)
            {
                numerator = default(Int32);
                unsafe
                {
                    fixed (Int32* numerator_ptr = &numerator)
                    fixed (Int32* denominator_ptr = denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                        numerator = *numerator_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetMscRate(IntPtr hdc, [Out] out Int32 numerator, [Out] out Int32 denominator)
            {
                numerator = default(Int32);
                denominator = default(Int32);
                unsafe
                {
                    fixed (Int32* numerator_ptr = &numerator)
                    fixed (Int32* denominator_ptr = &denominator)
                    {
                        Boolean retval = Delegates.glGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                        numerator = *numerator_ptr;
                        denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Int64 SwapBuffersMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder)
            {
                return Delegates.glSwapBuffersMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder);
            }
            
            public static 
            Int64 SwapLayerBuffersMsc(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder)
            {
                return Delegates.glSwapLayerBuffersMscOML((IntPtr)hdc, (int)fuPlanes, (Int64)target_msc, (Int64)divisor, (Int64)remainder);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                unsafe { return Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc, (Int64*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                unsafe { return Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc, (Int64*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64*);
                msc = default(Int64);
                sbc = default(Int64);
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [In, Out] Int64[] ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] Int64* msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] Int64* msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64*);
                sbc = default(Int64);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [In, Out] Int64[] msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [In, Out] Int64[] msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] Int64* sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64*);
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] out Int64 msc, [In, Out] Int64[] sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                ust = default(Int64);
                msc = default(Int64);
                sbc = default(Int64);
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.glWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
        }

        public static class I3D
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [Out] int* piValue)
            {
                unsafe { return Delegates.glGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue); }
            }
            
            public static 
            Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [In, Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        Boolean retval = Delegates.glGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [Out] out int piValue)
            {
                piValue = default(int);
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.glGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, int* piValue)
            {
                unsafe { return Delegates.glSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue); }
            }
            
            public static 
            Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, [In, Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        Boolean retval = Delegates.glSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, ref int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.glSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [Out] int* piValue)
            {
                unsafe { return Delegates.glGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue); }
            }
            
            public static 
            Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [In, Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        Boolean retval = Delegates.glGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [Out] out int piValue)
            {
                piValue = default(int);
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.glGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, int* piValue)
            {
                unsafe { return Delegates.glSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue); }
            }
            
            public static 
            Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, [In, Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        Boolean retval = Delegates.glSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, ref int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.glSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue)
            {
                unsafe { return Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] Int16* puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16*);
                puBlue = default(Int16*);
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16*);
                puGreen = default(UInt16*);
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16*);
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16*);
                puGreen = default(UInt16*);
                puBlue = default(UInt16);
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] Int16* puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16*);
                puBlue = default(Int16);
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [In, Out] UInt16[] puGreen, [Out] UInt16* puBlue)
            {
                puRed = default(UInt16*);
                puBlue = default(UInt16*);
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [In, Out] Int16[] puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16*);
                puBlue = default(Int16*);
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16*);
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16*);
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [In, Out] UInt16[] puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16*);
                puBlue = default(UInt16);
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [In, Out] Int16[] puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16*);
                puBlue = default(Int16);
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] out UInt16 puGreen, [Out] UInt16* puBlue)
            {
                puRed = default(UInt16*);
                puGreen = default(UInt16);
                puBlue = default(UInt16*);
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] out Int16 puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16);
                puBlue = default(Int16*);
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] out UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16*);
                puGreen = default(UInt16);
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] out Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16);
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] out UInt16 puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16*);
                puGreen = default(UInt16);
                puBlue = default(UInt16);
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] out Int16 puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16*);
                puGreen = default(Int16);
                puBlue = default(Int16);
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue)
            {
                puGreen = default(UInt16*);
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = puRed)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] Int16* puGreen, [Out] Int16* puBlue)
            {
                puGreen = default(Int16*);
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = puRed)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                puGreen = default(UInt16*);
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                puGreen = default(Int16*);
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] UInt16* puGreen, [Out] out UInt16 puBlue)
            {
                puGreen = default(UInt16*);
                puBlue = default(UInt16);
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] Int16* puGreen, [Out] out Int16 puBlue)
            {
                puGreen = default(Int16*);
                puBlue = default(Int16);
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, [Out] UInt16* puBlue)
            {
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, [Out] Int16* puBlue)
            {
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, [Out] out UInt16 puBlue)
            {
                puBlue = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, [Out] out Int16 puBlue)
            {
                puBlue = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] out UInt16 puGreen, [Out] UInt16* puBlue)
            {
                puGreen = default(UInt16);
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] out Int16 puGreen, [Out] Int16* puBlue)
            {
                puGreen = default(Int16);
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] out UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                puGreen = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] out Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                puGreen = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [Out] out UInt16 puGreen, [Out] out UInt16 puBlue)
            {
                puGreen = default(UInt16);
                puBlue = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [Out] out Int16 puGreen, [Out] out Int16 puBlue)
            {
                puGreen = default(Int16);
                puBlue = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16*);
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = &puRed)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] Int16* puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16*);
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = &puRed)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16*);
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16*);
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] UInt16* puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16*);
                puBlue = default(UInt16);
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] Int16* puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16*);
                puBlue = default(Int16);
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [In, Out] UInt16[] puGreen, [Out] UInt16* puBlue)
            {
                puRed = default(UInt16);
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [In, Out] Int16[] puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16);
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [In, Out] UInt16[] puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16);
                puBlue = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [In, Out] Int16[] puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16);
                puBlue = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] out UInt16 puGreen, [Out] UInt16* puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16);
                puBlue = default(UInt16*);
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] out Int16 puGreen, [Out] Int16* puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16);
                puBlue = default(Int16*);
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] out UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] out Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] out UInt16 puGreen, [Out] out UInt16 puBlue)
            {
                puRed = default(UInt16);
                puGreen = default(UInt16);
                puBlue = default(UInt16);
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] out Int16 puGreen, [Out] out Int16 puBlue)
            {
                puRed = default(Int16);
                puGreen = default(Int16);
                puBlue = default(Int16);
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue)
            {
                unsafe { return Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, Int16* puGreen, Int16* puBlue)
            {
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, ref UInt16 puBlue)
            {
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, Int16* puGreen, ref Int16 puBlue)
            {
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, [In, Out] UInt16[] puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, [In, Out] Int16[] puGreen, Int16* puBlue)
            {
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, [In, Out] UInt16[] puGreen, ref UInt16 puBlue)
            {
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, [In, Out] Int16[] puGreen, ref Int16 puBlue)
            {
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, ref UInt16 puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, ref Int16 puGreen, Int16* puBlue)
            {
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, ref UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, ref Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, ref UInt16 puGreen, ref UInt16 puBlue)
            {
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, ref Int16 puGreen, ref Int16 puBlue)
            {
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, UInt16* puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = puRed)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, Int16* puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = puRed)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, UInt16* puGreen, ref UInt16 puBlue)
            {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, Int16* puGreen, ref Int16 puBlue)
            {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, [In, Out] UInt16[] puGreen, ref UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, [In, Out] Int16[] puGreen, ref Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, ref UInt16 puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, ref Int16 puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, ref UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, ref Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] UInt16[] puRed, ref UInt16 puGreen, ref UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, [In, Out] Int16[] puRed, ref Int16 puGreen, ref Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, UInt16* puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = &puRed)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, Int16* puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = &puRed)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, UInt16* puGreen, [In, Out] UInt16[] puBlue)
            {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, Int16* puGreen, [In, Out] Int16[] puBlue)
            {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, UInt16* puGreen, ref UInt16 puBlue)
            {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, Int16* puGreen, ref Int16 puBlue)
            {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen, (UInt16*)puBlue_ptr);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, [In, Out] UInt16[] puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, [In, Out] Int16[] puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, [In, Out] UInt16[] puGreen, [In, Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, [In, Out] Int16[] puGreen, [In, Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, [In, Out] UInt16[] puGreen, ref UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, [In, Out] Int16[] puGreen, ref Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, ref UInt16 puGreen, UInt16* puBlue)
            {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, ref Int16 puGreen, Int16* puBlue)
            {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, ref UInt16 puGreen, [In, Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, ref Int16 puGreen, [In, Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, ref UInt16 puGreen, ref UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, ref Int16 puGreen, ref Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.glSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Boolean EnableGenlock(IntPtr hDC)
            {
                return Delegates.glEnableGenlockI3D((IntPtr)hDC);
            }
            
            public static 
            Boolean DisableGenlock(IntPtr hDC)
            {
                return Delegates.glDisableGenlockI3D((IntPtr)hDC);
            }
            
            public static 
            Boolean IsEnabledGenlock(IntPtr hDC, [Out] Boolean pFlag)
            {
                 return Delegates.glIsEnabledGenlockI3D((IntPtr)hDC, (Boolean)pFlag); 
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSource(IntPtr hDC, UInt32 uSource)
            {
                return Delegates.glGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }
            
            public static 
            Boolean GenlockSource(IntPtr hDC, Int32 uSource)
            {
                return Delegates.glGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] UInt32 uSource)
            {
                return Delegates.glGetGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }
            
            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] Int32 uSource)
            {
                return Delegates.glGetGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSourceEdge(IntPtr hDC, UInt32 uEdge)
            {
                return Delegates.glGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }
            
            public static 
            Boolean GenlockSourceEdge(IntPtr hDC, Int32 uEdge)
            {
                return Delegates.glGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] UInt32 uEdge)
            {
                return Delegates.glGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }
            
            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] Int32 uEdge)
            {
                return Delegates.glGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSampleRate(IntPtr hDC, UInt32 uRate)
            {
                return Delegates.glGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }
            
            public static 
            Boolean GenlockSampleRate(IntPtr hDC, Int32 uRate)
            {
                return Delegates.glGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] UInt32 uRate)
            {
                return Delegates.glGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }
            
            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] Int32 uRate)
            {
                return Delegates.glGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSourceDelay(IntPtr hDC, UInt32 uDelay)
            {
                return Delegates.glGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }
            
            public static 
            Boolean GenlockSourceDelay(IntPtr hDC, Int32 uDelay)
            {
                return Delegates.glGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] UInt32 uDelay)
            {
                return Delegates.glGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }
            
            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] Int32 uDelay)
            {
                return Delegates.glGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] UInt32 uMaxLineDelay, [Out] UInt32 uMaxPixelDelay)
            {
                return Delegates.glQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32)uMaxLineDelay, (UInt32)uMaxPixelDelay);
            }
            
            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] Int32 uMaxLineDelay, [Out] Int32 uMaxPixelDelay)
            {
                return Delegates.glQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32)uMaxLineDelay, (UInt32)uMaxPixelDelay);
            }
            
            [System.CLSCompliant(false)]
            public static 
            IntPtr CreateImageBuffer(IntPtr hDC, Int32 dwSize, UInt32 uFlags)
            {
                 return Delegates.glCreateImageBufferI3D((IntPtr)hDC, (Int32)dwSize, (UInt32)uFlags); 
            }
            
            public static 
            IntPtr CreateImageBuffer(IntPtr hDC, Int32 dwSize, Int32 uFlags)
            {
                unsafe
                {
                    {
                        IntPtr retval = Delegates.glCreateImageBufferI3D((IntPtr)hDC, (Int32)dwSize, (UInt32)uFlags);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean DestroyImageBuffer(IntPtr hDC, void* pAddress)
            {
                unsafe { return Delegates.glDestroyImageBufferI3D((IntPtr)hDC, (void*)pAddress); }
            }
            
            public static 
            Boolean DestroyImageBuffer(IntPtr hDC, [In, Out] object pAddress)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    try
                    {
                        Boolean retval = Delegates.glDestroyImageBufferI3D((IntPtr)hDC, (void*)pAddress_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, Int32* pSize, UInt32 count)
            {
                unsafe { return Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize, (UInt32)count); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, Int32* pSize, Int32 count)
            {
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, ref Int32 pSize, UInt32 count)
            {
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, void* pAddress, ref Int32 pSize, Int32 count)
            {
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32* pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32* pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, Int32* pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, Int32* pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, ref Int32 pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, void* pAddress, ref Int32 pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, Int32* pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, Int32* pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, [In, Out] IntPtr[] pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, Int32* pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, Int32* pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, ref Int32 pSize, UInt32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, void* pAddress, ref Int32 pSize, Int32 count)
            {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, Int32* pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, Int32* pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, [In, Out] Int32[] pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    try
                    {
                        Boolean retval = Delegates.glAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (void*)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ReleaseImageBufferEvents(IntPtr hDC, void* pAddress, UInt32 count)
            {
                unsafe { return Delegates.glReleaseImageBufferEventsI3D((IntPtr)hDC, (void*)pAddress, (UInt32)count); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ReleaseImageBufferEvents(IntPtr hDC, void* pAddress, Int32 count)
            {
                    {
                        Boolean retval = Delegates.glReleaseImageBufferEventsI3D((IntPtr)hDC, (void*)pAddress, (UInt32)count);
                        return retval;
                    }
            }
            
            [System.CLSCompliant(false)]
            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, [In, Out] object pAddress, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    try
                    {
                        Boolean retval = Delegates.glReleaseImageBufferEventsI3D((IntPtr)hDC, (void*)pAddress_ptr.AddrOfPinnedObject(), (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, [In, Out] object pAddress, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                unsafe
                {
                    try
                    {
                        Boolean retval = Delegates.glReleaseImageBufferEventsI3D((IntPtr)hDC, (void*)pAddress_ptr.AddrOfPinnedObject(), (UInt32)count);
                        return retval;
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
            
            public static 
            Boolean EnableFrameLock()
            {
                return Delegates.glEnableFrameLockI3D();
            }
            
            public static 
            Boolean DisableFrameLock()
            {
                return Delegates.glDisableFrameLockI3D();
            }
            
            public static 
            Boolean IsEnabledFrameLock([Out] Boolean pFlag)
            {
                 return Delegates.glIsEnabledFrameLockI3D((Boolean)pFlag); 
            }
            
            public static 
            Boolean QueryFrameLockMaster([Out] Boolean pFlag)
            {
                 return Delegates.glQueryFrameLockMasterI3D((Boolean)pFlag); 
            }
            
            public static 
            Boolean GetFrameUsage([Out] float pUsage)
            {
                return Delegates.glGetFrameUsageI3D((float)pUsage);
            }
            
            public static 
            Boolean BeginFrameTracking()
            {
                return Delegates.glBeginFrameTrackingI3D();
            }
            
            public static 
            Boolean EndFrameTracking()
            {
                return Delegates.glEndFrameTrackingI3D();
            }
            
            public static 
            Boolean QueryFrameTracking([Out] Int32 pFrameCount, [Out] Int32 pMissedFrames, [Out] float pLastMissedUsage)
            {
                return Delegates.glQueryFrameTrackingI3D((Int32)pFrameCount, (Int32)pMissedFrames, (float)pLastMissedUsage);
            }
            
        }

    }
}
