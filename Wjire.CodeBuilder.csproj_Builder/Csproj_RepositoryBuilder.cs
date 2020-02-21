using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_RepositoryBuilder : Csproj_AbstractBuilder
    {

        public Csproj_RepositoryBuilder()
        {
        }

        public Csproj_RepositoryBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {
        }


        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Repository.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Repository\\{formInfo.NameSpaceName}.Repository.csproj");
        }
    }
}
