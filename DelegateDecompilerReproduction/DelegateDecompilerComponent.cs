using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DeletegateDecompilerRepro
{
    public class DelegateDecompilerComponent : ComponentBase
    {
        private Game game = new();
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddContent(0, game?.State());
        }
    }
}