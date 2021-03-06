﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKAN.GameConfig
{
    public class Constants
    {

#if (!ONI)
        public const string CKANFolder = "CKAN";
        public static string GameName = "Kerbal Space Program";
		public static string GameNameShort = "KSP";
		public static string BuildMapUri = "https://raw.githubusercontent.com/KSP-CKAN/CKAN-meta/master/builds.json";
        public static string DefaultCKANRepoUri = "https://github.com/KSP-CKAN/CKAN-meta/archive/master.tar.gz";
		public static string DefaultRepoMasterList = "https://raw.githubusercontent.com/KSP-CKAN/CKAN-meta/master/repositories.json";
		public static string GameDir = "GameData";
		public static string[] FoldersToCheck = { "Ships/VAB", "Ships/SPH", "Ships/@thumbs/VAB", "Ships/@thumbs/SPH" };
		public static string ModsDir = "GameData";
		public static string GameFileFilter = "Build metadata file (buildID*.txt)|buildID*.txt";
		public static string GameCommandLineUnix = "./KSP.x86_64 -single-instance";
		public static string GameCommandLineMac = "./KSP.app/Contents/MacOS/KSP";
		public static string GameCommandLineWindows = "KSP_x64.exe -single-instance";
#else
        public const string CKANFolder = "CKAN-ONI";
        public static string GameName = "Oxygen Not Included";
        public static string GameNameShort = "ONI";
        public static string BuildMapUri = "https://raw.githubusercontent.com/javisar/CKAN/master/CKAN-meta/archive/builds.json";
		public static string DefaultCKANRepoUri = "https://raw.githubusercontent.com/javisar/CKAN/master/CKAN-meta/archive/master.tar.gz";
		public static string DefaultRepoMasterList = "https://raw.githubusercontent.com/javisar/CKAN/master/CKAN-meta/archive/repositories.json";
		public static string GameDir = "OxygenNotIncluded_Data";
		public static string[] FoldersToCheck = {  };
		public static string ModsDir = "Mods";
		public static string GameFileFilter = "ONI executable file (OxygenNotIncluded.exe)|OxygenNotIncluded.exe";
		public static string GameCommandLineUnix = "./OxygenNotIncluded.exe";
		public static string GameCommandLineMac = "./ONI.app/Contents/MacOS/ONI";
		public static string GameCommandLineWindows = "OxygenNotIncluded.exe";
#endif

	}
}
