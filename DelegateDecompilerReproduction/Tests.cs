using DelegateDecompiler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Internal;

namespace DeletegateDecompilerRepro
{

    public class Tests
    {
        // Test order matters

        [Test, Order(1)]
        public void Render_bunit_component()
        {
            using var context = new Bunit.TestContext();
            using var component = context.RenderComponent<DelegateDecompilerComponent>();
            Assert.Pass();
        }

        [Test, Order(2)]
        public void Run_decompiled_query()
        {
            var dbContext = new ApplicationDbContext(new DbContextOptionsBuilder().UseInMemoryDatabase(TestContext.CurrentContext.Test.FullName).Options);
            // Also breaks with DecompileAsync / FirstOrDefaultAsync
            dbContext.Games
                .Decompile()
                .FirstOrDefault(g => g.State() == GameState.Started);
            Assert.Pass();
        }
    }
}