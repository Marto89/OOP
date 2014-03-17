using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomberman
{
    public interface IRenderer
    {
        void LoadForRendering(IRenderable obj);

        void RendererAll();
        void ClearFrame();
    }
}
