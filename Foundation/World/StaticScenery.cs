﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Foundation.Core.Rendering;
using Foundation.Loaders;

namespace Foundation.World
{
    public class StaticScenery : IRenderableComponent
    {
        public Guid Id { get; set; }

        public WorldTransform Transform { get; set; }

        public List<Mesh> Meshes { get; set; }

        public StaticScenery()
        {
            Id = Guid.NewGuid();
            Transform = new WorldTransform(Id);
        }

        public static StaticScenery FromObj(string objPath)
        {
            var scenery = new StaticScenery();

            var objLoader = new ObjLoader(objPath);

            scenery.Meshes = objLoader.Meshes.Values.ToList();
            scenery.Id = objLoader.Id;

            return scenery;
        }
    }
}
