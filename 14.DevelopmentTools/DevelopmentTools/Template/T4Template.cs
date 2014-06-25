﻿// 01. Research and use the following tools on one of your projects and provide some output or screenshots 
// for each tool to prove that you actually used the tools
// - One source control system (TFS, SVN or Git)
// - log4net
// - StyleCop or JustCode
// - JustDecompile
// - Sandcastle or Doxygen
// - Some obfuscation tool of your choice
// 02. Write a simple T4 template of your choice
// 03. Upload anonymously a project to a project hosting site (GitHub, Google Code, etc.) and provide a public link to the project. 
// The project can be from your homework.
// https://github.com/vodkatini/KpkHomework

namespace Template
{
    using System;

    using log4net;
    using log4net.Config;

    /// <summary>
    /// Main class, entry point
    /// </summary>
    internal class T4Template
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(T4Template));

        static void Main()
        {
            BasicConfigurator.Configure();
            log.Debug("Debug msg");
            log.Error("Error msg");
        }
    }
}
