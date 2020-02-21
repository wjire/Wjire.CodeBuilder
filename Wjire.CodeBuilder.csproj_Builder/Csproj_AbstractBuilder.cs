using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public abstract class Csproj_AbstractBuilder : AbstractBuilder
    {
        private readonly List<Cs_AbstractBuilder> _builders;

        protected Csproj_AbstractBuilder()
        {
        }

        protected Csproj_AbstractBuilder(List<Cs_AbstractBuilder> builders)
        {
            _builders = builders;
        }

        public override void CreateFile(FormInfo formInfo)
        {
            base.CreateFile(formInfo);
            if (_builders == null || _builders.Count == 0)
            {
                return;
            }

            foreach (Cs_AbstractBuilder builder in _builders)
            {
                builder.CreateFile(formInfo);
            }
        }


        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), TemplatePath.Csproj);
        }

        protected override string ReplaceTemplateOfLine(string line, FormInfo formInfo)
        {
            return line.Replace(TemplatePlaceholder.NameSpaceName, formInfo.NameSpaceName);
        }
    }
}
