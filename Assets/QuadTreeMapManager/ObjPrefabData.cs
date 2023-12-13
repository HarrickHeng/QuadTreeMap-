using UnityEngine;

[DisallowMultipleComponent]
public class ObjPrefabData : MonoBehaviour
{
    [Header("填写资源预设路径")] public string prefabPath;
    [Header("填写模型尺寸")] public Vector3 modelSize;
}