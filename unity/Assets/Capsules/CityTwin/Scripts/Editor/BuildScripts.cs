using UnityEditor;
public class BuildScripts {
    public static void BuildWebGL() { Build(BuildTarget.WebGL, "build/webgl"); }
    public static void BuildWindows() { Build(BuildTarget.StandaloneWindows64, "build/windows/EastFlatbush90s.exe"); }
    public static void BuildAndroid() { Build(BuildTarget.Android, "build/android/EastFlatbush90s.apk"); }
    public static void BuildLinux() { Build(BuildTarget.StandaloneLinux64, "build/linux/EastFlatbush90s.x86_64"); }
    
    private static void Build(BuildTarget target, string path) {
        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = new[] { "Assets/Capsules/CityTwin/Scenes/Boot.unity", "Assets/Capsules/CityTwin/Scenes/Main.unity" };
        options.locationPathName = path;
        options.target = target;
        options.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(options);
    }
}
