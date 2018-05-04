using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.TestTools.Utils;

public class Test_Demo {

	[Test]
	public void GameObject_CreatedWithGiven_WillHaveTheName()
	{
		var test = "DemoObject";
		var go = new GameObject(test);
		Assert.AreEqual(test, go.name);
	}
}
