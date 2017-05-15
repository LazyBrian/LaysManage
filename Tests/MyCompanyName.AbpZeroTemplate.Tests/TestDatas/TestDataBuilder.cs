using EntityFramework.DynamicFilters;
using Lays.Manage.EntityFramework;

namespace Lays.Manage.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AbpZeroTemplateDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(AbpZeroTemplateDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
