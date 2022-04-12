using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void HealthTestSimplePasses()
    {
        // Arrange
        var gameObject = new GameObject();
        var knight = GameObject.FindWithTag("Player");

        // Act

        // Assert
        Assert.AreEqual(0, 0);
    }

    [Test]
    public void HealthTestSimplePasses2()
    {
        // Arrange
        var gameObject = new GameObject();
        var knight = GameObject.FindWithTag("Player");

        // Act

        // Assert
        Assert.AreEqual(1, 1);
    }

}
