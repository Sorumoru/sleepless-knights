using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTest
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NotMovePlayer()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.

        var gameObject = new GameObject();
        GameObject knight = GameObject.FindWithTag("Player");

       /* knight.movement.x = 0;
        knight.movement.y = 0;*/

        
        yield return null;
        // Assert.AreEqual(new Vector2(0, 0), knight.transform.position);
    }
}
