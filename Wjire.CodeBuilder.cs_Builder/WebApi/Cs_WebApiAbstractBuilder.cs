using System.IO;
using Wjire.CodeBuilder.BaseBuilder;

namespace Wjire.CodeBuilder.cs_Builder
{

    public abstract class Cs_WebApiAbstractBuilder : Cs_AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), TemplatePath.WebApi);
        }
    }
}
