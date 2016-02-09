using System.Collections.Generic;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Graphics;

namespace SiliconStudio.Xenko.Rendering
{
    public class RenderStage
    {
        public string Name { get; }
        public EffectPermutationSlot EffectSlot { get; set; }

        /// <summary>
        /// Index in <see cref="RootRenderFeature.RenderStages"/>.
        /// </summary>
        public int Index = -1;

        public RenderStage(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Defines render targets this stage outputs to.
        /// </summary>
        [DataMemberIgnore]
        public RenderOutputDescription Output;
    }
}