using System;
using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.csproj_Builder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.FileService
{

    public class Sln_Builder : AbstractBuilder
    {
        private readonly List<Csproj_AbstractBuilder> _builders;
        //private string FolderGuid = Guid.NewGuid().ToString();
        //private string FolderEntityGuid = Guid.NewGuid().ToString();
        //private string FolderLogicGuid = Guid.NewGuid().ToString();
        //private string FolderRepositoryGuid = Guid.NewGuid().ToString();
        //private string FolderWebApiGuid = Guid.NewGuid().ToString();

        private readonly string IRepositoryGuid = Guid.NewGuid().ToString();
        private readonly string IServiceGuid = Guid.NewGuid().ToString();
        private readonly string LogicGuid = Guid.NewGuid().ToString();
        private readonly string EntityGuid = Guid.NewGuid().ToString();
        private readonly string DTOGuid = Guid.NewGuid().ToString();
        private readonly string ProjectGuid = Guid.NewGuid().ToString();
        private readonly string RepositoryGuid = Guid.NewGuid().ToString();
        private readonly string ServiceGuid = Guid.NewGuid().ToString();
        private readonly string SolutionGuid = Guid.NewGuid().ToString();
        private readonly string WebApiGuid = Guid.NewGuid().ToString();


        public Sln_Builder() : this(null)
        {

        }

        public Sln_Builder(List<Csproj_AbstractBuilder> builders)
        {
            _builders = builders ?? new List<Csproj_AbstractBuilder>();
        }


        public void AddCsprojBuilder(Csproj_AbstractBuilder builder)
        {
            _builders.Add(builder);
        }


        public override void CreateFile(FormInfo formInfo)
        {
            base.CreateFile(formInfo);
            if (_builders == null || _builders.Count == 0)
            {
                return;
            }

            foreach (Csproj_AbstractBuilder builder in _builders)
            {
                builder.CreateFile(formInfo);
            }
        }

        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), TemplatePath.Sln + "\\sln.txt");
        }

        protected override string ReplaceTemplateOfLine(string line, FormInfo formInfo)
        {
            return line
                    .Replace(TemplatePlaceholder.NameSpaceName, formInfo.NameSpaceName)
                    .Replace(TemplatePlaceholder.IRepositoryGuid, IRepositoryGuid)
                    .Replace(TemplatePlaceholder.IServiceGuid, IServiceGuid)
                    .Replace(TemplatePlaceholder.LogicGuid, LogicGuid)
                    .Replace(TemplatePlaceholder.EntityGuid, EntityGuid)
                    .Replace(TemplatePlaceholder.DTOGuid, DTOGuid)
                    .Replace(TemplatePlaceholder.ProjectGuid, ProjectGuid)
                    .Replace(TemplatePlaceholder.RepositoryGuid, RepositoryGuid)
                    .Replace(TemplatePlaceholder.ServiceGuid, ServiceGuid)
                    .Replace(TemplatePlaceholder.SolutionGuid, SolutionGuid)
                    .Replace(TemplatePlaceholder.WebApiGuid, WebApiGuid)

                //.Replace(TemplatePlaceholder.FolderGuid, FolderGuid)
                //.Replace(TemplatePlaceholder.FolderEntityGuid, FolderEntityGuid)
                //.Replace(TemplatePlaceholder.FolderLogicGuid, FolderLogicGuid)
                //.Replace(TemplatePlaceholder.FolderRepositoryGuid, FolderRepositoryGuid)
                //.Replace(TemplatePlaceholder.FolderWebApiGuid, FolderWebApiGuid)
                ;
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.sln");
        }
    }
}
