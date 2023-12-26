using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ArrayElementTitleAttribute))]
public class ArrayElementTitleDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }

    protected virtual ArrayElementTitleAttribute Attribute => attribute as ArrayElementTitleAttribute;
    private SerializedProperty _titleNameProp;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        string fullPathName = property.propertyPath + "." + Attribute.VariableName;
        _titleNameProp = property.serializedObject.FindProperty(fullPathName);
        string newLabel = GetTitle();
        if (string.IsNullOrEmpty(newLabel))
            newLabel = label.text;
        EditorGUI.PropertyField(position, property, new GUIContent(newLabel, label.tooltip), true);
    }

    string GetTitle()
    {
        switch (_titleNameProp.propertyType)
        {
            case SerializedPropertyType.Generic:
                break;
            case SerializedPropertyType.Integer:
                return _titleNameProp.intValue.ToString();
            case SerializedPropertyType.Boolean:
                return _titleNameProp.boolValue.ToString();
            case SerializedPropertyType.Float:
                return _titleNameProp.floatValue.ToString();
            case SerializedPropertyType.String:
                return _titleNameProp.stringValue;
            case SerializedPropertyType.Color:
                return _titleNameProp.colorValue.ToString();
            case SerializedPropertyType.ObjectReference:
                return _titleNameProp.objectReferenceValue.ToString();
            case SerializedPropertyType.LayerMask:
                break;
            case SerializedPropertyType.Enum:
                return _titleNameProp.enumNames[_titleNameProp.enumValueIndex];
            case SerializedPropertyType.Vector2:
                return _titleNameProp.vector2Value.ToString();
            case SerializedPropertyType.Vector3:
                return _titleNameProp.vector3Value.ToString();
            case SerializedPropertyType.Vector4:
                return _titleNameProp.vector4Value.ToString();
            case SerializedPropertyType.Rect:
                break;
            case SerializedPropertyType.ArraySize:
                break;
            case SerializedPropertyType.Character:
                break;
            case SerializedPropertyType.AnimationCurve:
                break;
            case SerializedPropertyType.Bounds:
                break;
            case SerializedPropertyType.Gradient:
                break;
            case SerializedPropertyType.Quaternion:
                break;
            case SerializedPropertyType.ExposedReference:
                break;
            case SerializedPropertyType.FixedBufferSize:
                break;
            case SerializedPropertyType.Vector2Int:
                break;
            case SerializedPropertyType.Vector3Int:
                break;
            case SerializedPropertyType.RectInt:
                break;
            case SerializedPropertyType.BoundsInt:
                break;
            default:
                break;
        }
        return "";
    }
}