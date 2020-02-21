using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_WebApiBuilder : Csproj_AbstractBuilder
    {
        public Csproj_WebApiBuilder()
        {

        }

        public Csproj_WebApiBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }


        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "WebApi.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.WebApi\\{formInfo.NameSpaceName}.WebApi.csproj");
        }
    }
}
