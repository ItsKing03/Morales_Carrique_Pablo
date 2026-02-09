using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MathUtilsPlayModeTests
{
    [UnityTest]
    public IEnumerator GameObject_Is_Created()
    {
        GameObject obj = new GameObject("Test");
        yield return null;
        Assert.IsNotNull(obj);
    }

    [UnityTest]
    public IEnumerator Rigidbody_Is_Added()
    {
        GameObject obj = new GameObject("Physics");
        obj.AddComponent<Rigidbody>();
        yield return null;
        Assert.IsNotNull(obj.GetComponent<Rigidbody>());
    }

    [UnityTest]
    public IEnumerator Object_Starts_At_Zero()
    {
        GameObject obj = new GameObject("Position");
        yield return null;
        Assert.AreEqual(Vector3.zero, obj.transform.position);
    }
}

