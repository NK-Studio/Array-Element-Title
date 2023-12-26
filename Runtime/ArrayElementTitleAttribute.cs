using UnityEngine;

//Attribute
public class ArrayElementTitleAttribute : PropertyAttribute
{
    public readonly string VariableName;
    
    public ArrayElementTitleAttribute(string elementTitleVar)
    {
        VariableName = elementTitleVar;
    }
}
