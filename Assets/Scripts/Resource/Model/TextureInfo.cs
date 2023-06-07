using UnityEngine;

namespace MinecraftClient.Resource
{
    public struct TextureInfo
    {
        public Rect bounds;
        public int index;

        // More than 1 if the texture is animated
        public int frameCount;
        // Only used if it is an animated texture
        public float frameSize;
        public int framePerRow;
        // Duration of each frame
        public float frameInterval;

        public TextureInfo(Rect bounds, int index, int fc = 1, float fs = 1, int fr = 1, float fi = 1)
        {
            this.bounds = bounds;
            this.index = index;
            this.frameCount = fc;
            this.frameSize = fs;
            this.framePerRow = fr;
            this.frameInterval = fi;
        }
    }
}