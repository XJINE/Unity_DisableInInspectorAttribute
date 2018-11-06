# Unity_DisableInInspectorAttribute

<img src="https://github.com/XJINE/Unity_DisableInInspectorAttribute/blob/master/Screenshot.png" width="100%" height="auto" />

Add ``[DisableInInspector]`` attribute to make uneditable field.

## Import to Your Project

You can import this asset from UnityPackage.

- [DisableInInspectorAttribute.unitypackage](https://github.com/XJINE/Unity_DisableInInspectorAttribute/blob/master/DisableInInspectorAttribute.unitypackage)

## How to Use

Set ``[DisableInInspector]`` attribute on your field.

## Limitation

``[DisableInInspector]`` is ignored when any other GUI attribute is set after it.

``[DisableInInspector]`` can not limits array or list size changing.