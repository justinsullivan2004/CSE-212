using NUnit.Framework;
using prove_04;

public class PriorityTests
{
    // TODO Problem 2 - Write and run test cases and fix the code to match requirements
    /// <summary>
    /// Test 1
    /// Scenario: 
    /// Expected Result: 
    /// </summary>
    [Test]
    public void TestPriority1()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        
        Assert.AreEqual("C", priorityQueue.Dequeue());//has highest priortity then B then A
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    /// <summary>
    /// Test 2
    /// Scenario: 
    /// Expected Result: 
    /// </summary>
    [Test]
    public void TestPriority2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);
        
        Assert.AreEqual("A", priorityQueue.Dequeue());//same priority so should come out same order
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));
        
        // Defect(s) Found: 
    }

    // TODO Add more test cases as needed to test all of the requirements and find all the bugs
}