using UnityEngine;

public class Sample : MonoBehaviour
{
    private string _expression = "";

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, 200, 200));

        GUILayout.Label("Type Expression & Return");

        GUI.SetNextControlName("TextField");

        _expression = GUILayout.TextField(_expression);

        var focused = GUI.GetNameOfFocusedControl() == "TextField";

        GUILayout.EndArea();

        if ((Event.current.isKey && Event.current.keyCode == KeyCode.Return) || !focused)
        {
            var (success, value) = ExpressionParser.Parse(_expression);
        
            if (success)
            {
                _expression = value.ToString();
            }
        }
    }
}
