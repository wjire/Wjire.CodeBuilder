using System.IO;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public class Cs_IRepositoryBuilder : Cs_AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "IRepository.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.IRepository\\I{formInfo.TableName}Repository.cs");
        }
    }
}
