using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with differnt priorites. Enquue will ensure they are stored in correct ordered priorities
    // Expected Result: Enqueue will add items to the back of the queue.
    // Defect(s) Found: None. 
    public void TestPriorityQueue_1() // adds items with different priorities
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);
        priorityQueue.Enqueue("Medium", 3);

        // test assertions here
        Assert.AreEqual("High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: If two items with same priority are added to the queue, they are dequeued in the order they were added. using FIFO
    // Expected Result: If Dequeue is called, it will remove and return the item with the highest priority. If two items have the same priority, the one that was added first is returned first.
    // Defect(s) Found: None
    public void TestPriorityQueue_2() // test for FIFO for equal priority
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 3);
    // remove and return the item with the highest priority
        priorityQueue.Dequeue(); // this removes "First"

        // test assertions here
        Assert.AreEqual("Second", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Scenario: Dequeue is called on an empty queue
    //Expected Result: Dequeue will throw an InvalidOperationException  with message "The Queue is empty".
    // Defects Found: Expected:<The Queue is empty>. Actual:<The queue is empty.>.
    public void TestPriorityQueue_3() // test for empty queue
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    //Scenario: Multiple dequeues will follow priority order
    //Expected Result: Dequeue will return items in order of priority from highest to lowest.
    //Defects Found: Assert.AreEqual failed. Expected:<Three-1>. Actual:<Seven-2>. Multiple dequeues did not return the first duplicate priority items in correct priority order.
    // missing the removal step after dequeueing the highest priority item.
    // multipe dequeues should also loop through every item in the queue to ensure correct order.
    public void TestPriorityQueue_4() // test for multiple dequeues
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("One-10", 1);
        priorityQueue.Enqueue("Two-5", 5);
        priorityQueue.Enqueue("Three-1", 10);  
        priorityQueue.Enqueue("Four-8", 3);
        priorityQueue.Enqueue("Five-4", 7);
        priorityQueue.Enqueue("Six-6", 5);
        priorityQueue.Enqueue("Seven-2", 10);
        priorityQueue.Enqueue("Eight-9", 2);
        priorityQueue.Enqueue("Nine-3", 8);
        priorityQueue.Enqueue("Ten-7", 4);

    // remove and return the item with the highest priority
        priorityQueue.Dequeue(); // this removes "Three-1"

    // test assertions here for multiple dequeues according to priority
    Assert.AreEqual("Seven-2", priorityQueue.Dequeue()); 
    Assert.AreEqual("Nine-3", priorityQueue.Dequeue());
    Assert.AreEqual("Five-4", priorityQueue.Dequeue());
    Assert.AreEqual("Two-5", priorityQueue.Dequeue());  
    Assert.AreEqual("Six-6", priorityQueue.Dequeue());
    Assert.AreEqual("Ten-7", priorityQueue.Dequeue());
    Assert.AreEqual("Four-8", priorityQueue.Dequeue());
    Assert.AreEqual("Eight-9", priorityQueue.Dequeue());
    Assert.AreEqual("One-10", priorityQueue.Dequeue());

    // At this point, the queue should be empty. Test for empty queue exception is thrown
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    
    }
}