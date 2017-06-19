using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class UtilitiesTests {

    [Test]
    public void TestSquaresSimple() {
        Utilities util = new Utilities();
        Assert.AreEqual(1, util.square(1));
    }

	[TestCase(2, 4)]
    [TestCase(1, 1)]
    [TestCase(-3, 9)]
    [TestCase(0, 0)]
	public void TestSquares(int input, int expected) {
        // Use the Assert class to test conditions.
        GameObject go = new GameObject();
        go.AddComponent<Utilities>();
        Utilities utils = go.GetComponent<Utilities>();
        Assert.AreEqual(expected, utils.square(input));
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	//[UnityTest]
	//public IEnumerator NewEditModeTestWithEnumeratorPasses() {
	//	// Use the Assert class to test conditions.
	//	// yield to skip a frame
	//	yield return null;
	//}
}
