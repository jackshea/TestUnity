using System;
using System.IO;
using UnityEditor;
using UnityEngine;

/// 打包工具
public class BuildTool
{
    [MenuItem("Tools/构建/Android平台")]
    public static void BuildAndroid()
    {
        var buildTarget = BuildTarget.Android;
        string rootPath = "Build";
        //string build = $"{DateTime.Now:yyMMddHHmmss}";
        string outputPath = Path.Combine(rootPath, "Android");
        string filename = outputPath + $"\\SunlightRock.apk";
        
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        Directory.CreateDirectory(outputPath);
        EditorUserBuildSettings.androidBuildSystem = AndroidBuildSystem.Gradle;
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, filename, buildTarget, BuildOptions.None);
        Debug.Log(buildTarget + "平台构建完成.  文件位于" + filename);
    }

    [MenuItem("Tools/构建/iOS平台")]
    public static void BuildiOS()
    {
        var buildTarget = BuildTarget.iOS;
        string rootPath = "Build";
        //string build = $"{DateTime.Now:yyMMddHHmmss}";
        string outputPath = Path.Combine(rootPath, "iOS");

        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, true);
        }

        Directory.CreateDirectory(outputPath);
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, outputPath, buildTarget, BuildOptions.None);
        Debug.Log(buildTarget + "平台构建完成.  文件位于" + outputPath);
    }
}