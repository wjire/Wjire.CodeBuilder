using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.csproj_Builder
{

    public class Csproj_IRepositoryBuilder : Csproj_AbstractBuilder
    {

        public Csproj_IRepositoryBuilder()
        {

        }

        public Csproj_IRepositoryBuilder(List<Cs_AbstractBuilder> builders) : base(builders)
        {

        }

        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "IRepository.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.IRepository\\{formInfo.NameSpaceName}.IRepository.csproj");
        }
    }
}
