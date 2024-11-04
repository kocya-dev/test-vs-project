using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_vs_project
{
    public class Sample
    {
#pragma warning disable CS8602, CS8604
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
#pragma warning restore CS8602, CS8604

        public int Add(int lhs, int rhs)
        {
            _logger.Info($"add {lhs}, {rhs}");
            return lhs + rhs;
        }
        public int Sub(int lhs, int rhs)
        {
            _logger.Info($"sub {lhs}, {rhs}");
            return lhs - rhs;
        }
    }
}
