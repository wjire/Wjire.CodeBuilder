using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_EntityBuilder : Csproj_AbstractBuilder
    {

        public Csproj_EntityBuilder()
        {

        }

        public Csproj_EntityBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }

        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Entity.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Entity\\{formInfo.NameSpaceName}.Entity.csproj");
        }
    }
}
