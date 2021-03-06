﻿using WENTE.EntityFramework;
using EntityFramework.DynamicFilters;

namespace WENTE.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly WENTEDbContext _context;

        public InitialHostDbBuilder(WENTEDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
