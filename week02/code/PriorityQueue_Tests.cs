using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
   // Scenario: Enqueue multiple items and check that Dequeue returns the highest priority
// Expected Result: Items are dequeued in order of highest priority; FIFO is respected for same priorities
// Defect(s) Found: Initially, Dequeue did not remove items and loop logic was incorrect
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

   
    priorityQueue.Enqueue("A", 1);
    priorityQueue.Enqueue("B", 3);
    priorityQueue.Enqueue("C", 2);
    priorityQueue.Enqueue("D", 3); 

  
    var first = priorityQueue.Dequeue();
    Assert.AreEqual("B", first);


    var second = priorityQueue.Dequeue();
    Assert.AreEqual("D", second);


    var third = priorityQueue.Dequeue();
    Assert.AreEqual("C", third);


    var fourth = priorityQueue.Dequeue();
    Assert.AreEqual("A", fourth);

 
    try
    {
        priorityQueue.Dequeue();
        Assert.Fail("Expected InvalidOperationException not thrown");
    }
    catch (InvalidOperationException ex)
    {
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
    }

    [TestMethod]
 //    Scenario: Enqueue multiple items and check internal order and Dequeue FIFO for same priority
// Expected Result: Items with same priority are dequeued in insertion order
// Defect(s) Found: Initial code did not remove dequeued items and loop logic was incorrect
    public void TestPriorityQueue_2()
    {
       var priorityQueue = new PriorityQueue();

    // Ajouter plusieurs éléments, certains avec mêmes priorités
    priorityQueue.Enqueue("X", 2);
    priorityQueue.Enqueue("Y", 5);
    priorityQueue.Enqueue("Z", 5);
    priorityQueue.Enqueue("W", 1);

    // Vérifier l'ordre interne après Enqueue (ToString)
    Assert.AreEqual("[X (Pri:2), Y (Pri:5), Z (Pri:5), W (Pri:1)]", priorityQueue.ToString());

    // Dequeue doit retourner Y (premier élément avec priorité 5)
    var first = priorityQueue.Dequeue();
    Assert.AreEqual("Y", first);

    // Dequeue suivant doit retourner Z (FIFO pour même priorité 5)
    var second = priorityQueue.Dequeue();
    Assert.AreEqual("Z", second);

    // Dequeue suivant doit retourner X
    var third = priorityQueue.Dequeue();
    Assert.AreEqual("X", third);

    // Dequeue suivant doit retourner W
    var fourth = priorityQueue.Dequeue();
    Assert.AreEqual("W", fourth);

    // File vide => exception
    try
    {
        priorityQueue.Dequeue();
        Assert.Fail("Expected InvalidOperationException not thrown");
    }
    catch (InvalidOperationException ex)
    {
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
    }

    // Add more test cases as needed below.
}