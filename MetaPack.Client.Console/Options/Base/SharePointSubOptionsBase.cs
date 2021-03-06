﻿using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPack.Client.Console.Options.Base
{
    public class SharePointSubOptionsBase : MetaPackSubOptionsBase
    {
        #region properties

        [Option("url", HelpText = "SharePoint web site URL", Required = true)]
        public string Url { get; set; }

        [Option("username", HelpText = "SharePoint user name (for SP2013 or O365)")]
        public string UserName { get; set; }

        [Option("userpassword", HelpText = "SharePoint user password (for SP2013 or O365)")]
        public string UserPassword { get; set; }

        [Option("spversion", HelpText = "SharePoint version. Can be '13', '16' or 'O365'")]
        public string SharePointVersion { get; set; }

        [Option("prerelease", HelpText = "Include pre-release versions of packages")]
        public bool PreRelease { get; set; }

        #endregion

        #region help

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }

        #endregion
    }
}
