﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LetsDraw.Core;
using LetsDraw.Core.Rendering;
using LetsDraw.Loaders;
using LetsDraw.Rendering;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace LetsDraw.Core
{
    public class Terrain : IRenderableComponent
    {
        public Matrix4x4 Transform { get; set; }

        public List<Mesh> Meshes { get; set; }

        public byte[] Lightmap { get; set; }

        public Terrain()
        {
            Transform = Matrix4x4.Identity;
            var obj = new ObjLoader("Data/Objects/powerhouse.obj");
            Meshes = obj.Meshes.Values.ToList();

            foreach (var mesh in Meshes)
            {
                Renderer.CompileMesh(mesh);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Draw(Matrix4 ProjectionMatrix, Matrix4 ViewMatrix)
        {
            
        }

        public void Update(double deltaTime = 0)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
