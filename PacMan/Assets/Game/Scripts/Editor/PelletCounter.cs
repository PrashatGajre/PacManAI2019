using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.ShortcutManagement;

public class PelletCounter : EditorWindow
{
    [MenuItem("Tools/Pellet Counter")]
    [Shortcut("ShowPelletCount", KeyCode.F9)]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        PelletCounter window = (PelletCounter)EditorWindow.GetWindow(typeof(PelletCounter));
        window.maxSize = new Vector2(200, 50);
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Pellets in Scene: ", EditorStyles.boldLabel);
        GUILayout.Label("" + FindObjectsOfType(typeof(PelletController)).Length);

        GUILayout.Label("Objects Selected: ", EditorStyles.boldLabel);
        GUILayout.Label("" + ((Selection.objects.Length > 0) ? Selection.objects.Length.ToString() : "0"));

    }

    private void OnSelectionChange()
    {
        Repaint();
    }
}
