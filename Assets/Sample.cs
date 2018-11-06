using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // NOTE:
    // DisableInInspector is ignored when any other GUI attribute is set after it.
    // DisableInInspector can not limit array or list size changing.

    #region Field

    [DisableInInspector]
    public int intValue = 0;

    [Range(0, 3), DisableInInspector]
    public int intRange = 0;

    [DisableInInspector, Range(0, 3)]
    public int intRangeR = 0;

    [DisableInInspector]
    public int[] intArray;

    [DisableInInspector]
    public List<int> intList;

    [HideInInspector, DisableInInspector]
    public int intHideIn;

    [DisableInInspector, HideInInspector]
    public int intHideInR;

    [SerializeField, DisableInInspector]
    private int intSerialize;

    [DisableInInspector, SerializeField]
    private int intSerializeR;

    #endregion Field
}