using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FirstStrikeChance)), CanEditMultipleObjects]
public class FirstStrikeEditor : Editor
{
    public SerializedProperty
          type_prop,
          onAdvantage_prop,
          attribute_prop,
          successThreshold_prop;

    private void OnEnable()
    {
        type_prop = serializedObject.FindProperty("m_type");
        onAdvantage_prop = serializedObject.FindProperty("m_onAdvantage");
        attribute_prop = serializedObject.FindProperty("m_attribute");
        successThreshold_prop = serializedObject.FindProperty("m_successThreshold");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(type_prop);

        CheckType type = (CheckType)type_prop.enumValueIndex;

        switch (type)
        {
            case CheckType.BooleanExpressions:
                EditorGUILayout.PropertyField(onAdvantage_prop, new GUIContent("onAdvantage"));
                break;
            case CheckType.Random:
                EditorGUILayout.PropertyField(successThreshold_prop, new GUIContent("successThreshold"));
                break;
            case CheckType.RandomInfluencedByAnATTR:
                EditorGUILayout.PropertyField(successThreshold_prop, new GUIContent("successThreshold"));
                EditorGUILayout.PropertyField(attribute_prop, new GUIContent("attribute"));
                break;
        }

        serializedObject.ApplyModifiedProperties();
    }
}
