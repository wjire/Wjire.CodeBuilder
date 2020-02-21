using System.IO;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public class Cs_RepositoryFactoryBuilder : Cs_AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "RepositoryFactory.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Repository\\Factory\\{formInfo.TableName}RepositoryFactory.cs");
        }
    }
}
