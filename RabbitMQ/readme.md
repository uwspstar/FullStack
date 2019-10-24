
# RabbitMQ
- https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html
- RabbitMQ is a message broker: it accepts and forwards messages.
- RabbitMQ speaks multiple protocols. 
- This tutorial uses AMQP 0-9-1, which is an open, general-purpose protocol for messaging. 
- The message content is a byte array, so you can encode whatever you like there.
### Work Queues
- The main idea behind Work Queues (aka: Task Queues) is to avoid doing a resource-intensive task immediately and having to wait for it to complete. Instead we schedule the task to be done later.
