using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace AarhusWebDevCoop.ViewModels
{
    public class ProjectsViewModel : ContentModel
    {
        public ProjectsViewModel(IPublishedContent content) : base (content)
        {

        }

        public IEnumerable<IPublishedContent> Projects { get; set; }
        public IEnumerable<string> ProjectStatusList { get; set; }
        public string ProjectStatus { get; set; }
    }
}