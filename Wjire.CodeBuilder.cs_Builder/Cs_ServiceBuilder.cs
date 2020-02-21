using System.IO;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public class Cs_ServiceBuilder : Cs_AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Service.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Service\\{formInfo.DbName}Service.cs");
        }
    }
}
