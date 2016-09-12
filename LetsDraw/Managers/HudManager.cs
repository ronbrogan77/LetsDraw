﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsDraw.Core;
using LetsDraw.Rendering;
using LetsDraw.Rendering.Models;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace LetsDraw.Managers
{
    public class HudManager
    {
        private Dictionary<string, IHudElement> Elements;
        private ShaderManager shaderManager;

        public HudManager(ShaderManager shaderManager)
        {
            this.shaderManager = shaderManager;
            Elements = new Dictionary<string, IHudElement>();

            // Manually add test hud element here.
            var fpsReadout = new TextDisplay(0, 0);
            fpsReadout.SetShader(shaderManager.GetShader("HudShader"));
            fpsReadout.Create();
            Elements.Add("FpsReadout", fpsReadout);
        }

        public void Draw()
        {
            foreach (var elem in Elements.Values)
            {
                elem.Draw();
            }
        }

        public void Update(double deltaTime)
        {
            foreach (var model in Elements.Values)
            {
                model.Update(deltaTime);
            }
        }

        public void DeleteElement(string name)
        {
            if (!Elements.ContainsKey(name))
                return;

            //var elem = Elements[name];
            //model.Dispose();

            Elements.Remove(name);
        }

        public IHudElement GetElement(string elem)
        {
            if (Elements.ContainsKey(elem))
                return Elements[elem];

            return null;
        }
    }
}
