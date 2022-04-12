using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UtilityTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void AngleTowardsMouseTestTrue()
    {
        // Arrange
        Vector3 pos = new Vector3(0, 0, 0);
        float angle;

        // Act
        angle = Utility.AngleTowardsMouse(pos);

        // Assert
        Assert.AreEqual(-46.078804f, angle);
    }

    [Test]
    public void AngleTowardsMouseTestFalse()
    {
        // Arrange
        Vector3 pos = new Vector3(0, 0, 0);
        float angle;

        // Act
        angle = Utility.AngleTowardsMouse(pos);

        // Assert
        Assert.AreNotEqual(0f, angle);
    }

}
