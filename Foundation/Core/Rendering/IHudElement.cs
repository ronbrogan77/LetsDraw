﻿namespace Core.Core.Rendering
{
    public interface IHudElement
    {
        void Draw();

        void Update();
        void Update(double deltaTime);

        void SetShader(int ProgramHandle);
    }
}