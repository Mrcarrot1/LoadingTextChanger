using UnityEngine;
using TMPro;
using System;
using System.IO;

/// <summary>
/// This Plugin is under the MIT License and was made by Arthur C.
/// (@Tutur on ksp forums)
/// </summary>
namespace LoadingTextChanger
{
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class TextChanger : MonoBehaviour
    {
        string LoadingText = File.ReadAllText(KSPUtil.ApplicationRootPath + @"/GameData/LoadingTextChanger/text.txt");;

        void Awake()
        {
            GameObject loadingGO = GameObject.Find("Text");
            TextMeshPro t = loadingGO.GetComponent<TMPro.TextMeshPro>();
            t.text = LoadingText;
        }
    }
}
