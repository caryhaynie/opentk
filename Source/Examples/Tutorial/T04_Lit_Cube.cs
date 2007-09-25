﻿#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK;
using OpenTK.OpenGL;
using Examples.Shapes;

namespace Examples.Tutorial
{
    class T04_Lit_Cube : GameWindow, IExample
    {
        float x_angle, zoom;
        Shape shape = new Plane(16, 16, 4.0f, 4.0f);

        #region Constructor

        public T04_Lit_Cube()
        {
            this.CreateWindow(new DisplayMode(800, 600));
        }

        #endregion

        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);
            GL.Enable(GL.Enums.EnableCap.CULL_FACE);
            
            GL.EnableClientState(GL.Enums.EnableCap.VERTEX_ARRAY);
            GL.EnableClientState(GL.Enums.EnableCap.NORMAL_ARRAY);
            GL.VertexPointer(3, GL.Enums.VertexPointerType.FLOAT, 0, shape.Vertices);
            GL.NormalPointer(GL.Enums.NormalPointerType.FLOAT, 0, shape.Normals);

            // Enable Light 0 and set its parameters.
            GL.Lightv(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.POSITION, new float[] { 1.0f, 1.0f, -0.5f });
            GL.Lightv(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.AMBIENT, new float[] { 0.3f, 0.3f, 0.3f, 1.0f });
            GL.Lightv(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.DIFFUSE, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Lightv(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.SPECULAR, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.LightModelv(GL.Enums.LightModelParameter.LIGHT_MODEL_AMBIENT, new float[] { 0.2f, 0.2f, 0.2f, 1.0f });
            GL.Enable(GL.Enums.EnableCap.LIGHTING);
            GL.Enable(GL.Enums.EnableCap.LIGHT0);

            // Use GL.Material to set your object's material parameters..
            GL.Materialv(GL.Enums.MaterialFace.FRONT, GL.Enums.MaterialParameter.AMBIENT, new float[] { 0.3f, 0.3f, 0.3f, 1.0f });
            GL.Materialv(GL.Enums.MaterialFace.FRONT, GL.Enums.MaterialParameter.DIFFUSE, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Materialv(GL.Enums.MaterialFace.FRONT, GL.Enums.MaterialParameter.SPECULAR, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Materialv(GL.Enums.MaterialFace.FRONT, GL.Enums.MaterialParameter.EMISSION, new float[] { 0.0f, 0.0f, 0.0f, 1.0f });
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[0][OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }

            if ((Keyboard[0][OpenTK.Input.Key.AltLeft] || Keyboard[0][OpenTK.Input.Key.AltRight]) &&
                Keyboard[0][OpenTK.Input.Key.Enter])
            {
                Fullscreen = !Fullscreen;
            }

            if (Mouse[0][OpenTK.Input.MouseButton.Left])
                x_angle += Mouse[0].XDelta * 2;
            else
                x_angle += 0.5f;

            if (Mouse[0][OpenTK.Input.MouseButton.Right])
                zoom += Mouse[0].YDelta * 0.5f;

            if (x_angle > 720.0f)
                x_angle -= 720.0f;
            else if (x_angle < -720.0f)
                x_angle += 720.0f;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 0.0, -7.5 + zoom,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0);
            GL.Rotate(x_angle, 0.0f, 1.0f, 0.0f);

            unsafe
            {
                fixed (int* ptr = shape.Indices)
                {
                    GL.DrawElements(GL.Enums.BeginMode.TRIANGLES, shape.Indices.Length,
                        GL.Enums.All.UNSIGNED_INT, ptr);
                }
            }
            GL.DrawArrays(GL.Enums.BeginMode.POINTS, 0, shape.Vertices.Length);

            Context.SwapBuffers();
        }

        #endregion

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public void Launch()
        {
            // Lock UpdateFrame and RenderFrame at 60Hz.
            Run(60.0, 60.0);
        }

        #endregion
    }
}
