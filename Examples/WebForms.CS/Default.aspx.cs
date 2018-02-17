﻿using System;
using System.Web.UI;
using GleamTech.Examples;
using GleamTech.FileUltimate;

namespace GleamTech.FileUltimateExamples.WebForms.CS
{
    public partial class DefaultPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            exampleExplorer.VersionTitle = "v" + FileUltimateConfiguration.AssemblyInfo.FileVersion;

            exampleExplorer.Examples = new ExampleBase[]
            {
                new ExampleFolder
                {
                    Title = "FileManager",
                    Children = new ExampleBase[]
                    {
                        new Example
                        {
                            Title = "Overview",
                            Url = "FileManager/Overview.aspx",
                            SourceFiles = new[] {"FileManager/Overview.aspx", "FileManager/Overview.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Overview.html"
                        },
                        new Example
                        {
                            Title = "Setting properties programmatically",
                            Url = "FileManager/Programmatic.aspx",
                            SourceFiles = new[] { "FileManager/Programmatic.aspx", "FileManager/Programmatic.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Programmatic.html"
                        },
                        new Example
                        {
                            Title = "Displaying control on demand",
                            Url = "FileManager/Display.aspx",
                            SourceFiles = new[] {"FileManager/Display.aspx", "FileManager/Display.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Display.html"
                        },
                        new Example
                        {
                            Title = "Events",
                            Url = "FileManager/Events.aspx",
                            SourceFiles = new[] {"FileManager/Events.aspx", "FileManager/Events.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Events.html"
                        },
                        new Example
                        {
                            Title = "Dynamic folder and permissions",
                            Url = "FileManager/Dynamic.aspx",
                            SourceFiles = new[] {"FileManager/Dynamic.aspx", "FileManager/Dynamic.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Dynamic.html"
                        },
                        new Example
                        {
                            Title = "File/Folder chooser",
                            Url = "FileManager/Chooser.aspx",
                            SourceFiles = new[] {"FileManager/Chooser.aspx", "FileManager/Chooser.aspx.cs"},
                            DescriptionFile = "Descriptions/FileManager/Chooser.html"
                        }
                    }
                }
            };

            exampleExplorer.ExampleProjectName = "ASP.NET Web Forms (C#)";
            exampleExplorer.ExampleProjects = ExamplesConfiguration.LoadExampleProjects(Server.MapPath("~/App_Data/ExampleProjects.json"));
        }
    }
}