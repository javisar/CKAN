using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using CKAN.Versioning;
using log4net;

namespace CKAN.GameVersionProviders
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class OniBuildIdVersionProvider : IGameVersionProvider
    {
        private static readonly Regex BuildIdPattern = new Regex(@"^build id\s+=\s+0*(?<buildid>\d+)",
            RegexOptions.IgnoreCase | RegexOptions.Compiled
        );

        private static readonly ILog Log = LogManager.GetLogger(typeof(OniBuildIdVersionProvider));

        private readonly IKspBuildMap _kspBuildMap;

        public OniBuildIdVersionProvider(IKspBuildMap kspBuildMap)
        {
            _kspBuildMap = kspBuildMap;
        }

        public bool TryGetVersion(string directory, out KspVersion result)
        {
			//result = new KspVersion(0, 0, 303030);
			//return true;
			AppDomain dom = AppDomain.CreateDomain("FindONIVersion");
			try
			{				
				AssemblyName assemblyName = new AssemblyName();
				assemblyName.CodeBase = Path.Combine(directory, GameConfig.Constants.GameDir+"/Managed/Assembly-CSharp.dll");

				Assembly loaded = Assembly.Load(assemblyName);
				Type t = loaded.GetType("KleiVersion");
				var fieldInfo = t.GetField("ChangeList");
				uint version = (uint)fieldInfo.GetValue(null);
				AppDomain.Unload(dom);
				result = new KspVersion(0, Convert.ToInt32(version));
				return true;
			}
			catch (Exception ex)
			{
				AppDomain.Unload(dom);
				result = default(KspVersion);
				return false;
			}
			/*
            KspVersion buildIdVersion;
            var hasBuildId = TryGetVersionFromFile(Path.Combine(directory, "buildID.txt"), out buildIdVersion);

            KspVersion buildId64Version;
            var hasBuildId64 = TryGetVersionFromFile(Path.Combine(directory, "buildID64.txt"), out buildId64Version);

            if (hasBuildId && hasBuildId64)
            {
                result = KspVersion.Max(buildIdVersion, buildId64Version);

                if (buildIdVersion != buildId64Version)
                {
                    Log.WarnFormat(
                        "Found different KSP versions in buildID.txt ({0}) and buildID64.txt ({1}), assuming {2}.",
                        buildIdVersion,
                        buildId64Version,
                        result
                    );
                }

                return true;
            }
            else if (hasBuildId64)
            {
                result = buildId64Version;
                return true;
            }
            else if (hasBuildId)
            {
                result = buildIdVersion;
                return true;
            }
            else
            {
                result = default(KspVersion);
                return false;
            }
			*/
		}

        private bool TryGetVersionFromFile(string file, out KspVersion result)
        {
            if (File.Exists(file))
            {
                var match = File
                    .ReadAllLines(file)
                    .Select(i => BuildIdPattern.Match(i))
                    .FirstOrDefault(i => i.Success);

                if (match != null)
                {
                    var version = _kspBuildMap[match.Groups["buildid"].Value];

                    if (version != null)
                    {
                        result = version;
                        return true;
                    }
                }
            }

            result = default(KspVersion);
            return false;
        }
    }
}
