#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

    [CustomPropertyDrawer(typeof(SceneField))]
    public class SceneFieldDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var sceneAsset = property.FindPropertyRelative("sceneAsset");
            var sceneName = property.FindPropertyRelative("sceneName");
        
            EditorGUI.BeginProperty(position, label, property);
            sceneAsset.objectReferenceValue = EditorGUI.ObjectField(position, label, sceneAsset.objectReferenceValue, typeof(SceneAsset), false);
        
            if (sceneAsset.objectReferenceValue != null)
                sceneName.stringValue = ((SceneAsset)sceneAsset.objectReferenceValue).name;
        
            EditorGUI.EndProperty();
        }
    }
#endif
