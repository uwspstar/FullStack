// MessageQueue

using System;
using System.Globalization;
using System.Messaging;

namespace DemoX
{
    /*MessageQueue supports two types of message retrieval:
     * synchronous and asynchronous.
     * The synchronous methods, Peek and Receive,
     * cause the process thread to wait a specified time interval
     * for a new message to arrive in the queue.
     * The asynchronous methods,
     * BeginPeek and BeginReceive,
     * allow the main application tasks to continue in a separate thread
     * until a message arrives in the queue.
     * These methods work by using callback objects
     * and state objects to communicate information between threads.
     *
     */

    partial class Program
    {
        public static void PlayMessageQueue()
        {
            var myNewQueue = new MyNewQueue();

            myNewQueue.SendPublic();
            myNewQueue.SendPrivate();
            myNewQueue.SendByLabel();
            myNewQueue.SendByFormatName();
            myNewQueue.MonitorComputerJournal();
            myNewQueue.MonitorQueueJournal();
            myNewQueue.MonitorDeadLetter();
            myNewQueue.MonitorTransactionalDeadLetter();
            // Send a message to a queue.
            myNewQueue.SendMessage();
            // Receive a message from a queue.
            myNewQueue.ReceiveMessage();
        }
    }


    public class Order
    {
        public int OrderId;
        public DateTime OrderTime;
    };

    public class MyNewQueue
    {
        public void ReceiveMessage()
        {
            // Connect to the a queue on the local computer.
            var myQueue = new MessageQueue(".\\myQueue")
            {
                Formatter = new XmlMessageFormatter(new Type[] { typeof(Order) })
            };

            // Set the formatter to indicate body contains an Order.

            try
            {
                // Receive and format the message. 
                var myMessage = myQueue.Receive();
                var myOrder = (Order)myMessage.Body;

                // Display message information.
                Console.WriteLine("Order ID: " +
                                  myOrder.OrderId);
                Console.WriteLine("Sent: " +
                                  myOrder.OrderTime.ToString(CultureInfo.InvariantCulture));
            }

            catch (MessageQueueException)
            {
                // Handle Message Queuing exceptions.
            }

            // Handle invalid serialization format.
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            // Catch other exceptions as necessary.

            return;
        }
        public void SendMessage()
        {

            // Create a new order and set values.
            var sentOrder = new Order();
            sentOrder.OrderId = 3;
            sentOrder.OrderTime = DateTime.Now;

            // Connect to a queue on the local computer.
            var myQueue = new MessageQueue(".\\myQueue");

            // Send the Order to the queue.
            myQueue.Send(sentOrder);

            return;
        }
        // References public queues.
        public void SendPublic()
        {
            var myQueue = new MessageQueue(".\\myQueue");
            myQueue.Send("Public queue by path name.");
        }

        // References private queues.
        public void SendPrivate()
        {
            var myQueue = new MessageQueue(".\\Private$\\myQueue");
            myQueue.Send("Private queue by path name.");
        }

        // References queues by label.
        public void SendByLabel()
        {
            var myQueue = new MessageQueue("Label:TheLabel");
            myQueue.Send("Queue by label.");
        }

        // References queues by format name.
        public void SendByFormatName()
        {
            var myQueue = new MessageQueue("FormatName:Public=5A5F7535-AE9A-41d4" +
                "-935C-845C2AFF7112");
            myQueue.Send("Queue by format name.");
        }

        // References computer journal queues.
        public void MonitorComputerJournal()
        {
            var computerJournal = new MessageQueue(".\\Journal$");
            while (true)
            {
                var journalMessage = computerJournal.Receive();
                // Process the journal message.
            }
        }

        // References queue journal queues.
        public void MonitorQueueJournal()
        {
            var queueJournal = new MessageQueue(".\\myQueue\\Journal$");
            while (true)
            {
                var journalMessage = queueJournal.Receive();
                // Process the journal message.
            }
        }

        // References dead-letter queues.
        public void MonitorDeadLetter()
        {
            var deadLetter = new MessageQueue(".\\DeadLetter$");
            while (true)
            {
                var deadMessage = deadLetter.Receive();
                // Process the dead-letter message.
            }
        }

        // References transactional dead-letter queues.
        public void MonitorTransactionalDeadLetter()
        {
            var TxDeadLetter = new MessageQueue(".\\XactDeadLetter$");
            while (true)
            {
                var txDeadLetter = TxDeadLetter.Receive();
                // Process the transactional dead-letter message.
            }
        }

    }
}

