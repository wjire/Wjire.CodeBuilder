using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_IServiceBuilder : Csproj_AbstractBuilder
    {

        public Csproj_IServiceBuilder()
        {

        }

        public Csproj_IServiceBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }

        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "IService.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.IService\\{formInfo.NameSpaceName}.IService.csproj");
        }
    }
}
