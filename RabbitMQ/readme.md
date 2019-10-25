
# RabbitMQ
- https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html
- RabbitMQ is a message broker: it accepts and forwards messages.
- RabbitMQ speaks multiple protocols. 
- This tutorial uses AMQP 0-9-1, which is an open, general-purpose protocol for messaging. 
- The message content is a byte array, so you can encode whatever you like there.
### Work Queues
- The ```main idea``` behind Work Queues (aka: Task Queues) is to avoid doing a resource-intensive task immediately and having to wait for it to complete. Instead we schedule the task to be done later.
- One of the advantages of using a Task Queue is the ability to easily ```parallelise work```. If we are building up a backlog of work, we can just add more workers and that way, scale easily.
- By default, RabbitMQ will send each message to the next consumer, in sequence. On average every consumer will get the same number of messages. This way of distributing messages is called round-robin
- if you kill a worker we will lose the message it was just processing. We'll also lose all the messages that were dispatched to this particular worker but were not yet handled.
- In order to make sure a message is ```never lost```, RabbitMQ supports message acknowledgments. An ack(nowledgement) is sent back by the consumer to tell RabbitMQ that a particular message has been received, processed and that RabbitMQ is free to delete it.
