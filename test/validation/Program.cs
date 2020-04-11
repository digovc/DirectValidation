using NSpec;
using NSpec.Domain;
using NSpec.Domain.Formatters;
using System;
using System.Linq;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var types = typeof(Program).Assembly.GetTypes();
            var finder = new SpecFinder(types, string.Empty);
            var tagsFilter = new Tags().Parse(string.Empty);
            var builder = new ContextBuilder(finder, tagsFilter, new DefaultConventions());
            var runner = new ContextRunner(tagsFilter, new ConsoleFormatter(), false);
            var results = runner.Run(builder.Contexts().Build());

            if (results.Failures().Count() > 0)
            {
                Environment.Exit(1);
            }
        }
    }
}