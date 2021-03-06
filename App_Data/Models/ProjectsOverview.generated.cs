//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.16.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Projects Overview</summary>
	[PublishedModel("projectsOverview")]
	public partial class ProjectsOverview : PublishedContentModel, INavigationAndSeo
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const string ModelTypeAlias = "projectsOverview";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsOverview, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProjectsOverview(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Projects Body Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("projectsBodyText")]
		public virtual global::System.Web.IHtmlString ProjectsBodyText => this.Value<global::System.Web.IHtmlString>("projectsBodyText");

		///<summary>
		/// Projects Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("projectsTitle")]
		public virtual string ProjectsTitle => this.Value<string>("projectsTitle");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("description")]
		public virtual string Description => global::Umbraco.Web.PublishedModels.NavigationAndSeo.GetDescription(this);

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("keywords")]
		public virtual string Keywords => global::Umbraco.Web.PublishedModels.NavigationAndSeo.GetKeywords(this);

		///<summary>
		/// Hide in navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.NavigationAndSeo.GetUmbracoNaviHide(this);
	}
}
