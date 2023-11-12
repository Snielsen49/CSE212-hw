/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        //var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: adds three values and dequeues them and dequeues again
        // Expected Result: Clean, Read, Play, read, play, play, error
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Play",1);
        priorityQueue.Enqueue("Read",3);
        priorityQueue.Enqueue("Clean",5);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();

        // Defect(s) Found: Dequeue did not remove a value, Dequeue removed the middle value first 
        // Fixes: added a remove function, 
        // removed the -1 infront of _queue.Count in the dequeue index vs highpriorityindex loop

        Console.WriteLine("---------");

        // Test 2
        // Scenario: There are multiple values with the same priority
        // Expected Result: Clean, Read, Play, Read, Play, Play
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Clean",3);
        priorityQueue.Enqueue("Read",3);
        priorityQueue.Enqueue("Play",3);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: removed the second value instead of the first
        // Fixes: Removed the = in the dequeue index vs highpriorityindex loop

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}