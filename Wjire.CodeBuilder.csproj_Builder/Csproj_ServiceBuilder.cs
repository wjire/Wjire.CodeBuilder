using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_ServiceBuilder : Csproj_AbstractBuilder
    {

        public Csproj_ServiceBuilder()
        {

        }

        public Csproj_ServiceBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }

        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Service.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Service\\{formInfo.NameSpaceName}.Service.csproj");
        }
    }
}
