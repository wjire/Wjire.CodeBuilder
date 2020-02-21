using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_LogicBuilder : Csproj_AbstractBuilder
    {
        public Csproj_LogicBuilder()
        {

        }

        public Csproj_LogicBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Logic.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Logic\\{formInfo.NameSpaceName}.Logic.csproj");
        }
    }
}
